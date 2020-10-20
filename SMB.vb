Module SMB

    Public Sub CriticalError()
        MsgBox("An critical error occurenced and the program will now close. Contact the program author for more details.", MsgBoxStyle.Critical, Application.ProductName)
        ' Custom program
        Form1.Close()
        'ENDS HERE
    End Sub
    Public Sub InfoBox()
        MsgBox("You can custom this information box.", MsgBoxStyle.Information, Application.ProductName)
        ' Custom program

        'ENDS HERE
    End Sub
    Public Sub AlertBox()
        MsgBox("You can custom this alert box.", MsgBoxStyle.Exclamation, Application.ProductName)
        ' Custom program

        'ENDS HERE
    End Sub
End Module
