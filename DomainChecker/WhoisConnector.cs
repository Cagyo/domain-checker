using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace DomainChecker
{
    class WhoisConnector
    {
        Form1 f;
        bool Ready = true;
        public bool ReadyComponent
        {
            get
            {
                return Ready;
            }
        }
        string[] WServers;
        string[] DZones;
        string[] CExpressions;
        public List<string> resolves = new List<string>();
        public bool[] registered;
        private List<string> ServerList = new List<string>();
        public WhoisConnector(Form1 f)
        {
            this.f = f;
            LoadServerList();
            if (ServerList.Count == 0)
            {
                Ready=false;
            }
        }
        private void LoadServerList()
        {
            Loader DBldr = new Loader(f, "wservers.txt");
            ServerList = DBldr.TxtRead();
            char separator = '|';
            string[] str = new string[3];
            WServers = new string[ServerList.Count];
            DZones = new string[ServerList.Count];
            CExpressions = new string[ServerList.Count];
            int k=0;
            foreach (string s in ServerList)
            {
                str = s.Split(separator);
                DZones[k] = str[0];
                WServers[k] = str[1];
                CExpressions[k] = str[2];
                k++;
            }
        }
        public bool[] connect(string[] domains)
        {
            string zones;
            int k = 0;
            string[] str;
            registered = new bool[domains.Count()];
            try
            {
                foreach (string s in domains)
                {
                    str = s.Split('.');
                    zones = str[str.Count() - 1];
                    int index = 0;

                    List<string> lst = DZones.ToList();
                    index = lst.IndexOf(zones);
                    TcpClient tcpWhois;
                    NetworkStream nsWhois;
                    BufferedStream bfWhois;
                    StreamWriter swSend;
                    StreamReader srReceive;
                    // 43 порт для whois'а
                    tcpWhois = new TcpClient(WServers[index], 43);
                    // Создаем сетевой поток  
                    nsWhois = tcpWhois.GetStream();
                    // Буферный поток к сетевому потоку
                    bfWhois = new BufferedStream(nsWhois);
                    swSend = new StreamWriter(bfWhois);
                    swSend.WriteLine(s);
                    swSend.Flush();
                    try
                    {
                        srReceive = new StreamReader(bfWhois);
                        string strResponse;
                        string resolve = "";
                        // Ловим ответ сервера
                        registered[k] = true;
                        while ((strResponse = srReceive.ReadLine()) != null)
                        {
                            if (strResponse.Contains(CExpressions[index]) == true)
                            {
                                registered[k] = false;
                            }
                            else if (registered[k] != false) registered[k] = true;
                            resolve += strResponse + "\r\n";
                        }
                        resolves.Add(resolve);
                        srReceive.Close();
                        bfWhois.Close();
                    }
                    catch
                    {
                        f.RunForm2(f, "Произошла ошибка обработки данных!");
                    }
                    nsWhois.Close();
                    // Закрыть соединение, так ведь? (=
                    tcpWhois.Close();
                    Thread.Sleep(500);
                    k++;
                }
            }
            catch
            {
                f.RunForm2(f, "Ошибка соединения с WHOIS-сервером!");
            }
            return registered;
        }
    }
}
