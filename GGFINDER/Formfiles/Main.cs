using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGFINDER.Formfiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string loggedinusername;
        private void Main_Load(object sender, EventArgs e)
        {
            userlbl.Text = "WELCOME! "+ loggedinusername;
        }
    }
}
