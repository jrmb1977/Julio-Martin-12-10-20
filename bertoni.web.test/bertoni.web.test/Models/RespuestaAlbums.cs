using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.web.test.Models
{
    public class RespuestaAlbums: Respuesta
    {
        public List<Album> Data { get; set; }
    }
}