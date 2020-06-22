using System.Collections.Generic;
using Armageddon.Models.Base;

namespace Armageddon.Models.Game
{
    public class Soldier
    {
        public Dictionary<UnitTypesEnum, List<UnitBase>> UnitsDictionary = new Dictionary<UnitTypesEnum, List<UnitBase>>();

        public Soldier() : base()
        {
            //AttackDamage = AttackDamage + GunDammage;

        }

    }
}
