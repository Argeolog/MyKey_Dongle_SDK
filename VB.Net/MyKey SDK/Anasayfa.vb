Imports System.IO
Imports System.Runtime.InteropServices

Public Class Anasayfa


    Private Sub Login_Buton_Click(sender As Object, e As EventArgs) Handles Login_Buton.Click
        Try
            Gelen_Session_Text.Text = Marshal.PtrToStringAnsi(Login(Parametre_Text.Text, Pin_Text.Text))
            Giden_Session_Text.Text = Gelen_Session_Text.Text
            Veri_Yazma_SessionID_Text.Text = Gelen_Session_Text.Text
            GC.Collect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Data_Oku_Buton_Click(sender As Object, e As EventArgs) Handles Data_Oku_Buton.Click

        Okunan_Eeprom_Data_Text.Text = Marshal.PtrToStringAnsi(Read_Protected_Data(Giden_Session_Text.Text, CInt(Data_Oku_Adres_Text.Text), Data_Oku_Pin_Text.Text, Data_Oku_Key_Text.Text))
        GC.Collect()
    End Sub



    Private Sub Cihaz_Model_Oku_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_Model_Oku_Buton.Click
        Cihaz_Model_Text.Text = Marshal.PtrToStringAnsi(Device_Model_Read())
        GC.Collect()
    End Sub

    Private Sub Serial_Oku_Buton_Click(sender As Object, e As EventArgs) Handles Serial_Oku_Buton.Click
        Cihaz_SeriNo_Text.Text = Marshal.PtrToStringAnsi(Serial_No_Read())
        GC.Collect()
    End Sub

    Private Sub Pin_Yukle_Buton_Click(sender As Object, e As EventArgs) Handles Pin_Yukle_Buton.Click

        Dim Gelen As String = Marshal.PtrToStringAnsi(Pin_Write(Pin_Yukleme_Parametre.Text, Yuklenecek_Pin_Text.Text))
        GC.Collect()
        MsgBox(Gelen)
    End Sub

    Private Sub Data_Yaz_Buton_Click(sender As Object, e As EventArgs) Handles Data_Yaz_Buton.Click

        Dim Gelen As String = Marshal.PtrToStringAnsi(Write_Protected_Data(Veri_Yazma_SessionID_Text.Text, CInt(Veri_Yazma_Adres_Text.Text), Veri_Yazma_Eeprom_Data_Text.Text, Veri_Yazma_Pin_Text.Text, Veri_Yazma_Data_Key_Text.Text, "RW"))
        islem_Sonuc_Text.Text = Gelen
        GC.Collect()
    End Sub

    Private Sub Veri_Yazma_Adres_Text_TextChanged(sender As Object, e As EventArgs) Handles Veri_Yazma_Adres_Text.TextChanged
        Data_Oku_Adres_Text.Text = Veri_Yazma_Adres_Text.Text
    End Sub

    Private Sub Login_Paramete_Yukle_Buton_Click(sender As Object, e As EventArgs) Handles Login_Paramete_Yukle_Buton.Click


        Dim Hatavar As Boolean
        If (Yuklenecek_Login_Parametre_Text.Text.Length <> 24) Then
            MessageBox.Show("Yüklenecek Login Parametre 24 Karakterli Olmalıdır.")
            Hatavar = True
        ElseIf (Default_Pin_Text.Text.Length <> 4) Then
            MessageBox.Show("Yüklenecek Pin 4 Karakterli Olmalıdır.")
            Hatavar = True

        ElseIf (Yuklenecek_Pin_Parametre_Text.Text.Length <> 24) Then
            MessageBox.Show("Yüklenecek Pin Parametresi 24 Karakterli Olmalıdır.")
            Hatavar = True
        End If

        If Hatavar = False Then
            Dim Cevap As String = Marshal.PtrToStringAnsi(Parametreleri_Yukle(Yuklenecek_Login_Parametre_Text.Text, Default_Pin_Text.Text, Yuklenecek_Pin_Parametre_Text.Text))
            GC.Collect()
            MsgBox(Cevap)
        End If

    End Sub
    Private Sub Firmware_Oku_Buton_Click(sender As Object, e As EventArgs) Handles Firmware_Oku_Buton.Click

        Dim Gelen As String = Marshal.PtrToStringAnsi(Device_Firmware_Read())
        GC.Collect()
        MsgBox(Gelen)
    End Sub

    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
