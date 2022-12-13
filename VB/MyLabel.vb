Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.BrickExporters
Imports System.Drawing

Namespace Q305659
	Public Class MyLabel
		Inherits XRLabel
		Protected Overrides Function CreateBrick(ByVal childrenBricks() As DevExpress.XtraPrinting.VisualBrick) As DevExpress.XtraPrinting.VisualBrick
			Return New MyLabelBrick()
		End Function
	End Class
	<BrickExporter(GetType(MyLabelBrickExporter))> _
	Public Class MyLabelBrick
		Inherits LabelBrick
	End Class

	Public Class MyLabelBrickExporter
		Inherits VisualBrickExporter
		Protected Overrides Sub DrawClientContent(ByVal gr As IGraphics, ByVal clientRect As RectangleF)
			gr.DrawString("MyLabel string", VisualBrick.Style.Font, DXBrushes.Red, clientRect, VisualBrick.Style.StringFormat.Value)
		End Sub
	End Class
End Namespace


