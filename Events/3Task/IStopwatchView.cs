namespace _3Task
{
    public interface IStopwatchView
    {
        void UpdateTime(string time);
        event Action StartClicked;
        event Action StopClicked;
        event Action ResetClicked;
    }
}
