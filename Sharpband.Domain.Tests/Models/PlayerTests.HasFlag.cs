using Sharpband.Domain.Enums;
using Sharpband.Domain.Models;

namespace Sharpband.Domain.Tests.Models;

public partial class PlayerTests
{
    [Fact]
    public void HasFlag_HasTrapImmuneFlag_True()
    {
        Player player = new Player(new List<PlayerFlags>() { PlayerFlags.TrapImmune });

        bool result = player.HasFlag(PlayerFlags.TrapImmune);

        Assert.True(result);
    }

    [Fact]
    public void HasFlag_PlayerWithoutFlags_False()
    {
        Player player = new Player();

        bool result = player.HasFlag(PlayerFlags.TrapImmune);

        Assert.False(result);
    }
}
