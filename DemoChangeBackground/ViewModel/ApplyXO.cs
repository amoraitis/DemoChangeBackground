using DemoChangeBackground.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoChangeBackground.ViewModel
{
    //Viewmodel for TicTacToe items
    class ApplyXO
    {
        public List<XOModel> GetContainer()
        {
            List<XOModel> TicItems=new List<XOModel>();
            for (int i = 0; i < 9; i++)
            {
                TicItems.Add(new XOModel());
            }
            return TicItems;
        }
    }
}
