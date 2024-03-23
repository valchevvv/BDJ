using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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

        private void loadTrains()
        {
            trainComboBox.Items.Clear();
            Database.GetTrains().ForEach(x => trainComboBox.Items.Add($"{x.id}) {x.type}"));
        }

        private void loadRoutes()
        {
            cities.Clear();
            routeStopsComboBox.Items.Clear();
            Database.GetCities().ForEach(x => routeStopsComboBox.Items.Add($"{x.id}) {x.name}"));
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabs.SelectedTab.Name == "users")
            {
                loadUsers();
            } 
            else if (tabs.SelectedTab.Name == "trains")
            {
                loadTrains();
            }
            else if(tabs.SelectedTab.Name == "routes")
            {
                loadRoutes();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadTrains();
            guna2NumericUpDown1.Maximum = 24;
            guna2NumericUpDown2.Maximum = 59;
            
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            if (trainComboBox.SelectedIndex == -1) { MessageDialogAdmin.Show("Не е избран влак!", "Грешка"); return; }
            if (isEmpty(normalPriceText.Text)) { MessageDialogAdmin.Show("Въвеждането на основна цена е задължително!", "Грешка"); return; }
            
            int trainID = int.Parse(trainComboBox.SelectedItem.ToString().Split(')')[0]);
            DateTime start_date = DateParse(guna2DateTimePicker1.Value.Year, guna2DateTimePicker1.Value.Month, guna2DateTimePicker1.Value.Day, guna2NumericUpDown1.Value, guna2NumericUpDown2.Value);
            DateTime end_date = DateParse(guna2DateTimePicker2.Value.Year, guna2DateTimePicker2.Value.Month, guna2DateTimePicker2.Value.Day, guna2NumericUpDown4.Value, guna2NumericUpDown3.Value);
            decimal normal_price = decimal.Parse(normalPriceText.Text);

            Route newRoute = new Route();

            newRoute.train = trainID;
            newRoute.start_date = start_date;
            newRoute.end_date = end_date;
            newRoute.normal_price = normal_price;
            if (isEmpty(firstClassText.Text)) { newRoute.first_class = null; }
            else { newRoute.first_class = decimal.Parse(firstClassText.Text); }
            if(isEmpty(sleeperClassText.Text)) { newRoute.sleeper_class= null; } 
            else { newRoute.sleeper_class = decimal.Parse(sleeperClassText.Text); }

            int index = Database.AddRoute(newRoute);

            for (int i = 0; i < cities.Count; i++)
            {
                Database.AddStopToRoute(index, cities[i].id, i + 1,  DateTime.Now);
            }

            ClearDataRoutes();
            listBox1.Items.Clear();
            cities.Clear();

        }

        private DateTime DateParse(int year, int mount,int day,decimal hour, decimal minute)
        {
            return DateTime.Parse($"{year}-{mount}-{day} {hour}:{minute}:00.000");
        }

        private void ClearDataRoutes()
        {
            trainComboBox.SelectedIndex= -1;
            guna2NumericUpDown1.Value = 0;
            guna2NumericUpDown2.Value = 0;
            guna2NumericUpDown3.Value = 0;
            guna2NumericUpDown4.Value = 0;
            normalPriceText.Clear();
            firstClassText.Clear();
            sleeperClassText.Clear();
        }

        private void addCityBtn_Click(object sender, EventArgs e)
        {
            
            if (isEmpty(cityNameText.Text))return;
            if (ContainsCity(Database.GetCities(), cityNameText.Text)) { MessageDialogAdmin.Show("Този град вече е въведен!", "Грешка"); cityNameText.Clear(); return; }

            City newCity = new City();

            newCity.name= cityNameText.Text;

            Database.AddCity(newCity);
            cityNameText.Clear();

        }

        private bool ContainsCity(List<City> cities, string name)
        {
            bool contains = false;
            foreach (City city in cities) { if (city.name == name) { contains = true; } }
            return contains;
        }

        List<City> cities = new List<City>();

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (routeStopsComboBox.SelectedIndex == -1) return;
            int index = int.Parse(routeStopsComboBox.SelectedItem.ToString().Split(')')[0]);
            City city = Database.GetCities().Find(x => x.id == index);
            listBox1.Items.Add($"{listBox1.Items.Count + 1}) {city.name}");
            cities.Add(city);

            routeStopsComboBox.SelectedIndex = -1;
        }
    }
}
