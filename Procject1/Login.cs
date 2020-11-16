using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Procject1
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Cyan100, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            FileHandler fa = new FileHandler();
            Home home = new Home();
            if (fa.LoginAttempt(txtUsername.Text, txtPass.Text)== true)
            {
                string data = txtUsername.Text;
                home.changeMessage(data);
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed.Please Try again");

                txtPass.Clear();
                txtUsername.Clear();

            }
        }
    }
}
