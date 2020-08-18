using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening1
{
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }
        static Pretpark mijnPretpark = new Pretpark();
        private void button1_Click(object sender, EventArgs e)
        {
            string naam = "";
            if (textBox1.Text.Trim().Length > 0)
            {
                naam = textBox1.Text.Trim();
            }
            else
            {
                MessageBox.Show("Naam invullen a.u.b");
            }
            string kleur = "";
            if (textBox2.Text.Trim().Length > 0)
            {
                kleur = textBox2.Text.Trim();
            }
            else
            {
                MessageBox.Show("Kleur invullen a.u.b");
            }
            int min;
            min = Convert.ToInt32(textBox3.Text);
            int aantal;
            aantal = Convert.ToInt32(textBox4.Text);
            if (naam.Length > 0)
            {
                mijnPretpark.Attractiesadd(naam, kleur, min, aantal);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                LijstAttracties();
            }

        }
        public void LijstAttracties()
        {
            if (mijnPretpark.AttractiesLijst.Count > 0)
            {
                listBox1.Items.Clear();
                foreach (var item in mijnPretpark.AttractiesLijst)
                {
                    listBox1.Items.Add(item.Naam);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                label6.Text = mijnPretpark.Attractiesbekijken(listBox1.SelectedIndex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                mijnPretpark.Attractiesdelete(listBox1.SelectedIndex);
            }
            LijstAttracties();
        }

        public void Lijstwerknemers()
        {
            listBox2.Items.Clear();
            foreach (var item in mijnPretpark.WerknemersLijst)
            {
                listBox2.Items.Add(item.Naam);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                mijnPretpark.Werknemersdelete(listBox2.SelectedIndex);
            }
        }




        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedItems.Count > 0)
            {
                label9.Text = mijnPretpark.Werknemersbekijken(listBox2.SelectedIndex);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string naam = "";
            if (textBox5.Text.Trim().Length > 0)
            {
                naam = textBox5.Text.Trim();
            }
            else
            {
                MessageBox.Show("Naam invullen a.u.b");
            }
            string geboort = "";
            geboort = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string geslacht = "";
            ; foreach (var item in groupBox3.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                    geslacht = item.Text;
            }
            if (naam.Length > 0)
            {
                mijnPretpark.Werknemersadd(naam, geboort, geslacht);
                textBox5.Clear();
                dateTimePicker1.Value = DateTime.Now;
                foreach (RadioButton item in groupBox3.Controls)
                {
                    item.Checked = false;
                }
                    Lijstwerknemers();
                }
            }

    }
    }


