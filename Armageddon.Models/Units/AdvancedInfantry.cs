using Armageddon.Models.Base;
using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Units
{
    /// <summary>
    /// this class is for advanced soldier
    /// </summary>
    public class AdvancedInfantry : InfantryBase
    {

        public AdvancedInfantry() : base()
        {
            UnitType = UnitTypesEnum.AdvancedInfantry;
            Name = "Advanced Soldier";
            Health = 100;
            DefenseArmor = 5;
            AttackDamage = 20;
            AttackSpeed = 10;
            CriticalAttackChance = 2;
            GunDammage = 20;
            GunAmmunition = 400;
        }
    }
}
