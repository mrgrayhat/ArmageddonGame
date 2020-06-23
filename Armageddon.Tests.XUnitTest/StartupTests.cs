using System;
using Armageddon.Models.Base;
using Armageddon.Models.Base.Types;
using Armageddon.Models.Extensions;
using Armageddon.Models.Game;
using Armageddon.Models.Units;
using Xunit;

namespace Armageddon.Tests.XUnitTest
{
    /// <summary>
    /// contain starter and Necessary Data
    /// </summary>
    public abstract class StartupTests
    {
        /// <summary>
        /// is initialized before?
        /// </summary>
        protected bool isInitialized = false;
        /// <summary>
        /// an instance of player model
        /// </summary>
        protected PlayerBase player;

        public StartupTests()
        {
            // ensure game and unit initialized as default
            InitializeGame();
        }

        /// <summary>
        /// Test Game Init
        /// </summary>
        [Fact]
        public void InitializeGame()
        {
            if (isInitialized) return;
            // player unit's list
            //List<UnitBase> unitsList = new List<UnitBase>();

            // new instance of player model with simple data
            player = new PlayerBase(nickName: "TestCase", soldiers: new Soldier());

            #region add some simple units

            // add some basic infantries
            player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry());
            player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry
            {
                // custom name
                Name = "Basic 2"
            });
            player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry
            {
                // custom armor & etc
                //DefenseArmor = 10,
                Name = "Basic 3"
            });
            // add some advanced infantries
            player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry());
            player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry
            {
                Name = "Advanced 2"
            });
            player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry
            {
                Name = "Advanced 3"
            });

            #endregion
            // send this type of unit's to a ref list
            //player.Soldiers.TryGetUnits(UnitTypesEnum.BasicInfantry, out unitsList);

            // get all soldier's information, such as health, damage, name, id and etc...
            Console.WriteLine(player.Soldiers.GetSoldiersInformation());

            Assert.True(player.Soldiers.Count == 6, $"player count does'nt match, count is{player.Soldiers.Count}");
            isInitialized = true;
        }
    }
}
