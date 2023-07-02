using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls.Control.Services
{
	public class DropdownItemTemplateService : DataTemplateSelector
	{
		private readonly DataTemplate _defaultItemTemplate;		

		public DropdownItemTemplateService(DataTemplate selectedItemsItemTemplate)
		{
			_defaultItemTemplate = selectedItemsItemTemplate;
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{			
			if (item != null)
			{
				return _defaultItemTemplate;			
			}

			return base.SelectTemplate(null, container);
		}
	}
}
