namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Використовуючи конструктор діаграм класів DSL, створіть загальну діаграму класів для патерна MVP (Model-View-Presenter).*/
    class ConsoleView : IView
    {
        public void DisplayData(string data)
        {
            Console.WriteLine("View: " + data);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            IView view = new ConsoleView();
            Presenter presenter = new Presenter(view, model);

            presenter.UpdateView();
        }
    }
}
