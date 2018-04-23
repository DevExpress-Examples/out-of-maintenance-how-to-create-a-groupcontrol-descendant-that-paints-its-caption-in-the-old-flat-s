Namespace DxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.GroupControl = New DxSample.Editors.GroupControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			DirectCast(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupControl.SuspendLayout()
			DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' GroupControl
			' 
			Me.GroupControl.Controls.Add(Me.textEdit1)
			Me.GroupControl.Controls.Add(Me.labelControl1)
			Me.GroupControl.Location = New System.Drawing.Point(44, 48)
			Me.GroupControl.Name = "GroupControl"
			Me.GroupControl.Size = New System.Drawing.Size(200, 100)
			Me.GroupControl.TabIndex = 0
			Me.GroupControl.Text = "Group Control"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(87, 28)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 22)
			Me.textEdit1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 31)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(75, 16)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Label Control"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(615, 287)
			Me.Controls.Add(Me.GroupControl)
			Me.LookAndFeel.SkinName = "Valentine"
			Me.Name = "MainForm"
			Me.Text = "Main Form"
			DirectCast(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupControl.ResumeLayout(False)
			Me.GroupControl.PerformLayout()
			DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private GroupControl As DxSample.Editors.GroupControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

