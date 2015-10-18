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
    public partial class Obstaculos : Form
    {
        private Game game;

        public Obstaculos(ref Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void btnSizeMap_Click(object sender, EventArgs e)
        {
            Map map = game.getMap();
            map.setRandomStones(Int16.Parse(textBox1.Text));
            game.Print();
            this.Close();
        }
    }
}
