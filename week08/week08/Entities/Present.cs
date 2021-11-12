using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08.Abstractions;

namespace week08.Entities
{
    public class Present : Abstractions.Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }
        public Present(Color ribbon, Color box)
        {
            RibbonColor = new SolidBrush(ribbon);
            BoxColor = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);

            g.FillRectangle(RibbonColor, Width / 2 - Width / 12, 0, Width / 6, Height);
            g.FillRectangle(RibbonColor, 0, Height / 2 - Height / 12, Width, Height / 6);
        }
    }
}
