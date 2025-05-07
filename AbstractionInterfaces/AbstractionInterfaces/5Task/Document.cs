using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Task
{
    internal class Document
    {
        Title title;
        Body body;
        Footer footer;

        void InitializeDocument()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }

        public Document()
        {
            InitializeDocument();
        }
        public string Title
        {
            set { title.Content = value; }
        }
        public string Body
        {
            set { body.Content = value; }
        }

        public string Footer
        {
            set { footer.Content = value; }
        }

        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

    }
}
