﻿using System.Text.RegularExpressions;

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
                return match.Groups[2].Value;
            }
        }
    }
}