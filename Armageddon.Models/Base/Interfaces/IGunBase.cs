namespace Armageddon.Models.Base.Interfaces
{
    public interface IGunBase
    {
        GunTypesEnum GunType { get; set; }
        GunDamageTypesEnum GunDamageType { get; set; }
        double GunDammage { get; set; }
        long GunAmmunition { get; set; }

    }
}
