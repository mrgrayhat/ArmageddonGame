using System;
using System.Text;
using Armageddon.Models.Game;
using Armageddon.Models.Base;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace Armageddon.Models.Extensions
{

    public static class SoldierExtensions
    {

        public static long GetUnitsPopulation(this Soldier soldiers)
        {
            long count = 0;
            try
            {
                foreach (var item in soldiers.UnitsDictionary.Values)
                {
                    count += item.Count;
                }
            }
            catch (Exception getUnitsPopulationEx)
            {
                Console.WriteLine("GetUnitsPopulation error, " + getUnitsPopulationEx);
            }
            return count;
        }

        public static string GetSoldiersInformation(this Soldier soldiers)
        {
            List<UnitBase> infantriesList = new List<UnitBase>();
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                _ = soldiers.UnitsDictionary.TryGetValue(UnitTypesEnum.BasicInfantry, out infantriesList);

                foreach (var unit in infantriesList)
                {
                    stringBuilder.AppendLine($"Id: {unit.ID}, name: {unit.Name}, type: {unit.UnitType}, health: {unit.Health}, attack damage: {unit.AttackDamage}, DefenseArmor: {unit.DefenseArmor}, Damage Taken: {unit.DamageTaken}, attack speed: {unit.AttackSpeed}, Cost: {unit.Cost}");
                }
                stringBuilder.AppendLine(
                    $"-Total Basic soldiers, {infantriesList[0].UnitType} : {infantriesList.Count}");
                infantriesList.Clear();
                _ = soldiers.UnitsDictionary.TryGetValue(UnitTypesEnum.AdvancedInfantry, out infantriesList);
                foreach (var unit in infantriesList)
                {
                    stringBuilder.AppendLine($"Id: {unit.ID}, name: {unit.Name}, type: {unit.UnitType}, health: {unit.Health}, attack damage{unit.AttackDamage}, DefenseArmor: {unit.DefenseArmor}, Damage Taken: {unit.DamageTaken}, attack speed: {unit.AttackSpeed}, Cost: {unit.Cost}");
                }
                stringBuilder.AppendLine(
                    $"-Total Advanced soldiers, {infantriesList[0].UnitType} : {infantriesList.Count}");
                stringBuilder.AppendLine($"-Total Units: {soldiers.GetUnitsPopulation()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex);
            }
            return stringBuilder.ToString();
        }
    }
}
