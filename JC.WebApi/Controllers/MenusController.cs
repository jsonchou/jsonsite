using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class MenusController : ApiController
    {
        BLL.menus bll = new JC.BLL.menus();
        Model.menus model = new Model.menus();
        List<Model.menus> modelList = new List<Model.menus>();

        // GET: api/Menus
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Menus/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        // POST: api/Menus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Menus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Menus/5
        public void Delete(int id)
        {
        }
    }
}
