Public Class creativeChecklist

    Public Property ControlNum As String
        Get
            Return lblControlNum.Text
        End Get
        Set(value As String)
            lblControlNum.Text = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return lblTitle.Text
        End Get
        Set(value As String)
            lblTitle.Text = value
        End Set
    End Property

    Public Property ClientName As String
        Get
            Return lblClientName.Text
        End Get
        Set(value As String)
            lblClientName.Text = value
        End Set
    End Property

    Public Property SenderName As String
        Get
            Return lblSenderName.Text
        End Get
        Set(value As String)
            lblSenderName.Text = value
        End Set
    End Property

    Public Property DateCreated As String
        Get
            Return lblDateCreated.Text
        End Get
        Set(value As String)
            lblDateCreated.Text = value
        End Set
    End Property

    Public Property DateModified As String
        Get
            Return lblDateModified.Text
        End Get
        Set(value As String)
            lblDateModified.Text = value
        End Set
    End Property

    Public Property PreviousDept As String
        Get
            Return lblPrevDept.Text
        End Get
        Set(value As String)
            lblPrevDept.Text = value
        End Set
    End Property
    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get
        Set(value As String)
            lblStatus.Text = value
        End Set
    End Property

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

    End Sub
End Class
