using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace DomainChecker
{
    class ParceAddr:ICDomain
    {
        Form1 f;
        public ParceAddr(Form1 f)
        {
            this.f = f;
        }
        public bool IsAddr(string addr)//Проверка задан ли корректный адрес\домен
        {
            string pattern = @"(^[a-zA-Z]{0,25}://)([\w\-]{0,25}\.(?:[a-zA-Z]{0,10}|[a-zA-Z]{0,4}\.[a-zA-Z]{0,10})$)|(^[\w\-]{0,25})\.(?:[a-zA-Z]{0,10}|[a-zA-Z]{0,4}\.[a-zA-Z]{0,10})$";
            Regex AddrControl = new Regex(pattern);
            return AddrControl.IsMatch(addr);
        }
        public string BDeleter(string addr)
        {
            string pattern = @"^[a-zA-Z]{0,25}://";
            Regex AddrControl = new Regex(pattern);
            string domen;
            if (AddrControl.IsMatch(addr))
                domen = AddrControl.Replace(addr, "");
            else
                domen = addr;
            return domen;
        }
        public string[] Decomposer(string addr)
        {
            string[] domain = new string[2];
            return domain;
        }
        public bool ChkDZone(string domain)
        {
            return true;
        }
        public bool ChkDomain(string domain)
        {
            return true;
        }
        public string ChkIP(string domain, bool registered)
        {
            try
            {
                string ip;
                if (registered == true)
                    try
                    {
                        ip = System.Net.Dns.GetHostEntry(domain).AddressList[0].ToString();
                    }
                    catch (SocketException)
                    {
                        ip = "Ошибка";
                    }
                else ip = "Отсутствует";
                return ip;
            }
            catch
            {
                f.RunForm2(f, "Вероятно глобальная ошибка!");
                return "Не определено";
            }
        }

    }
}
