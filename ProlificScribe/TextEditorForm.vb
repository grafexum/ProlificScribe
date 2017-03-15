'2016.09.16
'Charles DeGrapharee Exum
'http://www.github.com/grafexum
Public Class TextEditorForm
#Region "Declarations"

    'Dim cs_CopiedTextBoxContents As String 'Stuff selected contents of the rtf box into here
    Dim mi_TabCount As Integer = 0

#End Region

#Region "Properties"

    Private ReadOnly Property GetCurrentDocument() As RichTextBox
        Get
            Return CType(TabControl1.SelectedTab.Controls.Item("Body"), RichTextBox)
        End Get
    End Property

#End Region

#Region "Form-Level Methods"

#Region "Tab Controls"
    Private Sub AddTab()
        Dim Body As New RichTextBox()

        Body.Name = "Body"
        Body.Dock = DockStyle.Fill
        Body.ContextMenuStrip = ContextMenuStrip

        Dim NewPage As New TabPage()
        mi_TabCount = mi_TabCount + 1

        Dim DocumentText As String = "Document " & mi_TabCount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        TabControl1.TabPages.Add(NewPage)

    End Sub

    Private Sub RemoveTab()
        If TabControl1.TabPages.Count > 1 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            AddTab()
        End If
    End Sub

    Private Sub RemoveAllTabs()
        Dim TabCount As Integer = TabControl1.TabPages.Count

        For count As Integer = 0 To TabCount - 1 Step +1
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        Next
        AddTab()
        mi_TabCount = mi_TabCount - 1 'most certainly not the best way to handle this...
        RemoveTab()

    End Sub

    Private Sub RemoveAllButThisTab()
        For Each page As TabPage In TabControl1.TabPages
            If Not page.Name = TabControl1.SelectedTab.Name Then
                TabControl1.TabPages.Remove(page)
            End If
        Next
    End Sub

    Private Sub InsertTab_Click(sender As System.Object, e As System.EventArgs) Handles InsertTab.Click
        AddTab()
    End Sub

    Private Sub RemTab_Click(sender As System.Object, e As System.EventArgs) Handles RemTab.Click
        RemoveTab()
    End Sub

    Private Sub PurgeTabs_Click(sender As System.Object, e As System.EventArgs) Handles PurgeTabs.Click
        RemoveAllTabs()
    End Sub

    Private Sub RetainThisTab_Click(sender As System.Object, e As System.EventArgs) Handles RetainTab.Click
        RemoveAllButThisTab()
    End Sub

#End Region

#Region "File Handling"

    Private Sub SaveAs_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click

        Try

            Dim mo_SaveTxtFileDialog As New SaveFileDialog()
            mo_SaveTxtFileDialog.Filter = "Txt File|*.txt|Rtf File|*.rtf|VB File|*.vb|c# File|*.cs"
            mo_SaveTxtFileDialog.DefaultExt = "txt"
            'mo_SaveTxtFileDialog.ShowDialog()

            Dim result As System.Nullable(Of Boolean) = mo_SaveTxtFileDialog.ShowDialog()
            If result = True Then

                Dim fileStream As System.IO.Stream = mo_SaveTxtFileDialog.OpenFile()
                Dim sw As New System.IO.StreamWriter(fileStream)
                sw.WriteLine(GetCurrentDocument().Text)
                sw.Flush()
                sw.Close()
            End If

            If result = False Then
                Return
            End If

        Catch ex As Exception

            MessageBox.Show("There was a problem saving the file.")

        End Try

    End Sub

    Private Sub OpenSesame_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        Try


            Dim mo_OpenTxtFileDialog As New OpenFileDialog()
            mo_OpenTxtFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            mo_OpenTxtFileDialog.Filter = "Txt File|*.txt|Rtf File|*.rtf|VB File|*.vb|c# File|*.cs"

            If mo_OpenTxtFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If mo_OpenTxtFileDialog.FileName.Length > 0 Then
                    GetCurrentDocument().LoadFile(mo_OpenTxtFileDialog.FileName, RichTextBoxStreamType.PlainText)
                End If
            End If

        Catch ex As Exception

            MessageBox.Show("There was a problem opening the file.")

        End Try
    End Sub
#End Region

#Region "System"

    Private Sub exitprolificscript_click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("ProlificScribe v1.1" & vbCrLf & "A redefinition of generic text manipulation.")
    End Sub

#End Region

#Region "Text Manipulation"

    Private Sub NewDocument_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        AddTab()

        'Old stuff before I added in tab functionality
        'If RichTextBox1.Text <> "" Then
        '    If MessageBox.Show("Do you want to save the current document?", "Save..?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '        SaveAs_Click(sender, e)
        '    End If
        '    RichTextBox1.Text = ""
        'End If
    End Sub

    Private Sub ColorOptions_Click(Sender As System.Object, e As System.EventArgs) Handles ColorOptions.Click
        Dim mo_ManipulateTextColor As New ColorDialog
        mo_ManipulateTextColor.ShowDialog()
        GetCurrentDocument().SelectionColor = mo_ManipulateTextColor.Color
    End Sub

    Private Sub FontOptions_Click(sender As System.Object, e As System.EventArgs) Handles ChangeFont.Click
        Dim mo_ManipulateFonts As New FontDialog()
        mo_ManipulateFonts.ShowDialog()
        GetCurrentDocument().Font = mo_ManipulateFonts.Font
    End Sub

    Private Sub CopyText_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If GetCurrentDocument().SelectionLength <> 0 Then
            GetCurrentDocument().Copy()
        End If
    End Sub

    Private Sub CutText_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        If GetCurrentDocument().SelectionLength <> 0 Then
            GetCurrentDocument().Cut()
        End If
    End Sub

    Private Sub PasteText_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
            ' Determine if any text is selected in the text box.
            If GetCurrentDocument().SelectionLength > 0 Then
                ' Ask user if they want to paste over currently selected text.
                If MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) = DialogResult.No Then
                    ' Move selection to the point after the current selection and paste.
                    GetCurrentDocument().SelectionStart = GetCurrentDocument().SelectionStart + _
                        GetCurrentDocument().SelectionLength
                End If
            End If
            ' Paste current text in Clipboard into text box.
            GetCurrentDocument().Paste()
        End If
    End Sub

    Private Sub GetWordCount_Click(sender As System.Object, e As System.EventArgs) Handles WordCountToolStripMenuItem.Click

    End Sub

#End Region

#End Region

#Region "Utilitarian Methods"

    Private Sub TextEditorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddTab()
    End Sub

    'Private Function ReturnRichTextBoxText() As String
    '    Return RichTextBox1.Text
    'End Function

#End Region

End Class
