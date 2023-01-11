namespace EmlakDB
{
    partial class FRMMUSTERI
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
            this.butlist = new System.Windows.Forms.Button();
            this.buttemizle = new System.Windows.Forms.Button();
            this.butsil = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmüsadı = new System.Windows.Forms.TextBox();
            this.txtmüsoyad = new System.Windows.Forms.TextBox();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.comevıd = new System.Windows.Forms.ComboBox();
            this.txtgorsel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butlist
            // 
            this.butlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butlist.Location = new System.Drawing.Point(648, 209);
            this.butlist.Name = "butlist";
            this.butlist.Size = new System.Drawing.Size(138, 54);
            this.butlist.TabIndex = 20;
            this.butlist.Text = "LİSTELE";
            this.butlist.UseVisualStyleBackColor = true;
            this.butlist.Click += new System.EventHandler(this.butlist_Click);
            // 
            // buttemizle
            // 
            this.buttemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttemizle.Location = new System.Drawing.Point(648, 139);
            this.buttemizle.Name = "buttemizle";
            this.buttemizle.Size = new System.Drawing.Size(138, 54);
            this.buttemizle.TabIndex = 19;
            this.buttemizle.Text = "TEMİZLE";
            this.buttemizle.UseVisualStyleBackColor = true;
            this.buttemizle.Click += new System.EventHandler(this.buttemizle_Click);
            // 
            // butsil
            // 
            this.butsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butsil.Location = new System.Drawing.Point(648, 74);
            this.butsil.Name = "butsil";
            this.butsil.Size = new System.Drawing.Size(138, 54);
            this.butsil.TabIndex = 18;
            this.butsil.Text = "SİL";
            this.butsil.UseVisualStyleBackColor = true;
            this.butsil.Click += new System.EventHandler(this.butsil_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonekle.Location = new System.Drawing.Point(648, 14);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(138, 54);
            this.buttonekle.TabIndex = 17;
            this.buttonekle.Text = "EKLE VE GÜNCELLE";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "SOYADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "TELEFON NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "EV ID";
            // 
            // txtmüsadı
            // 
            this.txtmüsadı.Location = new System.Drawing.Point(147, 21);
            this.txtmüsadı.Name = "txtmüsadı";
            this.txtmüsadı.Size = new System.Drawing.Size(100, 20);
            this.txtmüsadı.TabIndex = 25;
            // 
            // txtmüsoyad
            // 
            this.txtmüsoyad.Location = new System.Drawing.Point(147, 70);
            this.txtmüsoyad.Name = "txtmüsoyad";
            this.txtmüsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmüsoyad.TabIndex = 26;
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(147, 122);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(100, 20);
            this.txttelno.TabIndex = 27;
            // 
            // comevıd
            // 
            this.comevıd.FormattingEnabled = true;
            this.comevıd.Location = new System.Drawing.Point(147, 172);
            this.comevıd.Name = "comevıd";
            this.comevıd.Size = new System.Drawing.Size(121, 21);
            this.comevıd.TabIndex = 28;
            // 
            // txtgorsel
            // 
            this.txtgorsel.Location = new System.Drawing.Point(147, 229);
            this.txtgorsel.Name = "txtgorsel";
            this.txtgorsel.Size = new System.Drawing.Size(100, 20);
            this.txtgorsel.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(313, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "EV GÖRSELLERİ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(147, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "GÖRSEL EKLE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Kapora Odeyecek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMMUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtgorsel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comevıd);
            this.Controls.Add(this.txttelno);
            this.Controls.Add(this.txtmüsoyad);
            this.Controls.Add(this.txtmüsadı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butlist);
            this.Controls.Add(this.buttemizle);
            this.Controls.Add(this.butsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMMUSTERI";
            this.Text = "FRMMUSTERI";
            this.Load += new System.EventHandler(this.FRMMUSTERI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butlist;
        private System.Windows.Forms.Button buttemizle;
        private System.Windows.Forms.Button butsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmüsadı;
        private System.Windows.Forms.TextBox txtmüsoyad;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.ComboBox comevıd;
        private System.Windows.Forms.TextBox txtgorsel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}