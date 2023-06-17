using System;
using System.Text;

namespace FileRead
{
    internal class Gold : IFile
    {
        public string Read()
        {
            //TXTファイルを読み込む
            try
            {
                var lines = System.IO.File.ReadAllLines(@"D:\FileRead\sample.txt", Encoding.GetEncoding("Shift_JIS"));
                return lines[0];
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
                string lines = "Goldが作ったよ";
                System.IO.File.WriteAllText(@"D:\FileRead\CreateGold.txt", lines, Encoding.GetEncoding("Shift_JIS"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
