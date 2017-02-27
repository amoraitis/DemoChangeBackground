using DemoChangeBackground.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoChangeBackground.ViewModel
{
    //Viewmodel for TicTacToe items
    class ApplyXO
    {
        public ObservableCollection<MyShape> GetContainer()
        {
            ObservableCollection<MyShape> TicItems = new ObservableCollection<MyShape>();
            for (int i = 0; i < 9; i++)
            {
                TicItems.Add(new MyShape());
            }
            return TicItems;
        }
    }
}
