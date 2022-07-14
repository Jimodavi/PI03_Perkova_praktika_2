using System.Drawing;

namespace praktika_2
{    class Cell
    {/*класс, описывающий параметры типа клетки*/
        public Brush CellBrush;
        public sbyte CellNumber;
        public Cell (Brush Color, sbyte Number)
        {
            this.CellBrush = Color;
            this.CellNumber = Number;
        }
    }
}