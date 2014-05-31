'Need to import the following library for file manipulation
Imports System.IO

Public Class clsContactsDirectory

    Private strDirectoryName As String

    Public Sub New()
        strDirectoryName = String.Empty
    End Sub

    Public Property name As String
        Get
            Return strDirectoryName
        End Get
        Set(ByVal value As String)
            strDirectoryName = value
        End Set
    End Property

    'it takes a list-of-contacts parameter as a ListBox 
    'it then saves all data from the ListBox onto a text file
    Public Sub saveToFile(ByVal contactsList As ListBox)

        'create a stream writer object
        Dim objContactsFile As StreamWriter

        Try

            'Open a given text file for appending data to it
            objContactsFile = File.AppendText(strDirectoryName)

            'Write all contact information to the file
            For i = 0 To contactsList.Items.Count - 1
                objContactsFile.WriteLine(contactsList.Items(i))
            Next

            'Close the file when finished
            objContactsFile.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    'it retrieves all contact infromation from a selected file
    'and then it sends them back to the frmMain to be displayed in the GUI listbox
    Public Sub readFromFile(ByRef contactsList As ListBox)

        'create a stream reader object variable
        Dim objContactsFile As StreamReader

        Try
            'Open the text file to read from it
            objContactsFile = File.OpenText(strDirectoryName)

            While objContactsFile.Peek <> -1    'while end-of-file
                'Read a line from the file and store it in the contactsList box
                contactsList.Items.Add(objContactsFile.ReadLine())
            End While

            'Close the file
            objContactsFile.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub
End Class
