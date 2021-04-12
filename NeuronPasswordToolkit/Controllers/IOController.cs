using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace NeuronPasswordToolkit.Controllers
{
    public class IOController
    {
        void HandleSecureString(SecureString value, StreamWriter sw)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                for (int i = 0; i < value.Length; i++)
                {
                    short unicodeChar = Marshal.ReadInt16(valuePtr, i * 2);
                    sw.Write((char)unicodeChar);
                }
                sw.Write("\r\n");
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        //Save function
        public void save(SecureString pass)
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            FileStream fs = new FileStream(strPath + "\\pass.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("Generated Password: ");
            HandleSecureString(pass, sw);
            sw.Flush();
            sw.Dispose();
            fs.Dispose();
            pass.Dispose();
        }

        //mosWrite: measure of strength write function
        public void mosWrite(string input)
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            FileStream fs = new FileStream(strPath + "\\pass.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("Measure of strength: " + input);
            sw.Flush();
            sw.Dispose();
            fs.Flush();
            fs.Dispose();
        }

        //write: measure of strength write function
        public void write(string input)
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            FileStream fs = new FileStream(strPath + "\\pass.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(input);
            sw.Flush();
            sw.Dispose();
            fs.Flush();
            fs.Dispose();
        }
    }
}
