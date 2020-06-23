using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Armageddon.Models.Base;
using Armageddon.Models.Extensions;
using Armageddon.Models.Game;
using Armageddon.Models.Base.Types;
using Armageddon.Models.Units;

namespace Armageddon.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintGameMenu();

            Console.ReadKey(true);

        }

        static void PrintGameMenu()
        {
            Console.WriteLine("Hi, Welcome To Armageddon Game!", Console.ForegroundColor = ConsoleColor.Green);
        TeamMenu:
            #region Menu
            Console.WriteLine("---------------------------");
            Console.WriteLine("Please Choose You'r Team:", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("1) Team1 -> Blue", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("2) Team2 - > Red", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("---------------------------");
            Console.ResetColor();
            try
            {
                byte userTeam = Convert.ToByte(Console.ReadLine());
                if (userTeam > 0 && userTeam < 3)
                {
                    InitializeTest(userTeam);
                }
                else
                {
                    Console.WriteLine("oh, something went wrong!");
                    goto TeamMenu;
                }
            }
            catch (Exception gameBannerEx)
            {
                Console.WriteLine("oh, something went wrong! " + gameBannerEx.Message);
                goto TeamMenu;
            }
            finally
            {
            }
            #endregion
        }

        internal static Task Initialize(byte team)
        {

            return Task.CompletedTask;
        }
        /// <summary>
        /// simple and test starter for game
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        static Task InitializeTest(byte team)
        {
            try
            {
                Console.WriteLine($"You'r Team is {(team == 1 ? "Blue" : "Red")}", Console.ForegroundColor = (team == 1 ? ConsoleColor.Blue : ConsoleColor.Red));
                Console.ResetColor();

                // player unit's list
                List<UnitBase> unitsList = new List<UnitBase>();
                PlayerBase player = new PlayerBase(nickName: "saeed", soldiers: new Soldier());

                // add some simple units
                // add some basic infantries
                player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry());
                player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry());
                player.Soldiers.AddUnit(UnitTypesEnum.BasicInfantry, new BasicInfantry());
                // add some advanced infantries
                player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry());
                player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry());
                player.Soldiers.AddUnit(UnitTypesEnum.AdvancedInfantry, new AdvancedInfantry());

                // send this type of unit's to a ref list
                player.Soldiers.TryGetUnits(UnitTypesEnum.BasicInfantry, out unitsList);

                // get all soldier's information, such as health, damage, name, id and etc...
                Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);
                Console.ResetColor();
                Console.WriteLine(player.Soldiers.GetSoldiersInformation());

                // simulate attacking to units' (to test armor and health calculations and reports)
                // And we get a notification for everyone who gets hurt
                player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).TakeDamage(10);
                player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).TakeDamage(20);

                player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
                player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
                player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(25);

                player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).TakeDamage(10);
                player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).TakeDamage(20);
                player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(50);
                player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(100);

                // refresh information
                Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);
                Console.ResetColor();
                Console.WriteLine(player.Soldiers.GetSoldiersInformation());

                // repeat attack simulation

                //player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 0).TakeDamage(30);
                //player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 1).TakeDamage(40);

                //player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
                //player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(20);
                //player.Soldiers.GetUnit(UnitTypesEnum.BasicInfantry, 2).TakeDamage(25);

                //player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 0).TakeDamage(10);
                //player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 1).TakeDamage(20);
                //player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(50);
                //player.Soldiers.GetUnit(UnitTypesEnum.AdvancedInfantry, 2).TakeDamage(100);

                // refresh information
                Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);
                Console.ResetColor();



                Console.WriteLine("--------------------");
                // get soldier's info again, to recheck after test actions(attack..)
                Console.WriteLine(player.Soldiers.GetSoldiersInformation());

            }
            catch (Exception initEx)
            {
                Console.WriteLine("Game Initialize, " + initEx.Message);
            }

            return Task.CompletedTask;
        }
        static void CreateGameBoard()
        {

        }
    }
}
