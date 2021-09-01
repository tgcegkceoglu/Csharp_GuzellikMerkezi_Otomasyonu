
namespace guzellikmerkezison
{
    partial class frmhatırlatıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhatırlatıcı));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.txtadisoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::guzellikmerkezison.Properties.Resources.saat_2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "durdur.png");
            this.ımageList1.Images.SetKeyName(1, "başlat.png");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "sil.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(12, 106);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(162, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "Hatırlatıcıyı Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtadisoyadi
            // 
            this.txtadisoyadi.Location = new System.Drawing.Point(419, 149);
            this.txtadisoyadi.Name = "txtadisoyadi";
            this.txtadisoyadi.Size = new System.Drawing.Size(213, 20);
            this.txtadisoyadi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 103);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(330, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 150;
            this.dataGridView2.Size = new System.Drawing.Size(378, 100);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Silmek istediğiniz kişiyi seçiniz";
            // 
            // frmhatırlatıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(776, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadisoyadi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmhatırlatıcı";
            this.Text = "frmhatırlatıcı";
            this.Load += new System.EventHandler(this.frmhatırlatıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.BindingSource seansekleme1BindingSource;
      
      
        private System.Windows.Forms.BindingSource seansekleme1BindingSource1;

    
        private System.Windows.Forms.BindingSource seansekleme1BindingSource2;
     
        private System.Windows.Forms.BindingSource seansekleme1BindingSource3;
     
     
        private System.Windows.Forms.BindingSource tarihBindingSource;
        
       
        private System.Windows.Forms.BindingSource tarih1BindingSource;
        
        
        private System.Windows.Forms.BindingSource seansekleme1BindingSource4;
       
      
        private System.Windows.Forms.BindingSource seansekleme1BindingSource5;
       
        
        private System.Windows.Forms.BindingSource seansekleme1BindingSource6;
        
        private System.Windows.Forms.BindingSource seansekleme1BindingSource7;
       
        private System.Windows.Forms.BindingSource seansekleme1BindingSource8;
       
        private System.Windows.Forms.BindingSource seansekleme1BindingSource9;
       
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtadisoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
    }
}