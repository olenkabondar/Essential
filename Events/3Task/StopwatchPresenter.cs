namespace _3Task
{
    public class StopwatchPresenter
    {
        private readonly IStopwatchView _view;
        private readonly StopwatchModel _model;
        private readonly System.Timers.Timer _timer;

        public StopwatchPresenter(IStopwatchView view, StopwatchModel model)
        {
            _view = view;
            _model = model;
            _timer = new System.Timers.Timer(100); // 100 мс оновлення

            _view.StartClicked += OnStart;
            _view.StopClicked += OnStop;
            _view.ResetClicked += OnReset;

            _timer.Elapsed += (s, e) =>
            {
                if (_model.IsRunning)
                {
                    _view.UpdateTime(_model.GetElapsedTime());
                }
            };
        }

        private void OnStart()
        {
            _model.Start();
            _timer.Start();
        }

        private void OnStop()
        {
            _model.Stop();
        }

        private void OnReset()
        {
            _model.Reset();
            _view.UpdateTime("00:00:00");
        }
    }
}
