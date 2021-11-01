using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.formater
{
    public class Formatter
    {
        public static string Format(string text)
        {
            if (text == null)
            {
                return "";
            }
            text = FormatCustom(text);
            Console.WriteLine($"RECEIVED {text}");
            var pattern = @"\[(.*?)\]";
            // var query = "H1-receptor antagonist [DATE.NOW] [DATE.HOUR.NOW] [DAY]";
            MatchCollection matches = Regex.Matches(text, pattern);
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            string result = "";
            foreach (Match m in matches)
            {
                var showMethod = Globals.CustomFormater.Functions.FirstOrDefault((inv) => inv.Identificator.ToUpper() == m.Groups[1].ToString().ToUpper());
                if(showMethod != null && !showMethod.IsCustom)
                {
                if (!replacements.ContainsKey(m.Groups[1].ToString().ToUpper()))
                {
                    replacements.Add(m.Groups[1].ToString().ToUpper(), showMethod.Method());
                }
                }
            }
            // var regex = new Regex(String.Join(pattern, map.Keys));
            foreach (var item in replacements)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            try
            {
                result = Regex.Replace(text, pattern, match => replacements.ContainsKey(match.Value.Substring(1, match.Value.Length - 2).ToUpper()) ? replacements[match.Value.Substring(1, match.Value.Length - 2)]?.ToString() : "");

            }
            catch (Exception)
            {

            }
            return result;
        }
        public static string FormatCustom(string text)
        {
            if (text == null)
            {
                return "";
            }
            Dictionary<string, Func<string,object>> replacements = new Dictionary<string, Func<string,object>>();

            var list = Globals.CustomFormater.Functions.FindAll((v) =>v.IsCustom == true);
            foreach (var item in list)
            {
                var showMethod = Globals.CustomFormater.Functions.FirstOrDefault((inv) => inv.Identificator == item.Identificator);
                string key = item.Identificator;
                Regex regex = new Regex(@$"\[{key}](.*)\[/{key}]");

                MatchCollection matches = regex.Matches(text);
                foreach (Match m in matches)
                {
                    Debug.WriteLine(m.Groups[1].Value);
                    return Convert.ToString(showMethod.MethodCustom(m.Groups[1].Value));
                }
                
            }
            return text;
        }

    }
}
