using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class UsersController : ApiController
    {
        BLL.users bll = new JC.BLL.users();
        Model.users model = new Model.users();
        List<Model.users> modelList = new List<Model.users>();

        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
