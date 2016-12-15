using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        BazaEntities1 db = new BazaEntities1();
        public Form1()
        {
            InitializeComponent();
            dodaj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            oknaEdycji o = new oknaEdycji();
            o.ShowDialog();
            dodaj();
        }

        private void dodaj()
        {
            wyswietl.Items.Clear();
            foreach (Czlowiek czlowiek in db.Czlowiek)
            {
                wyswietl.Items.Add(czlowiek);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Czlowiek.Remove((Czlowiek)wyswietl.SelectedItem);
            db.SaveChanges();
            dodaj();
        }
    }
}
