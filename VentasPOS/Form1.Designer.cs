namespace VentasPOS
{
    partial class frmVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            lblTitulo = new Label();
            grpDatosVenta = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            lblTotal = new Label();
            grpBotones = new GroupBox();
            btnNuevaVenta = new Button();
            btnEliminar = new Button();
            btnGuardarVenta = new Button();
            btnLimpiar = new Button();
            btnImprimir = new Button();
            pdVenta = new System.Drawing.Printing.PrintDocument();
            grpDatosVenta.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(753, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE VENTAS POS - GESTIÓN DE CLIENTES Y PRODUCTOS";
            // 
            // grpDatosVenta
            // 
            grpDatosVenta.Controls.Add(lblCliente);
            grpDatosVenta.Controls.Add(txtCliente);
            grpDatosVenta.Controls.Add(lblProducto);
            grpDatosVenta.Controls.Add(cmbProducto);
            grpDatosVenta.Controls.Add(lblCantidad);
            grpDatosVenta.Controls.Add(txtCantidad);
            grpDatosVenta.Controls.Add(btnAgregar);
            grpDatosVenta.Location = new Point(12, 50);
            grpDatosVenta.Name = "grpDatosVenta";
            grpDatosVenta.Size = new Size(400, 300);
            grpDatosVenta.TabIndex = 1;
            grpDatosVenta.TabStop = false;
            grpDatosVenta.Text = "1. DATOS DE VENTA";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(15, 35);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(142, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre del Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(15, 60);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(360, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(15, 110);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(15, 135);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(360, 28);
            cmbProducto.TabIndex = 3;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 185);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(15, 210);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(120, 27);
            txtCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(200, 200);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(175, 45);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Location = new Point(430, 50);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(560, 300);
            grpDetalle.TabIndex = 2;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "2. DETALLE DE VENTA (TABLA)";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(10, 25);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(540, 220);
            dgvDetalle.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotal.Location = new Point(10, 258);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(258, 30);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "TOTAL DE LA VENTA: $0";
            // 
            // grpBotones
            // 
            grpBotones.Controls.Add(btnNuevaVenta);
            grpBotones.Controls.Add(btnEliminar);
            grpBotones.Controls.Add(btnGuardarVenta);
            grpBotones.Controls.Add(btnLimpiar);
            grpBotones.Controls.Add(btnImprimir);
            grpBotones.Location = new Point(12, 365);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(978, 162);
            grpBotones.TabIndex = 3;
            grpBotones.TabStop = false;
            grpBotones.Text = "BOTONES";
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Image = (Image)resources.GetObject("btnNuevaVenta.Image");
            btnNuevaVenta.ImageAlign = ContentAlignment.TopCenter;
            btnNuevaVenta.Location = new Point(6, 50);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(180, 106);
            btnNuevaVenta.TabIndex = 0;
            btnNuevaVenta.Text = "NUEVA VENTA";
            btnNuevaVenta.TextAlign = ContentAlignment.BottomCenter;
            btnNuevaVenta.UseVisualStyleBackColor = true;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(195, 50);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 106);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR PRODUCTO";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Image = (Image)resources.GetObject("btnGuardarVenta.Image");
            btnGuardarVenta.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarVenta.Location = new Point(390, 50);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(180, 106);
            btnGuardarVenta.TabIndex = 2;
            btnGuardarVenta.Text = "GUARDAR VENTA";
            btnGuardarVenta.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.TopCenter;
            btnLimpiar.Location = new Point(580, 50);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 106);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.TopCenter;
            btnImprimir.Location = new Point(770, 50);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(180, 106);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "IMPRIMIR VENTA";
            btnImprimir.TextAlign = ContentAlignment.BottomCenter;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pdVenta
            // 
            pdVenta.PrintPage += pdVenta_PrintPage;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 551);
            Controls.Add(grpBotones);
            Controls.Add(grpDetalle);
            Controls.Add(grpDatosVenta);
            Controls.Add(lblTitulo);
            Name = "frmVentas";
            Text = "Sistema de Ventas POS";
            Load += frmVentas_Load;
            grpDatosVenta.ResumeLayout(false);
            grpDatosVenta.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatosVenta;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private GroupBox grpDetalle;
        private DataGridView dgvDetalle;
        private Label lblTotal;
        private GroupBox grpBotones;
        private Button btnNuevaVenta;
        private Button btnEliminar;
        private Button btnGuardarVenta;
        private Button btnLimpiar;
        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument pdVenta;
    }
}