using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Interfaces
{
    public interface IHttpClientService
    {
        Task<TRes> PostRequestAsync<TReq, TRes>(string baseUrl, string requestUrl, TReq requestModel, string token = null)
            where TRes : class
            where TReq : class;
        Task<TRes> GetRequestAsync<TRes>(string baseUrl, string requestUrl, string token = null)
            where TRes : class;
    }
}
