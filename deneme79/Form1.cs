using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace deneme79
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BJO2DGU\\SQLEXPRESS;Initial Catalog=DbFilmArsivi;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Fimler (FilmAd,FilmTur,FilmPuan,FilmKategori,FilmResim) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komutekle.Parameters.AddWithValue("@p1",txtAd.Text);
            komutekle.Parameters.AddWithValue("@p2", txtTur.Text);
            komutekle.Parameters.AddWithValue("@p3", float.Parse(txtPuan.Text));
            komutekle.Parameters.AddWithValue("@p4",txtKategori.Text);
            komutekle.Parameters.AddWithValue("@p5",txtResim.Text);
            komutekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFilmArsiviDataSet.Tbl_Fimler' table. You can move, or remove it, as needed.
            this.tbl_FimlerTableAdapter.Fill(this.dbFilmArsiviDataSet.Tbl_Fimler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPuan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
