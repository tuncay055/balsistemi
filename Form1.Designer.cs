namespace WinFormsApp8
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSDF1 = new TextBox();
            txtSDF2 = new TextBox();
            txtFF = new TextBox();
            txtSeminar = new TextBox();
            txtFinal = new TextBox();
            groupBox1 = new GroupBox();
            btnHesabla = new Button();
            btnSifirla = new Button();
            label7 = new Label();
            txtNomre = new TextBox();
            txtAd = new TextBox();
            btnCixis = new Button();
            dgvTelebeler = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colNomre = new DataGridViewTextBoxColumn();
            colUmumiBal = new DataGridViewTextBoxColumn();
            colKateqoriya = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTelebeler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(604, 86);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 1;
            label1.Text = "İmtahan sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bmu;
            pictureBox1.Location = new Point(38, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 172);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 1;
            label2.Text = "SDF1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 230);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 2;
            label3.Text = "SDF2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 292);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 3;
            label4.Text = "FF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 342);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 4;
            label5.Text = "SEMİNAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 409);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 5;
            label6.Text = "FİNAL";
            // 
            // txtSDF1
            // 
            txtSDF1.Location = new Point(119, 174);
            txtSDF1.Name = "txtSDF1";
            txtSDF1.Size = new Size(124, 23);
            txtSDF1.TabIndex = 6;
            // 
            // txtSDF2
            // 
            txtSDF2.Location = new Point(119, 232);
            txtSDF2.Name = "txtSDF2";
            txtSDF2.Size = new Size(124, 23);
            txtSDF2.TabIndex = 7;
            // 
            // txtFF
            // 
            txtFF.Location = new Point(119, 294);
            txtFF.Name = "txtFF";
            txtFF.Size = new Size(124, 23);
            txtFF.TabIndex = 8;
            // 
            // txtSeminar
            // 
            txtSeminar.Location = new Point(119, 344);
            txtSeminar.Name = "txtSeminar";
            txtSeminar.Size = new Size(124, 23);
            txtSeminar.TabIndex = 9;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(119, 411);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(124, 23);
            txtFinal.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesabla);
            groupBox1.Controls.Add(btnSifirla);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNomre);
            groupBox1.Controls.Add(txtAd);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(268, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 260);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tələbə məlumatları";
            // 
            // btnHesabla
            // 
            btnHesabla.BackColor = Color.FromArgb(0, 192, 192);
            btnHesabla.Location = new Point(6, 163);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(188, 34);
            btnHesabla.TabIndex = 4;
            btnHesabla.Text = "Hesabla";
            btnHesabla.UseVisualStyleBackColor = false;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.BackColor = Color.FromArgb(0, 192, 192);
            btnSifirla.Location = new Point(6, 210);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(188, 34);
            btnSifirla.TabIndex = 3;
            btnSifirla.Text = "Xanaları sıfırla";
            btnSifirla.UseVisualStyleBackColor = false;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 101);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 2;
            label7.Text = "Tələbə nömrəsi";
            // 
            // txtNomre
            // 
            txtNomre.Location = new Point(6, 120);
            txtNomre.Name = "txtNomre";
            txtNomre.Size = new Size(188, 23);
            txtNomre.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(6, 58);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(188, 23);
            txtAd.TabIndex = 0;
            // 
            // btnCixis
            // 
            btnCixis.Location = new Point(832, 480);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(75, 23);
            btnCixis.TabIndex = 12;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = true;
            btnCixis.Click += btnCixis_Click;
            // 
            // dgvTelebeler
            // 
            dgvTelebeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelebeler.Columns.AddRange(new DataGridViewColumn[] { colAd, colNomre, colUmumiBal, colKateqoriya });
            dgvTelebeler.Location = new Point(474, 174);
            dgvTelebeler.Name = "dgvTelebeler";
            dgvTelebeler.Size = new Size(447, 260);
            dgvTelebeler.TabIndex = 13;
            dgvTelebeler.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colAd
            // 
            colAd.HeaderText = "Tələbə adı ";
            colAd.Name = "colAd";
            // 
            // colNomre
            // 
            colNomre.HeaderText = "Tələbə nömrəsi";
            colNomre.Name = "colNomre";
            // 
            // colUmumiBal
            // 
            colUmumiBal.HeaderText = "Ümumi bal";
            colUmumiBal.Name = "colUmumiBal";
            // 
            // colKateqoriya
            // 
            colKateqoriya.HeaderText = "Kateqoriya";
            colKateqoriya.Name = "colKateqoriya";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(919, 515);
            Controls.Add(dgvTelebeler);
            Controls.Add(btnCixis);
            Controls.Add(groupBox1);
            Controls.Add(txtFinal);
            Controls.Add(txtSeminar);
            Controls.Add(txtFF);
            Controls.Add(txtSDF2);
            Controls.Add(txtSDF1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTelebeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSDF1;
        private TextBox txtSDF2;
        private TextBox txtFF;
        private TextBox txtSeminar;
        private TextBox txtFinal;
        private GroupBox groupBox1;
        private TextBox txtNomre;
        private TextBox txtAd;
        private Button btnHesabla;
        private Button btnSifirla;
        private Label label7;
        private Button btnCixis;
        private DataGridView dgvTelebeler;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colNomre;
        private DataGridViewTextBoxColumn colUmumiBal;
        private DataGridViewTextBoxColumn colKateqoriya;
    }
}
