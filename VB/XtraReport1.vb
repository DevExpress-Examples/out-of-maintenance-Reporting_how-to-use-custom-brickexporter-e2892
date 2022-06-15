Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace Q305659
	Public Class XtraReport1
		Inherits XtraReport
		Private topMarginBand1 As TopMarginBand
		Private detailBand1 As DetailBand
		Private xrLabel1 As MyLabel
		Private bottomMarginBand1 As BottomMarginBand
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New Q305659.MyLabel()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.detailBand1.Name = "detailBand1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(205.2083F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(144.7916F, 52.16667F)
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1})
			Me.Version = "10.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
