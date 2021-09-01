
namespace guzellikmerkezison
{
    partial class seanslisteleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.txtseans = new System.Windows.Forms.TextBox();
            this.txtyapilanis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmusterino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadisoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(194, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsme Göre Listele";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(500, 478);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tüm Seanslar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(298, 94);
            this.txtara.Multiline = true;
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(246, 25);
            this.txtara.TabIndex = 5;
            this.txtara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 288);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txttarih);
            this.groupBox1.Controls.Add(this.txtseans);
            this.groupBox1.Controls.Add(this.txtyapilanis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtsaat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmusterino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Controls.Add(this.txtadisoyadı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(27, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(319, 294);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(138, 186);
            this.txttarih.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txttarih.Multiline = true;
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(131, 20);
            this.txttarih.TabIndex = 22;
            this.txttarih.TextChanged += new System.EventHandler(this.txttarih_TextChanged);
            // 
            // txtseans
            // 
            this.txtseans.Location = new System.Drawing.Point(138, 159);
            this.txtseans.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtseans.Multiline = true;
            this.txtseans.Name = "txtseans";
            this.txtseans.Size = new System.Drawing.Size(131, 20);
            this.txtseans.TabIndex = 21;
            // 
            // txtyapilanis
            // 
            this.txtyapilanis.Location = new System.Drawing.Point(137, 133);
            this.txtyapilanis.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtyapilanis.Multiline = true;
            this.txtyapilanis.Name = "txtyapilanis";
            this.txtyapilanis.Size = new System.Drawing.Size(132, 18);
            this.txtyapilanis.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Seans:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Yapılan İş:";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(136, 218);
            this.txtsaat.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtsaat.Multiline = true;
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(131, 20);
            this.txtsaat.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seans Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seans Tarihi:";
            // 
            // txtmusterino
            // 
            this.txtmusterino.Enabled = false;
            this.txtmusterino.Location = new System.Drawing.Point(138, 53);
            this.txtmusterino.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtmusterino.Multiline = true;
            this.txtmusterino.Name = "txtmusterino";
            this.txtmusterino.Size = new System.Drawing.Size(131, 18);
            this.txtmusterino.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Müşteri No:";
            // 
            // txttelefon
            // 
            this.txttelefon.Enabled = false;
            this.txttelefon.Location = new System.Drawing.Point(137, 105);
            this.txttelefon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txttelefon.Multiline = true;
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(131, 20);
            this.txttelefon.TabIndex = 5;
            // 
            // txtadisoyadı
            // 
            this.txtadisoyadı.Enabled = false;
            this.txtadisoyadı.Location = new System.Drawing.Point(137, 79);
            this.txtadisoyadı.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtadisoyadı.Multiline = true;
            this.txtadisoyadı.Name = "txtadisoyadı";
            this.txtadisoyadı.Size = new System.Drawing.Size(132, 18);
            this.txtadisoyadı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adı Soyadı:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "İptal Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // seanslisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(866, 687);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seanslisteleme";
            this.Text = "Seans Listeleme";
            this.Load += new System.EventHandler(this.seanslisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmusterino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadisoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtseans;
        private System.Windows.Forms.TextBox txtyapilanis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txttarih;
    }
}