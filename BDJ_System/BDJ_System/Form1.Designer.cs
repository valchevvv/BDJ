
namespace BDJ_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.header_panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.show_close_pass = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(289, 7);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 40);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 1;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Controls.Add(this.close_btn);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(341, 56);
            this.header_panel.TabIndex = 2;
            this.header_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_panel_MouseMove);
            // 
            // usernameBox
            // 
            this.usernameBox.BorderRadius = 12;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "Admin";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameBox.ForeColor = System.Drawing.Color.Black;
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.Location = new System.Drawing.Point(56, 92);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameBox.PlaceholderText = "Потребителско име";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(229, 48);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderRadius = 12;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "admin_pass";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordBox.ForeColor = System.Drawing.Color.Black;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Location = new System.Drawing.Point(56, 152);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '#';
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordBox.PlaceholderText = "Парола";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(229, 48);
            this.passwordBox.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.BorderRadius = 12;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(80, 218);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 45);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Вход";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // show_close_pass
            // 
            this.show_close_pass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_close_pass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_close_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_close_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_close_pass.FillColor = System.Drawing.Color.Transparent;
            this.show_close_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.show_close_pass.ForeColor = System.Drawing.Color.White;
            this.show_close_pass.Image = global::BDJ_System.Properties.Resources.close_eye;
            this.show_close_pass.Location = new System.Drawing.Point(291, 165);
            this.show_close_pass.Name = "show_close_pass";
            this.show_close_pass.Size = new System.Drawing.Size(25, 25);
            this.show_close_pass.TabIndex = 6;
            this.show_close_pass.Click += new System.EventHandler(this.show_close_pass_Click);
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog.Caption = null;
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MessageDialog.Parent = null;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MessageDialog.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 308);
            this.ControlBox = false;
            this.Controls.Add(this.show_close_pass);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox close_btn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel header_panel;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button show_close_pass;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
        private System.Windows.Forms.Label label1;
    }
}

