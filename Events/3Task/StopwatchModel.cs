using System.Diagnostics;

namespace _3Task
{
    public class StopwatchModel
    {
        private Stopwatch _stopwatch = new Stopwatch();

        public void Start() => _stopwatch.Start();
        public void Stop() => _stopwatch.Stop();
        public void Reset()
        {
            _stopwatch.Reset();
        }

        public string GetElapsedTime()
        {
            var ts = _stopwatch.Elapsed;
            return $"{ts.Minutes:D2}:{ts.Seconds:D2}:{ts.Milliseconds / 10:D2}";
        }

        public bool IsRunning => _stopwatch.IsRunning;
    }
}
