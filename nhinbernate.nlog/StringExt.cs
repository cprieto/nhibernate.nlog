namespace NHibernate
{
    internal static class StringExt
    {
        internal static string ToStringSafe(this object obj)
        {
            object aux = obj ?? string.Empty;
            return aux.ToString();
        } 
    }
}