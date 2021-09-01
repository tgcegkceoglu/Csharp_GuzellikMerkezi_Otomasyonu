namespace guzellikmerkezison
{
    partial class frmtahsilat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtahsilat));
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtyatırılantoplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkalanborc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttoplamborc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmusterino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadisoyadı = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pdyazici = new System.Drawing.Printing.PrintDocument();
            this.ppdiyalog = new System.Windows.Forms.PrintPreviewDialog();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "yazdır.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(312, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(131, 41);
            this.button2.TabIndex = 45;
            this.button2.Text = "Yazdır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yazdır.png");
            this.ımageList1.Images.SetKeyName(1, "anasayfa.png");
            this.ımageList1.Images.SetKeyName(2, "kalan.png");
            // 
            // txtyatırılantoplam
            // 
            this.txtyatırılantoplam.Location = new System.Drawing.Point(129, 176);
            this.txtyatırılantoplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtyatırılantoplam.Multiline = true;
            this.txtyatırılantoplam.Name = "txtyatırılantoplam";
            this.txtyatırılantoplam.Size = new System.Drawing.Size(128, 22);
            this.txtyatırılantoplam.TabIndex = 44;
            this.txtyatırılantoplam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyatırılantoplam_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Yatırılan toplam miktar";
            // 
            // txtkalanborc
            // 
            this.txtkalanborc.Enabled = false;
            this.txtkalanborc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkalanborc.Location = new System.Drawing.Point(129, 208);
            this.txtkalanborc.Margin = new System.Windows.Forms.Padding(2);
            this.txtkalanborc.Multiline = true;
            this.txtkalanborc.Name = "txtkalanborc";
            this.txtkalanborc.Size = new System.Drawing.Size(128, 22);
            this.txtkalanborc.TabIndex = 42;
            this.txtkalanborc.TextChanged += new System.EventHandler(this.txtkalanborc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kalan Borç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Toplam Borç ";
            // 
            // txttoplamborc
            // 
            this.txttoplamborc.CausesValidation = false;
            this.txttoplamborc.Enabled = false;
            this.txttoplamborc.Location = new System.Drawing.Point(129, 140);
            this.txttoplamborc.Margin = new System.Windows.Forms.Padding(2);
            this.txttoplamborc.Multiline = true;
            this.txttoplamborc.Name = "txttoplamborc";
            this.txttoplamborc.Size = new System.Drawing.Size(128, 23);
            this.txttoplamborc.TabIndex = 39;
            this.txttoplamborc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttoplamborc_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 2;
            this.button1.Location = new System.Drawing.Point(312, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kalan Borcu Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 245);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttelefon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmusterino);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttoplamborc);
            this.groupBox2.Controls.Add(this.txtadisoyadı);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtyatırılantoplam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtkalanborc);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(35, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(275, 245);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Bilgileri";
            // 
            // txttelefon
            // 
            this.txttelefon.Enabled = false;
            this.txttelefon.Location = new System.Drawing.Point(126, 102);
            this.txttelefon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(131, 20);
            this.txttelefon.TabIndex = 46;
            this.txttelefon.TextChanged += new System.EventHandler(this.txttelefon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Telefon:";
            // 
            // txtmusterino
            // 
            this.txtmusterino.Enabled = false;
            this.txtmusterino.Location = new System.Drawing.Point(126, 34);
            this.txtmusterino.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtmusterino.Name = "txtmusterino";
            this.txtmusterino.Size = new System.Drawing.Size(131, 20);
            this.txtmusterino.TabIndex = 13;
            this.txtmusterino.TextChanged += new System.EventHandler(this.txtmusterino_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Müşteri No:";
            // 
            // txtadisoyadı
            // 
            this.txtadisoyadı.Enabled = false;
            this.txtadisoyadı.Location = new System.Drawing.Point(126, 65);
            this.txtadisoyadı.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtadisoyadı.Name = "txtadisoyadı";
            this.txtadisoyadı.Size = new System.Drawing.Size(131, 20);
            this.txtadisoyadı.TabIndex = 3;
            this.txtadisoyadı.TextChanged += new System.EventHandler(this.txtadisoyadı_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Adı Soyadı:";
            // 
            // pdyazici
            // 
            this.pdyazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdyazici_PrintPage);
            // 
            // ppdiyalog
            // 
            this.ppdiyalog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdiyalog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdiyalog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdiyalog.Document = this.pdyazici;
            this.ppdiyalog.Enabled = true;
            this.ppdiyalog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdiyalog.Icon")));
            this.ppdiyalog.Name = "ppdiyalog";
            this.ppdiyalog.Text = "Baskı önizleme";
            this.ppdiyalog.Visible = false;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(297, 52);
            this.txtara.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(275, 20);
            this.txtara.TabIndex = 51;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            this.txtara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtara_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(294, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tahsilat yapmak istediğiniz müşterinin adını soyadını giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(70, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 368);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(275, 191);
            this.dataGridView2.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 55;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 56;
            this.button4.Text = "Tabloyu Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(465, 77);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 59;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bekleniyor";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(394, 77);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 58;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ödendi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(328, 77);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 57;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tümü";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmtahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(866, 687);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmtahsilat";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtahsilat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtyatırılantoplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkalanborc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttoplamborc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument pdyazici;
        private System.Windows.Forms.PrintPreviewDialog ppdiyalog;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtmusterino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadisoyadı;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}