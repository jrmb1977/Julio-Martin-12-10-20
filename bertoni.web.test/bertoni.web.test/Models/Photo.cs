using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace bertoni.web.test.Models
{
    public class Photo
    {
        [DisplayName("Código")]
        public int id { get; set; }//: 1, id pk auto numerico

        [DisplayName("Álbum")]
        public int albumId { get; set; }//: 1, fk agrupacioni        

        [DisplayName("Título")]
        public string title { get; set; }//: "accusamus beatae ad facilis cum similique qui sunt",

        [DisplayName("URL")]
        public string url { get; set; }//: "https://via.placeholder.com/600/92c952",

        [DisplayName("URL min")]
        public string thumbnailUrl { get; set; }//: "https://via.placeholder.com/150/92c952
    }
}