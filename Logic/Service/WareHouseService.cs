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


        public static ServiceResult<Order> CreateNewOrder(Material material, WareHouse toWarehouse)
        {
            var fromWareHouse =
                material?.Orders.OrderByDescending(u => u.DateTime).ThenBy(u => u.OrderID).Select(u => u.WareHouse).FirstOrDefault();
            var result = new ServiceResult<Order>();

            if (material == null || toWarehouse == null)
            {
                result.Status = ResultStatus.InvalidParameter;
            }
            else if (fromWareHouse != null && (!UserService.Me.IsAdmin && fromWareHouse.User.UserID != UserService.Me.UserID))
            {
                result.Status = ResultStatus.AccessFail;
            }
            else if (fromWareHouse != null && !fromWareHouse.AllowSend)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else if (!toWarehouse.AllowReceive)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {

                    var db = new EKAEntities();
                    var userId = UserService.Me.UserID;
                    var now = DateTime.Now;
                    var order = new Order
                    {
                        ToWareHouseID = toWarehouse.WareHouseID,
                        MaterialID = material.MaterialID,
                        UserID = userId,
                        DateTime = now
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();
                    result.Result = order;
                }
                catch (Exception ex)
                {
                    // ignored
                }
            }



            return result;
        }

        public static ServiceResult<IQueryable<Order>> GetOrders()
        {
            var result = new ServiceResult<IQueryable<Order>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.Orders;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }

        public static ServiceResult<IQueryable<MaterialExistance>> GetMaterialExistances()
        {
            var result = new ServiceResult<IQueryable<MaterialExistance>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.MaterialExistances.Where(u => u.Qty != 0);
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }
    }
}
