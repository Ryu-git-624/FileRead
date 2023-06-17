using System;
using System.IO;
using System.Text;

namespace FileRead
{
    internal class Platinum : IFile
    {
        public string Read()
        {
            //TXTファイルを読み込む
            try
            {
                //TXTファイルを1行読み込む
                using(var sr = new StreamReader(@"D:\FileRead\sample.txt", Encoding.GetEncoding("Shift_JIS")))
                {
                    sr.ReadLine();
                    return sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Write()
        {
            //TXTファイルを書き込む
            try
            {
                string lines = "Platinumが作ったよ";
                File.WriteAllText(@"D:\FileRead\CreatePlatinum.txt", lines, Encoding.GetEncoding("Shift_JIS"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
