using System;
using System.Linq;
using System.Text;
using Logic.Data;

namespace Logic.Service
{
    public static class UserService
    {
        public static User Me;
        public static bool IsLoggedIn => Me != null;

        public static ServiceResult<User> CreateUser(string userName, string firstName, string lastName, string password, bool isActive = true, bool isAdmin = false)
        {
            var result = new ServiceResult<User>();
            if (!Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var user = new User()
                    {
                        UserName = userName,
                        PasswordHash = CreateMd5(password),
                        FirstName = firstName,
                        LastName = lastName,
                        IsActive = isActive,
                        IsAdmin = isAdmin,
                        InsertDate = db.Users.Select(u => DateTime.Now).First()
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    result.Result = user;
                }
                catch(Exception ex)
                {
                    // ignored
                }
            }



            return result;
        }

        public static ServiceResult<IQueryable<User>> GetUsers()
        {
            var result = new ServiceResult<IQueryable<User>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.Users;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }

        public static ServiceResult<bool> IsFreeUserName(string userName)
        {
            var result = new ServiceResult<bool>();
            var db = new EKAEntities();

            try
            {
                if (userName.Length < 3)
                {
                    result.Result = false;
                }
                else if (!db.Users.Any(u => u.UserName == userName))
                {
                    result.Result = true;
                }
            }
            catch
            {
                result.Result = false;
            }
            return result;
        }

        public static ServiceResult EditUser(User user, string firstName, string lastName, string password, bool isActive, bool isAdmin)
        {
            var result = new ServiceResult();

            if (!Me.IsAdmin && user.UserID != Me.UserID)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var toEdit = db.Users.Find(user.UserID);
                    toEdit.FirstName = firstName;
                    toEdit.LastName = lastName;
                    if (Me.IsAdmin)
                    {
                        toEdit.IsActive = isActive;
                        toEdit.IsAdmin = isAdmin;
                    }
                    if (password.Trim() != "") toEdit.PasswordHash = CreateMd5(password);
                    db.SaveChanges();
                    result.Status = ResultStatus.Ok;
                }
                catch
                {
                    result.Status = ResultStatus.Unknown;
                }
            }
            return result;
        }

        public static ServiceResult RemoveUser(User user)
        {
            var result = new ServiceResult();
            if (!Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (user.Orders.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else if (user.WareHouses.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else if (user.UserID == Me.UserID)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.Users.Remove(db.Users.Find(user.UserID));
                    db.SaveChanges();
                    result.Status = ResultStatus.Ok;
                }
                catch
                {
                    result.Status = ResultStatus.Unknown;
                }
            }

            return result;
        }

        public static ServiceResult Login(string userName, string password)
        {
            var result = new ServiceResult();
            try
            {
                if (Me != null)
                {
                    result.Status = ResultStatus.Repeat;
                    return result;
                }
                var db = new EKAEntities();
                var passwordHash = CreateMd5(password);
                var user = db.Users.FirstOrDefault(u => u.UserName == userName && u.PasswordHash == passwordHash);

                if (user == null)
                {
                    result.Status = ResultStatus.NotFound;
                    return result;
                }
                if (!user.IsActive)
                {
                    result.Status = ResultStatus.AccessFail;
                    return result;
                }
                Me = user;
                user.LastLogin = db.Users.Select(u => DateTime.Now).First();
                db.SaveChanges();
                Me = user;
                result.Status = ResultStatus.Ok;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }
            return result;
        }

        public static ServiceResult Logout()
        {
            var result = new ServiceResult();
            if (Me == null)
            {
                result.Status = ResultStatus.NotFound;
                return result;
            }
            Me = null;
            result.Status = ResultStatus.Ok;
            return result;
        }

        private static string CreateMd5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (var t in hashBytes)
                {
                    sb.Append(t.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
