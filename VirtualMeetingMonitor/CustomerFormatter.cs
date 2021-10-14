using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VirtualMeetingMonitor.formater;

namespace VirtualMeetingMonitor
{
       public class CustomerFormatter 
        {

        private List<MethodExecutor> Functions { get; set; }

        public CustomerFormatter(List<MethodExecutor> functions)
        {
            Functions = functions;
        }
        public string Format(string format)
        {
            if (format == null)
            {
                return "";
            }
            var pattern = @"\[(.*?)\]";
            // var query = "H1-receptor antagonist [DATE.NOW] [DATE.HOUR.NOW] [DAY]";
            var matches = Regex.Matches(format, pattern);
            var replacements = new Dictionary<string, string>();
            string result = "";

            foreach (Match m in matches)
            {
                var showMethod = Functions.FirstOrDefault((inv) => inv.Identificator.ToUpper() == m.Groups[1].ToString().ToUpper());
                if (showMethod != null)
                {
                    replacements.Add(m.Groups[1].ToString().ToUpper(), showMethod.Method());
                }
                //    Console.WriteLine($"{m.Groups[1]} {showMethod()}");
            }
            // var regex = new Regex(String.Join(pattern, map.Keys));
     
            result = Regex.Replace(format, pattern, match => replacements.ContainsKey(match.Groups[1].ToString().ToUpper())  ? replacements[ match.Value.Substring(1, match.Value.Length - 2)]?.ToString() : "");

            //var pattern = $"##(?<placeholder>{string.Join("|", replacements.Keys)})##";
            //var result = Regex.Replace(format, pattern, m => replacements[m.Groups["placeholder"].Value], RegexOptions.ExplicitCapture);
            Console.WriteLine($"FORMAT {result}");
            return result;
        }
    }

}
