using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal_Electricity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txtB_username.Text;
            string pass = txtB_pass.Text;
            string confirm = txtB_confirm.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter password",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please retype your password to confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pass == confirm)
            {
                MessageBox.Show("Registration successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form1 = new Form2();
                form1.Show();
                Hide();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Are you want to exit","Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cc == DialogResult.Yes) 
            {
                Close();
            }
            else 
            {
                MessageBox.Show("I love You. Welcome to comeback");
            }
        }

    }
}
