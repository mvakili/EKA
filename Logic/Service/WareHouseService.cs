using System;
using System.Linq;
using Logic.Data;

namespace Logic.Service
{
    public static class WareHouseService
    {
        public static ServiceResult<WareHouse> CreateWareHouse(string name, bool allowSend, bool allowReceive, User manager, bool isCountable)
        {
            var result = new ServiceResult<WareHouse>();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var wareHouse = new WareHouse()
                    {
                        Name = name,
                        AllowSend =  allowSend,
                        AllowReceive = allowReceive,
                        UserID = manager.UserID,
                        IsCountable = isCountable,
                        
                    };
                    db.WareHouses.Add(wareHouse);
                    db.SaveChanges();
                    result.Result = wareHouse;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return result;
        }

        public static ServiceResult EditWareHouse(WareHouse wareHouse, string name, bool allowSend, bool allowReceive, User manager, bool isCountable)
        {
            var result = new ServiceResult();

            if (!UserService.Me.IsAdmin && wareHouse.User.UserID != UserService.Me.UserID)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var toEdit = db.WareHouses.Find(wareHouse.WareHouseID);
                    toEdit.Name = name;
                    toEdit.AllowSend = allowSend;
                    toEdit.AllowReceive = allowReceive;
                    toEdit.UserID = manager.UserID;
                    toEdit.IsCountable = isCountable;
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

        public static ServiceResult<IQueryable<WareHouse>> GetWareHouses()
        {
            var result = new ServiceResult<IQueryable<WareHouse>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.WareHouses;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }

        public static ServiceResult RemoveWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (wareHouse.Orders.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (wareHouse.MaterialExistances.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.WareHouses.Remove(db.WareHouses.Find(wareHouse.WareHouseID));
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
    }
}
