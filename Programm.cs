using System;
using System.Windows.Forms;
using Редактор_расписания.Scripts;

namespace Редактор_расписания
{
    internal class Programm
    {
        [STAThread] static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RootForm());
        }
    }
}
