using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AchadosPerdidos.Winform.Util
{
	public static class DropdownConvertUtil
	{
		const string defaultText = "-- Selecione --";
		const int defaultValue = -1;
		public static void PopulateDropdown(ComboBox comboBox, IEnumerable<object> list, string idPropertyName, string descriptionPropertyName)
		{
			comboBox.DataSource = list;
			comboBox.ValueMember = idPropertyName;
			comboBox.DisplayMember = descriptionPropertyName;
			comboBox.SelectedIndex = defaultValue;
			comboBox.Text = defaultText;

		}
	}
}
