using Armageddon.Models.Base;
using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Units
{
    /// <summary>
    /// this class is for basic soldier unit
    /// </summary>
    public class BasicTank : TankBase
    {

        public BasicTank() : base()
        {
            UnitType = UnitTypesEnum.BasicTank;
            Name = "Basic Tank";
            Health = 200;
            DefenseArmor = 20;
            AttackDamage = 20;
            AttackSpeed = 5;
            CriticalAttackChance = 1;
            GunType = GunTypesEnum.LargeShellCaliber;
            GunDamageType = GunDamageTypesEnum.AntiArmor;
            GunDammage = 50;
            GunAmmunition = 200;
        }

    }
}
