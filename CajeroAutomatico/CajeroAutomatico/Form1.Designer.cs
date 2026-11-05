namespace CajeroAutomatico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMonto = new TextBox();
            btnCalcular = new Button();
            lblMonto = new Label();
            panel1 = new Panel();
            lblPanel = new Label();
            tblBilletes = new TableLayoutPanel();
            pic20000 = new PictureBox();
            lblTexto20000 = new Label();
            lblCantidad20000 = new Label();
            pic10000 = new PictureBox();
            lblTexto10000 = new Label();
            lblCantidad10000 = new Label();
            pic2000 = new PictureBox();
            lblTexto2000 = new Label();
            lblCantidad2000 = new Label();
            pic1000 = new PictureBox();
            lblTexto1000 = new Label();
            lblCantidad1000 = new Label();
            pic500 = new PictureBox();
            lblTexto500 = new Label();
            lblCantidad500 = new Label();
            panel1.SuspendLayout();
            tblBilletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic20000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic10000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic500).BeginInit();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(300, 109);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(156, 25);
            txtMonto.TabIndex = 0;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            txtMonto.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(462, 78);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(136, 80);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(113, 104);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(181, 30);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Ingrese el Monto:";
            lblMonto.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(lblPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 54);
            panel1.TabIndex = 4;
            // 
            // lblPanel
            // 
            lblPanel.AutoSize = true;
            lblPanel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPanel.ForeColor = Color.White;
            lblPanel.Location = new Point(212, 9);
            lblPanel.Name = "lblPanel";
            lblPanel.Size = new Size(259, 37);
            lblPanel.TabIndex = 0;
            lblPanel.Text = "Cajero Automatico";
            // 
            // tblBilletes
            // 
            tblBilletes.BackColor = Color.White;
            tblBilletes.BorderStyle = BorderStyle.FixedSingle;
            tblBilletes.ColumnCount = 3;
            tblBilletes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblBilletes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBilletes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblBilletes.Controls.Add(pic20000, 0, 0);
            tblBilletes.Controls.Add(lblTexto20000, 1, 0);
            tblBilletes.Controls.Add(lblCantidad20000, 2, 0);
            tblBilletes.Controls.Add(pic10000, 0, 1);
            tblBilletes.Controls.Add(lblTexto10000, 1, 1);
            tblBilletes.Controls.Add(lblCantidad10000, 2, 1);
            tblBilletes.Controls.Add(pic2000, 0, 2);
            tblBilletes.Controls.Add(lblTexto2000, 1, 2);
            tblBilletes.Controls.Add(lblCantidad2000, 2, 2);
            tblBilletes.Controls.Add(pic1000, 0, 3);
            tblBilletes.Controls.Add(lblTexto1000, 1, 3);
            tblBilletes.Controls.Add(lblCantidad1000, 2, 3);
            tblBilletes.Controls.Add(pic500, 0, 4);
            tblBilletes.Controls.Add(lblTexto500, 1, 4);
            tblBilletes.Controls.Add(lblCantidad500, 2, 4);
            tblBilletes.Location = new Point(64, 168);
            tblBilletes.Name = "tblBilletes";
            tblBilletes.Padding = new Padding(10);
            tblBilletes.RowCount = 5;
            tblBilletes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBilletes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBilletes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBilletes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBilletes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBilletes.Size = new Size(556, 310);
            tblBilletes.TabIndex = 3;
            // 
            // pic20000
            // 
            pic20000.BorderStyle = BorderStyle.FixedSingle;
            pic20000.Dock = DockStyle.Fill;
            pic20000.Margin = new Padding(0, 4, 8, 4);
            pic20000.Name = "pic20000";
            pic20000.SizeMode = PictureBoxSizeMode.Zoom;
            pic20000.TabStop = false;
            // 
            // lblTexto20000
            // 
            lblTexto20000.AutoSize = false;
            lblTexto20000.Dock = DockStyle.Fill;
            lblTexto20000.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto20000.Margin = new Padding(5, 0, 5, 0);
            lblTexto20000.Name = "lblTexto20000";
            lblTexto20000.Text = "Billetes de $20.000:";
            lblTexto20000.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad20000
            // 
            lblCantidad20000.AutoSize = false;
            lblCantidad20000.Dock = DockStyle.Fill;
            lblCantidad20000.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad20000.Margin = new Padding(5, 0, 5, 0);
            lblCantidad20000.Name = "lblCantidad20000";
            lblCantidad20000.Text = "0";
            lblCantidad20000.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pic10000
            // 
            pic10000.BorderStyle = BorderStyle.FixedSingle;
            pic10000.Dock = DockStyle.Fill;
            pic10000.Margin = new Padding(0, 4, 8, 4);
            pic10000.Name = "pic10000";
            pic10000.SizeMode = PictureBoxSizeMode.Zoom;
            pic10000.TabStop = false;
            // 
            // lblTexto10000
            // 
            lblTexto10000.AutoSize = false;
            lblTexto10000.Dock = DockStyle.Fill;
            lblTexto10000.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto10000.Margin = new Padding(5, 0, 5, 0);
            lblTexto10000.Name = "lblTexto10000";
            lblTexto10000.Text = "Billetes de $10.000:";
            lblTexto10000.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad10000
            // 
            lblCantidad10000.AutoSize = false;
            lblCantidad10000.Dock = DockStyle.Fill;
            lblCantidad10000.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad10000.Margin = new Padding(5, 0, 5, 0);
            lblCantidad10000.Name = "lblCantidad10000";
            lblCantidad10000.Text = "0";
            lblCantidad10000.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pic2000
            // 
            pic2000.BorderStyle = BorderStyle.FixedSingle;
            pic2000.Dock = DockStyle.Fill;
            pic2000.Margin = new Padding(0, 4, 8, 4);
            pic2000.Name = "pic2000";
            pic2000.SizeMode = PictureBoxSizeMode.Zoom;
            pic2000.TabStop = false;
            // 
            // lblTexto2000
            // 
            lblTexto2000.AutoSize = false;
            lblTexto2000.Dock = DockStyle.Fill;
            lblTexto2000.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto2000.Margin = new Padding(5, 0, 5, 0);
            lblTexto2000.Name = "lblTexto2000";
            lblTexto2000.Text = "Billetes de $2.000:";
            lblTexto2000.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad2000
            // 
            lblCantidad2000.AutoSize = false;
            lblCantidad2000.Dock = DockStyle.Fill;
            lblCantidad2000.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad2000.Margin = new Padding(5, 0, 5, 0);
            lblCantidad2000.Name = "lblCantidad2000";
            lblCantidad2000.Text = "0";
            lblCantidad2000.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pic1000
            // 
            pic1000.BorderStyle = BorderStyle.FixedSingle;
            pic1000.Dock = DockStyle.Fill;
            pic1000.Margin = new Padding(0, 4, 8, 4);
            pic1000.Name = "pic1000";
            pic1000.SizeMode = PictureBoxSizeMode.Zoom;
            pic1000.TabStop = false;
            // 
            // lblTexto1000
            // 
            lblTexto1000.AutoSize = false;
            lblTexto1000.Dock = DockStyle.Fill;
            lblTexto1000.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto1000.Margin = new Padding(5, 0, 5, 0);
            lblTexto1000.Name = "lblTexto1000";
            lblTexto1000.Text = "Billetes de $1.000:";
            lblTexto1000.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad1000
            // 
            lblCantidad1000.AutoSize = false;
            lblCantidad1000.Dock = DockStyle.Fill;
            lblCantidad1000.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad1000.Margin = new Padding(5, 0, 5, 0);
            lblCantidad1000.Name = "lblCantidad1000";
            lblCantidad1000.Text = "0";
            lblCantidad1000.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pic500
            // 
            pic500.BorderStyle = BorderStyle.FixedSingle;
            pic500.Dock = DockStyle.Fill;
            pic500.Margin = new Padding(0, 4, 8, 4);
            pic500.Name = "pic500";
            pic500.SizeMode = PictureBoxSizeMode.Zoom;
            pic500.TabStop = false;
            // 
            // lblTexto500
            // 
            lblTexto500.AutoSize = false;
            lblTexto500.Dock = DockStyle.Fill;
            lblTexto500.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto500.Margin = new Padding(5, 0, 5, 0);
            lblTexto500.Name = "lblTexto500";
            lblTexto500.Text = "Billetes de $500:";
            lblTexto500.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad500
            // 
            lblCantidad500.AutoSize = false;
            lblCantidad500.Dock = DockStyle.Fill;
            lblCantidad500.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad500.Margin = new Padding(5, 0, 5, 0);
            lblCantidad500.Name = "lblCantidad500";
            lblCantidad500.Text = "0";
            lblCantidad500.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(684, 522);
            Controls.Add(tblBilletes);
            Controls.Add(panel1);
            Controls.Add(lblMonto);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cajero Automatico";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tblBilletes.ResumeLayout(false);
            tblBilletes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic20000).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic10000).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2000).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1000).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic500).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private Button btnCalcular;
        private Label lblMonto;
        private Panel panel1;
        private Label lblPanel;
        private TableLayoutPanel tblBilletes;
        private PictureBox pic20000;
        private Label lblTexto20000;
        private Label lblCantidad20000;
        private PictureBox pic10000;
        private Label lblTexto10000;
        private Label lblCantidad10000;
        private PictureBox pic2000;
        private Label lblTexto2000;
        private Label lblCantidad2000;
        private PictureBox pic1000;
        private Label lblTexto1000;
        private Label lblCantidad1000;
        private PictureBox pic500;
        private Label lblTexto500;
        private Label lblCantidad500;
    }
}
