namespace _4Task
{
    public interface ICalculatorView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        void ShowResult(string result);

        event Action AddClicked;
        event Action SubtractClicked;
        event Action MultiplyClicked;
        event Action DivideClicked;
    }
}
