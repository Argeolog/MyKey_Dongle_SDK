Imports System.Runtime.InteropServices

Module Modul
    Const LibName As String = "System.My.Data.dll"
    <DllImport(LibName)> Public Function Login(ByVal KeyData As String, ByVal Pin As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Serial_No_Read() As IntPtr
    End Function

    <DllImport(LibName)> Public Function Device_Model_Read() As IntPtr
    End Function
    <DllImport(LibName)> Public Function Device_Firmware_Read() As IntPtr
    End Function

    <DllImport(LibName)> Public Function Pin_Write(Parametre As String, YeniPin As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Read_Protected_Data(SessionID As String, ByVal Pin As String, ByVal Adres As Integer, ByVal Key As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Write_Protected_Data(SessionID As String, ByVal Pin As String, ByVal Adres As Integer, ByVal Key As String, ByVal Data As String, ByVal WRMode As String) As IntPtr
    End Function

    <DllImport(LibName)> Public Function Parametreleri_Yukle(CihazParametre As String, ByVal DefaultPin As String, ByVal PinParametre As String) As IntPtr
    End Function





End Module
