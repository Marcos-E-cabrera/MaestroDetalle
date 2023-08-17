namespace Carniceria_MD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvConcepto = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            label1 = new Label();
            txtCliente = new TextBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtProducto = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConcepto).BeginInit();
            SuspendLayout();
            // 
            // dgvConcepto
            // 
            dgvConcepto.AllowUserToAddRows = false;
            dgvConcepto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvConcepto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcepto.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, Precio, Eliminar });
            dgvConcepto.Location = new Point(12, 115);
            dgvConcepto.Name = "dgvConcepto";
            dgvConcepto.ReadOnly = true;
            dgvConcepto.RowHeadersWidth = 51;
            dgvConcepto.RowTemplate.Height = 29;
            dgvConcepto.Size = new Size(776, 281);
            dgvConcepto.TabIndex = 0;
            dgvConcepto.CellClick += dgvConcepto_CellClick;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(85, 16);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(92, 69);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 3;
            label2.Text = "Cantidad";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(308, 69);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(223, 68);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(512, 69);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(446, 68);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(694, 69);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(689, 402);
            button2.Name = "button2";
            button2.Size = new Size(99, 36);
            button2.TabIndex = 10;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(dgvConcepto);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvConcepto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConcepto;
        private Label label1;
        private TextBox txtCliente;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewButtonColumn Eliminar;
    }
}