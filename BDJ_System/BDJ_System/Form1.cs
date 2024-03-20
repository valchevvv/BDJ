using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BDJ_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private User login(string username, string password)
        {
            int index = Database.getContext().Users.ToList().FindIndex(x => x.username == username && x.password == password);

            return index != -1 ? Database.getContext().Users.ToList().Find(x => x.username == username && x.password == password) : null;
        }

        bool show_pass = false;

        private void show_close_pass_Click(object sender, EventArgs e)
        {
            show_pass = !show_pass;
            show_close_pass.Image = show_pass ? Properties.Resources.show_eye : Properties.Resources.close_eye;
            passwordBox.PasswordChar = show_pass ? '\0' : '#';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(usernameBox.Text))
            {
                MessageDialog.Show("Потребителското име не може да бъде празно !", "Грешка");
                return;
            }
            if (String.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageDialog.Show("Потребителското име не може да бъде празно !", "Грешка");
                return;
            }

            User user = login(usernameBox.Text, passwordBox.Text);

            if(user != null)
            {
                if((bool)user.isAdmin)
                {
                    Form2 form = new Form2();
                    // Form3 form = new Form3(user);
                    form.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
                    form.Show();
                } else
                {
                    Form3 form = new Form3(user);
                    form.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
                    form.Show();
                }
                this.Hide();
                MessageDialog.Show($"Добре дошли отново {user.username}");
            }
            else
            {
                MessageDialog.Show("Грешно потребителско име или парола !", "Грешка");
            }
        }

        private void header_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
