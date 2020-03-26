using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace GameLauncher
{
    public class LanguageManger
    {
        public static string LangFile = "";
        public static string Path =  $@"{Directory.GetCurrentDirectory()}\{LangFile}.csv";

        public string Description { get; set; }
        public static void ReadFile()
        {
            string[] file = File.ReadAllLines(Path);

            //TODO: read the file
        }
    }
}