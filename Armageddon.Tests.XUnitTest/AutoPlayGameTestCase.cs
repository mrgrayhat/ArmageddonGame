using System.Diagnostics;
using Armageddon.Models.Base.Types;
using Armageddon.Models.Extensions;
using Xunit;

namespace Armageddon.Tests.XUnitTest
{
    public class AutoPlayGameTestCase : StartupTests
    {

        public AutoPlayGameTestCase() : base()
        {

        }

        /// <summary>
        /// simply attack a unit
        /// </summary>
        [Fact]
        public void HitUnit()
        {
            // simply attack to a unit (to test armor and health)
            // And we get a notification for everyone who gets hurt
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).TakeDamage(10);
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).TakeDamage(20);
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(60);

            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).TakeDamage(10);
            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).TakeDamage(20);
            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(60);

            // get soldier's info again, to recheck after test actions(attack..)
            Debug.WriteLine(player.Soldiers.GetSoldiersInformation());
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).Health == (40.2));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).Health == (30.4));
            // unit died, because got strong damage
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).Health == (0));

            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).Health == (90.5));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).Health == (81));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).Health == (43));

        }

        [Fact]
        public void HitUnit2()
        {
            // simply attack to a unit (to test armor and health)
            // And we get a notification for everyone who gets hurt
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).TakeDamage(10);
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).TakeDamage(20);

            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
            player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(25);

            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).TakeDamage(10);
            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).TakeDamage(20);
            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(60);
            player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(100);

            // get soldier's info again, to recheck after test actions(attack..)
            Debug.WriteLine(player.Soldiers.GetSoldiersInformation());
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).Health == (40.2));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).Health == (30.4));
            // unit died, because got strong damage. check health & alive state
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).Health == (0));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).IsAlive == false);

            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).Health == (90.5));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).Health == (81));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).Health == (43));
            Assert.True(player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).IsAlive == false);

        }
    }
}
