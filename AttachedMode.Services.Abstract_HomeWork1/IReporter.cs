using System.Windows.Forms;

namespace AttachedMode.Services.Abstract_HomeWork2
{
    public interface IReporter
    {
        void MessageBox.Show(string text);
        void SendReporter(string tmp, string text);
    }
}