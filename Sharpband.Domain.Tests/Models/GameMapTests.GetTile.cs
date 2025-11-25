using Sharpband.Domain.Enums;
using Sharpband.Domain.Models;

namespace Sharpband.Domain.Tests.Models;

public partial class GameMapTests
{
    [Fact]
    public void GetTile_FoundTile_Tile()
    {
        GameMap gameMap = new GameMap();
        int x = 1, y = 1;
        TileTypes wall = TileTypes.Wall;
        gameMap.AddTile(x, y, wall);

        var tile = gameMap.GetTile(x, y);

        Assert.NotNull(tile);
    }

    [Fact]
    public void GetTile_SearchOutOfMapBoud_Null()
    {
        GameMap gameMap = new GameMap();
        int x = 1, y = 1;

        var tile = gameMap.GetTile(x, y);

        Assert.Null(tile);
    }
}
