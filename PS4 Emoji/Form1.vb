Imports System.IO
Imports System.Net
Imports System.Collections.Generic
Imports System.IO.Compression
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IP = "" Then
        Else
            TextBox1.Text = My.Settings.IP
        End If
    End Sub
    ''6.72 9.00
    Sub sendcheatcustom()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/PUI")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" custom !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Bcustom_Click(sender As Object, e As EventArgs) Handles Bcustom.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing custom?", "custom", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatcustom()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'original
    Sub sendcheatoriginal()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/original/PUI")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/original/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" original !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Boriginal_Click(sender As Object, e As EventArgs)
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing original?", "original", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatoriginal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''Blue
    Sub sendcheatcustomBlue()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/PUIBlue")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" Blue !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BuBlue672_Click(sender As Object, e As EventArgs) Handles BuBlue672.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "Blue", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatcustomBlue()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'PUIYellow 6.72 9.00
    Sub sendcheatcustomPUIY()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/PUIY")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" Yellow !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PUIY_Click(sender As Object, e As EventArgs) Handles PUIY.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "Yellow", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatcustomPUIY()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'PUIG
    Sub sendcheatcustomPUIG()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/PUIG")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" GreenY !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BGreenY_Click(sender As Object, e As EventArgs) Handles BGreenY.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "GreenY", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatcustomPUIG()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        About.ShowDialog()
    End Sub

    '5.05 custom
    Sub sendcheatcustom505()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/UI2")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" custom !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub B505_Click(sender As Object, e As EventArgs) Handles B505.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "custom", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatcustom505()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '505 original
    Sub sendcheatoriginal505()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/original/UI2")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/original/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" original !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Bu505_Click(sender As Object, e As EventArgs) Handles Bu505.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "original", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatoriginal505()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''Blue 5.05 custom
    Sub sendcheatBlue505()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/UI2Blue")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" Blue !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub But505_Click(sender As Object, e As EventArgs) Handles But505.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "Blue", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatBlue505()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '5.05 Yellow
    Sub sendcheatUI2Y()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/UI2Y")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" Yellow !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BUI2Y_Click(sender As Object, e As EventArgs) Handles BUI2Y.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "Yellow", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatUI2Y()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '5.05
    Sub sendcheatUI2G()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/emoji/custom/UI2G")
            Dim di1 As New DirectoryInfo(Application.StartupPath & "/emoji/custom/TopMenu")
            Dim ftp As New FTP("", "")


            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/vsh_asset/" & fi.Name)
                End If

            Next
            For Each fi As FileInfo In di1.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/system_ex/app/NPXS20001/psm/Application/resource/" & fi.Name)
                End If

            Next

            MsgBox(" GreenY !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing ?", "GreenY", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        Try

            If overwrite = DialogResult.No Then

            ElseIf ow = DialogResult.Yes Then

            ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
                MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            Else
                My.Settings.IP = TextBox1.Text
                Me.UseWaitCursor = True
                sendcheatUI2G()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '🎁🍲🍳🍴🍵🍶🍷🍸🍹🎀🎂🍀
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As String = TextBox17.Text
        txt = txt.Replace("a", "🍅")
        txt = txt.Replace("b", "🍇")
        txt = txt.Replace("c", "🍈")
        txt = txt.Replace("d", "🍉")
        txt = txt.Replace("e", "🍐")
        txt = txt.Replace("f", "🍑")
        txt = txt.Replace("g", "🍒")
        txt = txt.Replace("h", "🍓")
        txt = txt.Replace("i", "🍔")
        txt = txt.Replace("j", "🍕")
        txt = txt.Replace("k", "🍖")
        txt = txt.Replace("l", "🍗")
        txt = txt.Replace("m", "🍘")
        txt = txt.Replace("n", "🍙")
        txt = txt.Replace("o", "🍠")
        txt = txt.Replace("p", "🍡")
        txt = txt.Replace("q", "🍢")
        txt = txt.Replace("r", "🍣")
        txt = txt.Replace("s", "🍤")
        txt = txt.Replace("t", "🍥")
        txt = txt.Replace("u", "🍦")
        txt = txt.Replace("v", "🍧")
        txt = txt.Replace("w", "🍨")
        txt = txt.Replace("y", "🍰")
        txt = txt.Replace("x", "🍩")
        txt = txt.Replace("z", "🍱")
        txt = txt.Replace("A", "🌑")
        txt = txt.Replace("B", "🌒")
        txt = txt.Replace("C", "🌓")
        txt = txt.Replace("D", "🌔")
        txt = txt.Replace("E", "🌕")
        txt = txt.Replace("F", "🌖")
        txt = txt.Replace("G", "🌴")
        txt = txt.Replace("H", "🌤")
        txt = txt.Replace("I", "🌥")
        txt = txt.Replace("J", "🌦")
        txt = txt.Replace("K", "🌧")
        txt = txt.Replace("L", "🌨")
        txt = txt.Replace("M", "🌩")
        txt = txt.Replace("N", "🌱")
        txt = txt.Replace("O", "🌲")
        txt = txt.Replace("P", "🌳")
        txt = txt.Replace("Q", "🌴")
        txt = txt.Replace("R", "🌵")
        txt = txt.Replace("S", "🌷")
        txt = txt.Replace("T", "🌸")
        txt = txt.Replace("U", "🌹")
        txt = txt.Replace("V", "🍀")
        txt = txt.Replace("W", "🍁")
        txt = txt.Replace("Y", "🍃")
        txt = txt.Replace("X", "🍂")
        txt = txt.Replace("Z", "🍄")
        txt = txt.Replace("0", "🎁")
        txt = txt.Replace("1", "🍲")
        txt = txt.Replace("2", "🍳")
        txt = txt.Replace("3", "🍴")
        txt = txt.Replace("4", "🍵")
        txt = txt.Replace("5", "🍶")
        txt = txt.Replace("6", "🍷")
        txt = txt.Replace("7", "🍸")
        txt = txt.Replace("8", "🍹")
        txt = txt.Replace("9", "🎀")
        txt = txt.Replace(".", "🎂")


        TextBox18.Text = txt
    End Sub
    '🎁🍲🍳🍴🍵🍶🍷🍸🍹🎀🎂🍀
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txt As String = TextBox75.Text
        txt = txt.Replace("🍅", "a")
        txt = txt.Replace("🍇", "b")
        txt = txt.Replace("🍈", "c")
        txt = txt.Replace("🍉", "d")
        txt = txt.Replace("🍐", "e")
        txt = txt.Replace("🍑", "f")
        txt = txt.Replace("🍒", "g")
        txt = txt.Replace("🍓", "h")
        txt = txt.Replace("🍔", "i")
        txt = txt.Replace("🍕", "j")
        txt = txt.Replace("🍖", "k")
        txt = txt.Replace("🍗", "l")
        txt = txt.Replace("🍘", "m")
        txt = txt.Replace("🍙", "n")
        txt = txt.Replace("🍠", "o")
        txt = txt.Replace("🍡", "p")
        txt = txt.Replace("🍢", "q")
        txt = txt.Replace("🍣", "r")
        txt = txt.Replace("🍤", "s")
        txt = txt.Replace("🍥", "t")
        txt = txt.Replace("🍦", "u")
        txt = txt.Replace("🍧", "v")
        txt = txt.Replace("🍨", "w")
        txt = txt.Replace("🍰", "y")
        txt = txt.Replace("🍩", "x")
        txt = txt.Replace("🍱", "z")
        txt = txt.Replace("🌑", "A")
        txt = txt.Replace("🌒", "B")
        txt = txt.Replace("🌓", "C")
        txt = txt.Replace("🌔", "D")
        txt = txt.Replace("🌕", "E")
        txt = txt.Replace("🌖", "F")
        txt = txt.Replace("🌴", "G")
        txt = txt.Replace("🌤", "H")
        txt = txt.Replace("🌥", "I")
        txt = txt.Replace("🌦", "J")
        txt = txt.Replace("🌧", "K")
        txt = txt.Replace("🌨", "L")
        txt = txt.Replace("🌩", "M")
        txt = txt.Replace("🌱", "N")
        txt = txt.Replace("🌲", "O")
        txt = txt.Replace("🌳", "P")
        txt = txt.Replace("🌴", "Q")
        txt = txt.Replace("🌵", "R")
        txt = txt.Replace("🌷", "S")
        txt = txt.Replace("🌸", "T")
        txt = txt.Replace("🌹", "U")
        txt = txt.Replace("🍀", "V")
        txt = txt.Replace("🍁", "W")
        txt = txt.Replace("🍃", "Y")
        txt = txt.Replace("🍂", "X")
        txt = txt.Replace("🍄", "Z")
        txt = txt.Replace("🎁", "0")
        txt = txt.Replace("🍲", "1")
        txt = txt.Replace("🍳", "2")
        txt = txt.Replace("🍴", "3")
        txt = txt.Replace("🍵", "4")
        txt = txt.Replace("🍶", "5")
        txt = txt.Replace("🍷", "6")
        txt = txt.Replace("🍸", "7")
        txt = txt.Replace("🍹", "8")
        txt = txt.Replace("🎀", "9")
        txt = txt.Replace("🎂", ".")

        TextBox74.Text = txt

    End Sub


End Class
