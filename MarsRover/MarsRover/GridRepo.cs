namespace MarsRover
{
    public class GridRepo : IGridRepo
    {
        public IMarsRoverGrid GetGrid(int width, int hight)
        {
            return new MarsRoverGrid(width + 1 , hight + 1 );
        }
    }
}
