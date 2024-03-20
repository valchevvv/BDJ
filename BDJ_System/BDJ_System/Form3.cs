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
using System.Web.Routing;

namespace BDJ_System
{
    public partial class Form3 : Form
    {
        private User saved_login = null;
        public Form3(User login)
        {
            InitializeComponent();
            saved_login = login;
            label1.Text = $"Български Държавни Железници | {login.name}";
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

        private void loadRoutes()
        {
            routeComboBox.Items.Clear();



            Database.GetRoutes().ForEach(x => routeComboBox.Items.Add($"{x.id}) {Database.GetCityById((int)Database.FirstAndLastRouteStop(x.id)[0].city).name} - {Database.GetCityById((int)Database.FirstAndLastRouteStop(x.id)[1].city).name}"));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (routeComboBox.SelectedIndex == -1) return;
            Route route = Database.GetRoutes().Find(x=>x.id == int.Parse(routeComboBox.SelectedItem.ToString().Split(')')[0]));
            int board = (int)Database.GetRoute_Stop(int.Parse(boardComboBox.SelectedItem.ToString().Split(')')[0])).id;
            int arrive = (int)Database.GetRoute_Stop(int.Parse(arriveComboBox.SelectedItem.ToString().Split(')')[0])).id;
            Database.MakeReservation(saved_login.id, route.id, board, arrive);
            routeComboBox.SelectedIndex = -1;
            boardComboBox.SelectedIndex = -1;
            boardComboBox.Enabled = false;
            arriveComboBox.SelectedIndex = -1;
            arriveComboBox.Enabled = false;
            price_lbl.Text = String.Empty;
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedIndex == 0) loadRoutes();
            else if (guna2TabControl1.SelectedIndex == 1) loadReservations();
        }

        private void loadReservations()
        {
            dataGridView.Rows.Clear();
            foreach (Reservation reservation in Database.GetReservationsByUser(saved_login.id))
            {
                label1.Text += $" {reservation.route}";
                string route = Database.GetCityById((int)Database.FirstAndLastRouteStop((int)reservation.route)[0].city).name;
                route += $" - {Database.GetCityById((int)Database.FirstAndLastRouteStop((int)reservation.route)[1].city).name}";

                string board = Database.GetCityById((int)reservation.board).name;
                string arrive = Database.GetCityById((int)reservation.arrive).name;

                int board_number = (int)Database.GetRoute_Stop((int)reservation.board).number;
                int arrive_number = (int)Database.GetRoute_Stop((int)reservation.arrive).number;
                int route_stops_count = Math.Abs(arrive_number - board_number);

                decimal price = (decimal)Database.GetRoute((int)reservation.route).normal_price * (int)route_stops_count;

                string[] info = { route, board, arrive, $"{price:c}" };
                dataGridView.Rows.Add(info);
            }

        }

        private void routeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardComboBox.Enabled = routeComboBox.SelectedIndex != -1;
            if (routeComboBox.SelectedIndex == -1) return;
            Route route = Database.GetRoutes().Find(x => x.id == int.Parse(routeComboBox.SelectedItem.ToString().Split(')')[0]));
            boardComboBox.Items.Clear();
            List<Route_Stops> stops = Database.GetRoute_Stops(route.id);
            stops.RemoveAt(stops.Count - 1);
            stops.ForEach(x => boardComboBox.Items.Add($"{x.id}) {Database.GetCityById((int)x.city).name}"));
            boardComboBox.SelectedIndex = 0;
            Database.GetRoute_Stops(route.id).ToList().ForEach(x => arriveComboBox.Items.Add($"{x.id}) {Database.GetCityById((int)x.city).name}"));
            arriveComboBox.SelectedIndex = arriveComboBox.Items.Count - 1;
        }

        private void boardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            arriveComboBox.Enabled = boardComboBox.SelectedIndex != -1;
            if (boardComboBox.SelectedIndex == -1) return;
            Route route = Database.GetRoutes().Find(x => x.id == int.Parse(routeComboBox.SelectedItem.ToString().Split(')')[0]));
            int boardNumber = (int)Database.GetRoute_Stops(route.id).Find(x => x.id == int.Parse(boardComboBox.SelectedItem.ToString().Split(')')[0])).number;
            arriveComboBox.Items.Clear();
            Database.GetRoute_Stops(route.id).Where(x => x.number > boardNumber).ToList().ForEach(x => arriveComboBox.Items.Add($"{x.id}) {Database.GetCityById((int)x.city).name}"));
            Route_Stops last = Database.FirstAndLastRouteStop(route.id)[1];
            arriveComboBox.SelectedItem = $"{last.id}) {Database.GetCityById((int)last.city).name}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadRoutes();
        }

        private void arriveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (routeComboBox.SelectedIndex == -1) return;
            Route route = Database.GetRoutes().Find(x => x.id == int.Parse(routeComboBox.SelectedItem.ToString().Split(')')[0]));
            int board_number = (int)Database.GetRoute_Stop(int.Parse(boardComboBox.SelectedItem.ToString().Split(')')[0])).number;
            int arrive_number = (int)Database.GetRoute_Stop(int.Parse(arriveComboBox.SelectedItem.ToString().Split(')')[0])).number;
            int route_stops_count = Math.Abs(arrive_number - board_number);
            decimal price = (decimal)route.normal_price * (int)route_stops_count;
            price_lbl.Text = $"Цена: {price:c}";
        }
    }
}
