using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Windows.Forms;

namespace Procject1
{
    public partial class Home : MaterialForm
    {
        public  MaterialSkinManager materialSkinManager;
        public Home()
        {
            Employee newEmp = new Employee();
            
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            populateProg();
            PopulateGen();
            populateSales();
            this.pnlSales.Hide();
            this.btnAdd.Hide();
        }

        
        private void Home_page_Load(object sender, EventArgs e)
        {
            
        }
        BindingSource genSourse = new BindingSource();
        public void PopulateGen()
        {
            GeneralEmp gen = new GeneralEmp();
            List<GeneralEmp> g = new List<GeneralEmp>();
            g = gen.GetGeneral();
            genSourse.DataSource = g;
            dgGeneral.DataSource = genSourse;
            //foreach (var item in g)
            //{
            //    string[] data = new string[4];
            //    data[0] = item.name.ToString();
            //    data[1] = item.hoursworked.ToString();
            //    data[2] = item.payrate.ToString();
            //    //data[3] = item.pStatus;
            //    var k = new ListViewItem(data);
            //    lstgen.Items.Add(k);

            //}
        }
        BindingSource SalesSours = new BindingSource();
        public void populateSales()
        {
            MarketingEmp mark = new MarketingEmp();
            List<MarketingEmp> m = new List<MarketingEmp>();
            
            m = mark.GetSalesStaff();
            SalesSours.DataSource = m;
            dgSales.DataSource = SalesSours;
           //List<MarketingEmp> NoDups = m.Distinct().ToList<MarketingEmp>();

            //foreach (var item in NoDups)
            //{
            //    string[] data = new string[4];
            //    data[0] = item.name.ToString();
            //    data[1] = item.hoursworked.ToString();
            //    data[2] = item.payrate.ToString();
            //    data[3] = item.sales.ToString();
            //    var k = new ListViewItem(data);
            //    lstsales.Items.Add(k);

            //}
            
        }
        BindingSource progSours  = new BindingSource();
        public void populateProg()
        {
            
           
            List<Programmer> p = new List<Programmer>();
            Programmer prog = new Programmer();
            p = prog.GetProgrammer();
            progSours.DataSource = p;
            dgProgramer.DataSource = progSours;
            //List<Programmer> NoDups = p.Distinct().ToList<Programmer>();
            //foreach (var item in NoDups)
            //{
            //    string[] data = new string[4];
            //    data[0] = item.name.ToString();
            //    data[1] = item.hoursworked.ToString();
            //    data[2] = item.payrate.ToString();
            //    data[3] = item.pStatus;
            //    var k = new ListViewItem(data);
                
            //        lstProgrammer.Items.Add(k);
                
                

            //}
            
           
        }
        public void MakeCalcsales()
        {
            

            //MessageBox.Show(data);
            //string selected = lstsales.FocusedItem.Text;
            //MarketingEmp ma = new MarketingEmp();
            //List<MarketingEmp> dis = ma.selectthis(selected);

            //foreach (var item in dis)
            //{
            //    double pay = item.CalculatePay();
            //    MessageBox.Show(pay.ToString());
            //    break;
            //}
        }
        private void btncSales_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
            
            
        }
        public void changeMessage(string user)
        {
            lblwelcome.Text = "Welcome " + user; 
        }
        private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2) colorSchemeIndex = 0;

          
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }
        
        //public ListBox.SelectedObjectCollection SelectedItems { get; }
        private void lstsales_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }

        MarketingEmp salesemp = new MarketingEmp();
        private void btnCSales_Click(object sender, EventArgs e)
        {


           // dgSales.Hide();
            pnlSales.Show();
            txtName.DataBindings.Add("Text", SalesSours, "name");
            txtHw.DataBindings.Add("Text", SalesSours, "hoursworked");
            txtPayrate.DataBindings.Add("Text", SalesSours, "payrate");
            txtSales.DataBindings.Add("Text", SalesSours, "sales");
            txtJobcode.DataBindings.Add("Text", SalesSours, "jobcode");
            txtPay.Text = Convert.ToString(salesemp.CalculatePay(double.Parse(txtHw.Text), double.Parse(txtPayrate.Text)));
    
        }

        private void dgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSales.Hide();
            //dgSales.Show();
        }
        Programmer prog = new Programmer();
        private void btnCProg_Click(object sender, EventArgs e)
        {

            //dgSales.Hide();
            pnlSales.Show();
            txtName.DataBindings.Add("Text", progSours, "name");
            txtHw.DataBindings.Add("Text", progSours, "hoursworked");
            txtPayrate.DataBindings.Add("Text", progSours, "payrate");
            lblSalesorPstatus.Text = "Project Status";
            txtSales.DataBindings.Add("Text", progSours, "pstatus");
            txtJobcode.DataBindings.Add("Text", progSours, "jobcode");
            txtPay.Text = Convert.ToString(prog.CalculatePay(double.Parse(txtHw.Text), double.Parse(txtPayrate.Text),txtSales.Text));
        }
        GeneralEmp gen = new GeneralEmp();
        private void btnCGen_Click(object sender, EventArgs e)
        {
            pnlSales.Show();
            txtName.DataBindings.Add("Text", genSourse, "name");
            txtHw.DataBindings.Add("Text", genSourse, "hoursworked");
            txtPayrate.DataBindings.Add("Text", genSourse, "payrate");
            lblSalesorPstatus.Text = "";
            txtSales.Hide();
            //txtSales.DataBindings.Add("Text", progSours, "pstatus");
            txtJobcode.DataBindings.Add("Text", genSourse, "jobcode");
            txtPay.Text = Convert.ToString(gen.CalculatePay(double.Parse(txtHw.Text), double.Parse(txtPayrate.Text)));
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSales.Show();
            lblSalesorPstatus.Text = "Project Status";
            btnAdd.Show();
            txtHw.Text = "";
            txtJobcode.Text = "";
            txtName.Text = "";
            txtPay.Text = "";
            txtPayrate.Text = "";
           // txtSales.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileHandler fa = new FileHandler();
            
            List<string> NewEmp = new List<string>();
            NewEmp.Add("\n");
            NewEmp.Add(txtName.Text + "," + txtPayrate.Text + "," + txtHw.Text + "," + txtJobcode.Text + "," + txtSales.Text);
            if (txtJobcode.Text.ToUpper() == "P")
            {
                fa.WriteData(NewEmp, "TPogrammerList.txt", true);
            }
            else if (txtJobcode.Text.ToUpper() == "M")
            {
                fa.WriteData(NewEmp, "TMarketList.txt", true);
            }
            else
            {
                NewEmp.Clear();
                NewEmp.Add(txtName.Text + "," + txtPayrate.Text + "," + txtHw.Text + "," + txtJobcode.Text);
                fa.WriteData(NewEmp, "TGeneral.txt", true);
            }

            NewEmp.Clear();
            pnlSales.Hide();
            dgGeneral.Refresh();
            dgProgramer.Refresh();
            dgSales.Refresh();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSalesorPstatus.Text = "Sales";
            btnAdd.Show();
            txtHw.Text = "";
            txtJobcode.Text = "";
            txtName.Text = "";
            txtPay.Text = "";
            txtPayrate.Text = "";
            txtSales.Text = "";

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSalesorPstatus.Hide();
            btnAdd.Show();
            txtHw.Text = "";
            txtJobcode.Text = "";
            txtName.Text = "";
            txtPay.Text = "";
            txtPayrate.Text = "";
            txtSales.Hide();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();

            
        }
       
       
       
    }
}
