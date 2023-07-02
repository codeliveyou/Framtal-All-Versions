using System.Collections;
using System.Windows.Data;
using FN.Framtal.UserControls.Control.API;

namespace FN.Framtal.UserControls.Control.Services
{
	public class GroupComparerService : IComparer
	{
		public int Compare(object x, object y)
		{
			if (x is CollectionViewGroup viewGroup1 && y is CollectionViewGroup viewGroup2)
			{
				if (viewGroup1.Name is IItemGroup itemGroup1 && viewGroup2.Name is IItemGroup itemGroup2)
				{
					return itemGroup1.Order.CompareTo(itemGroup2.Order);
				}
			}

			return 0;
		}
	}
}
