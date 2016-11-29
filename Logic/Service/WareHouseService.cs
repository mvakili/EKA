using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Data;

namespace Logic.Service
{
    public static class WareHouseService
    {
        public static ServiceResult<WareHouse> CreateWareHouse(string name, bool allowReceive = true, bool allowSend = true)
        {
            var result = new ServiceResult<WareHouse>();
            var db = new EKAEntities();
            var spResult = db.CreateWareHouse(UserService.Me.UserID, name, allowReceive, allowSend).Single().Value;
            if (spResult > 0)
                result.Result = db.WareHouses.Find(spResult);
            return result;
        }
        public static ServiceResult SetManagerToWareHouse(WareHouse wareHouse, User user)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.SetManagerToWareHouse(UserService.Me.UserID, wareHouse.WareHouseID, user.UserID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
        public static ServiceResult RemoveManagerOfWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.RemoveManagerOfWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
        public static ServiceResult DisableAllowSendWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.DisableAllowSendWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
        public static ServiceResult EnableAllowSendWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.EnableAllowSendWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
        public static ServiceResult DisableAllowReceiveWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.DisableAllowReceiveWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
        public static ServiceResult EnableAllowReceiveWareHouse(WareHouse wareHouse)
        {
            var result = new ServiceResult();
            var db = new EKAEntities();
            var spResult = db.EnableAllowReceiveWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            switch (spResult)
            {
                case -1: result.Status = ResultStatus.AccessFail; break;
                case 0: result.Status = ResultStatus.Ok; break;
                default: result.Status = ResultStatus.Unknown; break;
            }
            return result;
        }
    }
}
