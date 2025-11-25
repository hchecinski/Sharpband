using Sharpband.Domain.Enums;
using Sharpband.Domain.Models;

namespace Sharpband.Domain.Tests.Models;

public partial class GameMapTests
{
    [Fact]
    public void CanEnter_TargetIsFloor_True()
    {
        GameMap gameMap = new GameMap();
        int x = 1;
        int y = 1;
        TileTypes floor = TileTypes.Floor;
        gameMap.AddTile(x, y, floor);

        bool result = gameMap.CanEnter(x, y);

        Assert.True(result);
    }

    [Fact]
    public void CanEnter_TargetIsWall_False()
    {
        GameMap gameMap = new GameMap();
        int x = 1;
        int y = 1;
        TileTypes wall = TileTypes.Wall;
        gameMap.AddTile(x, y, wall);

        bool result = gameMap.CanEnter(x, y);

        Assert.False(result);
    }

    [Fact]
    public void CanEnter_TargetIsOutOfMapBound_False()
    {
        GameMap gameMap = new GameMap();

        bool result = gameMap.CanEnter(1, 1);

        Assert.False(result);
    }
}
