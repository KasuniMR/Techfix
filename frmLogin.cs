using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFix
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Simulate a simple user validation (you can connect it to a database or use more secure methods).
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Simple hardcoded validation
            if (username == "sup1" && password == "789")
            {
                // On successful login, open the next form (e.g., dashboard).
                MessageBox.Show("Login successful!");
                Form1 dashboard = new Form1(); // Assuming you have another form.
                dashboard.Show();
                this.Hide(); // Hide the login form.
            }
            else
            {
                // Show error if login fails.
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
