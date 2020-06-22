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
            return soldiers.Count;
        }

        public static string GetSoldiersInformation(this Soldier soldiers)
        {
            //List<UnitBase> infantriesList;
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

                //soldiers.TryGetUnits(UnitTypesEnum.BasicInfantry, out infantriesList);

                //foreach (var unit in infantriesList)
                //{
                //    stringBuilder.AppendLine($"Id: {unit.ID}, name: {unit.Name}, type: {unit.UnitType}, health: {unit.Health}, attack damage: {unit.AttackDamage}, DefenseArmor: {unit.DefenseArmor}, Damage Taken: {unit.DamageTaken}, attack speed: {unit.AttackSpeed}, Cost: {unit.Cost}");
                //}
                //stringBuilder.AppendLine(
                //    $"-Total Basic soldiers, {infantriesList[0].UnitType} : {infantriesList.Count}");

                //soldiers.TryGetUnits(UnitTypesEnum.AdvancedInfantry, out infantriesList);
                //foreach (var unit in infantriesList)
                //{
                //    stringBuilder.AppendLine($"Id: {unit.ID}, name: {unit.Name}, type: {unit.UnitType}, health: {unit.Health}, attack damage{unit.AttackDamage}, DefenseArmor: {unit.DefenseArmor}, Damage Taken: {unit.DamageTaken}, attack speed: {unit.AttackSpeed}, Cost: {unit.Cost}");
                //}
                //stringBuilder.AppendLine(
                //    $"-Total Advanced soldiers, {infantriesList[0].UnitType} : {infantriesList.Count}");
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
