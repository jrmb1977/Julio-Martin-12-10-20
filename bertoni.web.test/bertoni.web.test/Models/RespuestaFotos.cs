using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.web.test.Models
{
    public class RespuestaFotos: Respuesta
    {
        public List<Photo> Data { get; set; }
    }
}