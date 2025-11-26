using Sharpband.Domain.Player;

namespace Sharpband.Domain.Tests.Player;

public partial class PlayerTests
{
    [Fact]
    public void HasFlag_HasTrapImmuneFlag_True()
    {
        MainCharacter player = new(new List<PlayerFlags>() { PlayerFlags.TrapImmune });

        bool result = player.HasFlag(PlayerFlags.TrapImmune);

        Assert.True(result);
    }

    [Fact]
    public void HasFlag_PlayerWithoutFlags_False()
    {
        MainCharacter player = new();

        bool result = player.HasFlag(PlayerFlags.TrapImmune);

        Assert.False(result);
    }
}
