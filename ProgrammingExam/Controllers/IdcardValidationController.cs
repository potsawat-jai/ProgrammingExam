using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProgrammingExam.Controllers
{
    public class IdcardValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Route("api/Validation")]
        [HttpPost]
        public output Validation([FromBody] Idcardinput id)
        {
            var reply = new output();
            bool chkcitizen = true;
            var i = 0;
            var total = 0;

            if (id.citizenid.Length != 13 || id.citizenid.Length == 0) chkcitizen = false;

            if (chkcitizen)
            {
                string[] idcard = id.citizenid.ToCharArray().Select(c => c.ToString()).ToArray();
                foreach (var s in idcard)
                {
                    i++;
                    var value = Convert.ToInt32(s);
                    //sum += Convert.ToInt32(s) * (13 - i);
                    total = (total + ((value) * (13 - i)));

                }
                if ((11 - total % 11) % 10 != float.Parse(id.citizenid.Substring(12))) chkcitizen = false; chkcitizen = true;

                if (chkcitizen)
                {
                    reply.success = true;
                    reply.error_code = "200";
                    reply.error_msg = "";
                } else
                {
                    reply.success = false;
                    reply.error_code = "001";
                    reply.error_msg = "citizen_id invalid.";
                }
            } else
            {
                reply.success = false;
                reply.error_code = "001";
                reply.error_msg = "citizen_id is require.";
            }

            return reply;
        }

        public class Idcardinput
        {
            public string citizenid { get; set; }

        }

        public class output
        {
            public bool success { get; set; }
            public string error_code { get; set; }
            public string error_msg { get; set; }
        }
    }
}
