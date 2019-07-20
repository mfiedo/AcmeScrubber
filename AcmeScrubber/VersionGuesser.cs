using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace AcmeScrubber
{
    partial class Program
    {
        public class VersionGuesser
        {
            public string [] guessVer (string buffer)
            {
                var metadataCollection = new List<string>();
                if (buffer.Contains("<Market>") == true) //ver7 identify and extract group
                {
                    Regex regex = new Regex(@"<Object>((.|\s)*?)<\/Object>");
                    foreach (Match match in regex.Matches(buffer))
                    {
                        metadataCollection.Add(match.Value);
                    }
                }
                else if (buffer.Contains("WarehouseId") == true) //ver6 identify and extract group
                {
                    Regex regex = new Regex(@"WarehouseId(.|s|\n)*?\}");
                    foreach (Match match in regex.Matches(buffer))
                    {
                        metadataCollection.Add(match.Value);
                    }
                }
                else if (buffer.Contains("<ItemType>") == true) //ver5 identify and extract group
                {
                    Regex regex = new Regex(@"<Object>((.|\s)*?)<\/Object>");
                    foreach (Match match in regex.Matches(buffer))
                    {
                        metadataCollection.Add(match.Value);
                    }
                }
                else //catches versions 1-4 and extracts by line
                {
                    Regex regex = new Regex(@".+");
                    foreach (Match match in regex.Matches(buffer))
                    {
                        metadataCollection.Add(match.Value);
                    }
                } 
                string[] metadataList = metadataCollection.Select(i => i.ToString()).ToArray();
                return metadataList;
            }            
        }
    }
}


