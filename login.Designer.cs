namespace patitasOrgMILAV
{
    partial class login
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
            panel1 = new Panel();
            btnClose = new Button();
            imgbLog = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogIn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgbLog).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 136);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.MenuHighlight;
            btnClose.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.HighlightText;
            btnClose.Location = new Point(282, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // imgbLog
            // 
            imgbLog.Image = Properties.Resources.images;
            imgbLog.Location = new Point(94, 59);
            imgbLog.Name = "imgbLog";
            imgbLog.Size = new Size(125, 128);
            imgbLog.SizeMode = PictureBoxSizeMode.StretchImage;
            imgbLog.TabIndex = 1;
            imgbLog.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(121, 219);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(104, 287);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = SystemColors.MenuHighlight;
            btnLogIn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = SystemColors.ControlLightLight;
            btnLogIn.Location = new Point(77, 369);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(158, 43);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Iniciar Sesion";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(321, 414);
            Controls.Add(btnLogIn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgbLog);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgbLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private PictureBox imgbLog;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogIn;
    }
}