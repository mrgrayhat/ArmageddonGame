using Armageddon.Models.Base.Interfaces;

namespace Armageddon.Models.Base
{
    public abstract class GunBase : UnitBase, IGunBase
    {
        public GunTypesEnum GunType { get; set; }
        public GunDamageTypesEnum GunDamageType { get; set; }
        public double GunDammage { get; set; }
        public long GunAmmunition { get; set; }

        public GunBase()
        {

        }
    }
}
