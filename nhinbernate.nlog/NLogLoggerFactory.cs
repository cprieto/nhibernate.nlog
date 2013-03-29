using System;
using NHibernate;

namespace nhinbernate.nlog
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        public IInternalLogger LoggerFor(string keyName)
        {
            throw new NotImplementedException();
        }

        public IInternalLogger LoggerFor(Type type)
        {
            throw new NotImplementedException();
        }
    }
}