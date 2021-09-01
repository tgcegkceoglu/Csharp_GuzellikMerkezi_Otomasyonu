using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guzellikmerkezison
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmmusteriekle msj = new frmmusteriekle();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmmusterilistele msj = new frmmusterilistele();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            seansss msj = new seansss();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            seanslisteleme msj = new seanslisteleme();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmtahsilat msj = new frmtahsilat();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmbugun msj = new frmbugun();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }
       
        private void anasayfa_Load(object sender, EventArgs e)
        { 
            WindowState = FormWindowState.Maximized;
            panel1.Controls.Clear();
            resim msj1 = new resim();
            msj1.TopLevel = false;
            panel1.Controls.Add(msj1);
            msj1.Show();
            msj1.Dock = DockStyle.Fill;
            msj1.BringToFront();


            panel2.Controls.Clear();
           frmbugun  msj = new frmbugun();
            msj.TopLevel = false;
            panel2.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();

            panel3.Controls.Clear();
            frmhatırlatıcı msj2 = new frmhatırlatıcı();
            msj2.TopLevel = false;
            panel3.Controls.Add(msj2);
            msj2.Show();
            msj2.Dock = DockStyle.Fill;
            msj2.BringToFront();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmayarlar msj = new frmayarlar();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            resim msj = new resim();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();

            panel2.Controls.Clear();
            frmbugun msj1 = new frmbugun();
            msj1.TopLevel = false;
            panel2.Controls.Add(msj1);
            msj1.Show();
            msj1.Dock = DockStyle.Fill;
            msj1.BringToFront();


            panel3.Controls.Clear();
            frmhatırlatıcı msj2 = new frmhatırlatıcı();
            msj2.TopLevel = false;
            panel3.Controls.Add(msj2);
            msj2.Show();
            msj2.Dock = DockStyle.Fill;
            msj2.BringToFront();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mailgonderme  msj = new mailgonderme();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmhatırlatıcı msj = new frmhatırlatıcı();
            msj.TopLevel = false;
            panel1.Controls.Add(msj);
            msj.Show();
            msj.Dock = DockStyle.Fill;
            msj.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmhatırlatıcı frm = new frmhatırlatıcı();
            frm.cagır();
            frm.timer1_Tick(sender,e);
        }
    }
}
