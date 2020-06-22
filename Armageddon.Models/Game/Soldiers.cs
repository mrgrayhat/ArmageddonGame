using System.Collections.Generic;
using Armageddon.Models.Base;

namespace Armageddon.Models.Game
{
    public class Soldier
    {
        Dictionary<UnitTypesEnum, List<UnitBase>> UnitsDictionary = new Dictionary<UnitTypesEnum, List<UnitBase>>();
        List<UnitBase> AllUnits { get; set; } = new List<UnitBase>();

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
            if (UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> units))
                return units.Count;
            return 0;
        }
        

        public UnitBase GetUnit(UnitTypesEnum unitTypesEnum, int index)
        {
            if (UnitsDictionary.TryGetValue(unitTypesEnum, out List<UnitBase> units))
                return units[index];
            return null;
        }
    }
}
