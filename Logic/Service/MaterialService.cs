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
        public static ServiceResult<IQueryable<Material>> GetMaterials()
        {
            var result = new ServiceResult<IQueryable<Material>>();
            try
            {
                
                var db = new EKAEntities();
                result.Result = db.Materials;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }

        public static ServiceResult<IQueryable<UnitGroup>> GetUnitGroups()
        {
            var result = new ServiceResult<IQueryable<UnitGroup>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.UnitGroups;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }

        public static ServiceResult<IQueryable<Unit>> GetUnits()
        {
            var result = new ServiceResult<IQueryable<Unit>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.Units;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }
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

        public static ServiceResult RemoveUnitGroup(UnitGroup unitGroup)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (unitGroup.Units.Count > 0)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.UnitGroups.Remove(db.UnitGroups.Find(unitGroup.UnitGroupID));
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

        public static ServiceResult EditUnitGroup(UnitGroup unitGroup, string name)
        {
            var result = new ServiceResult();

            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.UnitGroups.Find(unitGroup.UnitGroupID).Name = name;
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

        public static ServiceResult RemoveUnit(Unit unit)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (unit.MaterialGroups.Count > 0)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.Units.Remove(db.Units.Find(unit.UnitID));
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

        public static ServiceResult EditUnit(Unit unit, string name, UnitGroup unitGroup, double factor)
        {
            var result = new ServiceResult();

            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var toEdit = db.Units.Find(unit.UnitID);
                    toEdit.Name = name;
                    toEdit.UnitGroupID = unitGroup.UnitGroupID;
                    toEdit.Factor = factor;
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

        public static ServiceResult<Unit> CreateUnit(string name, UnitGroup unitGroup, double factor)
        {
            var result = new ServiceResult<Unit>();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var unit = new Unit
                    {
                        Name = name,
                        UnitGroupID = unitGroup.UnitGroupID,
                        Factor = factor
                    };
                    db.Units.Add(unit);
                    db.SaveChanges();
                    result.Result = unit;
                }
                catch
                {
                    // ignored
                }
            }



            return result;
        }

        public static ServiceResult<UnitGroup> CreateUnitGroup(string name)
        {

            var result = new ServiceResult<UnitGroup>();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var unitGroup = new UnitGroup
                    {
                        Name = name
                    };
                    db.UnitGroups.Add(unitGroup);
                    db.SaveChanges();
                    result.Result = unitGroup;
                }
                catch
                {
                    // ignored
                }
            }
            
            
            
            return result;
        }

        public static ServiceResult<Order> CreateNewOrder(Material material, WareHouse warehouse)
        {
            var result = new ServiceResult<Order>();
            var db = new EKAEntities();
            var spResult = db.CreateNewOrder(UserService.Me.UserID, material.MaterialID, warehouse.WareHouseID).Single().Value;
            if (spResult > 0)
                result.Result = db.Orders.Find(spResult);
            return result;
        }
    }
}
