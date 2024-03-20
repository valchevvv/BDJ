
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
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.trainComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.users.SuspendLayout();
            this.routes.SuspendLayout();
            this.trains.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
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
            this.tabs.Location = new System.Drawing.Point(0, 62);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1105, 648);
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
            this.users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users.Name = "users";
            this.users.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users.Size = new System.Drawing.Size(917, 640);
            this.users.TabIndex = 0;
            this.users.Text = "Потребители";
            this.users.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Админ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Парола";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Потребителко име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
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
            this.users_edit.Location = new System.Drawing.Point(241, 479);
            this.users_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_edit.Name = "users_edit";
            this.users_edit.Size = new System.Drawing.Size(110, 56);
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
            this.users_remove.Location = new System.Drawing.Point(124, 479);
            this.users_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_remove.Name = "users_remove";
            this.users_remove.Size = new System.Drawing.Size(110, 56);
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
            this.users_add.Location = new System.Drawing.Point(7, 479);
            this.users_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_add.Name = "users_add";
            this.users_add.Size = new System.Drawing.Size(110, 56);
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
            this.users_isadmin.Location = new System.Drawing.Point(7, 415);
            this.users_isadmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_isadmin.Name = "users_isadmin";
            this.users_isadmin.Size = new System.Drawing.Size(344, 36);
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
            this.users_pass.Location = new System.Drawing.Point(7, 320);
            this.users_pass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.users_pass.Name = "users_pass";
            this.users_pass.PasswordChar = '\0';
            this.users_pass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_pass.PlaceholderText = "Парола";
            this.users_pass.ReadOnly = true;
            this.users_pass.SelectedText = "";
            this.users_pass.Size = new System.Drawing.Size(344, 60);
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
            this.users_name.Location = new System.Drawing.Point(7, 224);
            this.users_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.users_name.Name = "users_name";
            this.users_name.PasswordChar = '\0';
            this.users_name.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_name.PlaceholderText = "Име";
            this.users_name.ReadOnly = true;
            this.users_name.SelectedText = "";
            this.users_name.Size = new System.Drawing.Size(344, 60);
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
            this.users_uname.Location = new System.Drawing.Point(7, 128);
            this.users_uname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.users_uname.Name = "users_uname";
            this.users_uname.PasswordChar = '\0';
            this.users_uname.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.users_uname.PlaceholderText = "Потребителко име";
            this.users_uname.ReadOnly = true;
            this.users_uname.SelectedText = "";
            this.users_uname.Size = new System.Drawing.Size(344, 60);
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
            this.usersComboBox.Location = new System.Drawing.Point(7, 36);
            this.usersComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(344, 36);
            this.usersComboBox.TabIndex = 0;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // routes
            // 
            this.routes.Controls.Add(this.label12);
            this.routes.Controls.Add(this.label11);
            this.routes.Controls.Add(this.guna2NumericUpDown2);
            this.routes.Controls.Add(this.guna2NumericUpDown1);
            this.routes.Controls.Add(this.guna2DateTimePicker1);
            this.routes.Controls.Add(this.label7);
            this.routes.Controls.Add(this.trainComboBox);
            this.routes.Controls.Add(this.label9);
            this.routes.Controls.Add(this.guna2Button2);
            this.routes.Location = new System.Drawing.Point(184, 4);
            this.routes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.routes.Name = "routes";
            this.routes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.routes.Size = new System.Drawing.Size(917, 640);
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
            this.trains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trains.Name = "trains";
            this.trains.Size = new System.Drawing.Size(917, 640);
            this.trains.TabIndex = 2;
            this.trains.Text = "Влакове";
            this.trains.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Тип";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(32, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
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
            this.guna2Button1.Location = new System.Drawing.Point(32, 234);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(344, 56);
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
            this.typeTrainText.Location = new System.Drawing.Point(32, 154);
            this.typeTrainText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.typeTrainText.Name = "typeTrainText";
            this.typeTrainText.PasswordChar = '\0';
            this.typeTrainText.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.typeTrainText.PlaceholderText = "Тип на влака";
            this.typeTrainText.SelectedText = "";
            this.typeTrainText.Size = new System.Drawing.Size(344, 60);
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
            this.trainPlacesText.Location = new System.Drawing.Point(32, 50);
            this.trainPlacesText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.trainPlacesText.Name = "trainPlacesText";
            this.trainPlacesText.PasswordChar = '\0';
            this.trainPlacesText.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.trainPlacesText.PlaceholderText = "Места";
            this.trainPlacesText.SelectedText = "";
            this.trainPlacesText.Size = new System.Drawing.Size(344, 60);
            this.trainPlacesText.TabIndex = 13;
            // 
            // stops
            // 
            this.stops.Location = new System.Drawing.Point(184, 4);
            this.stops.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stops.Name = "stops";
            this.stops.Size = new System.Drawing.Size(917, 640);
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
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1105, 62);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Български Държавни Железници";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(1050, 6);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(45, 50);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(27, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Изберете влак";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 12;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(16, 335);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(344, 56);
            this.guna2Button2.TabIndex = 25;
            this.guna2Button2.Text = "Добави";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // trainComboBox
            // 
            this.trainComboBox.BackColor = System.Drawing.Color.Transparent;
            this.trainComboBox.BorderRadius = 12;
            this.trainComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.trainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trainComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trainComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.trainComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.trainComboBox.ItemHeight = 30;
            this.trainComboBox.Location = new System.Drawing.Point(27, 58);
            this.trainComboBox.Name = "trainComboBox";
            this.trainComboBox.Size = new System.Drawing.Size(293, 36);
            this.trainComboBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Начална дата и час";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 12;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(31, 150);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(295, 36);
            this.guna2DateTimePicker1.TabIndex = 30;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 20, 12, 4, 57, 125);
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderRadius = 12;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(78, 194);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(63, 43);
            this.guna2NumericUpDown1.TabIndex = 31;
            // 
            // guna2NumericUpDown2
            // 
            this.guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown2.BorderRadius = 12;
            this.guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown2.Location = new System.Drawing.Point(263, 194);
            this.guna2NumericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2NumericUpDown2.Name = "guna2NumericUpDown2";
            this.guna2NumericUpDown2.Size = new System.Drawing.Size(63, 43);
            this.guna2NumericUpDown2.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(27, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Час";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(179, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Минути";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabs.ResumeLayout(false);
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            this.routes.ResumeLayout(false);
            this.routes.PerformLayout();
            this.trains.ResumeLayout(false);
            this.trains.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox trainComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}