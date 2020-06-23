using Armageddon.Models.Base.Interfaces;

namespace Armageddon.Models.Base
{
    /// <summary>
    /// all unit's who can attack uses this
    /// </summary>
    public abstract class AttackerBase : GunBase, IAttackerBase
    {

        public AttackerBase() : base()
        {

        }
    }
}
