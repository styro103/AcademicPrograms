'Author: Panos Linos
'Project: ReadWriteToFile
'Description: This application allows the user to enter data about personal contacts and then save it to a directory.
'It uses two classes as follows: 
'1) The Contact class for storing data about a contact and creating the full name
'2) The ContactsDirectory class which provides a save-to-a-file and a load-from-a-file services

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEmail.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhoneNumber.Clear()
        txtFirstName.Focus()
        lstDirectory.Items.Clear()
    End Sub

    Private Sub btnSaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFile.Click
        'create a ContactsDirectory object
        Dim objDirectory As New clsContactsDirectory

        Try
            'the following piece of code is used to open a file dialog window
            'and allow the user to select a file to save onto

            'create dialog box to select file from
            Dim fileChooser As New OpenFileDialog

            'record the action taken in the dialog box
            Dim result As DialogResult = fileChooser.ShowDialog

            If result = DialogResult.Cancel Then
                MessageBox.Show("Please specify file name.",
                                "Contacts Directory Application",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            Else

                'get and save the selected file name
                objDirectory.name = fileChooser.FileName

                If objDirectory.name <> "" Then
                    'save all contact info found in the GUI listbox into a text file directory
                    objDirectory.saveToFile(lstDirectory)
                    MessageBox.Show("Successful file save at " & objDirectory.name,
                                    "Save File Status",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub btnReadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFromFile.Click
        'create a ContactsDirectory object
        Dim objDirectory As New clsContactsDirectory

        Try
            'the following piece of code is used to open a file dialog window
            'and allow the user to select a file to read/load data from

            'create dialog box to select file from
            Dim fileChooser As New OpenFileDialog

            'record the action taken in the dialog box
            Dim result As DialogResult = fileChooser.ShowDialog

            If result = DialogResult.Cancel Then
                MessageBox.Show("Please specify file name.",
                                "Contacts Directory Application",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            Else
                'get and save the selected file name
                objDirectory.name = fileChooser.FileName

                If objDirectory.name <> "" Then
                    'read all the data from the selected text file
                    'and display it on the GUI listbox
                    objDirectory.readFromFile(lstDirectory)
                    MessageBox.Show("Successful file load from " & objDirectory.name,
                                    "Load File Status",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub btnAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToList.Click
        'create a new Contact object
        Dim objContact As New clsContact

        Try
            'populate the Contact object with the data from the GUI form
            objContact.firstname = CStr(txtFirstName.Text)
            objContact.lastname = CStr(txtLastName.Text)
            objContact.phonenumber = CStr(txtPhoneNumber.Text)
            objContact.email = CStr(txtEmail.Text)

            'Display the Contact info in the list box
            lstDirectory.Items.Add(objContact.fullName & vbTab &
                                   objContact.phonenumber & vbTab &
                                   objContact.email)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub
End Class
