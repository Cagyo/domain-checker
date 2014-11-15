using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace DomainChecker
{
    class Indexer
    {
        Form1 f;
        private const UInt32 myConst = 0xE6359A60;
        public Indexer(Form1 f)
        {
            this.f = f;
        }
        public int TiC(string domain)
        {
            try
            {
                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create("http://yandex.ru/cy?base=0&amp;host=" + domain);

                HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                // Insert code that uses the response object.
                StreamReader srReceive = new StreamReader(HttpWResp.GetResponseStream());
                string strResponse;
                int n = -1, k = 0;
                int index = 0;
                List<string> AllResponse = new List<string>();
                while ((strResponse = srReceive.ReadLine()) != null)
                {
                    if (strResponse.Contains("arr-hilite.gif") == true)
                        n = k + 6;
                    if (k == n)
                    {
                        char[] separators = { '>', '<' };
                        string[] SplittedResponse = strResponse.Split(separators);
                        index = Convert.ToInt32(SplittedResponse[2]);
                    }
                    AllResponse.Add(strResponse);
                    k++;
                }
                char[] separator = { '—', '<' };
                if (n == -1)
                {
                    string[] SplittedResponse;
                    foreach (string s in AllResponse)
                        if (s.Contains("тИЦ") == true)
                        {
                            SplittedResponse = s.Split(separator);
                            index = Convert.ToInt32(SplittedResponse[1]);
                            break;
                        }
                }
                srReceive.Dispose();
                HttpWResp.Close();
                return index;
            }
            catch
            {
                f.RunForm2(f, "Произошла ошибка при определении Яндекс ТиЦ!");
                return -1;
            }
        }

        private void _Hashing(ref UInt32 a, ref UInt32 b, ref UInt32 c)
        {
            a -= b; a -= c; a ^= c >> 13;
            b -= c; b -= a; b ^= a << 8;
            c -= a; c -= b; c ^= b >> 13;
            a -= b; a -= c; a ^= c >> 12;
            b -= c; b -= a; b ^= a << 16;
            c -= a; c -= b; c ^= b >> 5;
            a -= b; a -= c; a ^= c >> 3;
            b -= c; b -= a; b ^= a << 10;
            c -= a; c -= b; c ^= b >> 15;
        }
        public string PerfectHash(string theURL)
        {
            string url = string.Format("info:{0}", theURL);

            int length = url.Length;

            UInt32 a, b;
            UInt32 c = myConst;

            int k = 0;
            int len = length;

            a = b = 0x9E3779B9;

            while (len >= 12)
            {
                a += (UInt32)(url[k + 0] + (url[k + 1] << 8) +
                     (url[k + 2] << 16) + (url[k + 3] << 24));
                b += (UInt32)(url[k + 4] + (url[k + 5] << 8) +
                     (url[k + 6] << 16) + (url[k + 7] << 24));
                c += (UInt32)(url[k + 8] + (url[k + 9] << 8) +
                     (url[k + 10] << 16) + (url[k + 11] << 24));
                _Hashing(ref a, ref b, ref c);
                k += 12;
                len -= 12;
            }
            c += (UInt32)length;
            switch (len)
            {
                case 11:
                    c += (UInt32)(url[k + 10] << 24);
                    goto case 10;
                case 10:
                    c += (UInt32)(url[k + 9] << 16);
                    goto case 9;
                case 9:
                    c += (UInt32)(url[k + 8] << 8);
                    goto case 8;
                case 8:
                    b += (UInt32)(url[k + 7] << 24);
                    goto case 7;
                case 7:
                    b += (UInt32)(url[k + 6] << 16);
                    goto case 6;
                case 6:
                    b += (UInt32)(url[k + 5] << 8);
                    goto case 5;
                case 5:
                    b += (UInt32)(url[k + 4]);
                    goto case 4;
                case 4:
                    a += (UInt32)(url[k + 3] << 24);
                    goto case 3;
                case 3:
                    a += (UInt32)(url[k + 2] << 16);
                    goto case 2;
                case 2:
                    a += (UInt32)(url[k + 1] << 8);
                    goto case 1;
                case 1:
                    a += (UInt32)(url[k + 0]);
                    break;
                default:
                    break;
            }

            _Hashing(ref a, ref b, ref c);

            return string.Format("6{0}", c);
        }

        public int MyPR(string myURL)
        {
            string strDomainHash = PerfectHash(myURL);
            string myRequestURL = string.Format("http://toolbarqueries.google.com/" +
                   "tbr?features=Rank&sourceid=navclient-ff&client=navclient-auto-ff&ch={0}&q=info:{1}",
                   strDomainHash, myURL);

            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(myRequestURL);
                StreamReader StreamR = new StreamReader(myRequest.GetResponse().GetResponseStream());
                string myResponse = StreamR.ReadToEnd();
                StreamR.Close();
                if (myResponse.Length == 0)
                    return 0;
                else
                    return int.Parse(Regex.Match(myResponse,
                           "Rank_1:[0-9]:([0-9]+)").Groups[1].Value);
            }
            catch (Exception)
            {
                f.RunForm2(f, "Произошла ошибка при определении Google Page Rank!");
                return -1;
            }
        }

    }
}
