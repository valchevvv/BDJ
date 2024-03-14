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

        public static void AddUser(User user)
        {
            BDJ bdj = getContext();
            bdj.Users.Add(user);
            bdj.SaveChanges();
        }

        public static void DeleteUser(User user)
        {
            BDJ bdj = getContext();
            bdj.Users.Remove(user);
            bdj.SaveChanges();
        }

        public static void EditUser(int id, string uname, string name, string pass, bool isAdmin)
        {
            BDJ bdj = getContext();
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
