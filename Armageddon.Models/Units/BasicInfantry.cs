using Armageddon.Models.Base;

namespace Armageddon.Models.Units
{
    /// <summary>
    /// this class is for basic soldier unit
    /// </summary>
    public class BasicInfantry : InfantryBase
    {

        public BasicInfantry() : base()
        {
            UnitType = UnitTypesEnum.BasicInfantry;
            Name = "Basic Soldier";
            Health = 50;
            DefenseArmor = 2;
            AttackDamage = 10;
            AttackSpeed = 5;
            CriticalAttackChance = 1;
            GunType = GunTypesEnum.Pistol;
            GunDamageType = GunDamageTypesEnum.Single;
            GunDammage = 10;
            GunAmmunition = 200;
        }

    }
}
