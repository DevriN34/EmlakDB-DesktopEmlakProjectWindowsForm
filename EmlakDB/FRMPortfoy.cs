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
    public partial class FRMPortfoy : Form
    {
        public FRMPortfoy()
        {
            InitializeComponent();
        }

        private void FRMPortfoy_Load(object sender, EventArgs e)
        {
            LISTELE();
        }
        private void LISTELE()
        {
            dataGridView1.DataSource = Home2cs.LISTELE();

            comboBox1.DataSource = Home2cs.LISTELE();
            comboBox1.DisplayMember = "EvID";
            comboBox1.ValueMember = "EvID";

            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = dataGridView1.CurrentRow.Cells["Evresim"].Value.ToString();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "SATILIK")
            {
                SORGULA();
            }
            if (comboBox2.Text == "KİRALIK")
            {
                SORGULA1();
            }
        }
        private void SORGULA()
        {
            dataGridView1.DataSource = Home2cs.SATILIK();

        }
        private void SORGULA1()
        {
            dataGridView1.DataSource = Home2cs.KIRALIK();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMMUSTERI frmmusteri = new FRMMUSTERI();
            frmmusteri.Show();
            this.Hide();
        }
    }
}
