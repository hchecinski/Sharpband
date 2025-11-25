using Sharpband.Domain.Enums;
using Sharpband.Domain.Models;

namespace Sharpband.Domain.Tests.Models;

public partial class PlayerTests
{
    [Fact]
    public void HasFlag_HasInTrapImmuneFlag_True()
    {
        Player player = new Player(new List<PlayerFlags>() { PlayerFlags.IsTrapImmune });

        bool result = player.HasFlag(PlayerFlags.IsTrapImmune);

        Assert.True(result);
    }

    [Fact]
    public void HasFlag_HasntInTrapImmuneFlag_False()
    {
        Player player = new Player();

        bool result = player.HasFlag(PlayerFlags.IsTrapImmune);

        Assert.False(result);
    }
}
