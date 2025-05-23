namespace _4Task
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView view;
        private readonly CalculatorModel model;

        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            this.view = view;
            this.model = model;

            view.AddClicked += OnAdd;
            view.SubtractClicked += OnSubtract;
            view.MultiplyClicked += OnMultiply;
            view.DivideClicked += OnDivide;
        }

        private void PerformOperation(Func<int, int, double> operation)
        {
            int a = int.Parse(view.FirstNumber);
            int b = int.Parse(view.SecondNumber);
            double result = operation(a, b);
            view.ShowResult(result.ToString());
        }

        private void OnAdd() => PerformOperation(model.Add);
        private void OnSubtract() => PerformOperation(model.Subtract);
        private void OnMultiply() => PerformOperation(model.Multiply);
        private void OnDivide() => PerformOperation(model.Divide);
    }
}
