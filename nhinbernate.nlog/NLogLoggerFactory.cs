using System;

namespace NHibernate
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        public IInternalLogger LoggerFor(string keyName)
        {
            return new NLogLogger(keyName);
        }

        public IInternalLogger LoggerFor(System.Type type)
        {
            return new NLogLogger(type.FullName);
        }
    }
}