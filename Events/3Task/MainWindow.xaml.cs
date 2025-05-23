using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace _3Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IStopwatchView
    {
        /*Використовуючи Visual Studio, створіть проект за шаблоном WPF Application.Створіть програму секундоміру. 
         * Потрібно виводити показання секундоміра у вікні. Вікно має кнопки запуску, зупинки та скидання секундоміра.
         * Для реалізації секундоміра використовуйте патерн MVP.*/
        public event Action StartClicked;
        public event Action StopClicked;
        public event Action ResetClicked;
        public MainWindow()
        {
            InitializeComponent();

            // Прив'язка кнопок до подій
            StartButton.Click += (s, e) => StartClicked?.Invoke();
            StopButton.Click += (s, e) => StopClicked?.Invoke();
            ResetButton.Click += (s, e) => ResetClicked?.Invoke();

            // MVP
            var model = new StopwatchModel();
            var presenter = new StopwatchPresenter(this, model);
        }
        public void UpdateTime(string time)
        {
            Dispatcher.Invoke(() => TimeDisplay.Text = time);
        }
    }
}