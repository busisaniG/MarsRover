namespace MarsRover
{
    public interface IMarsRoveRepo
    {
        public IMarsRover GetMarsRover(int initilX, int initialY, char initialDirection);
    }
}
