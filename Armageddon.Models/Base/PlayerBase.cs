using Armageddon.Models.Base.Interfaces;
using Armageddon.Models.Game;

namespace Armageddon.Models.Base
{
    /// <summary>
    /// Player Base Class
    /// </summary>
    public class PlayerBase : IPlayerBase
    {
        #region Properties
        /// <summary>
        /// short name
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// game's score
        /// </summary>
        public long Score { get; set; }
        /// <summary>
        /// player cash
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// is defeated
        /// </summary>
        public bool HasLost { get; set; }
        /// <summary>
        /// instance of player soldier's
        /// </summary>
        public Soldier Soldiers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nickName">short /nick name</param>
        /// <param name="soldiers">Soldier Instance</param>
        public PlayerBase(string nickName, Soldier soldiers)
        {
            Nickname = nickName;
            Soldiers = soldiers;
        }

        /// <summary>
        /// default player instance and empty soldier's
        /// </summary>
        public PlayerBase()
        {
            Soldiers = new Soldier();
        }

        #endregion


    }
}
