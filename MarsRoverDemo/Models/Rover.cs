using MarsRoverDemo.Enums;

namespace MarsRoverDemo.Models
{
	public class Rover
	{

        private Plateau _plateau;
        private Position _position;
        private DirectionEnum _heading = MainRoverClass.heading;

        public Rover(Plateau plateau, Position position, DirectionEnum heading) {
            _plateau = plateau;
            _position = position;
            _heading = heading;
        }

        public Plateau plateau {
            get { return _plateau; }

            set { _plateau = value; }
        }

        public Position position {
            get { return _position; }

            set { _position = value; }
        }

        public DirectionEnum heading {
            get { return _heading; }

            set { _heading = value; }
        }

    }
}
