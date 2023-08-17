using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyKey_SDK_CSharp
{
    


    internal class MyKey_DLL
    {

        const string LibName = "System.My.Data.dll";
             
        [DllImport(LibName)]
        public static extern IntPtr Login(string CihazParametre, string Pin);

        [DllImport(LibName)]
        public static extern IntPtr Serial_No_Read();

        [DllImport(LibName)]
        public static extern IntPtr Device_Model_Read();

        [DllImport(LibName)]
        public static extern IntPtr Device_Firmware_Read();

        [DllImport(LibName)]
        public static extern IntPtr Pin_Write(string PinParametre, string YeniPin);
        [DllImport(LibName)]
         public static extern IntPtr Write_Protected_Data(string SessionID, int Address, string Data, string Pin, string Key, string EWMode);
        
        [DllImport(LibName)]
        public static extern IntPtr Read_Protected_Data(string SessionID, int Address, string Pin, string Key);
       

        [DllImport(LibName)]
        public static extern IntPtr Parametreleri_Yukle(string CihazParametre, string DefaultPin, string PinParametre);
       


    }
}
