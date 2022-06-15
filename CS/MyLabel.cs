using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BrickExporters;
using System.Drawing;
using DevExpress.Drawing;

namespace Q305659
{
    public class MyLabel : XRLabel {
        protected override DevExpress.XtraPrinting.VisualBrick CreateBrick(DevExpress.XtraPrinting.VisualBrick[] childrenBricks)
        {
            return new MyLabelBrick();
        }
    }
    [BrickExporter(typeof(MyLabelBrickExporter))]
    public class MyLabelBrick : LabelBrick
    { 
    }

    public class MyLabelBrickExporter : VisualBrickExporter {
        protected override void DrawClientContent(IGraphics gr, RectangleF clientRect) {
            gr.DrawString("MyLabel string", VisualBrick.Style.Font, DXBrushes.Red, clientRect, VisualBrick.Style.StringFormat.DXValue);
        }
    }
}


