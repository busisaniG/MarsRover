namespace MarsRover
{
    public interface IMarsRoverGrid
    {
        GridCel[,] Grid { get; }

        void LandRove(int x, int y);
    }
}