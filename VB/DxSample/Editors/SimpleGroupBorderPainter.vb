Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing

Namespace DxSample.Editors
	Public Class SimpleGroupBorderPainter
		Inherits SkinGroupBorderPainter

		Public Sub New(ByVal groupPainter As SkinGroupObjectPainter, ByVal provider As ISkinProvider)
			MyBase.New(groupPainter, provider)
		End Sub

		Protected Overrides Function GetPanelSkinElement(ByVal info As GroupObjectInfoArgs) As SkinElement
			Return CommonSkins.GetSkin(Me.Provider)(CommonSkins.SkinGroupPanel)
		End Function
	End Class
End Namespace
