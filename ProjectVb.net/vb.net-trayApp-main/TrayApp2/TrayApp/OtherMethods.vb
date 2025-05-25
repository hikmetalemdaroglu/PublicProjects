Friend Module otherMethods

    Private PF As PopupForm

    Public Sub exitApplication()
        'Perform any clean-up here
        'Then exit the application
        Application.Exit()
    End Sub

    Public Sub showDialog()
        If PF IsNot Nothing AndAlso Not PF.IsDisposed Then Exit Sub

        Dim CloseApp As Boolean

        PF = New PopupForm
        PF.ShowDialog()
        CloseApp = (PF.DialogResult = DialogResult.Abort)
        PF = Nothing

        If CloseApp Then Application.Exit()
    End Sub

End Module
