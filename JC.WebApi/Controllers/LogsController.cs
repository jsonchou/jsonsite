using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class LogsController : ApiController
    {
        BLL.logs bll = new JC.BLL.logs();
        Model.logs model = new Model.logs();
        List<Model.logs> modelList = new List<Model.logs>();

        // GET: api/Logs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Logs/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        // POST: api/Logs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Logs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Logs/5
        public void Delete(int id)
        {
        }
    }
}
