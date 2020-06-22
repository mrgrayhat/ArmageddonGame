using Armageddon.Models.Base.Interfaces;
using Armageddon.Models.Game;

namespace Armageddon.Models.Base
{
    public class PlayerBase : IPlayerBase
    {
        #region Properties

        public string Nickname { get; set; }
        public long Score { get; set; }
        public double Money { get; set; }
        public bool HasLost { get; set; }
        public Soldier Soldiers { get; set; }

        #endregion

        #region Constructors

        public PlayerBase(string nickName, Soldier soldiers)
        {
            Nickname = nickName;
            Soldiers = soldiers;
        }
        public PlayerBase()
        {
            Soldiers = new Soldier();
        }

        #endregion


    }
}
