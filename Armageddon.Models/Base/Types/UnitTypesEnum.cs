using System;

namespace Armageddon.Models.Base.Types
{
    [Flags]
    public enum UnitTypesEnum
    {
        Worker = 0,
        BasicInfantry = 1,
        AdvancedInfantry = 2,
        BasicTank = 3,
        AdvancedTank = 4,
        BasicAirplane = 5,
        AdvancedAirplane = 6,

    }
}
