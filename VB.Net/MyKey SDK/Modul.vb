Imports System.Runtime.InteropServices

Module Modul
    Const LibName As String = "System.My.Data.dll"
    <DllImport(LibName)> Public Function Login(ByVal CihazParametre As String, ByVal Pin As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Serial_No_Read() As IntPtr
    End Function
    <DllImport(LibName)> Public Function Serial_No_Write(SerialNo As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Device_Model_Read() As IntPtr
    End Function
    <DllImport(LibName)> Public Function Device_Firmware_Read() As IntPtr
    End Function
    <DllImport(LibName)> Public Function Pin_Write(PinParametre As String, YeniPin As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Write_Protected_Data(SessionID As String, ByVal Address As Integer, ByVal Data As String, Pin As String, Key As String, ByVal EWMode As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Read_Protected_Data(SessionID As String, ByVal Address As Integer, ByVal Pin As String, ByVal Key As String) As IntPtr
    End Function
    <DllImport(LibName)> Public Function Parametreleri_Yukle(CihazParametre As String, ByVal DefaultPin As String, ByVal PinParametre As String) As IntPtr
    End Function





End Module
