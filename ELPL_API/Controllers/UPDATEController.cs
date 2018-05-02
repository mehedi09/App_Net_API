using ELPL_API.DAL;
using ELPL_API.DTO;
using ELPL_API.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ELPL_API.Controllers
{
    public class UPDATEController : ApiController
    {
        BasicUtilities _BasicUtilities = new BasicUtilities();
        API _API = new API();
     
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(string _CODEREF, string _BID, string _DEVICEID, string _USER, string _DTime)
        {

            DataTable _dtResult = _API.Update_GiftVoucher(_CODEREF, _DTime, _BID, _DEVICEID, _USER);

            List<Dictionary<string, object>> _Result = _BasicUtilities.GetTableRows(_dtResult);

            HttpResponseMessage res;
            res = Request.CreateResponse(HttpStatusCode.OK, _Result);


            return res; //Json(SearchItemList);
        }
        

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}