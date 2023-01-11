using EmlakDB.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakDB
{
    public partial class FRMMUSTERI : Form
    {
        public FRMMUSTERI()
        {
            InitializeComponent();
        }
        int musteriID = 0;

        private void LISTELE()
        {
            dataGridView1.DataSource = Musterics.LISTELE();

            comevıd.DataSource = Home2cs.LISTELE();
            comevıd.DisplayMember = "EvID";
            comevıd.ValueMember = "EvID";

        }
        private void TEMIZLE()
        {
            txtmüsadı.Text = string.Empty;
            txtmüsoyad.Text = string.Empty;
            txttelno.Text = string.Empty;
            comevıd.Text = string.Empty;
            txtgorsel.Text = string.Empty;

            musteriID = 0;
        }
        private void buttonekle_Click(object sender, EventArgs e)
        {
            if (KONTROL_ET())
            {
                 Musteri musteriler = new Musteri();
               


                musteriler.MusteriID = musteriID;
                musteriler.Ad = txtmüsadı.Text;
                musteriler.Soyad = txtmüsoyad.Text;
                musteriler.EvID = Convert.ToInt32(comevıd.Text);
                musteriler.TelefonNO = txttelno.Text;
          
               



                musteriler.CREATEDATE = DateTime.Now;
                musteriler.IS_FLAG = 1;


                if (musteriID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Güncelleme yapılsın mı?", "Güncelleme İŞLEMİ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            Musterics.Update(musteriler);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("HATA :" + ex);
                        }

                    }

                }
                else
                {
                    try
                    {
                        Musterics.Insert(musteriler);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("HATA : " + ex);
                    }

                }
                TEMIZLE();
                LISTELE();
            }
        }
        private bool KONTROL_ET()
        {
            bool DON = true;

            if (txtmüsadı.Text == string.Empty)
            {
                MessageBox.Show("İSİM BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (txtmüsoyad.Text == string.Empty)
            {
                MessageBox.Show("SOYAD SAYI BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }


            if (txttelno.Text == string.Empty)
            {
                MessageBox.Show("TELEFON NUMARA BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }

            return DON;


        }

        private void FRMMUSTERI_Load(object sender, EventArgs e)
        {
            LISTELE();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            musteriID = (int)dataGridView1.CurrentRow.Cells["MusteriID"].Value;
            txtmüsadı.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtmüsoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            comevıd.Text = dataGridView1.CurrentRow.Cells["EvID"].Value.ToString();
            txttelno.Text = dataGridView1.CurrentRow.Cells["TelefonNO"].Value.ToString();
            openFileDialog1.FileName = dataGridView1.CurrentRow.Cells["Evresim"].Value.ToString();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Show();





        }

        private void butsil_Click(object sender, EventArgs e)
        {
            if (musteriID !=0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme İşlemi yapılsın mı?", "Silme İşlemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (giriskontrol== DialogResult.Yes)
                {
                    Musteri müsteri = new Musteri();
                    müsteri.MusteriID = musteriID;
                    try
                    {
                        Musterics.SIL(müsteri);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(" YAPMAAA" + ex);
                    }
                    TEMIZLE();
                    LISTELE();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtgorsel.Text = openFileDialog1.FileName;
        }

        private void buttemizle_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMDetails fRMDetails = new FRMDetails();
            fRMDetails.Show();
            this.Hide();
        }
       
        private void butlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Home2cs.LISTELE();
        }
    }
}
