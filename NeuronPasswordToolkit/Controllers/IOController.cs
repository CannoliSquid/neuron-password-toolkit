using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NeuronPasswordToolkit.Controllers
{
    public class IOController
    {
        //Save function
        public void save()
        {
            //TextBox gpt = Application.OpenForms["mainForm"].Controls["generatedPassTextBox"] as TextBox;
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            FileStream fs = new FileStream(strPath + "\\pass.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("Generated Password: " + ""); //gpt.Text);
            sw.Flush();
            sw.Dispose();
            fs.Flush();
            fs.Dispose();
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
