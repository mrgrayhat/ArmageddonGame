using Armageddon.Models.Base.Types;

namespace Armageddon.Models.Base.Interfaces
{
    /// <summary>
    /// interface of GunBase Class
    /// </summary>
    public interface IGunBase
    {
        GunTypesEnum GunType { get; set; }
        GunDamageTypesEnum GunDamageType { get; set; }
        double GunDammage { get; set; }
        long GunAmmunition { get; set; }

    }
}
