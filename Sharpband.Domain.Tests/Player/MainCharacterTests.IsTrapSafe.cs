using Sharpband.Domain.Player;

namespace Sharpband.Domain.Tests.Player;

public partial class PlayerTests
{
    [Fact]
    public void IsTrapSafe_HasTrapImmune_True()
    {
        MainCharacter player = new ([PlayerFlags.TrapImmune]);

        var result = player.IsTrapSafe();

        Assert.True(result);
    }

    [Fact]
    public void IsTrapSafe_TrapSafeTurnsAboveZero_True()
    {
        MainCharacter player = new () { TrapSafeTurns = 1 };

        var result = player.IsTrapSafe();

        Assert.True(result);
    }

    [Fact]
    public void IsTrapSafe_NoTrapImmuneAndNoTrapSafeTurns_False()
    {
        MainCharacter player = new ();

        var result = player.IsTrapSafe();

        Assert.False(result);
    }
}
