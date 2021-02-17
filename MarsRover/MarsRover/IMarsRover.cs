namespace MarsRover
{
    public interface IMarsRover
    {
        char Direction { get; set; }
        int X { get; set; }
        int Y { get; set; }

        void Land(IMarsRoverGrid grid);
        void Move();
        string Rove(char input);
        string Rove(string input);
        void TurnLeft();
        void TurnRight();
    }
}