namespace Procject1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnexit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.btnCSales = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgProgramer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgGeneral = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblwelcome = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJobcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPayrate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSales = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSalesorPstatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCProg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCGen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnexit.AutoSize = true;
            this.btnexit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnexit.Depth = 0;
            this.btnexit.Icon = null;
            this.btnexit.Location = new System.Drawing.Point(599, 484);
            this.btnexit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnexit.Name = "btnexit";
            this.btnexit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnexit.Primary = true;
            this.btnexit.Size = new System.Drawing.Size(50, 36);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(664, 36);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "awe";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 105);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(650, 313);
            this.materialTabControl1.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgSales);
            this.tabPage3.Controls.Add(this.btnCSales);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(642, 287);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgSales
            // 
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.GridColor = System.Drawing.SystemColors.Control;
            this.dgSales.Location = new System.Drawing.Point(0, 0);
            this.dgSales.Name = "dgSales";
            this.dgSales.Size = new System.Drawing.Size(639, 239);
            this.dgSales.TabIndex = 0;
            this.dgSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSales_CellContentClick);
            // 
            // btnCSales
            // 
            this.btnCSales.AutoSize = true;
            this.btnCSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCSales.Depth = 0;
            this.btnCSales.Icon = null;
            this.btnCSales.Location = new System.Drawing.Point(521, 248);
            this.btnCSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCSales.Name = "btnCSales";
            this.btnCSales.Primary = true;
            this.btnCSales.Size = new System.Drawing.Size(118, 36);
            this.btnCSales.TabIndex = 5;
            this.btnCSales.Text = "Print PaySlip";
            this.btnCSales.UseVisualStyleBackColor = true;
            this.btnCSales.Click += new System.EventHandler(this.btnCSales_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCProg);
            this.tabPage1.Controls.Add(this.dgProgramer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(642, 287);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Programmer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgProgramer
            // 
            this.dgProgramer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramer.Location = new System.Drawing.Point(3, 3);
            this.dgProgramer.Name = "dgProgramer";
            this.dgProgramer.Size = new System.Drawing.Size(636, 224);
            this.dgProgramer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCGen);
            this.tabPage2.Controls.Add(this.dgGeneral);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(642, 287);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgGeneral
            // 
            this.dgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGeneral.Location = new System.Drawing.Point(3, 0);
            this.dgGeneral.Name = "dgGeneral";
            this.dgGeneral.Size = new System.Drawing.Size(636, 240);
            this.dgGeneral.TabIndex = 0;
            this.dgGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGeneral_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialRaisedButton2);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialRaisedButton1);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(642, 287);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(13, 103);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Change";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Change Background";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(13, 32);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(123, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Change Color";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Them Color";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Depth = 0;
            this.lblwelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblwelcome.Location = new System.Drawing.Point(541, 462);
            this.lblwelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(108, 19);
            this.lblwelcome.TabIndex = 11;
            this.lblwelcome.Text = "materialLabel1";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmerToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add new Employee";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.btnAdd);
            this.pnlSales.Controls.Add(this.btnBack);
            this.pnlSales.Controls.Add(this.materialLabel8);
            this.pnlSales.Controls.Add(this.txtName);
            this.pnlSales.Controls.Add(this.lblSalesorPstatus);
            this.pnlSales.Controls.Add(this.txtPay);
            this.pnlSales.Controls.Add(this.materialLabel6);
            this.pnlSales.Controls.Add(this.txtJobcode);
            this.pnlSales.Controls.Add(this.materialLabel5);
            this.pnlSales.Controls.Add(this.txtHw);
            this.pnlSales.Controls.Add(this.materialLabel4);
            this.pnlSales.Controls.Add(this.txtSales);
            this.pnlSales.Controls.Add(this.materialLabel3);
            this.pnlSales.Controls.Add(this.txtPayrate);
            this.pnlSales.Location = new System.Drawing.Point(126, 53);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(402, 242);
            this.pnlSales.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(134, 9);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            this.txtName.Text = "materialSingleLineTextField1";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtJobcode
            // 
            this.txtJobcode.Depth = 0;
            this.txtJobcode.Hint = "";
            this.txtJobcode.Location = new System.Drawing.Point(134, 38);
            this.txtJobcode.MaxLength = 32767;
            this.txtJobcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJobcode.Name = "txtJobcode";
            this.txtJobcode.PasswordChar = '\0';
            this.txtJobcode.SelectedText = "";
            this.txtJobcode.SelectionLength = 0;
            this.txtJobcode.SelectionStart = 0;
            this.txtJobcode.Size = new System.Drawing.Size(250, 23);
            this.txtJobcode.TabIndex = 1;
            this.txtJobcode.TabStop = false;
            this.txtJobcode.Text = "materialSingleLineTextField1";
            this.txtJobcode.UseSystemPasswordChar = false;
            // 
            // txtHw
            // 
            this.txtHw.Depth = 0;
            this.txtHw.Hint = "";
            this.txtHw.Location = new System.Drawing.Point(134, 67);
            this.txtHw.MaxLength = 32767;
            this.txtHw.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHw.Name = "txtHw";
            this.txtHw.PasswordChar = '\0';
            this.txtHw.SelectedText = "";
            this.txtHw.SelectionLength = 0;
            this.txtHw.SelectionStart = 0;
            this.txtHw.Size = new System.Drawing.Size(250, 23);
            this.txtHw.TabIndex = 2;
            this.txtHw.TabStop = false;
            this.txtHw.Text = "materialSingleLineTextField1";
            this.txtHw.UseSystemPasswordChar = false;
            // 
            // txtPayrate
            // 
            this.txtPayrate.Depth = 0;
            this.txtPayrate.Hint = "";
            this.txtPayrate.Location = new System.Drawing.Point(134, 96);
            this.txtPayrate.MaxLength = 32767;
            this.txtPayrate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.PasswordChar = '\0';
            this.txtPayrate.SelectedText = "";
            this.txtPayrate.SelectionLength = 0;
            this.txtPayrate.SelectionStart = 0;
            this.txtPayrate.Size = new System.Drawing.Size(250, 23);
            this.txtPayrate.TabIndex = 3;
            this.txtPayrate.TabStop = false;
            this.txtPayrate.Text = "materialSingleLineTextField1";
            this.txtPayrate.UseSystemPasswordChar = false;
            // 
            // txtSales
            // 
            this.txtSales.Depth = 0;
            this.txtSales.Hint = "";
            this.txtSales.Location = new System.Drawing.Point(134, 125);
            this.txtSales.MaxLength = 32767;
            this.txtSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSales.Name = "txtSales";
            this.txtSales.PasswordChar = '\0';
            this.txtSales.SelectedText = "";
            this.txtSales.SelectionLength = 0;
            this.txtSales.SelectionStart = 0;
            this.txtSales.Size = new System.Drawing.Size(250, 23);
            this.txtSales.TabIndex = 8;
            this.txtSales.TabStop = false;
            this.txtSales.Text = "materialSingleLineTextField1";
            this.txtSales.UseSystemPasswordChar = false;
            // 
            // txtPay
            // 
            this.txtPay.Depth = 0;
            this.txtPay.Hint = "";
            this.txtPay.Location = new System.Drawing.Point(134, 154);
            this.txtPay.MaxLength = 32767;
            this.txtPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPay.Name = "txtPay";
            this.txtPay.PasswordChar = '\0';
            this.txtPay.SelectedText = "";
            this.txtPay.SelectionLength = 0;
            this.txtPay.SelectionStart = 0;
            this.txtPay.Size = new System.Drawing.Size(250, 23);
            this.txtPay.TabIndex = 10;
            this.txtPay.TabStop = false;
            this.txtPay.Text = "materialSingleLineTextField1";
            this.txtPay.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 42);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Job";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 71);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(113, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Houres Worked";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 100);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 19);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Payrate";
            // 
            // lblSalesorPstatus
            // 
            this.lblSalesorPstatus.AutoSize = true;
            this.lblSalesorPstatus.Depth = 0;
            this.lblSalesorPstatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalesorPstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesorPstatus.Location = new System.Drawing.Point(3, 129);
            this.lblSalesorPstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalesorPstatus.Name = "lblSalesorPstatus";
            this.lblSalesorPstatus.Size = new System.Drawing.Size(46, 19);
            this.lblSalesorPstatus.TabIndex = 9;
            this.lblSalesorPstatus.Text = "Sales";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 158);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(33, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Pay";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(328, 183);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(56, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCProg
            // 
            this.btnCProg.AutoSize = true;
            this.btnCProg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCProg.Depth = 0;
            this.btnCProg.Icon = null;
            this.btnCProg.Location = new System.Drawing.Point(521, 248);
            this.btnCProg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCProg.Name = "btnCProg";
            this.btnCProg.Primary = true;
            this.btnCProg.Size = new System.Drawing.Size(118, 36);
            this.btnCProg.TabIndex = 1;
            this.btnCProg.Text = "Print Payslip";
            this.btnCProg.UseVisualStyleBackColor = true;
            this.btnCProg.Click += new System.EventHandler(this.btnCProg_Click);
            // 
            // btnCGen
            // 
            this.btnCGen.AutoSize = true;
            this.btnCGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCGen.Depth = 0;
            this.btnCGen.Icon = null;
            this.btnCGen.Location = new System.Drawing.Point(521, 246);
            this.btnCGen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCGen.Name = "btnCGen";
            this.btnCGen.Primary = true;
            this.btnCGen.Size = new System.Drawing.Size(118, 36);
            this.btnCGen.TabIndex = 1;
            this.btnCGen.Text = "Print Payslip";
            this.btnCGen.UseVisualStyleBackColor = true;
            this.btnCGen.Click += new System.EventHandler(this.btnCGen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(274, 183);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(48, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 532);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.btnexit);
            this.Name = "Home";
            this.Text = "Home_page";
            this.Load += new System.EventHandler(this.Home_page_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnexit;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialLabel lblwelcome;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnCSales;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.DataGridView dgProgramer;
        private System.Windows.Forms.DataGridView dgGeneral;
        private System.Windows.Forms.Panel pnlSales;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPay;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJobcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHw;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSales;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPayrate;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblSalesorPstatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialRaisedButton btnCProg;
        private MaterialSkin.Controls.MaterialRaisedButton btnCGen;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;

    }
}