using DemoChangeBackground.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoChangeBackground.ViewModel
{
    class QuotaMenuItems
    {
        public static ObservableCollection<MenuItem> GetMenuItems()
        {
            var items = new ObservableCollection<MenuItem>();
            items.Add(new MenuItem() { Title = "React", SubTitle = "Check your Reaction", Page = typeof(Views.ChangeBackground) });
            return items;
        }
    }
}
