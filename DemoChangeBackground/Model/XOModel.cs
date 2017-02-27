using System;
using Windows.UI.Xaml.Controls;

namespace DemoChangeBackground.Model
{
    //Model for TicTacToe Items
    class MyShape
    {
        //Boolean to check if an item is X or O
        public Boolean X { get; set; }
        //The shape of the item
        public Symbol Shape { get; set; }
        public int size { get; private set; }

        public MyShape()
        {
            this.size=92;
            this.Shape = (Symbol)0x200B;
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
