using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFirst
{
    public partial class Form1 : Form
    {
        List<string> classes;
        public Form1()
        {
            classes = new List<string>();
            InitializeComponent();
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;

            lblwelcome.Text ="xos gelmisiz " + firstname + " " + lastname;
            lblwelcome.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblwelcome.Visible = false;
            cmbgourp.Items.Add("K30");
            cmbgourp.Items.Add("K10");
            cmbgourp.Items.Add("C10");
            cmbgourp.Items.Add("C20");
            
        }
        private void Group1_Click(object sender, EventArgs e)
        {
            string textGroupName = txtgroup.Text;
            classes.Add(textGroupName);
            neriman();
        }
        public void neriman()
        {
            cmbgourp.Items.Clear();
            cmbgourp.Items.AddRange(classes.ToArray());

        }
    }
}
