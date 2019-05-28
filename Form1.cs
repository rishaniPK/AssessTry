using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessTry

{
    
    public partial class Form1 : Form
    {
        game G1 = new game(); //Defining the object that is G1 of the name class
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            G1.load(); //Calling load function from name 
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
            btn_palyagain.Enabled = false;
        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            G1.spin(); //Calling spin function from name class
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            btn_palyagain.Enabled = false;
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            G1.shoot();//Calling shoot function from name class
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            btn_palyagain.Enabled = false;
        }

        private void Btn_shootaway_Click(object sender, EventArgs e)
        {
            G1.shootAway();//Calling shot away function from name class
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            btn_palyagain.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
            btn_palyagain.Enabled = false;
        }

        private void Btn_palyagain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
            btn_palyagain.Enabled = true;

        }
    }
}
