namespace EmlakDB
{
    partial class FRMDetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbper = new System.Windows.Forms.ComboBox();
            this.cmbEvID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butlist = new System.Windows.Forms.Button();
            this.buttemizle = new System.Windows.Forms.Button();
            this.butsil = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "NOTES :";
            // 
            // cmbper
            // 
            this.cmbper.FormattingEnabled = true;
            this.cmbper.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbper.Location = new System.Drawing.Point(153, 55);
            this.cmbper.Name = "cmbper";
            this.cmbper.Size = new System.Drawing.Size(121, 21);
            this.cmbper.TabIndex = 55;
            // 
            // cmbEvID
            // 
            this.cmbEvID.FormattingEnabled = true;
            this.cmbEvID.Location = new System.Drawing.Point(153, 22);
            this.cmbEvID.Name = "cmbEvID";
            this.cmbEvID.Size = new System.Drawing.Size(121, 21);
            this.cmbEvID.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "EV ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "PERSONEL ADI :";
            // 
            // butlist
            // 
            this.butlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butlist.Location = new System.Drawing.Point(416, 22);
            this.butlist.Name = "butlist";
            this.butlist.Size = new System.Drawing.Size(97, 54);
            this.butlist.TabIndex = 51;
            this.butlist.Text = "LİSTELE";
            this.butlist.UseVisualStyleBackColor = true;
            // 
            // buttemizle
            // 
            this.buttemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttemizle.Location = new System.Drawing.Point(519, 22);
            this.buttemizle.Name = "buttemizle";
            this.buttemizle.Size = new System.Drawing.Size(97, 54);
            this.buttemizle.TabIndex = 50;
            this.buttemizle.Text = "TEMİZLE";
            this.buttemizle.UseVisualStyleBackColor = true;
            this.buttemizle.Click += new System.EventHandler(this.buttemizle_Click);
            // 
            // butsil
            // 
            this.butsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butsil.Location = new System.Drawing.Point(622, 22);
            this.butsil.Name = "butsil";
            this.butsil.Size = new System.Drawing.Size(97, 54);
            this.butsil.TabIndex = 49;
            this.butsil.Text = "SİL";
            this.butsil.UseVisualStyleBackColor = true;
            this.butsil.Click += new System.EventHandler(this.butsil_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonekle.Location = new System.Drawing.Point(313, 22);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(97, 54);
            this.buttonekle.TabIndex = 48;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 300);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // FRMDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbper);
            this.Controls.Add(this.cmbEvID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butlist);
            this.Controls.Add(this.buttemizle);
            this.Controls.Add(this.butsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMDetails";
            this.Text = "FRMDetails";
            this.Load += new System.EventHandler(this.FRMDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbper;
        private System.Windows.Forms.ComboBox cmbEvID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butlist;
        private System.Windows.Forms.Button buttemizle;
        private System.Windows.Forms.Button butsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}