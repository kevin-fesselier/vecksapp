using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vecksapp
{
    public partial class mainForm : Form
    {
        FormWindowState previousWindowState;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //this.previousWindowState = this.WindowState;
                Hide();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.previousWindowState = this.WindowState;
                e.Cancel = true;
                Hide();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    if (this.Visible == false)
                    {
                        Show();
                        //this.WindowState = FormWindowState.Normal;
                        this.WindowState = this.previousWindowState;
                    }
                    else
                    {
                        this.previousWindowState = this.WindowState;
                        Hide();
                    }
                    break;

                case MouseButtons.Right:
                    // Right click
                    break;
            }

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    if (this.Visible == false)
                    {
                        Show();
                        //this.WindowState = FormWindowState.Normal;
                        this.WindowState = this.previousWindowState;
                    }
                    else
                    {
                        this.previousWindowState = this.WindowState;
                        Hide();
                    }
                    break;

                case MouseButtons.Right:
                    // Right click
                    break;
            }
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
