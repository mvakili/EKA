using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Data;

namespace Logic.Service
{
    public static class MaterialService
    {

        public static Material CreateMaterial(MaterialGroup materialGroup, decimal qty)
        {
            var db = new EKAEntities();
            var result = db.CreateMaterial(UserService.Me.UserID, materialGroup.MaterialGroupID, qty).Single().Value;
            if (result > 0)
                return db.Materials.Find(result);
            return null;
        }


        public static MaterialGroup CreateMaterialGroup(string name, Unit unit)
        {
            var db = new EKAEntities();
            var result = db.CreateMaterialGroup(UserService.Me.UserID, name, unit.UnitID).Single().Value;
            if (result > 0)
                return db.MaterialGroups.Find(result);
            return null;
        }

        public static Unit CreateUnit(string name, UnitGroup unitGroup, float factor)
        {
            var db = new EKAEntities();
            var result = db.CreateUnit(UserService.Me.UserID, name, unitGroup.UnitGroupID, factor).Single().Value;
            if (result > 0)
                return db.Units.Find(result);
            return null;
        }

        public static UnitGroup CreateUnitGroup(string name)
        {
            var db = new EKAEntities();
            var result = db.CreateUnitGroup(UserService.Me.UserID, name).Single().Value;
            if (result > 0)
                return db.UnitGroups.Find(result);
            return null;
        }

        public static Order CreateNewOrder(Material material, WareHouse warehouse)
        {
            var db = new EKAEntities();
            var result = db.CreateNewOrder(UserService.Me.UserID, material.MaterialID, warehouse.WareHouseID).Single().Value;
            if (result > 0)
                return db.Orders.Find(result);
            return null;
        }
    }
}
