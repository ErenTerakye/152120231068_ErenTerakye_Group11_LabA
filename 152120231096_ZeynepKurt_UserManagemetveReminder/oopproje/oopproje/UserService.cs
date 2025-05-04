using System.Collections.Generic;

namespace oopproje
{
    public static class UserService
    {
        private static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static User GetUserByEmailAndPassword(string email, string password)
        {
            return users.Find(u => u.Email == email && u.Password == password);
        }

        public static List<User> GetAllUsers()
        {
            return users;
        }
    }
}
