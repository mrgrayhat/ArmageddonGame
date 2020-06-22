using System;
using Armageddon.Models.Base;

namespace Armageddon.Models.Extensions
{
    public static class UnitExtensions
    {
        public static void TakeDamage(this UnitBase unitBase, double damageHit)
        {
            unitBase.DamageTaken = damageHit;
            unitBase.NotifyTakenDamage();
        }
        public static void NotifyTakenDamage(this UnitBase unitBase)
        {
            Console.WriteLine($"unit {unitBase.Name} toke {unitBase.DamageTaken} damage. Current health: {unitBase.Health}", Console.ForegroundColor = ConsoleColor.Red);
        }
    }
}
