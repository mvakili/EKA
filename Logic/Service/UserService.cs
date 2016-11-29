using System.Linq;
using System.Text;
using Logic.Data;

namespace Logic.Service
{
    public static class UserService
    {
        public static User Me;
        public static bool IsLoggedIn => Me != null;

        public static ServiceResult<User> CreateUser(string userName, string password, string firstName, string lastName, bool isActive = true)
        {
            var result = new ServiceResult<User>();
            var db = new EKAEntities();
            var spResult = db.CreateUser(Me.UserID, userName, password, firstName, lastName, isActive).Single().Value;
            if (spResult > 0)
                result.Result = db.Users.Find(result);
            return result;
        }

        public static ServiceResult ActivateUser(User user)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.ActivateUser(Me.UserID, user.UserID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult DeactivateUser(User user)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.DeactivateUser(Me.UserID, user.UserID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult ChangePasswordOfUser(User user, string oldPassword, string newPassword)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.ChangePasswordOfUser(Me.UserID, user.UserID, oldPassword, newPassword).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult ChangeDetailsOfUser(User user, string firstName, string lastName)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.ChangeDetailsOfUser(Me.UserID, user.UserID, firstName, lastName).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult AddToAdminsUsers(User user)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.AddToAdminUsers(Me.UserID, user.UserID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult RemoveFromAdminUsers(User user)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.RemoveFromAdminUsers(Me.UserID, user.UserID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default:
                    result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }

        public static ServiceResult Login(string userName, string password)
        {
            var result = new ServiceResult();
            if (Me != null)
            {
                result.Status = ResultStatus.Repeat;
                return result;
            }
            var db = new EKAEntities();
            var passwordHash = CreateMD5(password);
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
            result.Status = ResultStatus.Ok;
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
