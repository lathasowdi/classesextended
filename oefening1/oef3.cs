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
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }

        private void oef3_Load(object sender, EventArgs e)
        {

        }
        Danslessen nieuwestudent = new Danslessen();
        private void button2_Click(object sender, EventArgs e)
        {
            string naam = textBox1.Text.ToString();
            string geslacht = "";
            foreach (var item in groupBox1.Controls.OfType<RadioButton>())
            {
                if (item.Checked == true)
                    geslacht = item.Text;
            }
            int leeftijd;
            leeftijd = (int)numericUpDown1.Value;
            nieuwestudent.Studenttoevoegen(naam, geslacht, leeftijd);
            listBox1.Items.Clear();
            if (nieuwestudent.dansstudentslijst.Count < 13)
            {
                foreach (var item in nieuwestudent.dansstudentslijst)
                {
                    listBox1.Items.Add(item.Naam);
                }
                textBox1.Clear();
                textBox1.Focus();
                if (nieuwestudent.dansstudentslijst.Count == 12)
                {
                    button2.Enabled = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nieuwestudent.dansstudentslijst.Count > 6)
            {
                List<string> Finalje = nieuwestudent.Finalestudenten();
                foreach (var item in Finalje)
                {
                    listBox2.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Registered Students are less than 6");
            }


        }
    }
}
    

