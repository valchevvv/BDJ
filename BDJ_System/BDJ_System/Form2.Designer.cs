
namespace BDJ_System
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.users = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.users_edit = new Guna.UI2.WinForms.Guna2Button();
            this.users_remove = new Guna.UI2.WinForms.Guna2Button();
            this.users_add = new Guna.UI2.WinForms.Guna2Button();
            this.users_isadmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.users_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.users_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.users_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.usersComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.routes = new System.Windows.Forms.TabPage();
            this.trains = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.typeTrainText = new Guna.UI2.WinForms.Guna2TextBox();
            this.trainPlacesText = new Guna.UI2.WinForms.Guna2TextBox();
            this.stops = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.tabs.SuspendLayout();
            this.users.SuspendLayout();
            this.trains.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.users);
            this.tabs.Controls.Add(this.routes);
            this.tabs.Controls.Add(this.trains);
            this.tabs.Controls.Add(this.stops);
            this.tabs.ItemSize = new System.Drawing.Size(180, 40);
            this.tabs.Location = new System.Drawing.Point(0, 50);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(982, 518);
            this.tabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(88)))), ((int)(((byte)(185)))));
            this.tabs.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabs.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabs.TabButtonTextOffset = new System.Drawing.Point(10, 0);
            this.tabs.TabIndex = 0;
            this.tabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // users
            // 
            this.users.Controls.Add(this.label6);
            this.users.Controls.Add(this.label5);
            this.users.Controls.Add(this.label4);
            this.users.Controls.Add(this.label3);
            this.users.Controls.Add(this.label2);
            this.users.Controls.Add(this.users_edit);
            this.users.Controls.Add(this.users_remove);
            this.users.Controls.Add(this.users_add);
            this.users.Controls.Add(this.users_isadmin);
            this.users.Controls.Add(this.users_pass);
            this.users.Controls.Add(this.users_name);
            this.users.Controls.Add(this.users_uname);
            this.users.Controls.Add(this.usersComboBox);
            this.users.Location = new System.Drawing.Point(184, 4);
            this.users.Name = "users";
            this.users.Padding = new System.Windows.Forms.Padding(3);
            this.users.Size = new System.Drawing.Size(794, 510);
            this.users.TabIndex = 0;
            this.users.Text = "Потребители";
            this.users.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Админ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Парола";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Потребителко име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Потребител";
            // 
            // users_edit
            // 
            this.users_edit.BorderRadius = 12;
            this.users_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.users_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.users_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.users_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.users_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_edit.ForeColor = System.Drawing.Color.White;
            this.users_edit.Location = new System.Drawing.Point(214, 383);
            this.users_edit.Name = "users_edit";
            this.users_edit.Size = new System.Drawing.Size(98, 45);
            this.users_edit.TabIndex = 7;
            this.users_edit.Text = "Edit";
            this.users_edit.Click += new System.EventHandler(this.users_edit_Click);
            // 
            // users_remove
            // 
            this.users_remove.BorderRadius = 12;
            this.users_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.users_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.users_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.users_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.users_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_remove.ForeColor = System.Drawing.Color.White;
            this.users_remove.Location = new System.Drawing.Point(110, 383);
            this.users_remove.Name = "users_remove";
            this.users_remove.Size = new System.Drawing.Size(98, 45);
            this.users_remove.TabIndex = 6;
            this.users_remove.Text = "Remove";
            this.users_remove.Click += new System.EventHandler(this.users_remove_Click);
            // 
            // users_add
            // 
            this.users_add.BorderRadius = 12;
            this.users_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.users_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.users_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.users_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.users_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_add.ForeColor = System.Drawing.Color.White;
            this.users_add.Location = new System.Drawing.Point(6, 383);
            this.users_add.Name = "users_add";
            this.users_add.Size = new System.Drawing.Size(98, 45);
            this.users_add.TabIndex = 5;
            this.users_add.Text = "Add";
            this.users_add.Click += new System.EventHandler(this.users_add_Click);
            // 
            // users_isadmin
            // 
            this.users_isadmin.BackColor = System.Drawing.Color.Transparent;
            this.users_isadmin.BorderColor = System.Drawing.Color.DarkGray;
            this.users_isadmin.BorderRadius = 12;
            this.users_isadmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.users_isadmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users_isadmin.Enabled = false;
            this.users_isadmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_isadmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_isadmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.users_isadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.users_isadmin.ItemHeight = 30;
            this.users_isadmin.Items.AddRange(new object[] {
            "Да",
            "Не"});
            this.users_isadmin.Location = new System.Drawing.Point(6, 332);
            this.users_isadmin.Name = "users_isadmin";
            this.users_isadmin.Size = new System.Drawing.Size(306, 36);
            this.users_isadmin.TabIndex = 4;
            // 
            // users_pass
            // 
            this.users_pass.BorderColor = System.Drawing.Color.DimGray;
            this.users_pass.BorderRadius = 12;
            this.users_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.users_pass.DefaultText = "";
            this.users_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.users_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.users_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_pass.ForeColor = System.Drawing.Color.Black;
            this.users_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_pass.Location = new System.Drawing.Point(6, 256);
            this.users_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_pass.Name = "users_pass";
            this.users_pass.PasswordChar = '\0';
            this.users_pass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_pass.PlaceholderText = "Парола";
            this.users_pass.ReadOnly = true;
            this.users_pass.SelectedText = "";
            this.users_pass.Size = new System.Drawing.Size(306, 48);
            this.users_pass.TabIndex = 3;
            // 
            // users_name
            // 
            this.users_name.BorderColor = System.Drawing.Color.DimGray;
            this.users_name.BorderRadius = 12;
            this.users_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.users_name.DefaultText = "";
            this.users_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.users_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.users_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_name.ForeColor = System.Drawing.Color.Black;
            this.users_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_name.Location = new System.Drawing.Point(6, 179);
            this.users_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_name.Name = "users_name";
            this.users_name.PasswordChar = '\0';
            this.users_name.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_name.PlaceholderText = "Име";
            this.users_name.ReadOnly = true;
            this.users_name.SelectedText = "";
            this.users_name.Size = new System.Drawing.Size(306, 48);
            this.users_name.TabIndex = 2;
            // 
            // users_uname
            // 
            this.users_uname.BorderColor = System.Drawing.Color.DimGray;
            this.users_uname.BorderRadius = 12;
            this.users_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.users_uname.DefaultText = "";
            this.users_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.users_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.users_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.users_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_uname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_uname.ForeColor = System.Drawing.Color.Black;
            this.users_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.users_uname.Location = new System.Drawing.Point(6, 102);
            this.users_uname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_uname.Name = "users_uname";
            this.users_uname.PasswordChar = '\0';
            this.users_uname.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_uname.PlaceholderText = "Потребителко име";
            this.users_uname.ReadOnly = true;
            this.users_uname.SelectedText = "";
            this.users_uname.Size = new System.Drawing.Size(306, 48);
            this.users_uname.TabIndex = 1;
            // 
            // usersComboBox
            // 
            this.usersComboBox.BackColor = System.Drawing.Color.Transparent;
            this.usersComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.usersComboBox.BorderRadius = 12;
            this.usersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usersComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usersComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.usersComboBox.ItemHeight = 30;
            this.usersComboBox.Location = new System.Drawing.Point(6, 29);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(306, 36);
            this.usersComboBox.TabIndex = 0;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // routes
            // 
            this.routes.Location = new System.Drawing.Point(184, 4);
            this.routes.Name = "routes";
            this.routes.Padding = new System.Windows.Forms.Padding(3);
            this.routes.Size = new System.Drawing.Size(794, 510);
            this.routes.TabIndex = 1;
            this.routes.Text = "Маршрути";
            this.routes.UseVisualStyleBackColor = true;
            // 
            // trains
            // 
            this.trains.Controls.Add(this.label8);
            this.trains.Controls.Add(this.label10);
            this.trains.Controls.Add(this.guna2Button1);
            this.trains.Controls.Add(this.typeTrainText);
            this.trains.Controls.Add(this.trainPlacesText);
            this.trains.Location = new System.Drawing.Point(184, 4);
            this.trains.Name = "trains";
            this.trains.Size = new System.Drawing.Size(794, 510);
            this.trains.TabIndex = 2;
            this.trains.Text = "Влакове";
            this.trains.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(28, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Тип";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(28, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Брой места";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(28, 187);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(306, 45);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Добави";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // typeTrainText
            // 
            this.typeTrainText.BorderColor = System.Drawing.Color.DimGray;
            this.typeTrainText.BorderRadius = 12;
            this.typeTrainText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typeTrainText.DefaultText = "";
            this.typeTrainText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.typeTrainText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.typeTrainText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.typeTrainText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.typeTrainText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeTrainText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeTrainText.ForeColor = System.Drawing.Color.Black;
            this.typeTrainText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeTrainText.Location = new System.Drawing.Point(28, 123);
            this.typeTrainText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeTrainText.Name = "typeTrainText";
            this.typeTrainText.PasswordChar = '\0';
            this.typeTrainText.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.typeTrainText.PlaceholderText = "Тип на влака";
            this.typeTrainText.SelectedText = "";
            this.typeTrainText.Size = new System.Drawing.Size(306, 48);
            this.typeTrainText.TabIndex = 15;
            // 
            // trainPlacesText
            // 
            this.trainPlacesText.BorderColor = System.Drawing.Color.DimGray;
            this.trainPlacesText.BorderRadius = 12;
            this.trainPlacesText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trainPlacesText.DefaultText = "";
            this.trainPlacesText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.trainPlacesText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.trainPlacesText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trainPlacesText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trainPlacesText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trainPlacesText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trainPlacesText.ForeColor = System.Drawing.Color.Black;
            this.trainPlacesText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trainPlacesText.Location = new System.Drawing.Point(28, 40);
            this.trainPlacesText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainPlacesText.Name = "trainPlacesText";
            this.trainPlacesText.PasswordChar = '\0';
            this.trainPlacesText.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.trainPlacesText.PlaceholderText = "Места";
            this.trainPlacesText.SelectedText = "";
            this.trainPlacesText.Size = new System.Drawing.Size(306, 48);
            this.trainPlacesText.TabIndex = 13;
            // 
            // stops
            // 
            this.stops.Location = new System.Drawing.Point(184, 4);
            this.stops.Name = "stops";
            this.stops.Size = new System.Drawing.Size(794, 510);
            this.stops.TabIndex = 3;
            this.stops.Text = "Спирки";
            this.stops.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.close_btn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(982, 50);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Български Държавни Железници";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(933, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 40);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 568);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabs.ResumeLayout(false);
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            this.trains.ResumeLayout(false);
            this.trains.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl tabs;
        private System.Windows.Forms.TabPage users;
        private System.Windows.Forms.TabPage routes;
        private System.Windows.Forms.TabPage trains;
        private System.Windows.Forms.TabPage stops;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox usersComboBox;
        private Guna.UI2.WinForms.Guna2TextBox users_uname;
        private Guna.UI2.WinForms.Guna2ComboBox users_isadmin;
        private Guna.UI2.WinForms.Guna2TextBox users_pass;
        private Guna.UI2.WinForms.Guna2TextBox users_name;
        private Guna.UI2.WinForms.Guna2Button users_add;
        private Guna.UI2.WinForms.Guna2Button users_remove;
        private Guna.UI2.WinForms.Guna2Button users_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox typeTrainText;
        private Guna.UI2.WinForms.Guna2TextBox trainPlacesText;
    }
}