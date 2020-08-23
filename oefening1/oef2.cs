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
    public partial class oef2 : Form
    {
        Ziekenhuis huis = new Ziekenhuis();
      
        
        public oef2()
        {
            InitializeComponent();
        }

        private void oef2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = huis.DokterList;
           dateTimePicker1.MinDate = System.DateTime.Now.AddDays(1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Afspraak nieuweafspraak;
            nieuweafspraak = new Afspraak(dateTimePicker1.Value, (int)numericUpDown1.Value, textBox1.Text);
            huis.DokterList[comboBox1.SelectedIndex].AfspraakLijst.Add(nieuweafspraak);
            MessageBox.Show($"Nieuwe afspraak met {huis.DokterList[comboBox1.SelectedIndex]}\n" +
                           $"op {dateTimePicker1.Value.ToString("dd.MM.yyyy")}\n" +
                           $"om {numericUpDown1.Value} uur\n" +
                           $"voor {textBox1.Text}."
                           );
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(huis.DokterList.Count>0)
            {
                if (huis.DokterList[comboBox1.SelectedIndex].AfspraakLijst.Count > 0)
                    listBox1.Items.Clear();
                foreach (var item in huis.DokterList[comboBox1.SelectedIndex].AfspraakLijst)
                {
                    string afsprak =$"Naam:{ item.Naam} Datum:{ item.Datum.ToString("dd/MM/yyyy")} UUR:{item.UUR}";
                    listBox1.Items.Add(afsprak);
                }
            }
            else
            {
                listBox1.Items.Clear();
            }
            
            }
    }
    }

