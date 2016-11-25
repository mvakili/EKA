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
        public static WareHouse CreateWareHouse(string name, bool allowReceive = true, bool allowSend = true)
        {
            var db = new EKAEntities();
            var result = db.CreateWareHouse(UserService.Me.UserID, name, allowReceive, allowSend).Single().Value;
            if (result > 0)
                return db.WareHouses.Find(result);
            return null;
        }
        public static int SetManagerToWareHouse(WareHouse wareHouse, User user)
        {
            var db = new EKAEntities();
            var result = db.SetManagerToWareHouse(UserService.Me.UserID, wareHouse.WareHouseID, user.UserID).Single().Value;
            return result;
        }
        public static int RemoveManagerOfWareHouse(WareHouse wareHouse)
        {
            var db = new EKAEntities();
            var result = db.RemoveManagerOfWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            return result;
        }
        public static int DisableAllowSendWareHouse(WareHouse wareHouse)
        {
            var db = new EKAEntities();
            var result = db.DisableAllowSendWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            return result;
        }
        public static int EnableAllowSendWareHouse(WareHouse wareHouse)
        {
            var db = new EKAEntities();
            var result = db.EnableAllowSendWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            return result;
        }
        public static int DisableAllowReceiveWareHouse(WareHouse wareHouse)
        {
            var db = new EKAEntities();
            var result = db.DisableAllowReceiveWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            return result;
        }
        public static int EnableAllowReceiveWareHouse(WareHouse wareHouse)
        {
            var db = new EKAEntities();
            var result = db.EnableAllowReceiveWareHouse(UserService.Me.UserID, wareHouse.WareHouseID).Single().Value;
            return result;
        }
    }
}
