Namespace NavBarCustomPaintHeader
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
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            DirectCast(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup1
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1})
            Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBarControl1.Size = New System.Drawing.Size(182, 344)
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Caption = "navBarGroup1"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.Name = "navBarGroup1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(460, 344)
            Me.Controls.Add(Me.navBarControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    End Class
End Namespace

