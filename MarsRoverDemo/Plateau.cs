using MarsRoverDemo.Models;

namespace MarsRoverDemo
{
    public static class MainPlateauClass
    {
        public static bool IsMoveAvailable(this Plateau plateau, Position position) {
            return plateau.Min_Width <= position.x && position.x <= plateau.Width && plateau.Min_Height <= position.y && position.y <= plateau.Height;
        }
    }
}
