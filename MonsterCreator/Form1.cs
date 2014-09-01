using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Form1 Form1 = new Form1();
            Application.Run(Form1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAgility.Text = "";
            txtBreed.Text = "";
            txtDefense.Text = "";
            txtGender.Text = "";
            txtHP.Text = "";
            txtMP.Text = "";
            txtUPC.Text = "";
            txtPower.Text = "";
            txtLeadership.Text = "";
        }

        enum MonstBreed
        {
            Animal = 0,
            Plant = 10,
            Fire = 20,
            Water = 30,
            Flying = 40,
            Ground = 50,
            Bug = 60,
            Air = 70,
            Light = 80,
            Dark = 90,
            Normal = 100
        };

        private void button2_Click(object sender, EventArgs e)
        {
            double UPC = double.Parse(txtUPC.Text);
            Random rand = new Random( (int) UPC );

            int rndHP = rand.Next(20);
            int rndMP = rand.Next(25);
            int rndAgility = rand.Next(30);
            int rndDefense = rand.Next(35);
            int rndGender = rand.Next(40);
            int rndBreed = rand.Next(45);
            int rndPower = rand.Next(50);
            int rndLeadership = rand.Next(55);

            if (rndBreed >= 0 && rndBreed < 10)
            {
                txtBreed.Text = MonstBreed.Animal.ToString();
            }
            else if (rndBreed >= 10 && rndBreed < 20)
            {
                txtBreed.Text = MonstBreed.Plant.ToString();
            }
            else if (rndBreed >= 20 && rndBreed < 30)
            {
                txtBreed.Text = MonstBreed.Fire.ToString();
            }
            else if (rndBreed >= 30 && rndBreed < 40)
            {
                txtBreed.Text = MonstBreed.Water.ToString();
            }
            else if (rndBreed >= 40 && rndBreed < 50)
            {
                txtBreed.Text = MonstBreed.Flying.ToString();
            }
            else if (rndBreed >= 50 && rndBreed < 60)
            {
                txtBreed.Text = MonstBreed.Ground.ToString();
            }
            else if (rndBreed >= 60 && rndBreed < 70)
            {
                txtBreed.Text = MonstBreed.Bug.ToString();
            }
            else if (rndBreed >= 70 && rndBreed < 80)
            {
                txtBreed.Text = MonstBreed.Air.ToString();
            }
            else if (rndBreed >= 80 && rndBreed < 90)
            {
                txtBreed.Text = MonstBreed.Light.ToString();
            }
            else if (rndBreed >= 90)
            {
                txtBreed.Text = MonstBreed.Dark.ToString();
            }
            else
            {
                txtBreed.Text = MonstBreed.Normal.ToString();
            }

            txtHP.Text = rndHP.ToString();
            txtMP.Text = rndMP.ToString();
            txtAgility.Text = rndAgility.ToString();
            txtDefense.Text = rndDefense.ToString();
            txtGender.Text = rndGender.ToString();
            //txtBreed.Text = rndBreed.ToString();
            txtPower.Text = rndPower.ToString();
            txtLeadership.Text = rndLeadership.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }            
    }
}
