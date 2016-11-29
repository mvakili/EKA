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

        public static ServiceResult<Material> CreateMaterial(MaterialGroup materialGroup, decimal qty)
        {
            var result = new ServiceResult<Material>();
            var db = new EKAEntities();
            var spResult = db.CreateMaterial(UserService.Me.UserID, materialGroup.MaterialGroupID, qty).Single().Value;
            if (spResult > 0)
                result.Result = db.Materials.Find(result);
            return result;
        }


        public static ServiceResult<MaterialGroup> CreateMaterialGroup(string name, Unit unit)
        {
            var result = new ServiceResult<MaterialGroup>();
            var db = new EKAEntities();
            var spResult = db.CreateMaterialGroup(UserService.Me.UserID, name, unit.UnitID).Single().Value;
            if (spResult > 0)
                result.Result = db.MaterialGroups.Find(result);
            return result;
        }

        public static ServiceResult<Unit> CreateUnit(string name, UnitGroup unitGroup, float factor)
        {
            var result = new ServiceResult<Unit>();
            var db = new EKAEntities();
            var spResult = db.CreateUnit(UserService.Me.UserID, name, unitGroup.UnitGroupID, factor).Single().Value;
            if (spResult > 0)
                result.Result = db.Units.Find(spResult);
            return result;
        }

        public static ServiceResult<UnitGroup> CreateUnitGroup(string name)
        {
            var result = new ServiceResult<UnitGroup>();
            var db = new EKAEntities();
            var spResult = db.CreateUnitGroup(UserService.Me.UserID, name).Single().Value;
            if (spResult > 0)
                result.Result = db.UnitGroups.Find(result);
            return result;
        }

        public static ServiceResult<Order> CreateNewOrder(Material material, WareHouse warehouse)
        {
            var result = new ServiceResult<Order>();
            var db = new EKAEntities();
            var spResult = db.CreateNewOrder(UserService.Me.UserID, material.MaterialID, warehouse.WareHouseID).Single().Value;
            if (spResult > 0)
                result.Result = db.Orders.Find(result);
            return result;
        }
    }
}
