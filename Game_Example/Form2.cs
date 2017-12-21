using Game_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Example
{
    public partial class Form2 : Form
    {
        Player Gamer;
        Dragon Dragon;
        Form1 form;
        bool Beginning = false;
        bool looping = true;
        public Form2(Form1 f1)
        {
            form = f1;
            Gamer = f1.Gamer;
            Dragon = f1.Dragon;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblGHealt.Text = Gamer.Health.ToString();
            lblGPower.Text = Gamer.Power.ToString();
            lblDHealt.Text = Dragon.Health.ToString();
            lblDPower.Text = Dragon.Power.ToString();
            gbGamer.Text = "";
            gbGamer.Text = Gamer.UserName;
            Gamer.OnDeath += Gamer_OnDeath;
            Dragon.OnDeath += Dragon_OnDeath;

        }

        private void Dragon_OnDeath()
        {
            MessageBox.Show("Kazandın");
            looping = false;
        }

        private void Gamer_OnDeath()
        {
            MessageBox.Show("Öldün");
            looping = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
            Dispose();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.D)
            {
                looping = true;
                while (looping)
                {
                    Beginning = true;
                    Attack();
                    Beginning = false;
                    Attack();
                }

                lblResult.Text = "Anasayfaya Gidiyorsunuz...";
                this.Refresh();
                Thread.Sleep(1000);

                form.Show();
                Dispose();

            }
        }
        private void Attack()
        {
            Random r = new Random();
            int result = r.Next(0, 20);
            int num = 0;
            if(result>=0 && result <= 7)
            {
                num = 0;
                if (Beginning)
                {
                    lblResult.Text = $"{Gamer.UserName}, Zar Atıyorsun...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"{Gamer.UserName} {result} Attın...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Point = result;
                    lblGPoint.Text = $"{Gamer.Point}";
                    lblResult.Text = $"{num * Dragon.Power} vurdun.";
                    this.Refresh();
                    Thread.Sleep(500);

                    Dragon.Demage(num);
                    //Dragon.Power -= num * Gamer.Power;
                    lblDHealt.Text = $"{Dragon.Health}";
                }
                else
                {
                    lblResult.Text = "Dragon, Zar Atıyor...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"Dragon {result} Attı...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Dragon.Point = result;
                    lblDPoint.Text = $"{Dragon.Point}";
                    lblResult.Text = $"{num * Gamer.Power} vurdu.";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Demage(num);
                    lblGHealt.Text = $"{Gamer.Health}";
                }

            }else if (result > 7 && result <= 17)
            {
                num = 1;
                if (Beginning)
                {
                    lblResult.Text = $"{Gamer.UserName}, Zar Atıyorsun...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"{Gamer.UserName} {result} Attın...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Point = result;
                    lblGPoint.Text = $"{Gamer.Point}";
                    lblResult.Text = $"{num * Gamer.Power} vurdun.";
                    this.Refresh();
                    Thread.Sleep(500);
                    Dragon.Demage(num * Gamer.Power);
                    //Dragon.Power -= num * Gamer.Power;
                    lblDHealt.Text = $"{Dragon.Health}";
                }
                else
                {
                    lblResult.Text = "Dragon, Zar Atıyor...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"Dragon {result} Attı...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Dragon.Point = result;
                    lblDPoint.Text = $"{Dragon.Point}";
                    lblResult.Text = $"{num * Dragon.Power} vurdu.";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Demage(num * Dragon.Power);
                    lblGHealt.Text = $"{Gamer.Health}";
                }
            }
            else
            {
                num = 2;
                if (Beginning)
                {
                    lblResult.Text = $"{Gamer.UserName}, Zar Atıyorsun...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"{Gamer.UserName} {result} Attın...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Point = result;
                    lblGPoint.Text = $"{Gamer.Point}";
                    lblResult.Text = $"{num * Gamer.Power} vurdun.";
                    this.Refresh();
                    Thread.Sleep(500);
                    Dragon.Demage(num * Gamer.Power);
                    //Dragon.Power -= num * Gamer.Power;
                    lblDHealt.Text = $"{Dragon.Health}";
                }
                else
                {
                    lblResult.Text = "Dragon, Zar Atıyor...";
                    this.Refresh();
                    Thread.Sleep(500);
                    lblResult.Text = $"Dragon {result} Attı...";
                    this.Refresh();
                    Thread.Sleep(500);
                    Dragon.Point = result;
                    lblDPoint.Text = $"{Dragon.Point}";
                    lblResult.Text = $"{num * Dragon.Power} vurdu.";
                    this.Refresh();
                    Thread.Sleep(500);
                    Gamer.Demage(num * Dragon.Power);
                    lblGHealt.Text = $"{Gamer.Health}";
                }
            }
        }
    }
}
