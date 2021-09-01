namespace guzellikmerkezison
{
    partial class frmmusteriekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtmusterino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtadisoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saat = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
      
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Controls.Add(this.txtmusterino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtadisoyadı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(895, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(439, 163);
            this.txttelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(173, 21);
            this.txttelefon.TabIndex = 14;
            this.txttelefon.TextChanged += new System.EventHandler(this.txttelefon_TextChanged);
            this.txttelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefon_KeyPress_1);
            // 
            // txtmusterino
            // 
            this.txtmusterino.Enabled = false;
            this.txtmusterino.Location = new System.Drawing.Point(439, 85);
            this.txtmusterino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmusterino.Name = "txtmusterino";
            this.txtmusterino.Size = new System.Drawing.Size(173, 21);
            this.txtmusterino.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Müşteri No:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.Location = new System.Drawing.Point(487, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal Et";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(357, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtadisoyadı
            // 
            this.txtadisoyadı.Location = new System.Drawing.Point(439, 125);
            this.txtadisoyadı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadisoyadı.Name = "txtadisoyadı";
            this.txtadisoyadı.Size = new System.Drawing.Size(173, 21);
            this.txtadisoyadı.TabIndex = 3;
            this.txtadisoyadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadisoyadı_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.ForeColor = System.Drawing.Color.Gold;
            this.saat.Location = new System.Drawing.Point(70, 9);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(30, 16);
            this.saat.TabIndex = 55;
            this.saat.Text = "saat";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.ForeColor = System.Drawing.Color.Gold;
            this.tarih.Location = new System.Drawing.Point(12, 9);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(33, 16);
            this.tarih.TabIndex = 54;
            this.tarih.Text = "tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 526);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 161);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
            // 
            // ayarlarTableAdapter1
            // 
       
            // 
            // frmmusteriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(932, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmmusteriekle";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmmusteriekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadisoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtmusterino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.TextBox txttelefon;
    }
}