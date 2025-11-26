namespace Sharpband.Domain.Player;

public class MainCharacter
{
    public int TrapSafeTurns { get; set; } = 0;
    public IEnumerable<PlayerFlags> Flags { get; set; } = new List<PlayerFlags>();

    public MainCharacter() { }
    public MainCharacter(IEnumerable<PlayerFlags> flags)
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
