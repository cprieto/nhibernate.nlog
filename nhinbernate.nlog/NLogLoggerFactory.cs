using System;

namespace NHibernate
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        public IInternalLogger LoggerFor(string keyName)
        {
            throw new NotImplementedException();
        }

        public IInternalLogger LoggerFor(System.Type type)
        {
            throw new NotImplementedException();
        }
    }
}