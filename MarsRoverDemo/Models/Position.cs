namespace MarsRoverDemo.Models
{
	public class Position
	{
        #region Field 

        private int _x;
        private int _y;

        #endregion

        #region Constructor

        public Position(int x, int y) {
            _x = x;
            _y = y;
        }

        #endregion

        #region Property

        public int x {
            get { return _x; }

            set { _x = value; }
        }

        public int y {
            get { return _y; }

            set { _y = value; }
        }

        #endregion
    }
}
