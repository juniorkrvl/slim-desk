
Imports System.IO
Imports Microsoft.Win32
Imports IWshRuntimeLibrary
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    Public Shared allfiles() As String
    Public Shared alldirs() As String

    Dim loading As Boolean = False
    Dim frmSplash As Splash

    Dim cl As New ClDatabase

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadConfs()
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If 0 = 1 Then 'conf.LimpezaAutomatica Then
            Limpar()
        End If
    End Sub

    Sub Limpar()

        processFolders()
        processFiles()

    End Sub

    Sub processFiles()

        allfiles = Directory.GetFiles(Core.Desktop, "*.*", SearchOption.TopDirectoryOnly)

        If allfiles.Length > 0 Then

            For Each s As String In allfiles

                Dim achou As Boolean = False

                Dim file As New FileInfo(s)
                file.Attributes = FileAttributes.Normal

                Dim e As New ExtensoesGrupo
                e.Extensao = file.Extension.Replace(".", "")

                For Each g As Grupo In config.Grupos

                    Dim emp As New ExtensoesGrupo
                    emp = g.Extensoes.Find(Function(ex)
                                               Return (ex.Extensao = e.Extensao.ToLower)
                                           End Function)

                    If Not IsNothing(emp) Then
                        If Not Directory.Exists(Core.slimfolder & "\" & g.Grupo) Then
                            Directory.CreateDirectory(Core.slimfolder & "\" & g.Grupo)
                        End If

                        If IO.File.Exists(Core.slimfolder & "\" & g.Grupo & "\" & file.Name.Replace(file.Extension, "") & file.Extension) Then
                            Dim cont As Integer = 1
                            While IO.File.Exists(Core.slimfolder & "\" & g.Grupo & "\" & file.Name.Replace(file.Extension, "") & cont & file.Extension)
                                cont += 1
                            End While

                            file.MoveTo(Core.slimfolder & "\" & g.Grupo & "\" & file.Name.Replace(file.Extension, "") & cont & file.Extension)
                        Else
                            file.MoveTo(Core.slimfolder & "\" & g.Grupo & "\" & file.Name)
                        End If

                        achou = True

                        Exit For
                    Else
                        ' If conf.PastaOutros Then

                        'End If

                    End If

                Next

                If Not achou Then
                    If config.PastaOutros Then

                        If Not IO.Directory.Exists(Core.slimfolder & "\Outros") Then
                            Directory.CreateDirectory(Core.slimfolder & "\Outros")
                        End If

                        Dim nome As String = file.Name
                        If file.Extension.Trim.Length > 0 Then nome = file.Name.Replace(file.Extension, "")

                        If IO.File.Exists(Core.slimfolder & "\Outros\" & nome & file.Extension) Then
                            Dim cont As Integer = 1
                            While IO.File.Exists(Core.slimfolder & "\Outros" & file.Name.Replace(file.Extension, "") & cont & file.Extension)
                                cont += 1
                            End While

                            file.MoveTo(Core.slimfolder & "\Outros" & file.Name.Replace(file.Extension, "") & cont & file.Extension)
                        Else
                            file.MoveTo(Path.Combine(Core.slimfolder, "Outros", file.Name))
                        End If


                    End If
                End If


            Next





        End If

    End Sub

    Sub processFolders()

        If Directory.Exists(Core.Desktop) Then

            If Not Directory.Exists(Core.slimfolder) Then
                Directory.CreateDirectory(Core.slimfolder)
            End If

            'getfolders
            alldirs = Directory.GetDirectories(Core.Desktop, "*.*", SearchOption.TopDirectoryOnly)

            'movefolders
            If alldirs.Length > 0 Then
                If Not Directory.Exists(Core.Folders) Then
                    Directory.CreateDirectory(Core.Folders)
                End If

                For Each s As String In alldirs
                    If Not s = Core.slimfolder Then
                        Dim dir As DirectoryInfo = New DirectoryInfo(s)
                        dir.Attributes = FileAttributes.Normal
                        Try
                            dir.MoveTo((Core.Folders & "\" & dir.Name))
                        Catch ex As IO.IOException
                            Dim cont As Integer = 1
                            While Directory.Exists((Core.Folders & "\" & dir.Name & "_" & cont))
                                cont += 1
                            End While
                            Try
                                dir.MoveTo((Core.Folders & "\" & dir.Name & "_" & cont))
                            Catch ex1 As Exception
                            End Try
                        End Try
                    End If
                Next

            End If

        End If

    End Sub

    Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            ' Image.FromFile throws an OutOfMemoryException  
            ' if the file does not have a valid image format or 
            ' GDI+ does not support the pixel format of the file. 
            ' 
            Return False
        End Try
        Return True
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = False
        End If
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim frm As New FrmConf
        frm.Show()
    End Sub


    Private Sub LimparAgoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparAgoraToolStripMenuItem.Click
        Limpar()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Notify.Dispose()
        End
    End Sub


    Sub loadConfs()

        Try

            'carrega splash
        frmSplash = New Splash
        frmSplash.Show()
        Splash.Enabled = True
        loading = True

        If Not Directory.Exists(slimfolder) Then
            Directory.CreateDirectory(slimfolder)
            'insere icone

            Dim folder As DirectoryInfo
            Dim filename As String = "desktop.ini"
            folder = New DirectoryInfo(slimfolder)
            filename = Path.Combine(slimfolder, filename)


            Using sw As StreamWriter = New StreamWriter(filename)
                sw.WriteLine("[.ShellClassInfo]")
                'sw.WriteLine("ConfirmFileOp={0}", confirmDelete)
                'sw.WriteLine("NoSharing={0}", preventSharing)
                sw.WriteLine("IconFile={0}", Path.GetDirectoryName(Application.ExecutablePath) & "\slimDesk.exe")
                sw.WriteLine("IconIndex={0}", 0)
                'sw.WriteLine("InfoTip={0}", ToolTip)
                sw.Close()
            End Using

            folder.Attributes = folder.Attributes Or FileAttributes.System
            IO.File.SetAttributes(filename, IO.File.GetAttributes(filename) Or FileAttributes.Hidden)

        End If

        If Not IO.File.Exists(userfolder & "\Links\Slimdesk.lnk") Then
            Dim shell As New WshShell
            Dim link As IWshShortcut = shell.CreateShortcut(userfolder & "\Links\Slimdesk.lnk")
            link.TargetPath = slimfolder
            link.Save()
        End If



        If Not IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SlimDesk" & "\config.desk") Then
            config = New Configuracao
                config.Grupos = cl.retGrupos

                If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SlimDesk") Then
                    IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SlimDesk")
                End If

            Serialize(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SlimDesk" & "\config.desk", config)
        Else
            config = Deserialize(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SlimDesk" & "\config.desk")
        End If

            loading = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Splash_Tick(sender As Object, e As EventArgs) Handles Splash.Tick

        If loading = False Then
            Splash.Enabled = False
            If Not IsNothing(frmSplash) Then
                frmSplash.Close()
            End If
        End If

    End Sub

    Private Sub Notify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Notify.MouseDoubleClick
        Dim win As String = Environment.GetEnvironmentVariable("WINDIR")
        Dim prc As System.Diagnostics.Process = New System.Diagnostics.Process()
        prc.StartInfo.FileName = win & "\explorer.exe"
        prc.StartInfo.Arguments = slimfolder
        prc.Start()
    End Sub
End Class
