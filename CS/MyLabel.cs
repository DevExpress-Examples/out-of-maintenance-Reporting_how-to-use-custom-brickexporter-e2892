using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BrickExporters;
using System.Drawing;

namespace Q305659
{
    public class MyLabel : XRLabel {
        protected override DevExpress.XtraPrinting.VisualBrick CreateBrick(DevExpress.XtraPrinting.VisualBrick[] childrenBricks)
        {
            return new MaLabelBrick();
        }
    }
    [BrickExporter(typeof(MyLabelBrickExporter))]
    public class MaLabelBrick : LabelBrick
    { 
    }

    public class MyLabelBrickExporter : VisualBrickExporter {
        protected override void DrawClientContent(IGraphics gr, RectangleF clientRect) {
            gr.DrawString("MyLabel string", ((VisualBrick)this.Brick).Style.Font, Brushes.Red, clientRect.Location);
        }
    }
}


