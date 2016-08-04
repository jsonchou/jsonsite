using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace JC.WebApi.Controllers
{
    public class PostsController : ApiController
    {
        BLL.posts bll = new JC.BLL.posts();
        Model.posts model = new Model.posts();
        List<Model.posts> modelList = new List<Model.posts>();

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            model = bll.Get(id);
            return JsonConvert.SerializeObject(model);
        }

        [Authorize]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [Authorize]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [Authorize]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
