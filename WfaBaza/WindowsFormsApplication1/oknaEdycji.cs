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
    public partial class oknaEdycji : Form
    {
        BazaEntities1 db = new BazaEntities1();
        public Czlowiek czlowiek = new Czlowiek();
        public oknaEdycji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            czlowiek.imie = textBoxImie.Text;
            czlowiek.wiek = int.Parse(textBoxWiek.Text);
            czlowiek.wzrost = double.Parse(textBoxWzrost.Text);

            db.Czlowiek.Add(czlowiek);
            db.SaveChanges();
            this.Close();
        }
    }
}
