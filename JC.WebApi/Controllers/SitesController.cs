using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class SitesController : ApiController
    {
        BLL.sites bll = new JC.BLL.sites();
        Model.sites model = new Model.sites();
        List<Model.sites> modelList = new List<Model.sites>();

        // GET: api/Sites
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sites/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        // POST: api/Sites
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sites/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sites/5
        public void Delete(int id)
        {
        }
    }
}
