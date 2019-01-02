using DonarKart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
namespace DonarKart.Controllers
{
    public class DonarKartController : ApiController
    {
        [HttpPost]
        [Route("api/donorcreation")]
        public IHttpActionResult DonorCreation(Donor data)
        {
            try
            {
                StreamWriter sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/log.txt"),true);
                sw.WriteLine("user created:" +data.Name +","+data.Email+","+data.Phone+" on "+DateTime.Now);
                sw.Close();
                
                return Ok("user created");
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/log.txt"));
                sw.WriteLine("Exception Occured on " + DateTime.Now);
                sw.Close();
                return   Ok("Exception Occured");
            } 
        }
        [HttpPost]
        [Route("api/emailsending")]
        public IHttpActionResult EmailSending(Email data)
        {
            try
            {
                StreamWriter sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/log.txt"),true);
                sw.WriteLine("Email Sent:"+ "on:"+DateTime.Now + " To:"+ data.ToEmail + "," +"From:"+ data.FromEmail + "," + "Body:"+data.Body);
                sw.Close();
                
                return Ok("Email Sent");
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/log.txt"));
                sw.WriteLine("Exception Occured on " + DateTime.Now);
                sw.Close();
                return Ok("Exception Occured");
            }
        }


    }
}
