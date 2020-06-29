using System;

namespace Armageddon.Models.Base.Types
{

    [Flags]
    public enum GunTypesEnum
    {
        // hand guns
        Pistol = 0,
        // SemiAutomatic
        Rifle = 1,
        // pomp action
        ShotGun = 1,
        // rpg, rockets, missiles, bazooka
        Rocket = 2,
        Snipe = 3,
        // full automatic, rapid file
        MachineGun = 4,
        // 
        LargeShellCaliber = 5,

    }
}
