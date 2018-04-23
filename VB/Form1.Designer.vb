Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.button1 = New System.Windows.Forms.Button()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(545, 327)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl1.Location = New System.Drawing.Point(4, 13)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(616, 308)
			Me.schedulerControl1.Start = New System.DateTime(2008, 2, 18, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 1
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.AppointmentDrag += New DevExpress.XtraScheduler.AppointmentDragEventHandler(Me.schedulerControl1_AppointmentDrag);
'			Me.schedulerControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.schedulerControl1_DragDrop);
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.ResourceSharing = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(632, 353)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
	End Class
End Namespace

