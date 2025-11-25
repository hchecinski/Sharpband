
namespace Sharpband.Domain.Models;

public class Player
{
    public bool IsTrapImmune { get; set; }
    public int TrapSafeTurns { get; set; }

    public bool IsTrapSafe()
    {
        return TrapSafeTurns > 0 || IsTrapImmune;
    }
}
