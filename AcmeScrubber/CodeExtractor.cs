using System.Text.RegularExpressions;

namespace AcmeScrubber
{
    partial class Program
    {
        public class CodeExtractor
        {
            public string GetCode(string metadata)
            {
                if (metadata.Contains("<Market>") == true)
                {
                    Match match = Regex.Match(metadata, @"(\<C.*?\>)(.+)(\<\/C.*?\>)"); //group 2
                    Match matchLangCode = Regex.Match(metadata, @"(\<Ma.*?\>)(.+)(\<\/Ma.*?\>)"); //group 2 to be subtracted
                    string langCode = matchLangCode.Groups[2].Value;
                    string code = match.Groups[2].Value;
                    Match matchCheck = Regex.Match(code, @"(.*)(..)");
                    if (matchCheck.Groups[2].Value == langCode)
                    {
                        return code.Substring(code.Length - 2); //remove language code from resault
                    }
                    else
                    {
                        return code;
                    }
                }
                else if (metadata.Contains("WarehouseId") == true)
                {
                    Match match = Regex.Match(metadata, @"(.+\<Metadata\>)(.*?~){2}(.*?)(~.+)"); // ver 6, group 4
                    return match.Groups[4].Value;
                }
                else if (metadata.Contains("<ItemType>") == true)
                {
                    Match match = Regex.Match(metadata, @"(.+\<Metadata\>)(.*?~){2}(.*?)(~.+)"); // ver 5, group 4
                    return match.Groups[4].Value;
                }
                else if (Regex.Match(metadata, @"(((.*?~)(.*?_)){2})(.*?_)(v\d)").Success == true)
                {
                    if (Regex.Match(metadata, @"(.*?)(_v([6-9]|\d{2,})~)(.*)").Success == true)
                    {
                        Match match = Regex.Match(metadata, @"(.+_v\d+)(.+_)(.+)(~.+)"); // ver 4 v6-above, group 3
                        return match.Groups[3].Value;
                    }
                    else
                    {
                        Match match = Regex.Match(metadata, @"(.*?~){3}(.*?)(~.+)"); // ver 4 v0-5, group 3
                        return match.Groups[3].Value;
                    }
                }
                else if (Regex.Match(metadata, @"(.*?~){4}").Success == true)
                {
                    Match match = Regex.Match(metadata, @"(.+_)(.+)(~.+)"); // ver 3, group 5
                    return match.Groups[5].Value;
                }
                else
                {
                    Match match = Regex.Match(metadata, @"(.+_)(.+)(~.+)"); // ver 1&2, group 2
                    return match.Groups[2].Value;
                }
            }
        }
    }
}
