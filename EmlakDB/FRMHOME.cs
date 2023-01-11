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
    public partial class FRMHOME : Form
    {
        public FRMHOME()
        {
            InitializeComponent();
        }

        private void FRMHOME_Load(object sender, EventArgs e)
        {
            LISTELE();
        }

        private void SORGULA()
        {
            dataGridView1.DataSource = Home2cs.SATILIK();

        }
        private void SORGULA1()
        {
            dataGridView1.DataSource = Home2cs.KIRALIK();
        }
            
        private void LISTELE()
        {
            dataGridView1.DataSource = Home2cs.LISTELE();

            //comEv.DataSource = Home2cs.LISTELE();
            //comEv.DisplayMember = "EvID";
            //comEv.ValueMember = "EvID";

            comilID.DataSource = ilcs.LISTELE();
            comilID.DisplayMember = "il_ID";
            comilID.ValueMember = "il_ID";

            comilceID.DataSource = ilcelercscs.LISTELE();
            comilceID.DisplayMember = "ilce_isim";
            comilceID.ValueMember = "ilce_ID";

            //comboBox1.DataSource = Homecs.LISTELE();
            //comboBox1.DisplayMember = "EvDurumu";
            //comboBox1.ValueMember = "EvDurumu";


        }
        private void TEMIZLE()
        {

            comilID.Text = string.Empty;
            comilceID.Text = string.Empty;
            txtodasayi.Text = string.Empty;
            txtevalani.Text = string.Empty;
            txtkatno.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            txtFiyat.Text = string.Empty;
            txtDepozito.Text = string.Empty;
            txtKapora.Text = string.Empty;
            Cmbsoz.Text = string.Empty;
            

            EvID = 0;
        }
        int EvID = 0;
        private void buttonekle_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sayi3 = 0;
            double kdv = 18;
            if (comboBox1.Text == "KİRALIK")
            {
                kdv = 18;
            }
            else if (Convert.ToDouble(txtevalani.Text) >= 150)
            {
                kdv = 18;
            }
            else if (Convert.ToDouble(txtevalani.Text) < 150)
            {
                kdv = 8;
            }
           

            sayi1 = Convert.ToDouble(txtFiyat.Text);
            sayi2 = Convert.ToDouble(txtDepozito.Text);
            sayi3 = Convert.ToDouble(txtKapora.Text);
            double sonuc = sayi1 - (sayi2 + sayi3);
            sonuc = sonuc + sonuc * kdv / 100;

            if (KONTROL_ET())
            {
                Home2 evler = new Home2();
                


                evler.EvID = EvID;
                evler.OdaSayisi = Convert.ToInt32(txtodasayi.Text);
                evler.KatNumarasi = Convert.ToInt32(txtkatno.Text);
                evler.YapimTarihi = Convert.ToDateTime(dateTimePicker1.Value);
                evler.EvDurumu = comboBox1.Text;
                evler.ilce_ID = Convert.ToInt32( comilceID.Text);
                evler.il_ID = Convert.ToInt32(comilID.Text);
                evler.ToplamEvAlani = Convert.ToInt32(txtevalani.Text.ToString());
                evler.Fiyat = Convert.ToInt32(sonuc);
                evler.Depozito = Convert.ToInt32(txtDepozito.Text);
                evler.Kapora = Convert.ToInt32(txtKapora.Text);
                 evler.Sözleşme = Cmbsoz.Text;
                evler.Evresim = openFileDialog1.FileName;
               
               

                evler.CREATEDATE = DateTime.Now;
                evler.IS_FLAG = 1;


                if (EvID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Güncelleme yapılsın mı?", "Güncelleme İŞLEMİ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            Home2cs.Update(evler);
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
                        Home2cs.Insert(evler);
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

            if (txtodasayi.Text == string.Empty)
            {
                MessageBox.Show("ODA SAYI BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("ZAMAN  BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }


            if (txtkatno.Text == string.Empty)
            {
                MessageBox.Show("KAT NUMARA BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (txtevalani.Text == string.Empty)
            {
                MessageBox.Show("EV ALAN BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }


            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("EV DURUM BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            else if (!(comboBox1.Text == "SATILIK" || comboBox1.Text == "KİRALIK"))
            {
                MessageBox.Show("EV DURUM BİLGİSİ S VEYA K OLMALI...");
                DON = false;
                return DON;
            }
            if (txtFiyat.Text == string.Empty)
            {
                MessageBox.Show("FİYAT BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (txtDepozito.Text == string.Empty)
            {
                MessageBox.Show("DEPOZİTO BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (txtKapora.Text == string.Empty)
            {
                MessageBox.Show("KAPORA BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
           
            if (Cmbsoz.Text == string.Empty)
            {
                MessageBox.Show("SÖZLEŞME BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (Cmbsoz.Text == string.Empty)
            {
                MessageBox.Show("SÖZLEŞME BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (comilceID.Text == string.Empty)
            {
                MessageBox.Show("İLÇE BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (comilID.Text == string.Empty)
            {
                MessageBox.Show("İL BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (txtgorsel.Text == string.Empty)
            {
                MessageBox.Show("Görsel BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }


            return DON;
            
            
        }
             
        private void butsil_Click(object sender, EventArgs e)
        {
            if (EvID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("SİLME YAPILSIN MI?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (giriskontrol == DialogResult.Yes)
                {
                    Home2 evler = new Home2();
                    evler.EvID = EvID;
                    try
                    {
                        Home2cs.SIL(evler);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("HATA : " + ex);
                    }

                    TEMIZLE();
                    LISTELE();
                   
                    
                }
            }
        }

        private void buttemizle_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void butlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Home2cs.DETAYLISTELE(comilceID.SelectedValue.ToString(), comilID.SelectedValue.ToString());
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            EvID = (int)dataGridView1.CurrentRow.Cells["EvID"].Value;
            txtodasayi.Text = dataGridView1.CurrentRow.Cells["OdaSayisi"].Value.ToString();
            txtkatno.Text = dataGridView1.CurrentRow.Cells["KatNumarasi"].Value.ToString();
            txtevalani.Text = dataGridView1.CurrentRow.Cells["ToplamEvAlani"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["YapimTarihi"].Value);
            comboBox1.Text = dataGridView1.CurrentRow.Cells["EvDurumu"].Value.ToString();
            comilceID.Text = dataGridView1.CurrentRow.Cells["ilce_isim"].Value.ToString();
            comilID.Text = dataGridView1.CurrentRow.Cells["il_isim"].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
            txtDepozito.Text = dataGridView1.CurrentRow.Cells["Depozito"].Value.ToString();
            txtKapora.Text = dataGridView1.CurrentRow.Cells["Kapora"].Value.ToString();
            Cmbsoz.Text = dataGridView1.CurrentRow.Cells["Sözleşme"].Value.ToString();
            txtgorsel.Text = dataGridView1.CurrentRow.Cells["Evresim"].Value.ToString();
            openFileDialog1.FileName = dataGridView1.CurrentRow.Cells["Evresim"].Value.ToString();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Show();

             
            

            







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comEv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "SATILIK")
            {
                SORGULA();
            }
            if (comboBox1.Text == "KİRALIK")
            {
                SORGULA1();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comilID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comilceID.DataSource = ilcelercscs.LISTELE(comilID.SelectedValue.ToString());
            comilceID.DisplayMember = "ilce_ID";
            comilceID.ValueMember = "ilce_ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LISTELE();
        }

        private void comilceID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void txtDepozito_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //EVGÖRSELLERİ frmev = new EVGÖRSELLERİ();
            //frmev.Show();
            //this.Hide();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtgorsel.Text = openFileDialog1.FileName;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
