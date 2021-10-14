using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VirtualMeetingMonitor.formater;

namespace VirtualMeetingMonitor
{
        class CustomerFormatter 
        {

        private List<MethodExecutor> Functions { get; set; }

        public CustomerFormatter(List<MethodExecutor> functions)
        {
            Functions = functions;
        }

        private string Teste()
        {
            return "";
        }
        private string Evaluator(List<KeyValuePair<string, string>> map, Match match)
        {
            for (int i = 0; i < match.Groups.Count; i++)
            {
                var group = match.Groups[i];
                if (group.Success)
                {
                    return map[i].Value;
                }
            }

            //shouldn't happen
            throw new ArgumentException("Match found that doesn't have any successful groups");
        }
        public string Format(string format)
        {
            var pattern = @"\[(.*?)\]";
           // var query = "H1-receptor antagonist [DATE.NOW] [DATE.HOUR.NOW] [DAY]";
           var matches = Regex.Matches(format, pattern);
            var replacements = new Dictionary<string, string>();
          

            foreach (Match m in matches)
            {
                Func<string> showMethod = Functions.Find((inv) => inv.Identificator.ToUpper() == m.Groups[1].ToString().ToUpper()).Method ;

                replacements.Add(m.Groups[1].ToString(), showMethod());
               Console.WriteLine($"{m.Groups[1]} {showMethod()}");
            }
            // var regex = new Regex(String.Join(pattern, map.Keys));

            string result = Regex.Replace(format,pattern,match => replacements[match.Value.Substring(1, match.Value.Length - 2)]?.ToString());
            //var pattern = $"##(?<placeholder>{string.Join("|", replacements.Keys)})##";
            //var result = Regex.Replace(format, pattern, m => replacements[m.Groups["placeholder"].Value], RegexOptions.ExplicitCapture);

            return result;
        }
    }

}
