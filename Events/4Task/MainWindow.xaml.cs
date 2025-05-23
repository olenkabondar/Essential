using System.Windows;


namespace _4Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICalculatorView
    {
        public MainWindow()
        {
            InitializeComponent();
            AddButton.Click += (s, e) => AddClicked?.Invoke();
            SubtractButton.Click += (s, e) => SubtractClicked?.Invoke();
            MultiplyButton.Click += (s, e) => MultiplyClicked?.Invoke();
            DivideButton.Click += (s, e) => DivideClicked?.Invoke();

            var model = new CalculatorModel();
            var presenter = new CalculatorPresenter(this, model);
        }

        public string FirstNumber => FirstNumberBox.Text;
        public string SecondNumber => SecondNumberBox.Text;

        public event Action AddClicked;
        public event Action SubtractClicked;
        public event Action MultiplyClicked;
        public event Action DivideClicked;

        public void ShowResult(string result)
        {
            ResultText.Text = "Результат: " + result;
        }
    }
}