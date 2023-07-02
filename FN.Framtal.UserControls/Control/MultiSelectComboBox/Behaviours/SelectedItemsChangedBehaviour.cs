using System.Windows;
using System.Windows.Input;

namespace FN.Framtal.UserControls.Control.Behaviours
{
	public class SelectedItemsChangedBehaviour
	{
		public static readonly DependencyProperty SelectedItemsChangedCommand = EventBehaviourFactory.CreateCommandExecutionEventBehaviour(
			MultiSelectComboBox.SelectedItemsChangedEvent, "SelectedItemsChanged", typeof(SelectedItemsChangedBehaviour));

		public static void SetSelectedItemsChanged(DependencyObject o, ICommand value)
		{
			o.SetValue(SelectedItemsChangedCommand, value);
		}

		public static ICommand GetSelectedItemsChanged(DependencyObject o)
		{
			return o.GetValue(SelectedItemsChangedCommand) as ICommand;
		}
	}
}
