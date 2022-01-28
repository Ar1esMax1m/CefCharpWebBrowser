using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;

namespace WebSharp2
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Keys KeyCode { get; }
        
        public Form1()
        {
            Cef.EnableHighDPISupport();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
            if (chromiumWebBrowser1.CanGoBack)
            {
                chromiumWebBrowser1.Back();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoForward)
            {
                chromiumWebBrowser1.Forward();
            }
        }
        private void urlField_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(urlField.Text);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Refresh();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if(this.chromiumWebBrowser1.Address != "") urlField.Text = this.chromiumWebBrowser1.Address;
        }
    }
}
