namespace LaPosadaBackOffice
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.paginaPedidos = new DevExpress.XtraTab.XtraTabPage();
            this.gridPedidos = new DevExpress.XtraGrid.GridControl();
            this.viewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paginaEditar = new DevExpress.XtraTab.XtraTabPage();
            this.tglImageMode = new DevExpress.XtraEditors.ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.imageControl = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.paginaDetalles = new DevExpress.XtraTab.XtraTabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridDetalles = new DevExpress.XtraGrid.GridControl();
            this.viewDetallesPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.menuPedidos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.menuReabrirTurno = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuCerrarTurno = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.menuEditarDatos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barUpdating = new DevExpress.XtraBars.BarStaticItem();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.paginaPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidos)).BeginInit();
            this.paginaEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglImageMode.Properties)).BeginInit();
            this.dropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageControl)).BeginInit();
            this.paginaDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetallesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tabControl);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(179, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(747, 527);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.paginaPedidos;
            this.tabControl.Size = new System.Drawing.Size(747, 527);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.paginaPedidos,
            this.paginaEditar,
            this.paginaDetalles});
            // 
            // paginaPedidos
            // 
            this.paginaPedidos.Controls.Add(this.gridPedidos);
            this.paginaPedidos.Name = "paginaPedidos";
            this.paginaPedidos.Size = new System.Drawing.Size(745, 502);
            this.paginaPedidos.Text = "Pedidos";
            // 
            // gridPedidos
            // 
            this.gridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPedidos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridPedidos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridPedidos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridPedidos.Location = new System.Drawing.Point(0, 0);
            this.gridPedidos.MainView = this.viewPedidos;
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.Size = new System.Drawing.Size(745, 502);
            this.gridPedidos.TabIndex = 0;
            this.gridPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewPedidos});
            // 
            // viewPedidos
            // 
            this.viewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colTotalPedido,
            this.colEstado});
            this.viewPedidos.GridControl = this.gridPedidos;
            this.viewPedidos.GroupPanelText = "Arrastre una columna aqui para agrupar los pedidos";
            this.viewPedidos.Name = "viewPedidos";
            this.viewPedidos.OptionsBehavior.Editable = false;
            this.viewPedidos.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewPedidos.OptionsDetail.EnableMasterViewMode = false;
            this.viewPedidos.OptionsDetail.ShowDetailTabs = false;
            this.viewPedidos.OptionsView.ShowDetailButtons = false;
            this.viewPedidos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewPedidos_RowClick);
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha de pedido";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colFecha.ImageOptions.Image")));
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.UnboundDataType = typeof(System.DateTime);
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            // 
            // colTotalPedido
            // 
            this.colTotalPedido.Caption = "Precio total";
            this.colTotalPedido.FieldName = "TotalPedido";
            this.colTotalPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTotalPedido.ImageOptions.Image")));
            this.colTotalPedido.Name = "colTotalPedido";
            this.colTotalPedido.Visible = true;
            this.colTotalPedido.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "NombreEstado";
            this.colEstado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEstado.ImageOptions.Image")));
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 1;
            // 
            // paginaEditar
            // 
            this.paginaEditar.Controls.Add(this.tglImageMode);
            this.paginaEditar.Controls.Add(this.label4);
            this.paginaEditar.Controls.Add(this.dropPanel);
            this.paginaEditar.Controls.Add(this.label3);
            this.paginaEditar.Controls.Add(this.label2);
            this.paginaEditar.Controls.Add(this.label1);
            this.paginaEditar.Controls.Add(this.lstProductos);
            this.paginaEditar.Controls.Add(this.lstCategorias);
            this.paginaEditar.Name = "paginaEditar";
            this.paginaEditar.Size = new System.Drawing.Size(745, 502);
            this.paginaEditar.Text = "Modo Edición";
            // 
            // tglImageMode
            // 
            this.tglImageMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tglImageMode.EditValue = true;
            this.tglImageMode.Location = new System.Drawing.Point(598, 63);
            this.tglImageMode.Name = "tglImageMode";
            this.tglImageMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglImageMode.Properties.Appearance.Options.UseFont = true;
            this.tglImageMode.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglImageMode.Properties.OffText = "categoria";
            this.tglImageMode.Properties.OnText = "producto";
            this.tglImageMode.Size = new System.Drawing.Size(126, 20);
            this.tglImageMode.TabIndex = 6;
            this.tglImageMode.Toggled += new System.EventHandler(this.tglImageMode_Toggled);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargar imagen de:";
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropPanel.Controls.Add(this.imageControl);
            this.dropPanel.Location = new System.Drawing.Point(474, 125);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(250, 250);
            this.dropPanel.TabIndex = 5;
            // 
            // imageControl
            // 
            this.imageControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageControl.Location = new System.Drawing.Point(0, 0);
            this.imageControl.Name = "imageControl";
            this.imageControl.Size = new System.Drawing.Size(250, 250);
            this.imageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageControl.TabIndex = 0;
            this.imageControl.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagen";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categorias";
            // 
            // lstProductos
            // 
            this.lstProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProductos.DisplayMember = "Nombre";
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(268, 65);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(179, 368);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.ValueMember = "IdProducto";
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // lstCategorias
            // 
            this.lstCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCategorias.DisplayMember = "Nombre";
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.Location = new System.Drawing.Point(31, 65);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(179, 368);
            this.lstCategorias.TabIndex = 0;
            this.lstCategorias.ValueMember = "IdCategoria";
            this.lstCategorias.SelectedIndexChanged += new System.EventHandler(this.lstCategorias_SelectedIndexChanged);
            // 
            // paginaDetalles
            // 
            this.paginaDetalles.Controls.Add(this.label6);
            this.paginaDetalles.Controls.Add(this.cboxEstado);
            this.paginaDetalles.Controls.Add(this.lblPrecioTotal);
            this.paginaDetalles.Controls.Add(this.label5);
            this.paginaDetalles.Controls.Add(this.gridDetalles);
            this.paginaDetalles.Name = "paginaDetalles";
            this.paginaDetalles.Size = new System.Drawing.Size(745, 502);
            this.paginaDetalles.Text = "Detalles pedido";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // cboxEstado
            // 
            this.cboxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxEstado.DisplayMember = "Nombre";
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(497, 444);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(121, 21);
            this.cboxEstado.TabIndex = 4;
            this.cboxEstado.SelectedIndexChanged += new System.EventHandler(this.cboxEstado_SelectedIndexChanged);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecioTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(156, 444);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(131, 22);
            this.lblPrecioTotal.TabIndex = 3;
            this.lblPrecioTotal.Text = "0,00€";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio total:";
            // 
            // gridDetalles
            // 
            this.gridDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 14.25F);
            this.gridDetalles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridDetalles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalles.Location = new System.Drawing.Point(40, 46);
            this.gridDetalles.MainView = this.viewDetallesPedido;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.Size = new System.Drawing.Size(578, 372);
            this.gridDetalles.TabIndex = 1;
            this.gridDetalles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDetallesPedido});
            // 
            // viewDetallesPedido
            // 
            this.viewDetallesPedido.Appearance.Row.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.viewDetallesPedido.Appearance.Row.Options.UseFont = true;
            this.viewDetallesPedido.GridControl = this.gridDetalles;
            this.viewDetallesPedido.Name = "viewDetallesPedido";
            this.viewDetallesPedido.OptionsBehavior.Editable = false;
            this.viewDetallesPedido.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.viewDetallesPedido.OptionsView.ShowGroupPanel = false;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuPedidos,
            this.accordionControlSeparator1,
            this.menuReabrirTurno,
            this.menuCerrarTurno,
            this.accordionControlSeparator2,
            this.menuEditarDatos});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(179, 527);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // menuPedidos
            // 
            this.menuPedidos.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPedidos.Appearance.Default.Options.UseFont = true;
            this.menuPedidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuPedidos.ImageOptions.Image")));
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuPedidos.Text = "Pedidos";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // menuReabrirTurno
            // 
            this.menuReabrirTurno.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReabrirTurno.Appearance.Default.Options.UseFont = true;
            this.menuReabrirTurno.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuReabrirTurno.ImageOptions.Image")));
            this.menuReabrirTurno.Name = "menuReabrirTurno";
            this.menuReabrirTurno.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuReabrirTurno.Text = "Abrir Turno";
            this.menuReabrirTurno.Visible = false;
            this.menuReabrirTurno.Click += new System.EventHandler(this.menuAbrirTurno_Click);
            // 
            // menuCerrarTurno
            // 
            this.menuCerrarTurno.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuCerrarTurno.Appearance.Default.Options.UseFont = true;
            this.menuCerrarTurno.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuCerrarTurno.ImageOptions.Image")));
            this.menuCerrarTurno.Name = "menuCerrarTurno";
            this.menuCerrarTurno.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuCerrarTurno.Text = "Cerrar Turno";
            this.menuCerrarTurno.Visible = false;
            this.menuCerrarTurno.Click += new System.EventHandler(this.menuCerrarTurno_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // menuEditarDatos
            // 
            this.menuEditarDatos.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuEditarDatos.Appearance.Default.Options.UseFont = true;
            this.menuEditarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarDatos.ImageOptions.Image")));
            this.menuEditarDatos.Name = "menuEditarDatos";
            this.menuEditarDatos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuEditarDatos.Text = "Editar datos";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barUpdating});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(926, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barUpdating);
            // 
            // barUpdating
            // 
            this.barUpdating.Caption = "Updating...";
            this.barUpdating.Id = 0;
            this.barUpdating.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUpdating.ImageOptions.Image")));
            this.barUpdating.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUpdating.ImageOptions.LargeImage")));
            this.barUpdating.Name = "barUpdating";
            this.barUpdating.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barUpdating.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 3000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 558);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "La Posada BackOffice";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.paginaPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidos)).EndInit();
            this.paginaEditar.ResumeLayout(false);
            this.paginaEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglImageMode.Properties)).EndInit();
            this.dropPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageControl)).EndInit();
            this.paginaDetalles.ResumeLayout(false);
            this.paginaDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetallesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuPedidos;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage paginaPedidos;
        private DevExpress.XtraGrid.GridControl gridPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView viewPedidos;
        private System.Windows.Forms.Timer UpdateTimer;
        private DevExpress.XtraBars.BarStaticItem barUpdating;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuCerrarTurno;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuReabrirTurno;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuEditarDatos;
        private DevExpress.XtraTab.XtraTabPage paginaEditar;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imageControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel dropPanel;
        private DevExpress.XtraEditors.ToggleSwitch tglImageMode;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraTab.XtraTabPage paginaDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.GridControl gridDetalles;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDetallesPedido;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxEstado;
    }
}

