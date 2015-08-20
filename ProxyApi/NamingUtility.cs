using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProxyApi
{
    public static class NamingUtility
	{
        public static string FromLowerCase(this string name)
        {
            return name[0].ToString().ToLowerInvariant() + name.Substring(1, name.Length - 1);
        }
	}
}
