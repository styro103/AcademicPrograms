Public Class Clients
    Dim clientlist = New clsClientList         'this will hold all the different clients locally.


    Private Sub Clients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JustTheJobDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.JustTheJobDataSet.Clients)
        btn_removeclient.Enabled = MainMenu.adminuser

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addclient.Click
        'create a new Cleaner object
        Dim objClient As New clsClient

        Try
            'populate the Contact object with the data from the GUI form
            objClient.strFirstName = CStr(txt_clientsfirstname.Text)
            objClient.strLastName = CStr(txt_clientslastname.Text)
            objClient.strPhone = CStr(txt_clientsphone.Text)
            objClient.strCellphone = CStr(txt_clientsphone2.Text)
            objClient.strEmail = CStr(txt_clientsemail.Text)
            objClient.strAddress = CStr(txt_clientsaddress.Text)
            objClient.strCity = CStr(txt_clientscity.Text)

            'Add the object into the list
            clientlist.addNewClient(objClient)

            'Add the object into the database 
            Dim entry As DataRow
            entry = JustTheJobDataSet.Tables(1).NewRow 'creates a new empty row in the database

            entry.Item("clientLastName") = objClient.lastname
            entry.Item("clientFirstName") = objClient.firstname
            entry.Item("clientPhone") = objClient.phone
            entry.Item("clientEmail") = objClient.email
            entry.Item("clientAddress") = objClient.address
            entry.Item("clientCity") = objClient.city
            entry.Item("clientCellphone") = objClient.cellphone

            JustTheJobDataSet.Tables(1).Rows.Add(entry) 'adds to database
            ClientsTableAdapter.Update(entry) 'displays it locally

            MessageBox.Show("Great Success! New client added to database.")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addjobforclient.Click
        Jobs.Show()
        Jobs.txt_jobaddress.Text = txt_clientsaddress.Text
        Jobs.txt_jobcity.Text = txt_clientscity.Text
    End Sub


    Private Sub btn_removeclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_removeclient.Click
        Try
            ClientsBindingSource.RemoveCurrent()

            Me.ClientsTableAdapter.Update(Me.JustTheJobDataSet.Tables("Clients"))
            JustTheJobDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try

    End Sub


End Class