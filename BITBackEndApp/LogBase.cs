using System;
using System.Collections.Generic;
using NLog;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBackEndApp
{
    public abstract class LogBase
    {
        public abstract void Log(string message);
    }
}
