using System.Windows.Controls;
using System.Windows;
using AvalonDock.Layout;
using AvalonDock.VS2013Test.ViewModels;

namespace AvalonDock.VS2013Test
{
	class PanesTemplateSelector : DataTemplateSelector
	{
		public PanesTemplateSelector()
		{
		}

		public DataTemplate FileViewTemplate
		{
			get;
			set;
		}

		public DataTemplate FileStatsViewTemplate
		{
			get;
			set;
		}

		public DataTemplate PropertiesViewTemplate
		{
			get;
			set;
		}

		public DataTemplate ExplorerViewTemplate
		{
			get;
			set;
		}

		public DataTemplate ErrorViewTemplate
		{
			get;
			set;
		}

		public DataTemplate OutputViewTemplate
		{
			get;
			set;
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			var itemAsLayoutContent = item as LayoutContent;

			if (item is FileViewModel)
				return FileViewTemplate;

			if (item is FileStatsViewModel)
				return FileStatsViewTemplate;

			if (item is PropertiesViewModel)
				return PropertiesViewTemplate;

			if (item is ExplorerViewModel)
				return ExplorerViewTemplate;

			if (item is ErrorViewModel)
				return ErrorViewTemplate;

			if (item is OutputViewModel)
				return OutputViewTemplate;

			return base.SelectTemplate(item, container);
		}
	}
}
