Friend Module Program

    <STAThread()>
    Friend Sub Main(args As String())
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        
        ' Initialize Database
        Utils.DatabaseHelper.InitializeDatabase()
        
        Application.Run(New Forms.LoginForm)
    End Sub

End Module
