using System;
using System.Text;
using Armageddon.Models.Game;
using Armageddon.Models.Base;
using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Extensions
{

    public static class SoldierExtensions
    {
        public static void RemoveUnit(this Soldier soldier)
        {
            //soldier.AllUnits.Remove();
        }
        public static long GetUnitsPopulation(this Soldier soldiers)
        {
            return soldiers.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="soldiers"></param>
        /// <returns></returns>
        public static string GetSoldiersInformation(this Soldier soldiers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                foreach (var unit in soldiers.GetAll())
                {
                    stringBuilder.AppendLine($"Id: {unit.ID}, name: {unit.Name}, type: {unit.UnitType}, health: {unit.Health}, attack damage: {unit.AttackDamage}, DefenseArmor: {unit.DefenseArmor}, Damage Taken: {unit.DamageTaken}, attack speed: {unit.AttackSpeed}, Cost: {unit.Cost}");
                }

                foreach (UnitTypesEnum unitTypesEnum in Enum.GetValues(typeof(UnitTypesEnum)))
                {
                    stringBuilder.AppendLine(
                   $"-Total Basic soldiers, {unitTypesEnum} : {soldiers.GetUnitsCount(unitTypesEnum)}");
                }
                stringBuilder.AppendLine($"-Total Units: {soldiers.GetUnitsPopulation()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetSoldiersInformation, " + ex);
            }
            return stringBuilder.ToString();
        }
    }
}
