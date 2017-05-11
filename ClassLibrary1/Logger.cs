using System;
using System.Diagnostics;

namespace ClassLibrary1
{
    public interface ILogger
    {
        void W(string x);
    }

    internal class Logger : ILogger
    {
        private readonly Guid _guid;
        public Logger()
        {
            _guid = Guid.NewGuid();
        }

        public void W(string x)
        {
            Debug.WriteLine(_guid + "---" + DateTime.Now + "---" + x);
        }
    }
}