Module Module1
    Public strSqlConnection = "Server=10.10.10.15\SQL2000;Database=AnlisDepTestE;User=usrstck;Password=admin123;Trusted_Connection=False"
    Public strSqlConnectionCtrl = "Server=10.10.10.15\SQL2000;Database=AnlisControl;User=usrstck;Password=admin123;Trusted_Connection=False"
    Public DestinoCod As String
    Public DestinoDesc As String
    Public NroSolConsumo As Long
    Public Const OpCons As Integer = 0
    Public Const OpAlta As Integer = 1
    Public Const OpModi As Integer = 2
    Public Const OpBaja As Integer = 3
    Public gFormatCantM = "########0.00"

    Public Function FormatNM(ByVal Nro As Double, ByVal Longitud As Integer, ByVal Mascara As String) As String
        Dim NroTexto As String
        NroTexto = Format(Nro, Mascara)
        If Len(NroTexto) < Longitud Then
            NroTexto = Space(Longitud - Len(NroTexto)) + NroTexto
        End If
        FormatNM = NroTexto
    End Function

    Public Function GetsServidorFromRegistry() As String
        Dim readValue, Ret, cl As String

        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Nothing)
        If readValue Is Nothing Then

            Ret = InputBox("Codigo", "Ingreso de Servidor")
            cl = LTrim(Str(Hour(Now))) + LTrim(Str(Year(Now))) + LTrim(Str(Month(Now)))
            If Ret = LTrim(Str(Hour(Now))) + LTrim(Str(Year(Now))) Then
                Ret = InputBox("Servidor", "Ingreso de Servidor")
                My.Computer.Registry.CurrentUser.CreateSubKey("AnlisStock")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Ret)
                readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Nothing)
            ElseIf Ret = "C2013" Then
                My.Computer.Registry.CurrentUser.CreateSubKey("AnlisStock")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", "ARAMIS\SQLEXPRESS")
                readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Nothing)
            ElseIf Ret = "F2013" Then 'Fatala
                My.Computer.Registry.CurrentUser.CreateSubKey("AnlisStock")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", "\SQLEXPRESS")
                readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Nothing)
            ElseIf Ret = "J2013" Then 'Fatala
                My.Computer.Registry.CurrentUser.CreateSubKey("AnlisStock")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", "DATOS\SQLEXPRESS")
                readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\AnlisStock", "Servidor", Nothing)
            Else
                readValue = ""
            End If

        End If
        'MsgBox("The value is " & readValue)
        GetsServidorFromRegistry = readValue
    End Function
    Public Function NoNull(ByVal Dato As Object) As String
        'Verifica si el campo es Null y devuelve blanco
        '
        If Not IsDBNull(Dato) Then NoNull = Dato
    End Function
    Public Function sRight(ByVal dato As String, ByVal nlargo As Integer) As String
        Dim largo As Integer
        largo = Len(dato)  '123456789
        sRight = Mid(dato, largo - nlargo + 1)
    End Function





    Public Function SinApostrofes(ByVal Dato As String) As String
        Dim Texto As String
        Dim TextoTmp As String
        Dim PosiA As Integer
        Texto = Dato
        Do
            PosiA = InStr(1, Texto, "'")
            If PosiA > 0 Then
                TextoTmp = ""
                If PosiA > 1 Then TextoTmp = Left(Texto, PosiA - 1)
                TextoTmp = TextoTmp + Mid(Texto, PosiA + 1)
                Texto = TextoTmp
            End If
        Loop Until PosiA = 0


        SinApostrofes = Texto

    End Function


  
End Module
