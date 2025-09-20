namespace Projet_Gestion_Hotel
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            MovingPanel = new Panel();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            uC_Employee1 = new All_User_Control.UC_Employee();
            customerDetails1 = new All_User_Control.CustomerDetails();
            uC_CustomerCheckOut1 = new All_User_Control.UC_CustomerCheckOut();
            uC_CustomerRegistration1 = new All_User_Control.UC_CustomerRegistration();
            uC_AddRoom1 = new All_User_Control.UC_AddRoom();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MovingPanel);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnCustomerDetail);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(btnCustomerRegistration);
            panel1.Controls.Add(btnAddRoom);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 115);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // MovingPanel
            // 
            MovingPanel.BackColor = Color.FromArgb(192, 255, 255);
            MovingPanel.Location = new Point(42, 94);
            MovingPanel.Name = "MovingPanel";
            MovingPanel.Size = new Size(199, 4);
            MovingPanel.TabIndex = 0;
            // 
            // btnEmployee
            // 
            btnEmployee.BorderRadius = 26;
            btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnEmployee.CheckedState.FillColor = Color.White;
            btnEmployee.CheckedState.ForeColor = Color.Black;
            btnEmployee.CustomizableEdges = customizableEdges1;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.FillColor = Color.FromArgb(73, 117, 162);
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(998, 18);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEmployee.Size = new Size(236, 75);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Employés";
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomerDetail
            // 
            btnCustomerDetail.BorderRadius = 26;
            btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerDetail.CheckedState.FillColor = Color.White;
            btnCustomerDetail.CheckedState.ForeColor = Color.Black;
            btnCustomerDetail.CustomizableEdges = customizableEdges3;
            btnCustomerDetail.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerDetail.FillColor = Color.FromArgb(73, 117, 162);
            btnCustomerDetail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerDetail.ForeColor = Color.White;
            btnCustomerDetail.Image = (Image)resources.GetObject("btnCustomerDetail.Image");
            btnCustomerDetail.Location = new Point(756, 18);
            btnCustomerDetail.Name = "btnCustomerDetail";
            btnCustomerDetail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCustomerDetail.Size = new Size(236, 75);
            btnCustomerDetail.TabIndex = 3;
            btnCustomerDetail.Text = "Clients";
            btnCustomerDetail.Click += btnCustomerDetail_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 26;
            btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCheckOut.CheckedState.FillColor = Color.White;
            btnCheckOut.CheckedState.ForeColor = Color.Black;
            btnCheckOut.CustomizableEdges = customizableEdges5;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.FromArgb(73, 117, 162);
            btnCheckOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Image = (Image)resources.GetObject("btnCheckOut.Image");
            btnCheckOut.ImageSize = new Size(50, 50);
            btnCheckOut.Location = new Point(514, 18);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCheckOut.Size = new Size(236, 75);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Facture";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCustomerRegistration
            // 
            btnCustomerRegistration.BorderRadius = 26;
            btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerRegistration.CheckedState.FillColor = Color.White;
            btnCustomerRegistration.CheckedState.ForeColor = Color.Black;
            btnCustomerRegistration.CustomizableEdges = customizableEdges7;
            btnCustomerRegistration.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerRegistration.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerRegistration.FillColor = Color.FromArgb(73, 117, 162);
            btnCustomerRegistration.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerRegistration.ForeColor = Color.White;
            btnCustomerRegistration.Image = (Image)resources.GetObject("btnCustomerRegistration.Image");
            btnCustomerRegistration.ImageSize = new Size(35, 35);
            btnCustomerRegistration.Location = new Point(265, 18);
            btnCustomerRegistration.Name = "btnCustomerRegistration";
            btnCustomerRegistration.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCustomerRegistration.Size = new Size(243, 75);
            btnCustomerRegistration.TabIndex = 1;
            btnCustomerRegistration.Text = "Ajout Clients";
            btnCustomerRegistration.Click += guna2Button2_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.Transparent;
            btnAddRoom.BorderRadius = 26;
            btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddRoom.CheckedState.FillColor = Color.White;
            btnAddRoom.CheckedState.ForeColor = Color.Black;
            btnAddRoom.CustomizableEdges = customizableEdges9;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.FillColor = Color.FromArgb(73, 117, 162);
            btnAddRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Image = (Image)resources.GetObject("btnAddRoom.Image");
            btnAddRoom.ImageSize = new Size(40, 40);
            btnAddRoom.Location = new Point(16, 18);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddRoom.Size = new Size(236, 75);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Chambres";
            btnAddRoom.Click += guna2Button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(uC_Employee1);
            panel2.Controls.Add(customerDetails1);
            panel2.Controls.Add(uC_CustomerCheckOut1);
            panel2.Controls.Add(uC_CustomerRegistration1);
            panel2.Controls.Add(uC_AddRoom1);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 446);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // uC_Employee1
            // 
            uC_Employee1.BackColor = Color.White;
            uC_Employee1.Dock = DockStyle.Fill;
            uC_Employee1.Location = new Point(0, 0);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(1297, 446);
            uC_Employee1.TabIndex = 2;
            uC_Employee1.Load += uC_Employee1_Load;
            // 
            // customerDetails1
            // 
            customerDetails1.BackColor = Color.White;
            customerDetails1.Dock = DockStyle.Fill;
            customerDetails1.Location = new Point(0, 0);
            customerDetails1.Name = "customerDetails1";
            customerDetails1.Size = new Size(1297, 446);
            customerDetails1.TabIndex = 2;
            // 
            // uC_CustomerCheckOut1
            // 
            uC_CustomerCheckOut1.BackColor = Color.White;
            uC_CustomerCheckOut1.Dock = DockStyle.Fill;
            uC_CustomerCheckOut1.ForeColor = Color.Black;
            uC_CustomerCheckOut1.Location = new Point(0, 0);
            uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            uC_CustomerCheckOut1.Size = new Size(1297, 446);
            uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            uC_CustomerRegistration1.BackColor = Color.White;
            uC_CustomerRegistration1.Dock = DockStyle.Fill;
            uC_CustomerRegistration1.ForeColor = Color.Black;
            uC_CustomerRegistration1.Location = new Point(0, 0);
            uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            uC_CustomerRegistration1.Size = new Size(1297, 446);
            uC_CustomerRegistration1.TabIndex = 2;
            // 
            // uC_AddRoom1
            // 
            uC_AddRoom1.BackColor = Color.White;
            uC_AddRoom1.Dock = DockStyle.Fill;
            uC_AddRoom1.Location = new Point(0, 0);
            uC_AddRoom1.Name = "uC_AddRoom1";
            uC_AddRoom1.Size = new Size(1297, 446);
            uC_AddRoom1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panel2;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 30;
            guna2Elipse6.TargetControl = this;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1329, 596);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Panel panel2;
        private Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CustomerRegistration uC_CustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}