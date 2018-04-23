Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace DxSample.Editors
	Public Class SimpleGroupObjectPainter
		Inherits SkinGroupObjectPainter

		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
			MyBase.New(owner, provider)
		End Sub
		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider, ByVal groupPanelSkinElementName As String)
			MyBase.New(owner, provider, groupPanelSkinElementName)
		End Sub

		Protected Overrides Function GetBorderBounds(ByVal info As GroupObjectInfoArgs) As Rectangle
			Dim result As Rectangle = info.Bounds
			If info.CaptionBounds.IsEmpty Then
				Return result
			End If
			If Me.IsVerticalCaption(info) Then
				Dim width As Integer = info.CaptionBounds.Width \ 2
				If Me.GetCaptionLocation(info) = Locations.Left Then
					result.X += width
				End If
				result.Width -= width
			Else
				Dim height As Integer = info.CaptionBounds.Height \ 2
				If Me.GetCaptionLocation(info) = Locations.Top Then
					result.Y += height
				End If
				result.Height -= height
			End If
			Return result
		End Function

		Protected Overrides Sub DrawCaptionSkinElement(ByVal info As GroupObjectInfoArgs)
		End Sub

		Protected Overrides Function GetBorderPainter(ByVal e As ObjectInfoArgs) As ObjectPainter
			Dim args As GroupObjectInfoArgs = CType(e, GroupObjectInfoArgs)
			If args.BorderStyle = BorderStyles.NoBorder AndAlso (Not args.ShowCaption) Then
				Return New SkinGroupEmptyBorderPainter(Me.Provider)
			End If
			Return New SimpleGroupBorderPainter(Me, Me.Provider)
		End Function

		Protected Overrides Sub DrawCaptionText(ByVal info As GroupObjectInfoArgs)
			MyBase.DrawCaptionText(info)
		End Sub

		Protected Overrides Function GetActualCaptionTextBackColor(ByVal info As GroupObjectInfoArgs) As Color
			Dim result As Color = MyBase.GetActualCaptionTextBackColor(info)
			Return If(result.IsEmpty, info.Appearance.BackColor, result)
		End Function
	End Class
End Namespace
