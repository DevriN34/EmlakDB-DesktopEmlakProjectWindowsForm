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
    public partial class FRMDetails : Form
    {
        public FRMDetails()
        {
            InitializeComponent();
        }
        private bool KONTROL_ET()
        {
            bool DON = true;
            if (cmbEvID.Text == string.Empty)
            {
                MessageBox.Show("İSİM BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
            if (cmbper.Text == string.Empty)
            {
                MessageBox.Show("İSİM BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("İSİM BİLGİSİ EKSİKTİR...");
                DON = false;
                return DON;
            }
        


            return DON;

        }

        private void FRMDetails_Load(object sender, EventArgs e)
        {
            LISTELE();
        }
        int HomedetailsID = 0;
        
        private void LISTELE()
        {
            dataGridView1.DataSource = HomeDetailscs.LISTELE();

            cmbEvID.DataSource = Home2cs.LISTELE();
            cmbEvID.DisplayMember = "EvID";
            cmbEvID.ValueMember = "EvID";

            cmbper.DataSource = Personelcs.LISTELE();
            cmbper.DisplayMember = "PersonelID";
            cmbper.ValueMember = "PersonelID";




        }
        private void TEMIZLE()
        {
            cmbper.Text = string.Empty;
            cmbEvID.Text = string.Empty;
            textBox1.Text = string.Empty;
          


            HomedetailsID = 0;
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            if (KONTROL_ET())
            {
                HomeDetails houses = new HomeDetails();

                houses.HomedetailsID = HomedetailsID;
                houses.EvID = Convert.ToInt32(cmbEvID.Text);
                houses.PersonelID = Convert.ToInt32(cmbper.Text);
                houses.Notes = textBox1.Text;
                houses.CREATEDATE = DateTime.Now;
                houses.IS_FLAG = 1;


                if (HomedetailsID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Güncelleme yapılsın mı?", "Güncelleme İŞLEMİ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            HomeDetailscs.Update(houses);
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
                        HomeDetailscs.Insert(houses);
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

     
            private void dataGridView1_Click(object sender, EventArgs e)
            {   HomedetailsID = (int)dataGridView1.CurrentRow.Cells["HomedetailsID"].Value;
                cmbEvID.Text = dataGridView1.CurrentRow.Cells["EvID"].Value.ToString();
                cmbper.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               textBox1.Text = dataGridView1.CurrentRow.Cells["Notes"].Value.ToString();
                
        }

        private void butsil_Click(object sender, EventArgs e)
        {
            if (HomedetailsID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("SİLME YAPILSIN MI?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (giriskontrol == DialogResult.Yes)
                {
                    HomeDetails evler = new HomeDetails();
                    evler.HomedetailsID = HomedetailsID;
                    try
                    {
                        HomeDetailscs.SIL(evler);
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
    }
}
