using System;
using System.Collections.Generic;
using System.Text;

namespace Model.API
{
    public class ApiRequest<TBody> where TBody : new()
    {
        public class Header 
        {
            /// <summary>
            /// Cultural
            /// </summary>
            public string Cultural { get; set; }

            /// <summary>
            /// Request|Response Time
            /// </summary>
            public DateTime Time { get; set; } = DateTime.Now;

            /// <summary>
            /// Current User Id
            /// </summary>
            public int UserId { get; set; }

            /// <summary>
            /// Api Url
            /// </summary>
            public string ApiUrl { get; set; }

            /// <summary>
            /// Api Method
            /// </summary>
            public string Method { get; set; }
        }

        public Header Head { get; set; } = new Header();
        public TBody Body { get; set; } = new TBody();
    }

    public class ApiResponse<TData> where TData : new()
    {
        public string Message { get; set; }
        public int Result { get; set; }
        public TData Data { get; set; } = new TData();
    }
}
