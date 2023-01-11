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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="24658463468" ||  textBox2.Text=="ozan")
            {
                MAIN frmmain = new MAIN();
                frmmain.Show();
                this.Hide();
            }
           else if (textBox1.Text == "28114454076" || textBox2.Text == "fahriye")
            {
                MAIN frmmain = new MAIN();
                frmmain.Show();
                this.Hide();
            }
             else if (textBox1.Text == "12259824924" || textBox2.Text == "kerim")
            {
                
                MAIN frmmain = new MAIN();
                frmmain.Show();
                this.Hide();
            }
             else if (textBox1.Text != "24658463468" || textBox2.Text != "ozan")
            {
                MessageBox.Show("Giriş Yapamazsın","Bilgileri Doldur");
            }

            else if (textBox1.Text != "28114454076" || textBox2.Text != "fahriye")
            {
                MessageBox.Show("Giriş Yapamazsın", "Bilgileri Doldur");
            }

            else if (textBox1.Text != "12259824924" || textBox2.Text != "kerim")
            {
                MessageBox.Show("Giriş Yapamazsın", "Bilgileri Doldur");
            }
           

        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            label3.BackColor = Color.Red;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            
            if (i ==1)
            {
                label3.BackColor = Color.Purple;
            }
            if (i == 2)
            {
                label3.BackColor = Color.Green;
            }
            if (i == 3)
            {
                label3.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                i = 0;
            }
            return;


        }
    }
}
