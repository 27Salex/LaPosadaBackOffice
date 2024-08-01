using DevExpress.Utils;
using DevExpress.XtraEditors;
using LaPosadaDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPosadaBackOffice
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Turno TurnoAbierto = null;

        Pedido pedidoDetalle = null;
        public MainForm()
        {
            InitializeComponent();
            InitializeEvents();

            tabControl.ShowTabHeader = DefaultBoolean.False;

            UpdateTimer.Interval = 30000;
            
        }

        private void InitializeEvents()
        {
            this.menuPedidos.Click += MenuPedidos_Click;
            this.menuEditarDatos.Click += MenuEditarDatos_Click;
            this.dropPanel.DragEnter += new DragEventHandler(imageControl_DragEnter);
            this.dropPanel.DragDrop += new DragEventHandler(imageControl_DragDrop);
        }

        public List<ShopItem> ParseToShopItems(Pedido pedido)
        {
            var items = new List<ShopItem>();
            foreach (var con in pedido.Consumiciones)
            {
                var shopItem = new ShopItem();
                shopItem.Producto = con.Producto.Nombre;
                shopItem.Cantidad = con.Cantidad;
                shopItem.Precio = con.PrecioTotal;

                items.Add(shopItem);
            }
            return items;
        }
    }

    public class ShopItem
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
