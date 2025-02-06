using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();

        }

        private void btn_getStarted_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();

        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
    }
}
