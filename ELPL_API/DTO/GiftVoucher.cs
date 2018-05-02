using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELPL_API.DTO
{

    public class GiftVoucher
    {
//        @CODE AS VARCHAR(20),
//@DOCDATE AS SMALLDATETIME,
//@BID as int,
//@DEVICEID AS VARCHAR(20),
//@USER AS INT

        public string CODE { get; set; }
        public string DOCDATE { get; set; }
        public string BID { get; set; }
        public string DEVICEID { get; set; }
        public string USER { get; set; }
        public string DateTime { get; set; }
      
    }
}