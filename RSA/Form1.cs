using System;
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

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonEnc.Checked = true;
        }


        int IntegerR { get; set; }
        int IntegerFunctionR { get; set; }
        int IntegerE { get; set; }
        int IntegerD { get; set; }

        byte[] OpenedPlainFileBytes { get; set; }

        byte[] OpenedCipherFileBytes { get; set; }

        enum myFileTypes {EncFile, DecFile}

        myFileTypes openFiletype;


        ushort[] CipherResult { get; set; }

        byte[] DecipherResult { get; set; }

        public  bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static int QuickPowerMod(int num, int power, int mod)
        {
            if (mod == 1)
                return 0;

            if (power == 0)
                return 1;

            if (num == 0)
                return 0;

            int result = 1;
            int current = num % mod;
            int exponent = power;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    result = (result * current) % mod;

                current = (current * current) % mod;
                exponent /= 2;
            }

            return result;
        }

        public static int FindGcd(int a, int b) => b == 0 ? a : FindGcd(b, a % b);

        public static (int gcd, int x, int y) ExtendedEuclidean(int a, int b)
        {
            // Инициализация начальных значений
            int x0 = 1, y0 = 0, x1 = 0, y1 = 1;
            int d0 = a, d1 = b; //поменять a и b местами для алгоритма по таблице

            while (d1 != 0)
            {
                // Вычисление остатка и частного
                int q = d0 / d1;
                int d2 = d0 % d1;
                int x2 = x0 - q * x1;
                int y2 = y0 - q * y1;

                // Обновление значений
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }

            if (y0 < 0) //Для RSA, не для рабина
            {
                y0 += a;
            }

            // Возвращаем НОД и коэффициенты x и y
            return (d0, x0, y0);
        }

        public static int EulerPhi(int n)
        {

            int result = n; // Изначально присваиваем результату значение n

            // Перебираем все простые числа, которые делят n
            for (int p = 2; p * p <= n; ++p)
            {
                if (n % p == 0)
                {
                    // Если p делит n, уменьшаем result на result / p и на p - 1
                    while (n % p == 0)
                    {
                        n /= p;
                    }
                    result -= result / p;
                }
            }

            // Если n осталось простым, уменьшаем result на result / n
            if (n > 1)
            {
                result -= result / n;
            }

            return result;
        }


        private static Random rng = new Random();
        public static int GetRandomCoprime(int eul)
        {
            int candidate;
            do
            {
                candidate = rng.Next(2, eul); // выбираем от 2 до max включительно
            } while (FindGcd(candidate, eul) != 1);

            return candidate;
        }




        private void ButtonR_Click(object sender, EventArgs e)
        {
            TextBoxP.Text = string.Join("", TextBoxP.Text.Where(char.IsDigit));
            TextBoxQ.Text = string.Join("", TextBoxQ.Text.Where(char.IsDigit));

            if (TextBoxP.Text.Length == 0)
            {
                MessageBox.Show("Длина вашего P должна быть отлична от нуля!");
                return;
            }

            if (TextBoxQ.Text.Length == 0)
            {
                MessageBox.Show("Длина вашего Q должна быть отлична от нуля!");
                return;
            }

            int IntegerP = 0;
            int IntegerQ = 0;
            try
            {

                IntegerP = int.Parse(TextBoxP.Text);
                if (!IsPrime(IntegerP))
                {
                    MessageBox.Show("Ваше число P не является простым!");
                    return;
                }

                IntegerQ = int.Parse(TextBoxQ.Text);
                if (!IsPrime(IntegerQ))
                {
                    MessageBox.Show("Ваше число Q не является простым!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте диапазон чисел");
                return;
            }

            IntegerR = IntegerQ * IntegerP;
            if (IntegerR < 256 || IntegerR > ushort.MaxValue)
            {
                MessageBox.Show($"Ваше произведение P и Q должно быть не меньше 256 и не больше {ushort.MaxValue}!");
                return;
            }

            TextBoxR.Text = IntegerR.ToString();
            IntegerFunctionR = EulerPhi(IntegerR);
            TextBoxEuler.Text = IntegerFunctionR.ToString();


            
            IntegerD = GetRandomCoprime(IntegerFunctionR);
            TextBoxD.Text = IntegerD.ToString();


            int gcd = FindGcd(IntegerD, IntegerFunctionR);
            if (gcd != 1)
            {
                MessageBox.Show("Ваша открытая константа E не взаимно простая с функцией Эйлера!");
                return;
            }

            var extendedEuclidResult = ExtendedEuclidean(IntegerFunctionR, IntegerD);

            IntegerE = extendedEuclidResult.y;

            TextBoxE.Text = IntegerE.ToString();

            //ResultButton.Enabled = true;
        }



        private void radioButtonEnc_CheckedChanged(object sender, EventArgs e)
        {
            //radioButtonDec.Checked = !radioButtonDec.Checked;
            openFiletype = myFileTypes.EncFile;
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            //radioButtonEnc.Checked = !radioButtonEnc.Checked;
            openFiletype = myFileTypes.DecFile;
        }



        OpenFileDialog openFileDialog = new OpenFileDialog();

        SaveFileDialog saveFileDialog = new SaveFileDialog();
        
        
        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            if (openFiletype == myFileTypes.EncFile)
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    OpenedPlainFileBytes = File.ReadAllBytes(openFileDialog.FileName);
                    TextBoxInput.Text = string.Join(" ", OpenedPlainFileBytes);
                }
            }
            else if (openFiletype == myFileTypes.DecFile)
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    OpenedCipherFileBytes = File.ReadAllBytes(openFileDialog.FileName);

                    //Если в каком-то рандомном файле не кратное двум число байт
                    if (OpenedCipherFileBytes.Length % 2 != 0)
                    {
                        OpenedCipherFileBytes = OpenedCipherFileBytes.Append((byte)0).ToArray();
                    }

                    CipherResult = new ushort[OpenedCipherFileBytes.Length / 2];

                    for (int i = 0; i < OpenedCipherFileBytes.Length; i += 2)
                    {
                        byte[] bytes = { OpenedCipherFileBytes[i], OpenedCipherFileBytes[i + 1] };

                        ushort combinedShort = BitConverter.ToUInt16(bytes, 0);
                        CipherResult[i / 2] = combinedShort;
                    }
                    TextBoxInput.Text = string.Join(" ", CipherResult);
                }

            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (openFiletype == myFileTypes.EncFile)
            {


                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using
                    (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        foreach (var item in CipherResult)
                        {
                            byte[] bytes = BitConverter.GetBytes(item);
                            fileStream.Write(bytes, 0, bytes.Length);
                        }
                    }
                    
                }
            }
            else if (openFiletype == myFileTypes.DecFile)
            {
                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, DecipherResult);
                }

            }
        }

        private void buttonStartAlgorithm_Click(object sender, EventArgs e)
        {
            if  (TextBoxInput.Text.Length == 0)
            {
                MessageBox.Show("Нету входных данных");
                return;
            }

            if (radioButtonEnc.Checked)
            {
                if (TextBoxE.Text.Length == 0)
                {
                    MessageBox.Show("Нету ключа шифрования");
                    return;
                }
                IntegerE = int.Parse(TextBoxE.Text);

                

                CipherResult = new ushort[OpenedPlainFileBytes.Length];
                for (int i = 0; i < CipherResult.Length; i++)
                {
                    CipherResult[i] = OpenedPlainFileBytes[i];
                }

                for (int i = 0; i < CipherResult.Length; i++)
                {
                    CipherResult[i] = (ushort)QuickPowerMod(CipherResult[i], IntegerE, IntegerR);
                }

                TextBoxOutput.Text = string.Join(" ", CipherResult);
            }

            if (radioButtonDec.Checked)
            {
                if (TextBoxD.Text.Length == 0)
                {
                    MessageBox.Show("Нету ключа дешифрования");
                    return;
                }
                IntegerD = int.Parse(TextBoxD.Text);
                ushort[] tempShort = new ushort[CipherResult.Length];

                for (int i = 0; i < tempShort.Length; i++)
                {
                    tempShort[i] = (ushort)QuickPowerMod(CipherResult[i], IntegerD, IntegerR);
                }

                DecipherResult = new byte[tempShort.Length];
                for (var index = 0; index < tempShort.Length; index++)
                {
                    var item = tempShort[index];
                    var bytes = BitConverter.GetBytes(item);
                    if (!BitConverter.IsLittleEndian)
                        Array.Reverse(bytes);
                    DecipherResult[index] = bytes[0];

                }

                TextBoxOutput.Text = string.Join(" ", tempShort);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBoxD.Text = String.Empty;
            TextBoxE.Text = String.Empty;
            TextBoxEuler.Text = String.Empty;
            TextBoxInput.Text = String.Empty;
            TextBoxOutput.Text = String.Empty;
            TextBoxP.Text = String.Empty;
            TextBoxQ.Text = String.Empty;
            TextBoxR.Text = String.Empty;
        }
    }
}
