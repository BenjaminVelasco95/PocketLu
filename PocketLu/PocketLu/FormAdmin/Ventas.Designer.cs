namespace PocketLu.FormAdmin
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNVenta = new System.Windows.Forms.Button();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.btnEProducto = new System.Windows.Forms.Button();
            this.dtgDVentas = new System.Windows.Forms.DataGridView();
            this.btnAProducto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.bntDellProdcutos = new System.Windows.Forms.Button();
            this.pCobro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDVentas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNVenta);
            this.groupBox1.Controls.Add(this.dtgVentas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = global::PocketLu.Properties.Resources.eliminar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(0, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR VENTA";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNVenta
            // 
            this.btnNVenta.FlatAppearance.BorderSize = 0;
            this.btnNVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNVenta.Image = global::PocketLu.Properties.Resources.anadir;
            this.btnNVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVenta.Location = new System.Drawing.Point(0, 10);
            this.btnNVenta.Name = "btnNVenta";
            this.btnNVenta.Size = new System.Drawing.Size(219, 40);
            this.btnNVenta.TabIndex = 2;
            this.btnNVenta.Text = "REALIZAR VENTA";
            this.btnNVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNVenta.UseVisualStyleBackColor = true;
            this.btnNVenta.Click += new System.EventHandler(this.btnNVenta_Click);
            // 
            // dtgVentas
            // 
            this.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.dtgVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgVentas.ColumnHeadersHeight = 25;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgVentas.EnableHeadersVisualStyles = false;
            this.dtgVentas.GridColor = System.Drawing.Color.Silver;
            this.dtgVentas.Location = new System.Drawing.Point(0, 102);
            this.dtgVentas.Name = "dtgVentas";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgVentas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentas.Size = new System.Drawing.Size(219, 498);
            this.dtgVentas.TabIndex = 1;
            this.dtgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentas_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pCobro);
            this.groupBox2.Controls.Add(this.lblCerrar);
            this.groupBox2.Controls.Add(this.btnEProducto);
            this.groupBox2.Controls.Add(this.dtgDVentas);
            this.groupBox2.Controls.Add(this.btnAProducto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(219, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 600);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCerrar.Location = new System.Drawing.Point(990, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(20, 19);
            this.lblCerrar.TabIndex = 3;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // btnEProducto
            // 
            this.btnEProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEProducto.FlatAppearance.BorderSize = 0;
            this.btnEProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEProducto.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEProducto.Image = global::PocketLu.Properties.Resources.carrito_de_compras_menos;
            this.btnEProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEProducto.Location = new System.Drawing.Point(748, 19);
            this.btnEProducto.Name = "btnEProducto";
            this.btnEProducto.Size = new System.Drawing.Size(219, 40);
            this.btnEProducto.TabIndex = 2;
            this.btnEProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEProducto.UseVisualStyleBackColor = true;
            this.btnEProducto.Click += new System.EventHandler(this.btnEProducto_Click);
            // 
            // dtgDVentas
            // 
            this.dtgDVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.dtgDVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgDVentas.ColumnHeadersHeight = 25;
            this.dtgDVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDVentas.EnableHeadersVisualStyles = false;
            this.dtgDVentas.GridColor = System.Drawing.Color.Silver;
            this.dtgDVentas.Location = new System.Drawing.Point(6, 65);
            this.dtgDVentas.Name = "dtgDVentas";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgDVentas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgDVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDVentas.Size = new System.Drawing.Size(1010, 484);
            this.dtgDVentas.TabIndex = 2;
            this.dtgDVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDVentas_CellContentClick);
            // 
            // btnAProducto
            // 
            this.btnAProducto.FlatAppearance.BorderSize = 0;
            this.btnAProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAProducto.Image = global::PocketLu.Properties.Resources.carrito_de_compras_verde;
            this.btnAProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAProducto.Location = new System.Drawing.Point(507, 19);
            this.btnAProducto.Name = "btnAProducto";
            this.btnAProducto.Size = new System.Drawing.Size(219, 40);
            this.btnAProducto.TabIndex = 2;
            this.btnAProducto.Text = "AGREGAR PRODUCTO";
            this.btnAProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAProducto.UseVisualStyleBackColor = true;
            this.btnAProducto.Click += new System.EventHandler(this.btnAProducto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCobrar);
            this.groupBox3.Controls.Add(this.bntDellProdcutos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(219, 536);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1016, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCobrar.Image = global::PocketLu.Properties.Resources.tarjeta_de_credito__2_;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(785, 16);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(219, 40);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // bntDellProdcutos
            // 
            this.bntDellProdcutos.FlatAppearance.BorderSize = 0;
            this.bntDellProdcutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bntDellProdcutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bntDellProdcutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDellProdcutos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDellProdcutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntDellProdcutos.Image = global::PocketLu.Properties.Resources.Sin_título_1;
            this.bntDellProdcutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDellProdcutos.Location = new System.Drawing.Point(6, 16);
            this.bntDellProdcutos.Name = "bntDellProdcutos";
            this.bntDellProdcutos.Size = new System.Drawing.Size(219, 40);
            this.bntDellProdcutos.TabIndex = 5;
            this.bntDellProdcutos.Text = "ELIMINAR PRODUCTOS";
            this.bntDellProdcutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntDellProdcutos.UseVisualStyleBackColor = true;
            this.bntDellProdcutos.Click += new System.EventHandler(this.bntDellProdcutos_Click);
            // 
            // pCobro
            // 
            this.pCobro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pCobro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pCobro.Controls.Add(this.lblTotalPagar);
            this.pCobro.Controls.Add(this.label3);
            this.pCobro.Controls.Add(this.lblCambio);
            this.pCobro.Controls.Add(this.label2);
            this.pCobro.Controls.Add(this.txtCPago);
            this.pCobro.Controls.Add(this.label1);
            this.pCobro.Location = new System.Drawing.Point(810, 325);
            this.pCobro.Name = "pCobro";
            this.pCobro.Size = new System.Drawing.Size(200, 205);
            this.pCobro.TabIndex = 4;
            this.pCobro.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Con cuanto Paga?";
            // 
            // txtCPago
            // 
            this.txtCPago.Location = new System.Drawing.Point(17, 139);
            this.txtCPago.Name = "txtCPago";
            this.txtCPago.Size = new System.Drawing.Size(131, 20);
            this.txtCPago.TabIndex = 1;
            this.txtCPago.TextChanged += new System.EventHandler(this.txtCPago_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cambio: $";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(91, 171);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 17);
            this.lblCambio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total: $";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(74, 54);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPagar.TabIndex = 5;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDVentas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.pCobro.ResumeLayout(false);
            this.pCobro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btnNVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEProducto;
        private System.Windows.Forms.DataGridView dtgDVentas;
        private System.Windows.Forms.Button btnAProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button bntDellProdcutos;
        private System.Windows.Forms.Panel pCobro;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label3;
    }
}