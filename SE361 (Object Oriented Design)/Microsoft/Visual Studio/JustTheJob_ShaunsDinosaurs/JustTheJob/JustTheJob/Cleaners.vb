Public Class Cleaners
    Dim cleanerlist = New clsCleanerList


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addcleaner.Click
        'create a new Cleaner object
        Dim objCleaner As New clsCleaner


        Try
            'populate the Contact object with the data from the GUI form
            objCleaner.strFirstName = CStr(txt_cleanersfirstname.Text)
            objCleaner.strLastName = CStr(txt_cleanerslastname.Text)
            objCleaner.strPhone = CStr(txt_cleanersphone.Text)
            objCleaner.strCellphone = CStr(txt_cleanersphone2.Text)
            objCleaner.strEmail = CStr(txt_cleanersemail.Text)
            objCleaner.strAddress = CStr(txt_cleanersaddress.Text)
            objCleaner.strCity = CStr(txt_cleanerscity.Text)

            'Add the object into the list
            cleanerlist.addNewCleaner(objCleaner)

            'Add the object into the database 
            Dim entry As DataRow
            entry = JustTheJobDataSet.Tables(0).NewRow

            entry.Item("cleanerLastName") = objCleaner.lastname
            entry.Item("cleanerFirstName") = objCleaner.firstname
            entry.Item("cleanerPhone") = objCleaner.phone
            entry.Item("cleanerEmail") = objCleaner.email
            entry.Item("cleanerAddress") = objCleaner.address
            entry.Item("cleanerCity") = objCleaner.city
            entry.Item("cleanerCellphone") = objCleaner.cellphone

            JustTheJobDataSet.Tables(0).Rows.Add(entry)
            CleanersTableAdapter.Update(entry) 'displays it



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try



    End Sub

    Private Sub Cleaners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JustTheJobDataSet.Cleaners' table. You can move, or remove it, as needed.
        Me.CleanersTableAdapter.Fill(Me.JustTheJobDataSet.Cleaners)
        Dim objCleaner As New clsCleaner
        btn_removecleaner.Enabled = MainMenu.adminuser


    End Sub

    Private Sub btn_removecleaner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_removecleaner.Click

        Try
            CleanersBindingSource.RemoveCurrent()

            Me.CleanersTableAdapter.Update(Me.JustTheJobDataSet.Tables("Cleaners"))
            JustTheJobDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try

    End Sub
End Class