using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public SampleModel Get(int id)
        {
            var sample = new SampleModel();
            sample.Id = "82151";
            sample.Name = "Karol Żak";
            sample.Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nondum autem explanatum satis, erat, quid maxime natura vellet. An est aliquid per se ipsum flagitiosum, etiamsi nulla comitetur infamia? Nullus est igitur cuiusquam dies natalis. Multoque hoc melius nos veriusque quam Stoici. Duo Reges: constructio interrete. An hoc usque quaque, aliter in vita? Aliud igitur esse censet gaudere, aliud non dolere. Inde sermone vario sex illa a Dipylo stadia confecimus. Optime, inquam. A primo, ut opinor, animantium ortu petitur origo summi boni.";
            return sample;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
