using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.API
{
    public interface IApiRequest<TBody>
    {
        public TBody Body { get; set; }
    }
}
