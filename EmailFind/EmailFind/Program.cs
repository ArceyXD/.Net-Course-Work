using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
namespace EmailFind
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"mailto:(\w+@\w+\.\w{3})";
            Regex rex = new Regex(pattern);

            //step through the websites for phone info
            WebClient client = new WebClient();
            //clear file if existing 
            File.Delete(@"C:\Users\Russell\source\repos\EmailFind\EmailFind\Emails.txt");
            for (char c = 'A'; c<= 'Z'; c++)
            {
                string url = "https://web.ramapo.edu/phone/?type=" + c;
                string rcInfo = client.DownloadString(url);
                //Console.WriteLine(rcInfo.Length);

                MatchCollection matches = rex.Matches(rcInfo);
               
                File.AppendAllText(@"C:\Users\Russell\source\repos\EmailFind\EmailFind\Emails.txt", "Last Name: " + c + Environment.NewLine + Environment.NewLine);
                foreach (Match m in matches)
                {
                    //Console.WriteLine(m.Groups[1].Value);
                    File.AppendAllText(@"C:\Users\Russell\source\repos\EmailFind\EmailFind\Emails.txt", m.Groups[1].Value + Environment.NewLine);
                }

                File.AppendAllText(@"C:\Users\Russell\source\repos\EmailFind\EmailFind\Emails.txt", Environment.NewLine);
            }

          
        }


        /*void getMatches(Regex reg, char index)
        {



        }
        */
    }
}
