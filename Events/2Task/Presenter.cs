using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly Model _model;

        public Presenter(IView view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void UpdateView()
        {
            string data = _model.GetData();
            _view.DisplayData(data);
        }
    }
}
