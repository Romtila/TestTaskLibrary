namespace TestTaskLibrary
{
    public interface IFigure<in T>
    {
        double CalculateSquare(T figure);
        double CalculateSquare();
    }
}