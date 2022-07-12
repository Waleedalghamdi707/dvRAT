using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dvrat.modules
{
    public partial class rename_dialog : Form
    {
        string old_fl_name = "";
        string new_fl_name = "";
        public rename_dialog(string name)
        {
            this.old_fl_name = name;
            InitializeComponent();
        }

        private void rename_dialog_Load(object sender, EventArgs e)
        {
            old_name_fl_label.Text = this.old_fl_name;
        }

        public string new_name
        {
            get => new_fl_name;
            set 
            {

                new_fl_name = value;                 
                
            }
        }

        private void rname_fl_button_Click(object sender, EventArgs e)
        {
            new_name_fl_label.Text = old_fl_name.Replace(old_fl_name.Split('\\')[old_fl_name.Split('\\').Length - 1], textBox_fr_fl_nm_chng.Text);
            if (MessageBox.Show("Do you wanna change ?", "Yes, No!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new_name = textBox_fr_fl_nm_chng.Text;

                Close();
            }
            else
            {
                //pass
            }
        }
    }
}
