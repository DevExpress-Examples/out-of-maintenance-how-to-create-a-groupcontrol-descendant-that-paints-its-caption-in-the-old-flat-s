Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing

Namespace DxSample.Editors
	Public Class GroupControl
		Inherits DevExpress.XtraEditors.GroupControl

		Protected Overrides Function CreatePainter() As ObjectPainter
			If Me.LookAndFeel IsNot Nothing AndAlso Me.LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
				Return New SimpleGroupObjectPainter(Me, Me.LookAndFeel.ActiveLookAndFeel)
			End If
			Return MyBase.CreatePainter()
		End Function
	End Class
End Namespace
