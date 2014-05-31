Public Class clsDependentList

    Dim dependents As New Collection 'implements a one-to-many association between clsDependentList and clsDependent

    Public Sub AddNewDependent(ByVal name As String, ByVal age As Integer, ByVal address As String)
        Try
            Dim objDependent As New clsDependent

            objDependent.Name = name
            objDependent.Age = age
            objDependent.Address = address

            dependents.Add(objDependent)

            MessageBox.Show("The following depedent object was added:" & vbTab & objDependent.Name &
                             vbTab & objDependent.Age & vbTab & objDependent.Address, "Creation Successful")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Public Function retrieveDependents() As String

        Dim strOut As String = ""
        Dim dependent As clsDependent

        Try
            For Each dependent In dependents
                strOut &= dependent.Name & vbTab & dependent.Age & vbTab &
                    dependent.Address & vbCrLf
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

        Return strOut

    End Function
End Class
