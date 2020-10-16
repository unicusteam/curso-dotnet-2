using System.Windows.Forms;

namespace Unicus.Acad.Apresentacao.WinForm2
{
    public static class Extensoes
    {
        public static T GetCurrentRow<T>(this DataGridView dataGridView)
        {
            return (T)dataGridView.CurrentRow.DataBoundItem;
        }
    }
}
