using bertoni.web.test.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace bertoni.web.test.Controllers
{
    public class FotoController : Controller
    {
        // GET: Foto
        public ActionResult Index(int? album)
        {
            List<Photo> fotos = new List<Photo>();
            if (album.HasValue)
            {
                int albumId = album.Value;
                RespuestaFotos respuesta = JsonBase.GetFotos(albumId);
                bool GetFotosOK = respuesta.Codigo == "0";
                if (GetFotosOK)
                    fotos = respuesta.Data;
            }
            return View(fotos);
        }
    }
}