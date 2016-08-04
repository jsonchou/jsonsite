using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class ModulesController : ApiController
    {
        BLL.modules bll = new JC.BLL.modules();
        Model.modules model = new Model.modules();
        List<Model.modules> modelList = new List<Model.modules>();

        // GET: api/Modules
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Modules/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        // POST: api/Modules
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Modules/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Modules/5
        public void Delete(int id)
        {
        }
    }
}
