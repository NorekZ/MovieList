using System.Collections;
using System.Windows.Input;
using Xamarin.Forms;

namespace MovieList.Controls
{
    /// <summary>
    /// Taken from http://www.codenutz.com/lac09-xamarin-forms-infinite-scrolling-listview/
    /// </summary>
    public class InfiniteListView : ListView
    {
        public static readonly BindableProperty LoadMoreCommandProperty = BindableProperty.Create<InfiniteListView, ICommand>(bp => bp.LoadMoreCommand, default(ICommand));

        public ICommand LoadMoreCommand
        {
            get { return (ICommand)GetValue(LoadMoreCommandProperty); }
            set { SetValue(LoadMoreCommandProperty, value); }
        }

        public InfiniteListView()
            : this(ListViewCachingStrategy.RecycleElement)
        {
        }

        public InfiniteListView(ListViewCachingStrategy strategy)
            : base(strategy)
        {
            Initialize();
        }

        private void Initialize()
        {
            ItemAppearing += InfiniteListView_ItemAppearing;
        }

        void InfiniteListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var items = ItemsSource as IList;

            if (items != null && e.Item == items[items.Count - 1])
            {
                if (LoadMoreCommand != null && LoadMoreCommand.CanExecute(null))
                {
                    LoadMoreCommand.Execute(null);
                }
            }
        }
    }
}
