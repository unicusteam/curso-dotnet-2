using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace Unicus.Acad.Apresentacao.WinForm2
{
    public static class Extensoes
    {
        public static T GetCurrentRow<T>(this DataGridView dataGridView)
        {
            return (T)dataGridView.CurrentRow.DataBoundItem;
        }

        public static T GetDataSource<T>(this BindingSource bindingSource)
        {
            return (T)bindingSource.DataSource;
        }

        public static void AddEnum<T>(this ComboBox comboBox)
        {
            var values = Enum.GetValues(typeof(T));

            foreach (var value in values)
            {
                var type = value.GetType();
                var memInfo = type.GetMember(value.ToString())[0];

                var display = memInfo.GetCustomAttributes(true).OfType<DisplayAttribute>().FirstOrDefault();
                comboBox.Items.Add(display != null ? display.Name : value);
            }
        }
    }
}
