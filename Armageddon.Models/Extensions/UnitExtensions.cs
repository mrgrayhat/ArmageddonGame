using System;
using System.Diagnostics;
using System.Linq;
using Armageddon.Models.Base;
using Armageddon.Models.Game;

namespace Armageddon.Models.Extensions
{
    public static class UnitExtensions
    {
        /// <summary>
        /// Attack The Refrenced Unit
        /// </summary>
        /// <param name="unitBase">unit ref</param>
        /// <param name="damageHit">damage amount</param>
        public static void TakeDamage(this UnitBase unitBase, double damageHit)
        {
            if (!unitBase.IsAlive)
            {
                Console.WriteLine("unit is dead, attack skiped!");
                return;
            }
            unitBase.DamageTaken = damageHit;
            unitBase.NotifyTakenDamage();
        }

        /// <summary>
        /// raise nonifiction when a unit died
        /// </summary>
        /// <param name="unitBase"></param>
        private static void NotifyUnitDeath(this UnitBase unitBase)
        {
            //#if Debug
            //            Debug.WriteLine($"unit [{unitBase.ID}/{unitBase.Name}] toke [{unitBase.DamageTaken}] damage and died!", Console.ForegroundColor = ConsoleColor.Red);
            //#endif
            Console.WriteLine($"unit [{unitBase.ID}/{unitBase.Name}] toke [{unitBase.DamageTaken}] damage and died!", Console.ForegroundColor = ConsoleColor.Red);

            //Soldier.AllUnits.Remove(unitBase);
            Soldier.RemoveUnit(unitBase.UnitType, unitBase);
            Console.ResetColor();
        }

        /// <summary>
        /// get a notification for everyone who gets hurt/die
        /// </summary>
        /// <param name="unitBase"></param>
        public static void NotifyTakenDamage(this UnitBase unitBase)
        {
            //#if Debug
            //            Debug.WriteLine($"unit {unitBase.ID}/{unitBase.Name} toke {unitBase.DamageTaken} damage. Current health: {unitBase.Health}", Console.ForegroundColor = ConsoleColor.Yellow);
            //#endif
            if (unitBase.IsAlive)
            {
                Console.WriteLine($"unit {unitBase.ID}/{unitBase.Name} toke {unitBase.DamageTaken} damage. Current health: {unitBase.Health}", Console.ForegroundColor = ConsoleColor.Yellow);
            }
            else
            {
                //NotifyUnitDeath(unitBase);
                unitBase.NotifyUnitDeath();
            }
            Console.ResetColor();
        }
    }
}
