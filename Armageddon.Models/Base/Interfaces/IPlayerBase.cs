using Armageddon.Models.Game;

namespace Armageddon.Models.Base.Interfaces
{
    public interface IPlayerBase
    {
        string Nickname { get; set; }
        long Score { get; set; }
        double Money { get; set; }
        bool HasLost { get; set; }
        Soldier Soldiers { get; set; }
    }
}
