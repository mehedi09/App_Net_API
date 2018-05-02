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
    public class ELPLAPIController : ApiController
    {
        BasicUtilities _BasicUtilities = new BasicUtilities();
        API _API = new API();
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        //[HttpPost]
        // [System.Web.Http.Route("api/Get/id")]


        public HttpResponseMessage Get(string _CODE, string _BID, string _DEVICEID, string _USER, string _DTime)

        {
            DataTable _dtResult = _API.Check_GiftVoucher(_CODE, _DTime, _BID, _DEVICEID, _USER);
            List<Dictionary<string, object>> SearchItemList = _BasicUtilities.GetTableRows(_dtResult);

            HttpResponseMessage res;
            res = Request.CreateResponse(HttpStatusCode.OK, SearchItemList);
            return res; //Json(SearchItemList);
        }

        //[System.Web.Http.Route("api/ELPLAPI/GetCode/{_CODEREF}/{_BID}/{_DEVICEID}/{_USER}/{_DTime}")]
        //public HttpResponseMessage GetCode(string _CODEREF, string _BID, string _DEVICEID, string _USER, string _DTime)

        //{


        //    DataTable _dtResult = _API.Update_GiftVoucher(_CODEREF, _DTime, _BID, _DEVICEID, _USER);

        //    List<Dictionary<string, object>> _Result = _BasicUtilities.GetTableRows(_dtResult);

        //    HttpResponseMessage res;
        //    res = Request.CreateResponse(HttpStatusCode.OK, _Result);


        //    return res; //Json(SearchItemList);
        //}







        // // GET api/values/5
        //// [System.Web.Http.HttpPost]
        //[System.Web.Http.Route("api/ELPLAPI/PostData")]
        //public List<Dictionary<string, object>> PostData([FromBody] string _CODEREF, string _BID, string _DEVICEID, string _USER, string _DTime)
        //{
        //    // return "value";
        //    DataTable _dtResult = _API.Update_GiftVoucher(_CODEREF, _DTime, _BID, _DEVICEID, _USER);

        //    List<Dictionary<string, object>> _Result = _BasicUtilities.GetTableRows(_dtResult);

        //   // HttpResponseMessage res;
        //  //  res = Request.CreateResponse(HttpStatusCode.OK, _Result);


        //    return _Result; //Json(SearchItemList);
        //}

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

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
