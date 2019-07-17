using System.Text.RegularExpressions;

namespace AcmeScrubber
{
    partial class Program
    {
        public class CodeExtractor
        {
            public string GetCode(string metadata)
            {
                Match match = Regex.Match(metadata, @"(.+_)(.+)(~.+)"); // ver 1&2, group 2
                //Match match = Regex.Match(metadata, @"(.+_)(.+)(~.+)"); // ver 3, group 5
                //Match match = Regex.Match(metadata, @"((.+_v[6-9])(.+_)(.+)(~.+))|((.*?~){3}(.*?)(~.+))"); // ver 4, group 3
                //Match match = Regex.Match(metadata, @"(.+\<Metadata\>)(.*?~){2}(.*?)(~.+)"); // ver 5, group 4
                //Match match = Regex.Match(metadata, @"//Match match = Regex.Match(metadata, @"(.+\<Metadata\>)(.*?~){2}(.*?)(~.+)"); // ver 5, group 4"); // ver 6, group 4
                return match.Groups[2].Value;
            }
        }
    }
}
