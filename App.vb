Module App
    Public Sub AddToListView(index As Integer, item As Array, listView As ListView)
        Dim list As New ListViewItem
        If item.Length = 0 Then
            Return
        End If
        list.Text = item(0)
        For i As Integer = 1 To listView.Columns.Count
            If i < item.Length Then
                list.SubItems.Add(item(i))
            End If
        Next
        listView.Items.Insert(index, list)
    End Sub

    Public Sub Save(fileName As String, listView As ListView)
        Dim file As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
        For Each item As ListViewItem In listView.Items
            Dim i As Integer = 0
            For Each subItem In item.SubItems
                If i < item.SubItems.Count - 1 Then
                    file.Write(subItem.Text & ",")
                Else
                    file.Write(subItem.Text)
                End If
                i += 1
            Next
            file.WriteLine()
        Next
        file.Close()
    End Sub

    Public Function Load(fileName As String) As List(Of ListViewItem)
        Dim file As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(fileName)
        Dim list As New List(Of ListViewItem)
        While Not file.EndOfStream
            Dim itemString As String = file.ReadLine()
            Dim itemArray = itemString.Split(New Char() {","c})
            Dim item As New ListViewItem
            Dim count As String = 0
            For Each i In itemArray
                If count = 0 Then
                    item.Text = i
                Else
                    item.SubItems.Add(i)
                End If
                count += 1
            Next
            list.Add(item)
        End While
        file.Close()
        Return list
    End Function

    Public Function GetPrice(index As Integer) As Double
        Dim prices = Load("../../database/price.txt")
        If index < prices(0).SubItems.Count And index >= 0 Then
            Return prices(0).SubItems(index).Text
        End If
        Return 0
    End Function

    Public Function Exist(key As String, fileName As String, index As Integer)
        Dim data = App.Load(fileName)
        Dim relative As Boolean = False
        For Each d1 In data
            If d1.SubItems(index).Text.CompareTo(key) = 0 Then
                relative = True
            End If
        Next
        Return relative
    End Function

    Public Function Count(fileName As String)
        Dim data = App.Load(fileName)
        Return data.Count
    End Function
End Module
