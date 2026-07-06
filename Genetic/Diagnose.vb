Imports System.Web
Imports System.Text
Imports System.Windows.Forms
Imports System.Security.Permissions
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Public Class Diagnose
    Dim str(10) As String

    Dim Con As New SqlClient.SqlConnection
    Dim Cmd As New SqlClient.SqlCommand
    Private Sub برگشتبهصفحهاصلیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles برگشتبهصفحهاصلیToolStripMenuItem.Click
        Login.StartPosition = FormStartPosition.CenterScreen
        Login.Show()
        Me.Close()
    End Sub

    Private Sub خروجازبرنامهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خروجازبرنامهToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        staffs2.StartPosition = FormStartPosition.CenterScreen
        staffs2.Show()
    End Sub

    Private Sub کاربرسیستمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کاربرسیستمToolStripMenuItem.Click
        users2.StartPosition = FormStartPosition.CenterScreen
        users2.Show()
    End Sub

    Private Sub پزشکمعالجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمعالجToolStripMenuItem.Click
        doctors2.StartPosition = FormStartPosition.CenterScreen
        doctors2.Show()
    End Sub

    Private Sub پزشکمشاورToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمشاورToolStripMenuItem.Click
        doctors2.StartPosition = FormStartPosition.CenterScreen
        doctors2.Show()
    End Sub

    Private Sub پزشکمعرفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمعرفToolStripMenuItem.Click
        doctors2.StartPosition = FormStartPosition.CenterScreen
        doctors2.Show()
    End Sub

    Private Sub نوشتننسخهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نوشتننسخهToolStripMenuItem.Click
        dictionary.StartPosition = FormStartPosition.CenterScreen
        dictionary.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        print.StartPosition = FormStartPosition.CenterScreen
        print.Show()
    End Sub

    Private Sub تهيهنسخهپشتيبانToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تهيهنسخهپشتيبانToolStripMenuItem.Click
        backup.StartPosition = FormStartPosition.CenterScreen
        backup.Show()
    End Sub

    Private Sub بازگرداندننسخهپشتيبانToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بازگرداندننسخهپشتيبانToolStripMenuItem.Click
        backup.StartPosition = FormStartPosition.CenterScreen
        backup.Show()
    End Sub

    Private Sub پاککردنتمامیفیلدهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پاککردنتمامیفیلدهاToolStripMenuItem.Click
        MsgBox("ارتباط با سرور مرکزی برقرار نیست", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub تقویمسالToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تقویمسالToolStripMenuItem.Click
        calendar.StartPosition = FormStartPosition.CenterScreen
        calendar.Show()
    End Sub

    Private Sub مبدلواحدهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مبدلواحدهاToolStripMenuItem.Click
        convert.StartPosition = FormStartPosition.CenterScreen
        convert.Show()
    End Sub

    Private Sub ماشینحسابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ماشینحسابToolStripMenuItem.Click
        calculator.StartPosition = FormStartPosition.CenterScreen
        calculator.Show()
    End Sub

    Private Sub اسکنتصاویرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اسکنتصاویرToolStripMenuItem.Click
        scan.StartPosition = FormStartPosition.CenterScreen
        scan.Show()
    End Sub

    Private Sub ارسالپیامکToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارسالپیامکToolStripMenuItem.Click
        sms.StartPosition = FormStartPosition.CenterScreen
        sms.Show()
    End Sub

    Private Sub رسمشجرهنامهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles رسمشجرهنامهToolStripMenuItem.Click
        prescription.StartPosition = FormStartPosition.CenterScreen
        prescription.Show()
    End Sub

    Private Sub ارتباطباماToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارتباطباماToolStripMenuItem.Click
        email.StartPosition = FormStartPosition.CenterScreen
        email.Show()
    End Sub

    Private Sub آموزشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles آموزشToolStripMenuItem.Click
        learn.StartPosition = FormStartPosition.CenterScreen
        learn.Show()
    End Sub

    Private Sub قوانینومقرارتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قوانینومقرارتToolStripMenuItem.Click
        laws.StartPosition = FormStartPosition.CenterScreen
        laws.Show()
    End Sub

    Private Sub حریمخصوصیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حریمخصوصیToolStripMenuItem.Click
        privacy.StartPosition = FormStartPosition.CenterScreen
        privacy.Show()
    End Sub

    Private Sub دربارهماToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دربارهماToolStripMenuItem.Click
        info.StartPosition = FormStartPosition.CenterScreen
        info.Show()
    End Sub

    Private Sub Button_diagnosis_Click(sender As Object, e As EventArgs) Handles Button_diagnosis.Click
        omim.StartPosition = FormStartPosition.CenterScreen
        omim.Show()
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            Con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Cmd.Connection = Con
            Cmd.CommandText = "Insert Into person ([case],name,family,gender,[national],certificate,job,education,race,religion,marriage,children,age,address,tel,[p-history],[p-history1],[p-history2],[p-history3],[p-history4],[p-history5],[f-history],[f-history1],[f-history2],[f-history3],[f-history4],[f-history5],[m-exam1],[m-exam2],[m-exam3],[m-exam4],[m-exam5],[m-location1],[m-location2],[m-location3],[m-location4],[m-location5],[p-exam1],[p-exam2],[p-exam3],[p-exam4],[p-location1],[p-location2],[p-location3],[p-location4],[s-exam],[h-exam],[t-exam],iq,eq,ps,[g-exam1],[g-exam2],[g-exam3],[g-exam4],[g-exam5],[l-type1],[l-type2],[l-type3],[l-type4],[l-type5],[l-type6],[l-type7],[l-type8],[l-type9],[l-type10],[l-type11],[l-type12],[l-type13],[l-type14],[l-name1],[l-name2],[l-name3],[l-name4],[l-name5],[l-name6],[l-name7],[l-name8],[l-name9],[l-name10],[l-name11],[l-name12],[l-name13],[l-name14],[l-result1],[l-result2],[l-result3],[l-result4],[l-result5],[l-result6],[l-result7],[l-result8],[l-result9],[l-result10],[l-result11],[l-result12],[l-result13],[l-result14],[l-result],[d-name1],[d-name2],[d-name3],[d-name4],[d-name5],[d-name6],[d-name7],[d-name8],[d-name9],[d-name10],[d-name11],[d-name12],[d-name13],[d-name14],[d-time1],[d-time2],[d-time3],[d-time4],[d-time5],[d-time6],[d-time7],[d-time8],[d-time9],[d-time10],[d-time11],[d-time12],[d-time13],[d-time14],[t-name1],[t-name2],[t-name3],[t-name4],[t-name5],[t-location1],[t-location2],[t-location3],[t-location4],[t-location5]) 
            values ('" + TextBox_case.Text + "','" + TextBox_name.Text + "','" + TextBox_family.Text + "','" + ComboBox_gender.SelectedItem + "','" + TextBox_national.Text + "','" + TextBox_certificate.Text + "','" + TextBox_job.Text + "','" + TextBox_eductaion.Text + "','" + ComboBox_race.SelectedItem + "','" + ComboBox_religion.Text + "','" + ComboBox_marriage.Text + "','" + TextBox_children.Text + "','" + TextBox_age.Text + "','" + TextBox_address.Text + "','" + TextBox_tel.Text + "','" + TextBox_phistory.Text + "','" + TextBox_phistory1.Text + "','" + TextBox_phistory2.Text + "','" + TextBox_phistory3.Text + "','" + TextBox_phistory4.Text + "','" + TextBox_phistory5.Text + "','" + TextBox_fhistory.Text + "','" + TextBox_fhistory1.Text + "','" + TextBox_fhistory2.Text + "','" + TextBox_fhistory3.Text + "','" + TextBox_fhistory4.Text + "','" + TextBox_fhistory5.Text + "','" + TextBox_mexam1.Text + "','" + TextBox_mexam2.Text + "','" + TextBox_mexam3.Text + "','" + TextBox_mexam4.Text + "','" + TextBox_mexam5.Text + "','" + TextBox_mlocation1.Text + "','" + TextBox_mlocation2.Text + "','" + TextBox_mlocation3.Text + "','" + TextBox_mlocation4.Text + "','" + TextBox_mlocation5.Text + "','" + TextBox_pexam1.Text + "','" + TextBox_pexam2.Text + "','" + TextBox_pexam3.Text + "','" + TextBox_pexam4.Text + "','" + TextBox_plocation1.Text + "','" + TextBox_plocation2.Text + "','" + TextBox_plocation3.Text + "','" + TextBox_plocation4.Text + "','" + TextBox_sexam.Text + "','" + TextBox_hexam.Text + "','" + TextBox_texam.Text + "','" + TextBox_iq.Text + "','" + TextBox_eq.Text + "','" + TextBox_ps.Text + "','" + TextBox_gexam1.Text + "','" + TextBox_gexam2.Text + "','" + TextBox_gexam3.Text + "','" + TextBox_gexam4.Text + "','" + TextBox_gexam5.Text + "','" + ComboBox_ltype1.SelectedItem + "','" + ComboBox_ltype2.SelectedItem + "','" + ComboBox_ltype3.SelectedItem + "','" + ComboBox_ltype4.SelectedItem + "','" + ComboBox_ltype5.SelectedItem + "','" + ComboBox_ltype6.SelectedItem + "','" + ComboBox_ltype7.SelectedItem + "','" + ComboBox_ltype8.SelectedItem + "','" + ComboBox_ltype9.SelectedItem + "','" + ComboBox_ltype10.SelectedItem + "','" + ComboBox_ltype11.SelectedItem + "','" + ComboBox_ltype12.SelectedItem + "','" + ComboBox_ltype13.SelectedItem + "','" + ComboBox_ltype14.SelectedItem + "','" + TextBox_lname1.Text + "','" + TextBox_lname2.Text + "','" + TextBox_lname3.Text + "','" + TextBox_lname4.Text + "','" + TextBox_lname5.Text + "','" + TextBox_lname6.Text + "','" + TextBox_lname7.Text + "','" + TextBox_lname8.Text + "','" + TextBox_lname9.Text + "','" + TextBox_lname10.Text + "','" + TextBox_lname11.Text + "','" + TextBox_lname12.Text + "','" + TextBox_lname13.Text + "','" + TextBox_lname14.Text + "','" + TextBox_lresult1.Text + "','" + TextBox_lresult2.Text + "','" + TextBox_lresult3.Text + "','" + TextBox_lresult4.Text + "','" + TextBox_lresult5.Text + "','" + TextBox_lresult6.Text + "','" + TextBox_lresult7.Text + "','" + TextBox_lresult8.Text + "','" + TextBox_lresult9.Text + "','" + TextBox_lresult10.Text + "','" + TextBox_lresult11.Text + "','" + TextBox_lresult12.Text + "','" + TextBox_lresult13.Text + "','" + TextBox_lresult14.Text + "','" + TextBox_lresult.Text + "','" + TextBox_dname1.Text + "','" + TextBox_dname2.Text + "','" + TextBox_dname3.Text + "','" + TextBox_dname4.Text + "','" + TextBox_dname5.Text + "','" + TextBox_dname6.Text + "','" + TextBox_dname7.Text + "','" + TextBox_dname8.Text + "','" + TextBox_dname9.Text + "','" + TextBox_dname10.Text + "','" + TextBox_dname11.Text + "','" + TextBox_dname12.Text + "','" + TextBox_dname13.Text + "','" + TextBox_dname14.Text + "','" + TextBox_dtime1.Text + "','" + TextBox_dtime2.Text + "','" + TextBox_dtime3.Text + "','" + TextBox_dtime4.Text + "','" + TextBox_dtime5.Text + "','" + TextBox_dtime6.Text + "','" + TextBox_dtime7.Text + "','" + TextBox_dtime8.Text + "','" + TextBox_dtime9.Text + "','" + TextBox_dtime10.Text + "','" + TextBox_dtime11.Text + "','" + TextBox_dtime12.Text + "','" + TextBox_dtime13.Text + "','" + TextBox_dtime14.Text + "','" + TextBox_tname1.Text + "','" + TextBox_tname2.Text + "','" + TextBox_tname3.Text + "','" + TextBox_tname4.Text + "','" + TextBox_tname5.Text + "','" + TextBox_tlocation1.Text + "','" + TextBox_tlocation2.Text + "','" + TextBox_tlocation3.Text + "','" + TextBox_tlocation4.Text + "','" + TextBox_tlocation5.Text + "')"
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("اطلاعات ثبت نشد", "خطا در پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Try
            Con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Cmd.Connection = Con
            Cmd.CommandText = "Select * From person where [case]='" + TextBox_case.Text + "'"
            Con.Open()
            Dim dr As SqlDataReader = Cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Con.Close()

            TextBox_name.Text = dt.Rows.Item(0).Item(2).ToString()
            TextBox_family.Text = dt.Rows.Item(0).Item(3).ToString()
            ComboBox_gender.Text = dt.Rows.Item(0).Item(4).ToString()
            TextBox_national.Text = dt.Rows.Item(0).Item(5).ToString()
            TextBox_certificate.Text = dt.Rows.Item(0).Item(6).ToString()
            TextBox_job.Text = dt.Rows.Item(0).Item(7).ToString()
            TextBox_eductaion.Text = dt.Rows.Item(0).Item(8).ToString()
            ComboBox_race.Text = dt.Rows.Item(0).Item(9).ToString()
            ComboBox_religion.Text = dt.Rows.Item(0).Item(10).ToString()
            ComboBox_marriage.Text = dt.Rows.Item(0).Item(11).ToString()
            TextBox_children.Text = dt.Rows.Item(0).Item(12).ToString()
            TextBox_age.Text = dt.Rows.Item(0).Item(13).ToString()

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(14)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_pic.Image = Bitmap.FromStream(MS)
                PictureBox_pic.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            TextBox_address.Text = dt.Rows.Item(0).Item(15).ToString()
            TextBox_tel.Text = dt.Rows.Item(0).Item(16).ToString()
            TextBox_phistory.Text = dt.Rows.Item(0).Item(17).ToString()
            TextBox_phistory1.Text = dt.Rows.Item(0).Item(18).ToString()
            TextBox_phistory2.Text = dt.Rows.Item(0).Item(19).ToString()
            TextBox_phistory3.Text = dt.Rows.Item(0).Item(20).ToString()
            TextBox_phistory4.Text = dt.Rows.Item(0).Item(21).ToString()
            TextBox_phistory5.Text = dt.Rows.Item(0).Item(22).ToString()
            TextBox_fhistory.Text = dt.Rows.Item(0).Item(23).ToString()
            TextBox_fhistory1.Text = dt.Rows.Item(0).Item(24).ToString()
            TextBox_fhistory2.Text = dt.Rows.Item(0).Item(25).ToString()
            TextBox_fhistory3.Text = dt.Rows.Item(0).Item(26).ToString()
            TextBox_fhistory4.Text = dt.Rows.Item(0).Item(27).ToString()
            TextBox_fhistory5.Text = dt.Rows.Item(0).Item(28).ToString()
            TextBox_mexam1.Text = dt.Rows.Item(0).Item(29).ToString()
            TextBox_mexam2.Text = dt.Rows.Item(0).Item(30).ToString()
            TextBox_mexam3.Text = dt.Rows.Item(0).Item(31).ToString()
            TextBox_mexam4.Text = dt.Rows.Item(0).Item(32).ToString()
            TextBox_mexam5.Text = dt.Rows.Item(0).Item(33).ToString()
            TextBox_mlocation1.Text = dt.Rows.Item(0).Item(34).ToString()
            TextBox_mlocation2.Text = dt.Rows.Item(0).Item(35).ToString()
            TextBox_mlocation3.Text = dt.Rows.Item(0).Item(36).ToString()
            TextBox_mlocation4.Text = dt.Rows.Item(0).Item(37).ToString()
            TextBox_mlocation5.Text = dt.Rows.Item(0).Item(38).ToString()
            TextBox_pexam1.Text = dt.Rows.Item(0).Item(39).ToString()
            TextBox_pexam2.Text = dt.Rows.Item(0).Item(40).ToString()
            TextBox_pexam3.Text = dt.Rows.Item(0).Item(41).ToString()
            TextBox_pexam4.Text = dt.Rows.Item(0).Item(42).ToString()
            'TextBox_pexam5.Text = dt.Rows.Item(0).Item(43).ToString()
            TextBox_plocation1.Text = dt.Rows.Item(0).Item(44).ToString()
            TextBox_plocation2.Text = dt.Rows.Item(0).Item(45).ToString()
            TextBox_plocation3.Text = dt.Rows.Item(0).Item(46).ToString()
            TextBox_plocation4.Text = dt.Rows.Item(0).Item(47).ToString()
            'TextBox_plocation5.Text = dt.Rows.Item(0).Item(48).ToString()
            TextBox_sexam.Text = dt.Rows.Item(0).Item(49).ToString()
            TextBox_hexam.Text = dt.Rows.Item(0).Item(50).ToString()
            TextBox_texam.Text = dt.Rows.Item(0).Item(51).ToString()
            TextBox_iq.Text = dt.Rows.Item(0).Item(52).ToString()
            TextBox_eq.Text = dt.Rows.Item(0).Item(53).ToString()
            TextBox_ps.Text = dt.Rows.Item(0).Item(54).ToString()
            TextBox_gexam1.Text = dt.Rows.Item(0).Item(55).ToString()
            TextBox_gexam2.Text = dt.Rows.Item(0).Item(56).ToString()
            TextBox_gexam3.Text = dt.Rows.Item(0).Item(57).ToString()
            TextBox_gexam4.Text = dt.Rows.Item(0).Item(58).ToString()
            TextBox_gexam5.Text = dt.Rows.Item(0).Item(59).ToString()

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(60)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_pedigree.Image = Bitmap.FromStream(MS)
                PictureBox_pedigree.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(61)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage1.Image = Bitmap.FromStream(MS)
                PictureBox_mimage1.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(62)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage2.Image = Bitmap.FromStream(MS)
                PictureBox_mimage2.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(63)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage3.Image = Bitmap.FromStream(MS)
                PictureBox_mimage3.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(64)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage4.Image = Bitmap.FromStream(MS)
                PictureBox_mimage4.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(65)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage5.Image = Bitmap.FromStream(MS)
                PictureBox_mimage5.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(66)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mimage6.Image = Bitmap.FromStream(MS)
                PictureBox_mimage6.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            ComboBox_ltype1.Text = dt.Rows.Item(0).Item(67).ToString()
            ComboBox_ltype2.Text = dt.Rows.Item(0).Item(68).ToString()
            ComboBox_ltype3.Text = dt.Rows.Item(0).Item(69).ToString()
            ComboBox_ltype4.Text = dt.Rows.Item(0).Item(70).ToString()
            ComboBox_ltype5.Text = dt.Rows.Item(0).Item(71).ToString()
            ComboBox_ltype6.Text = dt.Rows.Item(0).Item(72).ToString()
            ComboBox_ltype7.Text = dt.Rows.Item(0).Item(73).ToString()
            ComboBox_ltype8.Text = dt.Rows.Item(0).Item(74).ToString()
            ComboBox_ltype9.Text = dt.Rows.Item(0).Item(75).ToString()
            ComboBox_ltype10.Text = dt.Rows.Item(0).Item(76).ToString()
            ComboBox_ltype11.Text = dt.Rows.Item(0).Item(77).ToString()
            ComboBox_ltype12.Text = dt.Rows.Item(0).Item(78).ToString()
            ComboBox_ltype13.Text = dt.Rows.Item(0).Item(79).ToString()
            ComboBox_ltype14.Text = dt.Rows.Item(0).Item(80).ToString()
            TextBox_lname1.Text = dt.Rows.Item(0).Item(81).ToString()
            TextBox_lname2.Text = dt.Rows.Item(0).Item(82).ToString()
            TextBox_lname3.Text = dt.Rows.Item(0).Item(83).ToString()
            TextBox_lname4.Text = dt.Rows.Item(0).Item(84).ToString()
            TextBox_lname5.Text = dt.Rows.Item(0).Item(85).ToString()
            TextBox_lname6.Text = dt.Rows.Item(0).Item(86).ToString()
            TextBox_lname7.Text = dt.Rows.Item(0).Item(87).ToString()
            TextBox_lname8.Text = dt.Rows.Item(0).Item(88).ToString()
            TextBox_lname9.Text = dt.Rows.Item(0).Item(89).ToString()
            TextBox_lname10.Text = dt.Rows.Item(0).Item(90).ToString()
            TextBox_lname11.Text = dt.Rows.Item(0).Item(91).ToString()
            TextBox_lname12.Text = dt.Rows.Item(0).Item(92).ToString()
            TextBox_lname13.Text = dt.Rows.Item(0).Item(93).ToString()
            TextBox_lname14.Text = dt.Rows.Item(0).Item(94).ToString()
            TextBox_lresult1.Text = dt.Rows.Item(0).Item(95).ToString()
            TextBox_lresult2.Text = dt.Rows.Item(0).Item(96).ToString()
            TextBox_lresult3.Text = dt.Rows.Item(0).Item(97).ToString()
            TextBox_lresult4.Text = dt.Rows.Item(0).Item(98).ToString()
            TextBox_lresult5.Text = dt.Rows.Item(0).Item(99).ToString()
            TextBox_lresult6.Text = dt.Rows.Item(0).Item(100).ToString()
            TextBox_lresult7.Text = dt.Rows.Item(0).Item(101).ToString()
            TextBox_lresult8.Text = dt.Rows.Item(0).Item(102).ToString()
            TextBox_lresult9.Text = dt.Rows.Item(0).Item(103).ToString()
            TextBox_lresult10.Text = dt.Rows.Item(0).Item(104).ToString()
            TextBox_lresult11.Text = dt.Rows.Item(0).Item(105).ToString()
            TextBox_lresult12.Text = dt.Rows.Item(0).Item(106).ToString()
            TextBox_lresult13.Text = dt.Rows.Item(0).Item(107).ToString()
            TextBox_lresult14.Text = dt.Rows.Item(0).Item(108).ToString()
            TextBox_lresult.Text = dt.Rows.Item(0).Item(109).ToString()
            TextBox_dname1.Text = dt.Rows.Item(0).Item(110).ToString()
            TextBox_dname2.Text = dt.Rows.Item(0).Item(111).ToString()
            TextBox_dname3.Text = dt.Rows.Item(0).Item(112).ToString()
            TextBox_dname4.Text = dt.Rows.Item(0).Item(113).ToString()
            TextBox_dname5.Text = dt.Rows.Item(0).Item(114).ToString()
            TextBox_dname6.Text = dt.Rows.Item(0).Item(115).ToString()
            TextBox_dname7.Text = dt.Rows.Item(0).Item(116).ToString()
            TextBox_dname8.Text = dt.Rows.Item(0).Item(117).ToString()
            TextBox_dname9.Text = dt.Rows.Item(0).Item(118).ToString()
            TextBox_dname10.Text = dt.Rows.Item(0).Item(119).ToString()
            TextBox_dname11.Text = dt.Rows.Item(0).Item(120).ToString()
            TextBox_dname12.Text = dt.Rows.Item(0).Item(121).ToString()
            TextBox_dname13.Text = dt.Rows.Item(0).Item(122).ToString()
            TextBox_dname14.Text = dt.Rows.Item(0).Item(123).ToString()
            TextBox_dtime1.Text = dt.Rows.Item(0).Item(124).ToString()
            TextBox_dtime2.Text = dt.Rows.Item(0).Item(125).ToString()
            TextBox_dtime3.Text = dt.Rows.Item(0).Item(126).ToString()
            TextBox_dtime4.Text = dt.Rows.Item(0).Item(127).ToString()
            TextBox_dtime5.Text = dt.Rows.Item(0).Item(128).ToString()
            TextBox_dtime6.Text = dt.Rows.Item(0).Item(129).ToString()
            TextBox_dtime7.Text = dt.Rows.Item(0).Item(130).ToString()
            TextBox_dtime8.Text = dt.Rows.Item(0).Item(131).ToString()
            TextBox_dtime9.Text = dt.Rows.Item(0).Item(132).ToString()
            TextBox_dtime10.Text = dt.Rows.Item(0).Item(133).ToString()
            TextBox_dtime11.Text = dt.Rows.Item(0).Item(134).ToString()
            TextBox_dtime12.Text = dt.Rows.Item(0).Item(135).ToString()
            TextBox_dtime13.Text = dt.Rows.Item(0).Item(136).ToString()
            TextBox_dtime14.Text = dt.Rows.Item(0).Item(137).ToString()
            TextBox_tname1.Text = dt.Rows.Item(0).Item(138).ToString()
            TextBox_tname2.Text = dt.Rows.Item(0).Item(139).ToString()
            TextBox_tname3.Text = dt.Rows.Item(0).Item(140).ToString()
            TextBox_tname4.Text = dt.Rows.Item(0).Item(141).ToString()
            TextBox_tname5.Text = dt.Rows.Item(0).Item(142).ToString()
            TextBox_tlocation1.Text = dt.Rows.Item(0).Item(143).ToString()
            TextBox_tlocation2.Text = dt.Rows.Item(0).Item(144).ToString()
            TextBox_tlocation3.Text = dt.Rows.Item(0).Item(145).ToString()
            TextBox_tlocation4.Text = dt.Rows.Item(0).Item(146).ToString()
            TextBox_tlocation5.Text = dt.Rows.Item(0).Item(147).ToString()
            Button_save.Enabled = False
            Button_edit.Enabled = True

        Catch
            MessageBox.Show("اطلاعات بیمار در سیستم موجود نیست", "خطا در پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_case.Text = ""
        End Try

    End Sub

    Private Sub Button_open1_Click(sender As Object, e As EventArgs) Handles Button_open1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(1) = open.FileName
            PictureBox_pic.Image = Image.FromFile(str(1))
            PictureBox_pic.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button_save1_Click(sender As Object, e As EventArgs) Handles Button_save1.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(1))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [pic]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button_cam1_Click(sender As Object, e As EventArgs) Handles Button_cam1.Click

    End Sub

    Private Sub Button_del1_Click(sender As Object, e As EventArgs) Handles Button_del1.Click
        PictureBox_pic.Image = Nothing
        str(1) = ""
    End Sub

    Private Sub Button_open2_Click(sender As Object, e As EventArgs) Handles Button_open2.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(3) = open.FileName
            PictureBox_document.Image = Image.FromFile(str(3))
            PictureBox_document.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button_save2_Click(sender As Object, e As EventArgs) Handles Button_save2.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(3))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update financial set [document]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button_cam2_Click(sender As Object, e As EventArgs) Handles Button_cam2.Click

    End Sub

    Private Sub Button_del2_Click(sender As Object, e As EventArgs) Handles Button_del2.Click
        PictureBox_document.Image = Nothing
        str(3) = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pedigree.StartPosition = FormStartPosition.CenterScreen
        pedigree.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(4) = open.FileName
            PictureBox_mimage1.Image = Image.FromFile(str(4))
            PictureBox_mimage1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(4))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image1]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox_mimage1.Image = Nothing
        str(4) = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(5) = open.FileName
            PictureBox_mimage2.Image = Image.FromFile(str(5))
            PictureBox_mimage2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(5))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image2]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox_mimage2.Image = Nothing
        str(5) = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(6) = open.FileName
            PictureBox_mimage3.Image = Image.FromFile(str(6))
            PictureBox_mimage3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(6))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image3]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox_mimage3.Image = Nothing
        str(6) = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(7) = open.FileName
            PictureBox_mimage4.Image = Image.FromFile(str(7))
            PictureBox_mimage4.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(7))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image4]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PictureBox_mimage4.Image = Nothing
        str(7) = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(8) = open.FileName
            PictureBox_mimage5.Image = Image.FromFile(str(8))
            PictureBox_mimage5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(8))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image5]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PictureBox_mimage5.Image = Nothing
        str(8) = ""
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(9) = open.FileName
            PictureBox_mimage6.Image = Image.FromFile(str(9))
            PictureBox_mimage6.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(9))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [m-image6]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PictureBox_mimage6.Image = Nothing
        str(9) = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(10) = open.FileName
            PictureBox_pedigree.Image = Image.FromFile(str(10))
            PictureBox_pedigree.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(10))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update person set [pedigree]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox_pedigree.Image = Nothing
        str(10) = ""
    End Sub
End Class