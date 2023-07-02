using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls.Control.MultiSelectComboBoxControls
{
	public sealed class ContentItemsControl : ItemsControl
	{
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new ContentControl();
		}
	}
}
