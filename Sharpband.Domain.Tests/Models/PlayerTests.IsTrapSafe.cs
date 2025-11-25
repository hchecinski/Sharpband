using Sharpband.Domain.Enums;
using Sharpband.Domain.Models;

namespace Sharpband.Domain.Tests.Models;

public partial class PlayerTests
{
    [Fact]
    public void IsTrapSafe_HasTrapImmune_True()
    {
        Player player = new Player([PlayerFlags.TrapImmune]);

        var result = player.IsTrapSafe();

        Assert.True(result);
    }

    [Fact]
    public void IsTrapSafe_TrapSafeTurnsAboveZero_True()
    {
        Player player = new Player() { TrapSafeTurns = 1 };

        var result = player.IsTrapSafe();

        Assert.True(result);
    }

    [Fact]
    public void IsTrapSafe_NoTrapImmuneAndNoTrapSafeTurns_False()
    {
        Player player = new Player();

        var result = player.IsTrapSafe();

        Assert.False(result);
    }
}
