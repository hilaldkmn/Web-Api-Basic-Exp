using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KisiController : ApiController
    {
        [HttpGet]
        public List<KisiBilgileri> GetAllData()
        {
            var responseList = new List<KisiBilgileri>
            {
                new KisiBilgileri
                {
                    Ad= "Hilal",
                    Soyad= "Dikman",
                    AktifMi=true,
                },
                 new KisiBilgileri
                {
                    Ad= "Hilal2",
                    Soyad= "Dikman2",
                    AktifMi=true,
                },

            };
            return responseList;
        }
    }
}
