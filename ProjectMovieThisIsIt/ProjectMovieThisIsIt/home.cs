using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMovieThisIsIt
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
