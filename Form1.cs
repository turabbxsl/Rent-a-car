using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MasinKirayesi
{
    public partial class frmanasehife : Form
    {
        public frmanasehife()
        {
            InitializeComponent();
            CustomDesign();
        }
        private void CustomDesign()
        {
            panelmusteri.Visible = false;
            panelmasinlar.Visible = false;
            panelmuqavile.Visible = false;
        }

        //public void showSubmenu(Panel Submenu)
        //{
        //    if (Submenu.Visible == false)
        //    {

        //        Submenu.Visible = true;
        //    }
        //    else
        //    {
        //        Submenu.Visible = false;
        //    }

        //}
        private void HideSubmenu()
        {
            if (panelmusteri.Visible == true)
            {
                panelmusteri.Visible = false;
            }
            if (panelmasinlar.Visible == true)
            {
                panelmasinlar.Visible = false;
            }
            if (panelmuqavile.Visible == true)
            {
                panelmuqavile.Visible = false;
            }
        }
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuiButton7_Click(object sender, EventArgs e)
        {
            //    panelmusteri.Visible = false;
            frmMusteriListeleme list = new frmMusteriListeleme();
            list.ShowDialog();
            HideSubmenu();
        
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            //panelmusteri.Visible = false;
            frmmusterielaveet f = new frmmusterielaveet();
            f.ShowDialog();
            HideSubmenu();
          
        }

        private void xuiButton6_Click(object sender, EventArgs e)
        {
            frmMasinElavesi melavesi = new frmMasinElavesi();
            melavesi.ShowDialog();
            HideSubmenu();
           
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            frmMasinList list = new frmMasinList();
            list.ShowDialog();
            HideSubmenu();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            frmmuqavile m = new frmmuqavile();
            m.ShowDialog();
            HideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnmusteriler_Click(object sender, EventArgs e)
        {
            //    panelmusteri.Visible = true;
            ShowSubmenu(panelmusteri);
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void btnmasinlar_Click(object sender, EventArgs e)
        {
            //showSubmenu(panelmasinlar);
        }

        private void btnmuqavile_Click(object sender, EventArgs e)
        {
            //showSubmenu(panelmuqavile);
        }

        private void btnmasinlar_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(panelmasinlar);
        }

        private void btnmuqavile_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(panelmuqavile);
        }

        private void xuiButton4_Click_1(object sender, EventArgs e)
        {
            frmsatis s = new frmsatis();
            s.ShowDialog();
            HideSubmenu();
        }
    }
}
