using Sharpband.Domain.Enums;

namespace Sharpband.Domain.Models;

public class Tile
{
    public Tile() { }
    public Tile(int x, int y, TileTypes type)
    {
        X = x;
        Y = y;
        Type = type;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public TileTypes Type { get; set; }
    public bool IsMoveable => Type == TileTypes.Floor;
}
