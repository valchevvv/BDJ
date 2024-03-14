using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDJ_System
{
    static class Database
    {   
        private static BDJ getContext()
        {
            return new BDJ();
        }

        public static List<User> GetUsers()
        {
            return getContext().Users.ToList();
        }

        public static User GetUserById(int id)
        {
            return GetUsers().Find(x => x.id == id);
        }

        public static List<City> GetCities()
        {
            return getContext().Cities.ToList();
        }

        public static List<Reservation> GetReservations()
        {
            return getContext().Reservations.ToList();
        }
    }
}
