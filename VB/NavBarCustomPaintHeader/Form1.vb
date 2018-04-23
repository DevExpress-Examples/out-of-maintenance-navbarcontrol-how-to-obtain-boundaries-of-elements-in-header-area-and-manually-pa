Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar.ViewInfo

Namespace NavBarCustomPaintHeader
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            AddHandler navBarControl1.CustomDrawGroupCaption, AddressOf NavBarControl1_CustomDrawGroupCaption
        End Sub

        Private Sub NavBarControl1_CustomDrawGroupCaption(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs)
            Console.WriteLine(Date.Now.Ticks)
            Dim info = TryCast(e.ObjectInfo, NavGroupInfoArgs)
            Dim vInfo = TryCast(info.ClientInfo.NavBar.GetViewInfo(), SkinNavigationPaneViewInfo)
            If vInfo Is Nothing Then
                Return
            End If
            'custom paint
            Dim rect As Rectangle = vInfo.HeaderBounds
            rect.Width -= 1
            e.Graphics.DrawRectangle(Pens.Red, rect)
            e.Graphics.DrawRectangle(Pens.Green, vInfo.HeaderInfo.CaptionBounds)
            e.Graphics.DrawRectangle(Pens.Black, vInfo.HeaderInfo.ButtonBounds)
        End Sub
    End Class
End Namespace
