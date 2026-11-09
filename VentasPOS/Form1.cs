using System.Drawing.Printing;
using System.Globalization;

namespace VentasPOS
{
    // Clase (objeto) que representa un producto

    public partial class frmVentas : Form
    {
        private readonly CultureInfo cultura = new CultureInfo("es-CO");

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // Productos por defecto
            List<Producto> productos = new List<Producto>
            {
                new Producto("Teclado", 45000),
                new Producto("Mouse", 30000),
                new Producto("Monitor", 650000),
                new Producto("Impresora", 480000),
                new Producto("Memoria USB", 35000)
            };

            cmbProducto.DataSource = productos;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.SelectedIndex = -1;

            // Columnas de la tabla
            dgvDetalle.Columns.Add("colProducto", "Producto");
            dgvDetalle.Columns.Add("colPrecio", "Precio ($)");
            dgvDetalle.Columns.Add("colCantidad", "Cantidad");
            dgvDetalle.Columns.Add("colSubtotal", "Subtotal ($)");

            dgvDetalle.Columns["colPrecio"].DefaultCellStyle.Format = "N0";
            dgvDetalle.Columns["colPrecio"].DefaultCellStyle.FormatProvider = cultura;
            dgvDetalle.Columns["colSubtotal"].DefaultCellStyle.Format = "N0";
            dgvDetalle.Columns["colSubtotal"].DefaultCellStyle.FormatProvider = cultura;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Suma todos los subtotales y actualiza el label
        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
            }
            lblTotal.Text = "TOTAL DE LA VENTA: $" + total.ToString("N0", cultura);
            return total;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del cliente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (cmbProducto.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Seleccione un producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (número mayor a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            decimal subtotal = producto.Precio * cantidad;
            dgvDetalle.Rows.Add(producto.Nombre, producto.Precio, cantidad, subtotal);

            CalcularTotal();

            txtCantidad.Clear();
            cmbProducto.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el producto que desea eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            CalcularTotal();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            txtCliente.Clear();
            txtCantidad.Clear();
            cmbProducto.SelectedIndex = -1;
            CalcularTotal();
            txtCliente.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia solo los campos de captura, no la tabla
            txtCantidad.Clear();
            cmbProducto.SelectedIndex = -1;
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() == "" || dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese el cliente y al menos un producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Venta guardada para " + txtCliente.Text +
                "\nTotal: $" + CalcularTotal().ToString("N0", cultura),
                "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() == "" || dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay una venta para imprimir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                pdVenta.Print(); // Envía a la impresora predeterminada (PDF)
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo imprimir: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Aquí se "dibuja" el comprobante que se imprime
        private void pdVenta_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            using Font fTitulo = new Font("Arial", 16, FontStyle.Bold);
            using Font fNormal = new Font("Arial", 11);
            using Font fNegrita = new Font("Arial", 11, FontStyle.Bold);

            float x = 50;
            float y = 50;

            g.DrawString("COMPROBANTE DE VENTA", fTitulo, Brushes.Black, x, y);
            y += 45;
            g.DrawString("Cliente: " + txtCliente.Text, fNormal, Brushes.Black, x, y);
            y += 25;
            g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fNormal, Brushes.Black, x, y);
            y += 40;

            // Encabezados
            g.DrawString("Producto", fNegrita, Brushes.Black, 50, y);
            g.DrawString("Precio", fNegrita, Brushes.Black, 300, y);
            g.DrawString("Cant.", fNegrita, Brushes.Black, 440, y);
            g.DrawString("Subtotal", fNegrita, Brushes.Black, 540, y);
            y += 22;
            g.DrawLine(Pens.Black, 50, y, 700, y);
            y += 10;

            // Filas
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                decimal precio = Convert.ToDecimal(fila.Cells["colPrecio"].Value);
                decimal subtotal = Convert.ToDecimal(fila.Cells["colSubtotal"].Value);

                g.DrawString(fila.Cells["colProducto"].Value?.ToString(), fNormal, Brushes.Black, 50, y);
                g.DrawString("$" + precio.ToString("N0", cultura), fNormal, Brushes.Black, 300, y);
                g.DrawString(fila.Cells["colCantidad"].Value?.ToString(), fNormal, Brushes.Black, 440, y);
                g.DrawString("$" + subtotal.ToString("N0", cultura), fNormal, Brushes.Black, 540, y);
                y += 25;
            }

            y += 5;
            g.DrawLine(Pens.Black, 50, y, 700, y);
            y += 15;
            g.DrawString("TOTAL: $" + CalcularTotal().ToString("N0", cultura), fTitulo, Brushes.Black, 440, y);
        }
    }
}