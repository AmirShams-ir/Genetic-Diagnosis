Imports System.Web
Imports System.Text
Imports System.Windows.Forms
Imports System.Security.Permissions
Public Class omim
    Private Sub omim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Synopsis As String = Diagnose.TextBox_phistory1.Text + "+" + Diagnose.TextBox_phistory2.Text + "+" + Diagnose.TextBox_phistory3.Text + "+" + Diagnose.TextBox_phistory4.Text + "+" + Diagnose.TextBox_phistory5.Text + "+" + Diagnose.TextBox_mexam1.Text + "+" + Diagnose.TextBox_mlocation1.Text + Diagnose.TextBox_mexam2.Text + "+" + Diagnose.TextBox_mlocation2.Text + "+" + Diagnose.TextBox_mexam3.Text + "+" + Diagnose.TextBox_mlocation3.Text + "+" + Diagnose.TextBox_mexam4.Text + "+" + Diagnose.TextBox_mlocation4.Text + "+" + Diagnose.TextBox_mexam5.Text + "+" + Diagnose.TextBox_mlocation5.Text + "+" + Diagnose.TextBox_pexam1.Text + "+" + Diagnose.TextBox_plocation1.Text + "+" + Diagnose.TextBox_pexam2.Text + "+" + Diagnose.TextBox_plocation2.Text + "+" + Diagnose.TextBox_pexam3.Text + "+" + Diagnose.TextBox_plocation3.Text + "+" + Diagnose.TextBox_pexam4.Text + "+" + Diagnose.TextBox_plocation4.Text + "+" + Diagnose.TextBox_sexam.Text + "+" + Diagnose.TextBox_hexam.Text + "+" + Diagnose.TextBox_texam.Text + Diagnose.TextBox_iq.Text + "+" + Diagnose.TextBox_eq.Text + "+" + Diagnose.TextBox_gexam1.Text + "+" + Diagnose.TextBox_gexam2.Text + "+" + Diagnose.TextBox_gexam3.Text + "+" + Diagnose.TextBox_gexam4.Text + "+" + Diagnose.TextBox_gexam5.Text + "+" + Diagnose.TextBox_lresult.Text

        Dim link As String = "http://omim.org/search?index=clinicalSynopsis&search="
        Dim url As String = link + Synopsis
        WebBrowser.ScriptErrorsSuppressed = True
        WebBrowser.Navigate(url)
    End Sub

End Class