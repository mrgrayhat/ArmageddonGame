using System;
using System.Collections.Generic;
using Armageddon.Models.Base;
using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Game
{
    public class Soldier
    {
        static Dictionary<UnitTypesEnum, List<UnitBase>> UnitsDictionary = new Dictionary<UnitTypesEnum, List<UnitBase>>();
        public static List<UnitBase> AllUnits { get; set; } = new List<UnitBase>();

        public Soldier() : base()
        {
            //AttackDamage = AttackDamage + GunDammage;

        }
        public List<UnitBase> GetAll()
        {
            return AllUnits;
        }

        public int Count
        {
            get
            {
                return AllUnits.Count;
            }
        }

        public static void RemoveUnit(UnitTypesEnum unitTypesEnum, UnitBase unit)
        {
            if (UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> items))
            {
                items.Remove(unit);
            }
            AllUnits.Remove(unit);
        }

        public void AddUnit(UnitTypesEnum unitTypesEnum, UnitBase unit)
        {
            if (UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> items))
            {
                items.Add(unit);
            }
            else
            {
                items = new List<UnitBase>();
                UnitsDictionary[unitTypesEnum] = items;
                items.Add(unit);
            }
            AllUnits.Add(unit);
        }

        public void TryGetUnits(UnitTypesEnum unitTypesEnum, out List<UnitBase> units)
        {
            UnitsDictionary.TryGetValue(unitTypesEnum, out units);
        }

        public int GetUnitsCount(UnitTypesEnum unitTypesEnum)
        {
            // try get unit's count or return 0
            return UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> units) ? units.Count : 0;
        }

        public UnitBase GetUnit(UnitTypesEnum unitTypesEnum, int index)
        {
            try
            {
                if (UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> units))
                    return units[index];
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
