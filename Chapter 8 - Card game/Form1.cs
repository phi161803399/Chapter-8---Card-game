using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8___Card_game
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1,14);
            Card card = new Card((Suits)numberBetween0and3,(Values)numberBetween1and13);
            string cardname = card.Name;
            MessageBox.Show(cardname);
        }
    }
}
