using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Armageddon.Models.Base;
using Armageddon.Models.Base.Interfaces;
using Armageddon.Models.Extensions;
using Armageddon.Models.Game;
using Armageddon.Models.Units;

namespace Armageddon.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintGameBanner();

            Console.ReadKey(true);

        }

        static void PrintGameBanner()
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

        static Task InitializeTest(byte team)
        {
            try
            {

                #region old method
                //PlayerBase playerBase = new PlayerBase("saeed",
                //    new Soldiers
                //    {
                //        BasicInfantries = new List<BasicInfantry>
                //        {
                //            new BasicInfantry
                //            {
                //                Name = "basic soldier 1",
                //                Cost = 500
                //            },
                //            new BasicInfantry
                //            {
                //                Name = "basic soldier 2",
                //                Cost = 500
                //            },
                //            new BasicInfantry
                //            {
                //                Name = "basic soldier 3",
                //                Cost = 500
                //            }
                //        },
                //        AdvancedInfantries = new List<AdvancedInfantry>
                //        {
                //            new AdvancedInfantry
                //            {
                //                Name = "adv soldier 1",
                //                Cost = 1000
                //            },
                //            new AdvancedInfantry
                //            {
                //                Name = "adv soldier 2",
                //                Cost = 1000
                //            },
                //            new AdvancedInfantry
                //            {
                //                Name = "adv soldier 3",
                //                Cost = 1000
                //            }
                //        }
                //    });

                //Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);
                //// get soldiers information using an extension method
                //Console.WriteLine("Tactical Info:\n" + playerBase.Soldiers.GetSoldiersInformation(), Console.ForegroundColor = ConsoleColor.Yellow);
                //// do a simple damage
                //playerBase.Soldiers.BasicInfantries[0].TakeDamage(15);
                //playerBase.Soldiers.BasicInfantries[1].TakeDamage(50);

                //playerBase.Soldiers.AdvancedInfantries[0].TakeDamage(5);
                //playerBase.Soldiers.AdvancedInfantries[1].TakeDamage(60);
                //playerBase.Soldiers.AdvancedInfantries[2].TakeDamage(100);
                //// set a short delay and get updates
                //Task.Delay(2000).GetAwaiter().GetResult();
                //Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);
                //Console.WriteLine("Tactical Info:\n" + playerBase.Soldiers.GetSoldiersInformation(), Console.ForegroundColor = ConsoleColor.Yellow);
                #endregion

                Console.WriteLine($"You'r Team is {(team == 1 ? "Blue" : "Red")}", Console.ForegroundColor = (team == 1 ? ConsoleColor.Blue : ConsoleColor.Red));
                Console.ResetColor();

                List<UnitBase> unitsList = new List<UnitBase>();
                PlayerBase player = new PlayerBase(nickName: "saeed", soldiers: new Soldier());

                player.Soldiers.UnitsDictionary.Add(UnitTypesEnum.BasicInfantry, new List<UnitBase>
                {
                    new BasicInfantry(),
                    new BasicInfantry(),
                    new BasicInfantry()
                });
                player.Soldiers.UnitsDictionary.Add(UnitTypesEnum.AdvancedInfantry, new List<UnitBase>
                {
                    new AdvancedInfantry(),
                    new AdvancedInfantry(),
                });

                player.Soldiers.UnitsDictionary.TryGetValue(UnitTypesEnum.BasicInfantry, out unitsList);
                Console.WriteLine(player.Soldiers.GetSoldiersInformation());

                Console.WriteLine($"[{DateTime.Now}]", Console.ForegroundColor = ConsoleColor.Magenta);

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
