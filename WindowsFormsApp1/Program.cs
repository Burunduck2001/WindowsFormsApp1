using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CastleBetaForm.Presenter;
using CastleBetaForm.Model;

namespace CastleBetaForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            var presenter = new MyPresenter(new CurrentWorld(), new WorldView());
            presenter.Run();
        }
    }
}
