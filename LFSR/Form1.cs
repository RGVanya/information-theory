using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LFSR
{

    
    public partial class Form1 : Form
    {
        
        //размер регистра
        private const int registerSize = 36;
        
        //биты регистра
        bool[] RegisterBits = new bool[registerSize];
        
        //исходные данные
        byte[] fileData;

        //если регистр задан корректно
        bool IsRegisterCorrect = false;

        //биты которые учавстыуют в xor
        //инвертировал номера битов для удобства работы (начинаються с 1цы)
        int[] NumBitToMask = { registerSize - 36 + 1, registerSize - 11 + 1};

        StringBuilder KeyStr = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        //Заполняет регистр
        private void registerValue() 
        {
            string regInfo = RegisterInfoTBox.Text;
            int j = 0;
            int i = 0;

            if (regInfo.Length == 0)
            {
                IsRegisterCorrect = false;
                MessageBox.Show("Нету значения регистра");
                return;
            }


            while (j < registerSize && i < regInfo.Length)
            {

                if (regInfo[i] == '1') 
                {
                    RegisterBits[j] = true;
                    j++;
                }
                else if (regInfo[i] == '0')
                {
                    RegisterBits[j] = false;
                    j++;
                }
                i++;
            }
            


            if (j < registerSize) {
                IsRegisterCorrect = false;
                MessageBox.Show("Не полностью заполнен регистр");
                return;
            }
            IsRegisterCorrect = true;
        }

        //Шифрование
        private void FileEncryptButton_Click(object sender, EventArgs e)
        {
            //Проверка готовности регистра
            registerValue();
            if (!IsRegisterCorrect) 
            {
                return;
            }

            //Открытие исходного файла.
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл с текстом",
                Filter = "Все файлы (*.*)|*.*", // Фильтр форматов
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // Открыть "Документы"
            };





            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                KeyStr.Clear();
                FileInfo fileInfo = new FileInfo(filePath);


                //Сбор всех байтов файла.
                if (fileInfo.Length <= 200 * 1024)
                {
                    fileData = ReadFileBytes(filePath);
                }
                else 
                { 
                    fileData = BigFileBytes(filePath);
                }
                InFileTBox.Text = "";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < fileData.Length; i++)
                {
                    sb.Append(Convert.ToString(fileData[i], 2).PadLeft(8, '0') + " ");
                }
                InFileTBox.Text = sb.ToString();

                OutFileTBox.Text = "";
                FileEncryption();


                StringBuilder sb1 = new StringBuilder();
                for (int i = 0; i < fileData.Length; i++)
                {
                    sb1.Append(Convert.ToString(fileData[i], 2).PadLeft(8, '0') + " ");
                }
                OutFileTBox.Text = sb1.ToString();
                OutKeyTBox.Text = KeyStr.ToString();
                //debugOutput();
            }
            

        }

        private byte[] ReadFileBytes(string path)
        { 
            return File.ReadAllBytes(path);
        }

        private byte[] BigFileBytes(string path)
        {
            int byteCount = 30;
            byte[] buffer = new byte[byteCount * 2];

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                // Читаем первые 30 байт
                fs.Read(buffer, 0, byteCount);

                // Читаем последние 30 байт
                fs.Seek(-byteCount, SeekOrigin.End);
                fs.Read(buffer, byteCount, byteCount);
            }

            return buffer;
        }




        private void RegisterUpdate() 
        {
            bool res = RegisterBits[NumBitToMask[0] - 1];
            bool prevBit = RegisterBits[RegisterBits.Length - 1];
            bool nextBit = false;

            //xor для нового бита
            for (int i = 1; i < NumBitToMask.Length; i++)
            {
                res ^= RegisterBits[NumBitToMask[i] - 1];
            }
            prevBit = RegisterBits[RegisterBits.Length - 1];

            //сдвиг битов
            for (int i = RegisterBits.Length - 1; i > 0; i--)
            {
                nextBit = RegisterBits[i - 1];
                RegisterBits[i - 1] = prevBit;
                prevBit = nextBit;
            }

            if (KeyStr.Length % 9 == 8) 
            {
                KeyStr.Append(" ");
            }
            KeyStr.Append(Convert.ToString(Convert.ToInt16(nextBit)));

            RegisterBits[RegisterBits.Length - 1] = res;
        }


        private void FileEncryption() 
        {
            bool[] MyByte = new bool[8];
            bool bit = false;
            for (int i = 0; i < fileData.Length; i++)
            {
                byte CurrentByte = fileData[i];
                for (int j = 0; j < 8; j++) 
                {
                    bit = (CurrentByte & (1 << (7 - j))) != 0;
                    MyByte[j] = RegisterBits[0]^bit;
                    RegisterUpdate();
                }



                //собираю зашифрованный байт
                CurrentByte = 0;
                for (int j = 0; j < 8; j++) 
                {
                    CurrentByte = (byte)(CurrentByte | (Convert.ToInt32(MyByte[MyByte.Length - 1 - j]) << j));
                }
                fileData[i] = CurrentByte;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Выберите место сохранения файла",
                Filter = "Все файлы (*.*)|*.*", // Фильтр форматов
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // Открыть "Документы"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate)))
                {
                    if (fileData != null)
                        writer.Write(fileData);
                }
            }
        }
    }


}
