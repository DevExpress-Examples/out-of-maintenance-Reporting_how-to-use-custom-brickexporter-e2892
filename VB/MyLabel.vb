Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.BrickExporters
Imports System.Drawing

Namespace Q305659
	Public Class MyLabel
		Inherits XRLabel
		Protected Overrides Function CreateBrick(ByVal childrenBricks() As DevExpress.XtraPrinting.VisualBrick) As DevExpress.XtraPrinting.VisualBrick
			Return New MaLabelBrick()
		End Function
	End Class
	<BrickExporter(GetType(MyLabelBrickExporter))> _
	Public Class MaLabelBrick
		Inherits LabelBrick
	End Class

	Public Class MyLabelBrickExporter
		Inherits VisualBrickExporter
		Protected Overrides Sub DrawClientContent(ByVal gr As IGraphics, ByVal clientRect As RectangleF)
			gr.DrawString("MyLabel string", (CType(Me.Brick, VisualBrick)).Style.Font, Brushes.Red, clientRect.Location)
		End Sub
	End Class
End Namespace


