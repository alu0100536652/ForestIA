using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestIA
{
    public partial class Configuracion : Form
    {
        private Game game;

        public Configuracion(ref Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void btnSizeMap_Click(object sender, EventArgs e)
        {
            Point setupOfTheMap = new Point(Int16.Parse(textBox1.Text), Int16.Parse(textBox2.Text));
            game.Setup(setupOfTheMap);
            game.Print();
            this.Close();
        }
    }
}
