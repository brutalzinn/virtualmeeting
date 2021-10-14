using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.formater
{
    public class Formatter
    {
        public static string Format(string format)
        {
            if (format == null)
            {
                return "";
            }
            Console.WriteLine($"RECEIVED {format}");
            var pattern = @"\[(.*?)\]";
            // var query = "H1-receptor antagonist [DATE.NOW] [DATE.HOUR.NOW] [DAY]";
            MatchCollection matches = Regex.Matches(format, pattern);
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            string result = "";

            foreach (Match m in matches)
            {
                var showMethod = Globals.CustomFormater.Functions.FirstOrDefault((inv) => inv.Identificator.ToUpper() == m.Groups[1].ToString().ToUpper());
                if (showMethod != null && !replacements.ContainsKey(m.Groups[1].ToString().ToUpper()))
                {
                    replacements.Add(m.Groups[1].ToString().ToUpper(), showMethod.Method());
                }
            }
            // var regex = new Regex(String.Join(pattern, map.Keys));
            foreach (var item in replacements)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            result = Regex.Replace(format, pattern, match => replacements.ContainsKey(match.Value.Substring(1, match.Value.Length - 2).ToUpper()) ? replacements[match.Value.Substring(1, match.Value.Length - 2)]?.ToString() : "ERROR");


            return result;
            //var pattern = $"##(?<placeholder>{string.Join("|", replacements.Keys)})##";
            //var result = Regex.Replace(format, pattern, m => replacements[m.Groups["placeholder"].Value], RegexOptions.ExplicitCapture);


        }
    }
}
