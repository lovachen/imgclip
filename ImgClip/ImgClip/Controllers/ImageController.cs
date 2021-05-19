using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImgClip.Controllers
{

    public class ImageController : Controller
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("/")]
        public IActionResult DisPlay(string remote_url)
        {

            return Ok();
        }










    }
}
