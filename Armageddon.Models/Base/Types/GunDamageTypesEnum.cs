using System;

namespace Armageddon.Models.Base.Types
{
    [Flags]
    public enum GunDamageTypesEnum
    {
        Single = 0,
        Splash = 1,
        AntiArmor = 2,
        ArtilaryCaliber = 3,
        
    }
}
