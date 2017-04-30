using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private bool is_existstab(TabControl tabctl, Form frm)
        {

            for (int i = 0; i < tabctl.TabCount; i++)
            {
                if (tabctl.TabPages[i].Text.Trim().ToString() == frm.Text.Trim().ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabctl.TabPages.Clear();
            Form2 frm = new Form2();
            if (!is_existstab(tabctl, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
           


        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            tabctl.TabPages.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabctl.Width = this.Width - 110;
            tabctl.Height = this.Height - 150;
        }
    }
}
