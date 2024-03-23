using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BDJ_System
{
    static class Database
    {   
        public static BDJEntity getContext()
        {
            return new BDJEntity();
        }

        public static List<User> GetUsers()
        {
            return getContext().Users.ToList();
        }

        public static void AddUser(User user)
        {
            BDJEntity bdj = getContext();
            bdj.Users.Add(user);
            bdj.SaveChanges();
        }

        public static void DeleteUser(User user)
        {
            BDJEntity bdj = getContext();
            bdj.Users.Remove(user);
            bdj.SaveChanges();
        }

        public static void AddTrain(Train train)
        {
            BDJEntity bdj = getContext();
            bdj.Trains.Add(train);
            bdj.SaveChanges();
        }

        public static int AddRoute(Route route)
        {
            BDJEntity bdj = getContext();
            bdj.Routes.Add(route);
            bdj.SaveChanges();

            return bdj.Routes.ToList().Find(x => x == route).id;
        }

        public static void AddStopToRoute(int route, int city, int number, DateTime dateTime)
        {
            BDJEntity bdj = getContext();
            Route_Stops stop = new Route_Stops();
            stop.route = route;
            stop.city = city;
            stop.number = number;
            stop.arrival = dateTime;
            bdj.Route_Stops.Add(stop);
            bdj.SaveChanges();
        }


        public static void AddCity(City city)
        {
            BDJEntity bdj = getContext();
            bdj.Cities.Add(city);
            bdj.SaveChanges();
        }

        public static void EditUser(int id, string uname, string name, string pass, bool isAdmin)
        {
            BDJEntity bdj = getContext();
            User user = bdj.Users.ToList().Find(x => x.id == id);
            user.username = uname;
            user.name = name;
            user.password = pass;
            user.isAdmin = isAdmin;
            bdj.SaveChanges();
        }

        public static User GetUserById(int id)
        {
            return GetUsers().Find(x => x.id == id);
        }

        public static Train GetTrainById(int id)
        {
            return GetTrains().Find(x=>x.id == id);
        }

        public static List<City> GetCities()
        {
            return getContext().Cities.ToList();
        }

        public static List<Reservation> GetReservations()
        {
            return getContext().Reservations.ToList();
        }

        public static List<Route> GetRoutes()
        {
            return getContext().Routes.ToList();
        }

        public static Route GetRoute(int id)
        {
            return getContext().Routes.ToList().Find(x => x.id == id);
        }
        
        public static List<Train> GetTrains()
        {
            return getContext().Trains.ToList();
        }

        public static List<Route_Stops> GetRoute_Stops(int route_id)
        {
            return getContext().Route_Stops.ToList().Where(x => (int)x.route == route_id).OrderBy(x => x.number).ToList();
        }
        
        public static Route_Stops[] FirstAndLastRouteStop(int route_id)
        {
            Route_Stops[] stops = GetRoute_Stops(route_id).ToArray();
            if (stops.Length <= 0) return new Route_Stops[] { };
            Route_Stops[] first_last = { stops[0], stops[stops.Length - 1] };
            return first_last;
        }

        public static City GetCityById(int id)
        {
            return getContext().Cities.ToList().Find(x => x.id == id);
        }

        public static Route_Stops GetRoute_Stop(int id)
        {
            return getContext().Route_Stops.ToList().Find(x => x.id == id);
        }

        public static void MakeReservation(int passenger, int route, int board, int arrive)
        {
            Reservation reservation = new Reservation();
            reservation.passenger = passenger;
            reservation.route = route;
            reservation.board = board;
            reservation.arrive = arrive;
            BDJEntity context = getContext();
            context.Reservations.Add(reservation);
            context.SaveChanges();
        }

        public static List<Reservation> GetReservationsByUser(int id)
        {
            return getContext().Reservations.ToList().Where(x => x.passenger == id).ToList();
        }
    }
}
