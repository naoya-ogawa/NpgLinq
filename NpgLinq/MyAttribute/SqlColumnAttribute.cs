using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgLinq
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class SqlColumnAttribute : System.Attribute
    {
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}
