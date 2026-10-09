using System;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {

            int sdf1, sdf2, ff, seminar, finalBal;

            if (!int.TryParse(txtSDF1.Text, out sdf1) ||
                !int.TryParse(txtSDF2.Text, out sdf2) ||
                !int.TryParse(txtFF.Text, out ff) ||
                !int.TryParse(txtSeminar.Text, out seminar) ||
                !int.TryParse(txtFinal.Text, out finalBal))
            {
                MessageBox.Show("Bütün bal xanalarını düzgün doldurun!");
                return;
            }

            if (sdf1 < 0 || sdf1 > 10 ||
                sdf2 < 0 || sdf2 > 10 ||
                ff < 0 || ff > 10 ||
                seminar < 0 || seminar > 20 ||
                finalBal < 0 || finalBal > 50)
            {
                MessageBox.Show("Balları maksimum qiymətlərə uyğun daxil edin!");
                return;
            }

            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Tələbənin adını daxil edin!");
                return;
            }

            if (txtNomre.Text.Length != 9 ||
                !long.TryParse(txtNomre.Text, out _))
            {
                MessageBox.Show("Tələbə nömrəsi 9 rəqəm olmalıdır!");
                return;
            }

            int umumiBal = sdf1 + sdf2 + ff + seminar + finalBal;

            string kateqoriya;

            if (umumiBal >= 90)
                kateqoriya = "A";
            else if (umumiBal >= 80)
                kateqoriya = "B";
            else if (umumiBal >= 70)
                kateqoriya = "C";
            else if (umumiBal >= 60)
                kateqoriya = "D";
            else if (umumiBal > 50)
                kateqoriya = "F";
            else
                kateqoriya = "Kəsildi";

            dgvTelebeler.Rows.Add(
                txtAd.Text,
                txtNomre.Text,
                umumiBal,
                kateqoriya
            );

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtSDF1.Clear();
            txtSDF2.Clear();
            txtFF.Clear();
            txtSeminar.Clear();
            txtFinal.Clear();
            txtAd.Clear();
            txtNomre.Clear();

            txtSDF1.Focus();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
