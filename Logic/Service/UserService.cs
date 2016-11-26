using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Data;

namespace Logic.Service
{
    public static class UserService
    {
        public static User Me;
        public static bool IsLoggedIn => Me != null;

        public static User CreateUser(string userName, string password, string firstName, string lastName, bool isActive = true)
        {
            var db = new EKAEntities();
            var result = db.CreateUser(Me.UserID, userName, password, firstName, lastName, isActive).Single().Value;
            if (result > 0)
                return db.Users.Find(result);
            return null;
        }

        public static int ActivateUser(User user)
        {
            var db = new EKAEntities();
            var result = db.ActivateUser(Me.UserID, user.UserID).Single().Value;
            return result;
        }

        public static int DeactivateUser(User user)
        {
            var db = new EKAEntities();
            var result = db.DeactivateUser(Me.UserID, user.UserID).Single().Value;
            return result;
        }

        public static int ChangePasswordOfUser(User user, string oldPassword, string newPassword)
        {
            var db = new EKAEntities();
            var result = db.ChangePasswordOfUser(Me.UserID, user.UserID, oldPassword, newPassword).Single().Value;
            return result;
        }

        public static int ChangeDetailsOfUser(User user, string firstName, string lastName)
        {
            var db = new EKAEntities();
            var result = db.ChangeDetailsOfUser(Me.UserID, user.UserID, firstName, lastName).Single().Value;
            return result;
        }

        public static int AddToAdminsUsers(User user)
        {
            var db = new EKAEntities();
            var result = db.AddToAdminUsers(Me.UserID, user.UserID).Single().Value;
            return result;
        }

        public static int RemoveFromAdminUsers(User user)
        {
            var db = new EKAEntities();
            var result = db.RemoveFromAdminUsers(Me.UserID, user.UserID).Single().Value;
            return result;
        }

        public static int Login(string userName, string password)
        {
            if (Me != null) return -3;
            var db = new EKAEntities();
            var passwordHash = CreateMD5(password);
            var user = db.Users.FirstOrDefault(u => u.UserName == userName && u.PasswordHash == passwordHash);
            if (user == null) return -1;
            if (!user.IsActive) return -2;
            Me = user;

            return 0;
        }

        public static int Logout()
        {
            if (Me == null) return -1;
            Me = null;
            return 0;
        }

        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
