using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DemoChangeBackground.Model
{
    //Model for TicTacToe Items
    class XOModel
    {
        //Boolean to check if an item is X or O
        public Boolean X { get; set; }
        //The shape of the item
        public Symbol Shape { get; set; }
        public int size { get; private set; }

        public XOModel()
        {
            this.size=17;
            this.setX();            
        }
        public void setX()
        {
            this.Shape = Symbol.Clear;
        }
        public void setO()
        {
            this.Shape = (Symbol)0xed66;
        }
    }
}
