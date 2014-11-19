using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NpgLinq
{
    public class NpgQueryProvider : QueryProvider
    {
        public override string GetQueryText(Expression expression)
        {
            return string.Empty;
        }

        public override object Execute(Expression expression)
        {
            return null;
        }

        public static IQueryable<T> CreateQueryable<T>()
        {
            return new Query<T>(new NpgQueryProvider());
        }
    }


}
