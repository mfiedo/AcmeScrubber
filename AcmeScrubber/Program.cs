using AcmeCorp.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace AcmeScrubber
{
    partial class Program
    {
        static void Main(string[] args)
        {

            CodeExtractor codeExtractor = new CodeExtractor();
            LegacyObjectMetadataProvider.V1 metadataProviderVersion1 = new LegacyObjectMetadataProvider.V1();
            //string metadata = metadataProviderVersion1.ProvideMetadata();
            string buffer = File.ReadAllText(@"c:\Users\Marcin\Desktop\input1-4.txt", Encoding.UTF8);
            string [] metadataList = null;
            VersionGuesser ver = new VersionGuesser();
            metadataList = ver.guessVer(buffer);
            //metadataList = File.ReadAllLines(@"c:\Users\Marcin\Desktop\inputv5.txt", Encoding.UTF8);
            foreach (string metadata in metadataList)
            {
                Console.WriteLine($"Getting product code from {metadata}");
                string code = codeExtractor.GetCode(metadata);
                Console.WriteLine($"Recognized code as [{code}]");

                ObjectCodeValidator validator = new ObjectCodeValidator();
                validator.AssertCodeIsValid(code, metadata); //<- tu walidujemy czy Wasza logika zadziałała

                Console.WriteLine($"Code [{code}] is valid\n");
            }


            Console.ReadKey();

        }
    }
}


