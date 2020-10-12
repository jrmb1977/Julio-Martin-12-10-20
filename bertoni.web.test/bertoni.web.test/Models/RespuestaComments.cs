using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.web.test.Models
{
    public class RespuestaComments: Respuesta
    {
        public List<Comment> Data { get; set; }
    }
}