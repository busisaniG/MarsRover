namespace MarsRover
{
    public class MarsRoveRepo : IMarsRoveRepo
    {
        public IMarsRover GetMarsRover(int initilX, int initialY, char initialDirection)
        {
            return new MarsRover(initilX, initialY, initialDirection);
        }
    }
}
