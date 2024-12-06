namespace patitasOrgMILAV
{
    partial class paginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaInicial));
            tabCtrlPagPrin = new TabControl();
            Nosotros = new TabPage();
            lblInfoOrg = new Label();
            Campañas = new TabPage();
            lblCampañas = new Label();
            dgvCampañas = new DataGridView();
            Reportes = new TabPage();
            gbReportes = new GroupBox();
            btnSubirReporte = new Button();
            tbReportes = new TextBox();
            lblGbRepor = new Label();
            lblReportes = new Label();
            dataGridView1 = new DataGridView();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            tabCtrlPagPrin.SuspendLayout();
            Nosotros.SuspendLayout();
            Campañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).BeginInit();
            Reportes.SuspendLayout();
            gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabCtrlPagPrin
            // 
            tabCtrlPagPrin.Alignment = TabAlignment.Left;
            tabCtrlPagPrin.Controls.Add(Nosotros);
            tabCtrlPagPrin.Controls.Add(Campañas);
            tabCtrlPagPrin.Controls.Add(Reportes);
            tabCtrlPagPrin.Location = new Point(0, 1);
            tabCtrlPagPrin.Multiline = true;
            tabCtrlPagPrin.Name = "tabCtrlPagPrin";
            tabCtrlPagPrin.SelectedIndex = 0;
            tabCtrlPagPrin.Size = new Size(600, 397);
            tabCtrlPagPrin.TabIndex = 0;
            // 
            // Nosotros
            // 
            Nosotros.BackColor = Color.White;
            Nosotros.Controls.Add(lblInfoOrg);
            Nosotros.Cursor = Cursors.Hand;
            Nosotros.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nosotros.Location = new Point(27, 4);
            Nosotros.Name = "Nosotros";
            Nosotros.Padding = new Padding(3);
            Nosotros.Size = new Size(569, 389);
            Nosotros.TabIndex = 1;
            Nosotros.Text = "   Sobre Nosoros  ";
            // 
            // lblInfoOrg
            // 
            lblInfoOrg.AutoSize = true;
            lblInfoOrg.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoOrg.Location = new Point(0, 32);
            lblInfoOrg.Name = "lblInfoOrg";
            lblInfoOrg.Size = new Size(566, 299);
            lblInfoOrg.TabIndex = 0;
            lblInfoOrg.Text = resources.GetString("lblInfoOrg.Text");
            lblInfoOrg.TextAlign = ContentAlignment.TopCenter;
            // 
            // Campañas
            // 
            Campañas.BackColor = Color.WhiteSmoke;
            Campañas.Controls.Add(lblCampañas);
            Campañas.Controls.Add(dgvCampañas);
            Campañas.Cursor = Cursors.Hand;
            Campañas.Location = new Point(27, 4);
            Campañas.Name = "Campañas";
            Campañas.Padding = new Padding(3);
            Campañas.Size = new Size(569, 389);
            Campañas.TabIndex = 2;
            Campañas.Text = "  Campañas  ";
            // 
            // lblCampañas
            // 
            lblCampañas.AutoSize = true;
            lblCampañas.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCampañas.Location = new Point(93, 33);
            lblCampañas.Name = "lblCampañas";
            lblCampañas.Size = new Size(396, 36);
            lblCampañas.TabIndex = 1;
            lblCampañas.Text = "En esta seccion puedes apreciar las campañas \r\nque estan activas en la organizacion";
            lblCampañas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCampañas
            // 
            dgvCampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampañas.Location = new Point(43, 86);
            dgvCampañas.Name = "dgvCampañas";
            dgvCampañas.Size = new Size(487, 268);
            dgvCampañas.TabIndex = 0;
            // 
            // Reportes
            // 
            Reportes.BackColor = Color.White;
            Reportes.Controls.Add(gbReportes);
            Reportes.Controls.Add(lblReportes);
            Reportes.Controls.Add(dataGridView1);
            Reportes.Cursor = Cursors.Hand;
            Reportes.Location = new Point(27, 4);
            Reportes.Name = "Reportes";
            Reportes.Padding = new Padding(3);
            Reportes.Size = new Size(569, 389);
            Reportes.TabIndex = 3;
            Reportes.Text = "  Reportes  ";
            // 
            // gbReportes
            // 
            gbReportes.Controls.Add(btnSubirReporte);
            gbReportes.Controls.Add(tbReportes);
            gbReportes.Controls.Add(lblGbRepor);
            gbReportes.Location = new Point(324, 76);
            gbReportes.Name = "gbReportes";
            gbReportes.Size = new Size(239, 278);
            gbReportes.TabIndex = 2;
            gbReportes.TabStop = false;
            // 
            // btnSubirReporte
            // 
            btnSubirReporte.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirReporte.Location = new Point(82, 217);
            btnSubirReporte.Name = "btnSubirReporte";
            btnSubirReporte.Size = new Size(92, 33);
            btnSubirReporte.TabIndex = 2;
            btnSubirReporte.Text = "Reportar";
            btnSubirReporte.UseVisualStyleBackColor = true;
            // 
            // tbReportes
            // 
            tbReportes.Location = new Point(15, 70);
            tbReportes.Multiline = true;
            tbReportes.Name = "tbReportes";
            tbReportes.Size = new Size(217, 128);
            tbReportes.TabIndex = 1;
            // 
            // lblGbRepor
            // 
            lblGbRepor.AutoSize = true;
            lblGbRepor.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGbRepor.Location = new Point(6, 19);
            lblGbRepor.Name = "lblGbRepor";
            lblGbRepor.Size = new Size(226, 32);
            lblGbRepor.TabIndex = 0;
            lblGbRepor.Text = "Escribe breve y objetivamente \r\nla situacion que deseas reportar:";
            lblGbRepor.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportes.Location = new Point(73, 27);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(182, 25);
            lblReportes.TabIndex = 1;
            lblReportes.Text = "Reportes/Avisos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(296, 278);
            dataGridView1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(611, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Iniciar sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoMILAV_Final;
            pictureBox2.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox2.Location = new Point(611, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 371);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(tabCtrlPagPrin);
            Name = "paginaInicial";
            Text = "Pagina principal";
            tabCtrlPagPrin.ResumeLayout(false);
            Nosotros.ResumeLayout(false);
            Nosotros.PerformLayout();
            Campañas.ResumeLayout(false);
            Campañas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).EndInit();
            Reportes.ResumeLayout(false);
            Reportes.PerformLayout();
            gbReportes.ResumeLayout(false);
            gbReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCtrlPagPrin;
        private TabPage Nosotros;
        private TabPage Campañas;
        private TabPage Reportes;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private Label lblInfoOrg;
        private Label lblCampañas;
        private DataGridView dgvCampañas;
        private GroupBox gbReportes;
        private Label lblGbRepor;
        private Label lblReportes;
        private DataGridView dataGridView1;
        private Button btnSubirReporte;
        private TextBox tbReportes;
    }
}
