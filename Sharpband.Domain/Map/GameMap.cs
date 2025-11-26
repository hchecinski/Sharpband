namespace Sharpband.Domain.Map;

public class GameMap
{
    private readonly List<Tile> _tiles = new();

    public bool CanEnter(int x, int y)
    {
        var tile = GetTile(x, y);

        return tile?.IsMoveable ?? false;
    }

    public bool AddTile(int x, int y, TileTypes wall)
    {
        if(_tiles.Any(i => i.X == x && i.Y == y))
        {
            return false;
        }

        _tiles.Add(new Tile(x, y, wall));
        return true;
    }

    public Tile? GetTile(int x, int y)
    {
        return _tiles.FirstOrDefault(i => i.X == x && i.Y == y);
    }
}
