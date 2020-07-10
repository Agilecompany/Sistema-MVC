using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Infrastructure.Common
{
    public class ObjectReply
    {
        public string Message { get; set; }

        public EnumReply Reply { get; set; }
    }

    public class ObjectReply<T>: ObjectReply
    {
        public T Entity { get; set; }

    }
}
