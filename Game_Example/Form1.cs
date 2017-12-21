using Game_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Example
{
    public partial class Form1 : Form
    {
        internal Player Gamer;
        internal Dragon Dragon;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Gamer = new Player();
            Dragon = new Dragon();
            if (rbWarrior.Checked)
            {
                Gamer.CreatePlayer(txtUserName.Text,true);
            }
            else
            {
                Gamer.CreatePlayer(txtUserName.Text,false);
            }
            Form2 f= new Form2(this);
            Hide();
            f.Show();


        }

        
    }
}
