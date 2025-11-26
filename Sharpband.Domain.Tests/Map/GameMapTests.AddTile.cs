using Sharpband.Domain.Map;

namespace Sharpband.Domain.Tests.Map;

public partial class GameMapTests
{
    [Fact]
    public void AddTile_TileNotExists_True()
    {
        GameMap gameMap = new GameMap();
        int x = 1, y = 1;
        TileTypes tileType = TileTypes.Floor;

        var result = gameMap.AddTile(x, y, tileType);

        Assert.True(result);
    }

    [Fact]
    public void AddTile_TileAlreadyExists_False()
    {
        GameMap gameMap = new GameMap();
        int x = 1, y = 1;
        TileTypes tileType = TileTypes.Floor;
        gameMap.AddTile(x, y, tileType);

        var result = gameMap.AddTile(x, y, tileType);

        Assert.False(result);
    }
}
