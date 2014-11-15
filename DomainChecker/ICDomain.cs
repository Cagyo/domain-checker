using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DomainChecker
{
    interface ICDomain
    {
        bool IsAddr(string addr);
        string BDeleter(string addr);
        string[] Decomposer(string addr);
        bool ChkDZone(string domain);
        bool ChkDomain(string domain);
    }
}
