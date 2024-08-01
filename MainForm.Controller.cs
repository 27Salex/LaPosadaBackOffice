using DevExpress.Utils;
using DevExpress.XtraBars;
using LaPosadaDAL.Models;
using LaPosadaDAL.Services;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LaPosadaBackOffice
{
    partial class MainForm
    {
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            var ultTurno = new TurnoDAL().GetAll("WHERE EstaCerrado = 0 ORDER BY FechaHoraInicio", true).FirstOrDefault();

            if (ultTurno != null)
            {
                DialogResult res = MessageBox.Show("Se ha encontrado un turno sin cerrar de la ultima sesión, " +
                    "¿Desea retomar este y abirlo?", "Reanudar turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No)
                {
                    ultTurno.EstaCerrado = true;
                    ultTurno.FechaHoraFin = DateTime.Now;
                    ultTurno.Save();
                }
                else
                {
                    TurnoAbierto = ultTurno;
                    TurnoAbierto.FechaHoraFin = null;
                    TurnoAbierto.Save();
                    ActualizarPedidos();
                    cboxEstado.DataSource = new EstadoDAL().GetAll(null, false);
                }
            } 
        }

        #region Image Drag Drop

        private void imageControl_DragEnter(object sender, DragEventArgs e)
        {
            // Verifica si los datos arrastrados son del tipo que se puede soltar (en este caso, archivos)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Cambia el efecto del cursor para indicar que se puede soltar
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Evento DragDrop: se dispara cuando se suelta un objeto en el PictureBox
        private void imageControl_DragDrop(object sender, DragEventArgs e)
        {
            // Obtén los archivos arrastrados
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Length > 0)
            {
                if (IsImageFile(files[0]))
                {
                    imageControl.Image = Image.FromFile(files[0]);
                    if (tglImageMode.IsOn == true)
                    {
                        var producto = ((Producto)lstProductos.SelectedItem);
                        producto.Icon = imageControl.Image;
                        producto.Save();
                    }
                    else
                    {
                        var categoria = ((Categoria)lstCategorias.SelectedItem);
                        categoria.Icon = imageControl.Image;
                        categoria.Save();
                    }
                }
                else
                    MessageBox.Show("Solo se permiten archivos de imagen (jpg, jpeg, png, bmp, webp).", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool IsImageFile(string filePath)
        {
            // Obtén la extensión del archivo
            string ext = Path.GetExtension(filePath).ToLower();
            // Verifica si la extensión es una de las permitidas
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".webp";
        }

        #endregion

        #region Menu Events
        private void menuCerrarTurno_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            if (TurnoAbierto != null)
            {
                TurnoAbierto.EstaCerrado = true;
                TurnoAbierto.Save();
            }

            TurnoAbierto = null;
            menuCerrarTurno.Visible = false;
            menuReabrirTurno.Visible = true;
        }

        private void menuReabrirTurno_Click(object sender, EventArgs e)
        {
            TurnoAbierto = new Turno
            {
                FechaHoraInicio = DateTime.Now,
                EstaCerrado = false,
            };
            TurnoAbierto.Save();
            menuReabrirTurno.Visible = false;
            menuCerrarTurno.Visible = true;
            ActualizarPedidos();
        }

        private void MenuPedidos_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = paginaPedidos;
            ActualizarPedidos();
        }

        private void MenuEditarDatos_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = paginaEditar;
            lstCategorias.DataSource = new CategoriaDAL().GetAll();
            lstCategorias.SelectedIndex = 0;
        }
        
        #endregion

        #region Update Timer events
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            
            ActualizarPedidos();
        }

        void ActualizarPedidos()
        {
            UpdateTimer.Stop();
            barUpdating.Visibility = BarItemVisibility.Always;
            menuCerrarTurno.Visible = !TurnoAbierto.EstaCerrado;
            menuReabrirTurno.Visible = TurnoAbierto.EstaCerrado;

            Application.DoEvents();

            PedidoDAL pedidoDAL = new PedidoDAL();
            gridPedidos.DataSource = TurnoAbierto.Pedidos ?? null;

            barUpdating.Visibility = BarItemVisibility.Never;
            UpdateTimer.Start();
        }
        #endregion

        #region Editar datos
        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProductos.DataSource = new ProductoDAL().GetAll($"WHERE RidCategoria = {(int)lstCategorias.SelectedValue}", false);
            CargarImagenSeleccionada();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarImagenSeleccionada();
        }

        private void tglImageMode_Toggled(object sender, EventArgs e)
        {
            lstProductos.Enabled = tglImageMode.IsOn;
            CargarImagenSeleccionada();
        }

        private void CargarImagenSeleccionada()
        {
            imageControl.Image = tglImageMode.IsOn ? ((Producto)lstProductos.SelectedItem).Icon :
                                                                 ((Categoria)lstCategorias.SelectedItem).Icon;
        }
        #endregion

        #region View Detalles
        private void viewPedidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tabControl.SelectedTabPage = paginaDetalles;
            UpdateViewDetalles((Pedido)viewPedidos.GetRow(e.RowHandle));
        }

        private void UpdateViewDetalles(Pedido pedido)
        {
            gridDetalles.DataSource = ParseToShopItems(pedido);
            lblPrecioTotal.Text = pedido.TotalPedido.ToString() + "€";
            cboxEstado.SelectedIndex = pedido.RidEstado - 1;
            pedidoDetalle = pedido;
        }

        private void paginaDetalles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedidoDetalle != null)
            {
                pedidoDetalle.RidEstado = ((Estado)cboxEstado.SelectedItem).IdEstado;
                pedidoDetalle.Save();
            }
        } 
        #endregion
    }
}
