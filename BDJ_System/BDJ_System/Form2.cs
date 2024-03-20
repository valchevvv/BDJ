using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BDJ_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void loadUsers()
        {
            Database.GetUsers().ForEach(x => usersComboBox.Items.Add($"{x.id}) {x.name}"));
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedTab.Name == "users") loadUsers();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1) return;

            User user = Database.GetUserById(int.Parse(usersComboBox.Text.Split(')')[0]));

            users_uname.Text = user.username;
            users_name.Text = user.name;
            users_pass.Text = user.password;
            users_isadmin.SelectedIndex = (bool)user.isAdmin ? 0 : 1;
        }

        private void users_add_Click(object sender, EventArgs e)
        {
            if (isEmpty(users_uname.Text) || isEmpty(users_name.Text) || isEmpty(users_pass.Text)) return;

            if (users_add.BackColor == Color.Green)
            {
                User newuser = new User();
                newuser.username = users_uname.Text;
                newuser.name = users_name.Text;
                newuser.password = users_pass.Text;
                newuser.isAdmin = users_isadmin.SelectedIndex == 0;
                Database.AddUser(newuser);
                users_add.BackColor = Color.FromArgb(255, 94, 148, 255);
                users_remove.Enabled = true;
                users_add.Enabled = true;
                users_uname.ReadOnly = false;
                users_uname.Clear();
                users_name.ReadOnly = false;
                users_name.Clear();
                users_pass.ReadOnly = false;
                users_pass.Clear();
                users_isadmin.Enabled = false;
                users_isadmin.SelectedIndex = -1;
                return;
            }
            usersComboBox.SelectedIndex = -1;
            users_uname.ReadOnly = true;
            users_uname.Clear();
            users_name.ReadOnly = true;
            users_name.Clear();
            users_pass.ReadOnly = true;
            users_pass.Clear();
            users_isadmin.Enabled = true;
            users_isadmin.SelectedIndex = 1;
            users_add.BackColor = Color.Green;
            users_remove.Enabled = false;
            users_add.Enabled = false;
        }

        private void users_remove_Click(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1) return;

            User user = Database.GetUserById(int.Parse(usersComboBox.Text.Split(')')[0]));

            Database.DeleteUser(user);
            loadUsers();
        }

        private bool isEmpty(string text)
        {
            return String.IsNullOrWhiteSpace(text);
        }

        private void users_edit_Click(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1) return;
            if (isEmpty(users_uname.Text) || isEmpty(users_name.Text) || isEmpty(users_pass.Text)) return;

            User user = Database.GetUserById(int.Parse(usersComboBox.Text.Split(')')[0]));

            if (users_edit.BackColor == Color.Green)
            {
                Database.EditUser(user.id, users_uname.Text, users_name.Text, users_pass.Text, users_isadmin.SelectedIndex == 0);
                users_add.BackColor = Color.FromArgb(255, 94, 148, 255);
                users_add.Enabled = true;
                users_remove.Enabled = true;
                users_uname.ReadOnly = false;
                users_uname.Clear();
                users_name.ReadOnly = false;
                users_name.Clear();
                users_pass.ReadOnly = false;
                users_pass.Clear();
                users_isadmin.Enabled = false;
                users_isadmin.SelectedIndex = -1;
                return;
            }
            usersComboBox.SelectedIndex = -1;
            users_uname.ReadOnly = true;
            users_uname.Clear();
            users_name.ReadOnly = true;
            users_name.Clear();
            users_pass.ReadOnly = true;
            users_pass.Clear();
            users_isadmin.Enabled = true;
            users_isadmin.SelectedIndex = 1;
            users_edit.BackColor = Color.Green;
            users_add.Enabled = false;
            users_remove.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isEmpty(trainPlacesText.Text) || isEmpty(typeTrainText.Text)) return;

            Train newtrain = new Train();

            newtrain.places = int.Parse(trainPlacesText.Text);
            newtrain.type = typeTrainText.Text;

            Database.AddTrain(newtrain);


            trainPlacesText.Clear();
            typeTrainText.Clear();
        }
    }
}
