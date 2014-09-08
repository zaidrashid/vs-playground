using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text  = "3630856646";
            label2.Text = int.MaxValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Player> players = new List<Player>(){
                new Player(){PlayerNumber=10, PlayerName="Del Peiro"},
                new Player(){PlayerNumber=7, PlayerName="Raul Gonzalez"},
                new Player(){PlayerNumber=9, PlayerName="Batistuta"}
            };


            var item = players.SingleOrDefault(p => p.PlayerNumber == 11).PlayerName;


        }
    }

    public class Player
    {
        public int PlayerNumber { get; set; }
        public string PlayerName { get; set; }
    }
}
