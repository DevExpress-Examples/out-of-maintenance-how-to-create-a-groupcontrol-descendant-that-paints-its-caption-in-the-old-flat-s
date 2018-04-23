﻿Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports System
Imports System.Windows.Forms

Namespace DxSample
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.SkinName = "DevExpress Style"
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
