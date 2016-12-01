using System;
using System.Linq;
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
        public static ServiceResult<Material> CreateMaterial(MaterialGroup materialGroup, decimal qty)
        {
            var result = new ServiceResult<Material>();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var material = new Material()
                    {
                        Qty = qty,
                        MaterialGroupID = materialGroup.MaterialGroupID,

                    };
                    db.Materials.Add(material);
                    db.SaveChanges();
                    result.Result = material;
                }
                catch
                {
                    // ignored
                }
            }



            return result;
        }
        public static ServiceResult EditMaterial(Material material, MaterialGroup materialGroup, decimal qty)
        {
            var result = new ServiceResult();

            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else if (material.Orders.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var toEdit = db.Materials.Find(material.MaterialID);
                    toEdit.Qty = qty;
                    toEdit.MaterialGroupID = materialGroup.MaterialGroupID;
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
        public static ServiceResult RemoveMaterial(Material material)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (material.Orders.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.Materials.Remove(db.Materials.Find(material.MaterialID));
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

        public static ServiceResult<IQueryable<MaterialGroup>> GetMaterialGroups()
        {
            var result = new ServiceResult<IQueryable<MaterialGroup>>();
            try
            {

                var db = new EKAEntities();
                result.Result = db.MaterialGroups;
            }
            catch
            {
                result.Status = ResultStatus.Unknown;
            }

            return result;
        }
        public static ServiceResult<MaterialGroup> CreateMaterialGroup(string name, Unit unit)
        {
            var result = new ServiceResult<MaterialGroup>();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var materialGroup = new MaterialGroup()
                    {
                        Name = name,
                        UnitID = unit.UnitID,
 
                    };
                    db.MaterialGroups.Add(materialGroup);
                    db.SaveChanges();
                    result.Result = materialGroup;
                }
                catch
                {
                    // ignored
                }
            }



            return result;
        }
        public static ServiceResult RemoveMaterialGroup(MaterialGroup materilaGroup)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (materilaGroup.Materials.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    db.MaterialGroups.Remove(db.MaterialGroups.Find(materilaGroup.MaterialGroupID));
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
        public static ServiceResult EditMaterialGroup(MaterialGroup materilaGroup, string name, Unit unit)
        {
            var result = new ServiceResult();

            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            } else if (materilaGroup.Materials.Any())
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            {
                try
                {
                    var db = new EKAEntities();
                    var toEdit = db.MaterialGroups.Find(materilaGroup.MaterialGroupID);
                    toEdit.Name = name;
                    toEdit.UnitID = unit.UnitID;
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
        public static ServiceResult RemoveUnitGroup(UnitGroup unitGroup)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (unitGroup.Units.Any())
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
        public static ServiceResult RemoveUnit(Unit unit)
        {
            var result = new ServiceResult();
            if (!UserService.Me.IsAdmin)
            {
                result.Status = ResultStatus.AccessFail;
            }
            else
            if (unit.MaterialGroups.Any())
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
            else if (unit.MaterialGroups.Any())
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
