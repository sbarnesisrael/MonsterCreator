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

        private void button2_Click(object sender, EventArgs e)
        {
            decimal UPC = decimal.Parse(txtUPC.Text);
            Random rand = new Random();

            int rndHP = rand.Next(20);
            int rndMP = rand.Next(25);
            int rndAgility = rand.Next(30);
            int rndDefense = rand.Next(35);
            int rndGender = rand.Next(40);
            int rndBreed = rand.Next(45);
            int rndPower = rand.Next(50);
            int rndLeadership = rand.Next(55);

            txtHP.Text = rndHP.ToString();
            txtMP.Text = rndMP.ToString();
            txtAgility.Text = rndAgility.ToString();
            txtDefense.Text = rndDefense.ToString();
            txtGender.Text = rndGender.ToString();
            txtBreed.Text = rndBreed.ToString();
            txtPower.Text = rndPower.ToString();
            txtLeadership.Text = rndLeadership.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }            
    }
}
