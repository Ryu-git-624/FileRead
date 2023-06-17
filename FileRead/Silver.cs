using System;
using System.Text;

namespace FileRead
{
    internal class Silver : IFile
    {
        public string Read()
        {
            //CSVファイルを読み込む
            try
            {
                var lines = System.IO.File.ReadAllLines(@"D:\FileRead\sample.csv", Encoding.GetEncoding("Shift_JIS"));
                return lines[0];

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Write()
        {
            //CSVファイルを書き込む
            try
            {
                string lines = "Silverが作ったよ";
                System.IO.File.WriteAllText(@"D:\FileRead\CreateSilver.csv", lines, Encoding.GetEncoding("Shift_JIS"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
