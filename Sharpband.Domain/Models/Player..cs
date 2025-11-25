
using Sharpband.Domain.Enums;

namespace Sharpband.Domain.Models;

public class Player
{
    public Player() { }
    public Player(IEnumerable<PlayerFlags> flags)
    {
        if(flags is not null && flags.Any())
        {
            Flags = new List<PlayerFlags>(flags);
        }
    }

    public bool IsTrapImmune { get; set; } = false;
    public int TrapSafeTurns { get; set; } = 0;
    public IEnumerable<PlayerFlags> Flags { get; set; } = new List<PlayerFlags>();

    public bool IsTrapSafe()
    {
        return TrapSafeTurns > 0 || IsTrapImmune;
    }

    public bool HasFlag(PlayerFlags flag)
    {
        return Flags.Any(i => i == flag);
    }
}
