using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfChartLocalization
{
	public class ViewModel
	{
		public ObservableCollection<Model> RangeColumnData1 { get; set; }

		public ObservableCollection<Model> RangeColumnData2 { get; set; }

		public ViewModel()
		{
			RangeColumnData1 = new ObservableCollection<Model>
			{
				new Model("Sun", 10.8, 3.1),
				new Model("Mon", 14.4, 5.7),
				new Model("Tue", 16.9, 8.4),
				new Model("Wed", 19.2, 10.6),
				new Model("Thu", 16.1, 8.5),
				new Model("Fri", 12.5, 6.0),
				new Model("Sat", 6.9, 1.5)
			};

			RangeColumnData2 = new ObservableCollection<Model>
			{
				new Model("Sun", 9.8, 2.5),
				new Model("Mon", 11.4, 4.7),
				new Model("Tue", 14.4, 6.4),
				new Model("Wed", 17.2, 9.6),
				new Model("Thu", 15.1, 7.5),
				new Model("Fri", 10.5, 3.0),
				new Model("Sat", 7.9, 1.2)
			};
		}
	}
}
