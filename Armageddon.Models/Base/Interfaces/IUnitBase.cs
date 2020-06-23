using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Base.Interfaces
{
    /// <summary>
    /// Interface For UnitBase Class
    /// </summary>
    public interface IUnitBase
    {

        long ID { get; set; }
        string Name { get; set; }
        UnitTypesEnum UnitType { get; set; }
        double Health { get; set; }
        double AttackDamage { get; set; }
        double DamageTaken { get; set; }
        double AttackSpeed { get; set; }
        double CriticalAttackChance { get; set; }
        double DefenseArmor { get; set; }
        double Cost { get; set; }
        bool IsEnabled { get; set; }
        bool IsAlive { get; }

    }
}
