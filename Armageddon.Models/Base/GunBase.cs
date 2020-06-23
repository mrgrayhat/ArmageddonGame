using Armageddon.Models.Base.Interfaces;
using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Base
{
    /// <summary>
    /// all unit's(attacker's) who have a gun
    /// </summary>
    public abstract class GunBase : UnitBase, IGunBase
    {
        /// <summary>
        /// type of gun Like Pistol, Machine gun, ...
        /// </summary>
        public GunTypesEnum GunType { get; set; }
        /// <summary>
        /// type of gun damage. Like Splash damage to area
        /// </summary>
        public GunDamageTypesEnum GunDamageType { get; set; }
        /// <summary>
        /// gun dammage
        /// </summary>
        public double GunDammage { get; set; }
        /// <summary>
        /// The amount of gun ammunition
        /// </summary>
        public long GunAmmunition { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public GunBase() : base()
        {

        }
    }
}
