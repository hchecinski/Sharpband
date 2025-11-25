
using Sharpband.Domain.Enums;

namespace Sharpband.Domain.Models;

public class Player
{
    public int TrapSafeTurns { get; set; } = 0;
    public IEnumerable<PlayerFlags> Flags { get; set; } = new List<PlayerFlags>();

    public Player() { }
    public Player(IEnumerable<PlayerFlags> flags)
    {
        if(flags is not null && flags.Any())
        {
            Flags = new List<PlayerFlags>(flags);
        }
    }

    public bool IsTrapSafe()
    {
        return TrapSafeTurns > 0 || HasFlag(PlayerFlags.TrapImmune);
    }

    public bool HasFlag(PlayerFlags flag)
    {
        return Flags.Any(i => i == flag);
    }
}
