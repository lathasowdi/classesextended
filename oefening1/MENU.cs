using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening1
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oef1 oef = new oef1();
            oef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oef2 oef = new oef2();
            oef.Show();
        }
    }
}
