using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DomainChecker
{
    class Kernel
    {
        Form1 main;
        Addons AddonWindow;
        ParceAddr ParceAddress;
        WhoisConnector WhoisWorker;
        Loader LoaderF;
        Indexer indexer;
        Writer writer;

        public Kernel(Form1 f)
        {
            main = f;
            ParceAddress = new ParceAddr(f);
            WhoisWorker = new WhoisConnector(f);
            indexer = new Indexer(f);
            if (WhoisWorker.ReadyComponent == false)
            {
                f.NotReady();
            }
            else
            {
                AddonWindow = new Addons();
            }
        }

        public void SetFileName(string FileName)
        {
            LoaderF = new Loader(main, FileName);
        }

        public void SetFileNameExp(string FileName, List<string> data)
        {
            writer = new Writer(main, FileName, data);
        }

        public List<string> ReadFile(bool action)
        {
            if (action == true)
            {
                List<string> data;

                data = LoaderF.XlsRead();
                LoaderF = null;
                return data;
            }
            else
            {
                List<string> data;
                data = LoaderF.TxtRead();
                LoaderF = null;
                return data;
            }
        }

        public int Import(List<string> data)
        {
            int k = 0;
            bool added;
            foreach (string domen in data)
                if (ParceAddress.IsAddr(domen) == true)
                {
                    string addr = ParceAddress.BDeleter(domen);
                    added = main.AddToList(addr);
                    if (added == true)
                        k++;
                }
            return k;
        }

        public void WriteFile(bool action)
        {
            if (action == true)
            {
                writer.XlsWrite();
                writer = null;
            }
            else
            {
                writer.TxtWrite();
                writer = null;
            }
        }

        public bool AddDomain(string addr)
        {
            if (ParceAddress.IsAddr(addr) == true)
            {
                string address = ParceAddress.BDeleter(addr);
                main.AddToList(address);
            }
            return ParceAddress.IsAddr(addr);
        }

        public bool[] WhoisCheck(string[] domains)
        {
            return WhoisWorker.connect(domains);
        }

        public int GetIndexes(string domain, bool action)
        {
            if (action == true)
            {
                return indexer.TiC(domain);
            }
            else
            {
                return indexer.MyPR(domain);
            }
        }

        public string GetIP(string domain, bool registered)
        {
            return ParceAddress.ChkIP(domain, registered);
        }

        public string GetResolve(int i)
        {
            return WhoisWorker.resolves[i];
        }

        public void ClearResolves()
        {
            WhoisWorker.resolves.Clear();
        }
        public void DeleteResolve(int k)
        {
            WhoisWorker.resolves.RemoveAt(k);
        }
    }
}
