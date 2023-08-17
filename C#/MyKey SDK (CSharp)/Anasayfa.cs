using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyKey_SDK_CSharp
{
    public partial class Anasayfa : Form
    {




        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
                               

        }

      

        private void Firmware_Oku_Buton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Marshal.PtrToStringAnsi(MyKey_DLL.Device_Firmware_Read()));
        }

        private void Cihaz_Model_Oku_Buton_Click(object sender, EventArgs e)
        {
            Cihaz_Model_Text.Text = (Marshal.PtrToStringAnsi(MyKey_DLL.Device_Model_Read()));
        }

        private void Serial_Oku_Buton_Click(object sender, EventArgs e)
        {
            Cihaz_SeriNo_Text.Text = (Marshal.PtrToStringAnsi(MyKey_DLL.Serial_No_Read()));
        }

        private void Data_Yaz_Buton_Click(object sender, EventArgs e)
        {
            string Gelen = Marshal.PtrToStringAnsi(MyKey_DLL.Write_Protected_Data(Veri_Yazma_SessionID_Text.Text, System.Convert.ToInt32(Veri_Yazma_Adres_Text.Text), Veri_Yazma_Eeprom_Data_Text.Text, Veri_Yazma_Pin_Text.Text, Veri_Yazma_Data_Key_Text.Text, "RW"));
            islem_Sonuc_Text.Text = Gelen;
        }

        private void Pin_Yukle_Buton_Click(object sender, EventArgs e)
        {
            string Gelen = Marshal.PtrToStringAnsi(MyKey_DLL.Pin_Write(Pin_Yukleme_Parametre.Text, Yeni_Pin_Text.Text));
            MessageBox.Show(Gelen);
        }

        private void Login_Paramete_Yukle_Buton_Click(object sender, EventArgs e)
        {
            if (Yuklenecek_Login_Parametre_Text.Text.Length!=24)
            {
                 MessageBox.Show("Yüklenecek Login Parametre 24 Karakterli Olmalıdır.");
                return;
            }

            if (Yuklenecek_Pin_Text.Text.Length != 4)
            {
                MessageBox.Show("Yüklenecek Pin 4 Karakterli Olmalıdır.");
                return;
            }

            if (Yuklenecek_Pin_Parametre_Text.Text.Length != 24)
            {
                MessageBox.Show("Yüklenecek Pin Parametresi 24 Karakterli Olmalıdır.");
                return;
            }

            string Gelen = Marshal.PtrToStringAnsi(MyKey_DLL.Parametreleri_Yukle(Yuklenecek_Login_Parametre_Text.Text, Yuklenecek_Pin_Text.Text, Yuklenecek_Pin_Parametre_Text.Text));
            MessageBox.Show(Gelen);
        }

        private void Login_Buton_Click(object sender, EventArgs e)
        {
            Gelen_Session_Text.Text = Marshal.PtrToStringAnsi(MyKey_DLL.Login(Parametre_Text.Text, Pin_Text.Text));
            Giden_Session_Text.Text = Gelen_Session_Text.Text;
            Veri_Yazma_SessionID_Text.Text = Gelen_Session_Text.Text;
        }

        private void Data_Oku_Buton_Click(object sender, EventArgs e)
        {
            Okunan_Eeprom_Data_Text.Text = Marshal.PtrToStringAnsi(MyKey_DLL.Read_Protected_Data(Giden_Session_Text.Text, System.Convert.ToInt32(Data_Oku_Adres_Text.Text), Data_Oku_Pin_Text.Text,  Data_Oku_Key_Text.Text));
        }
    }
}
