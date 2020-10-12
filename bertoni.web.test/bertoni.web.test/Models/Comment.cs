using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.web.test.Models
{
    public class Comment
    {
        public int id { get; set; }//: 1, id pk auto numerico
        public int postId { get; set; }//: 1, agrupacion fk photo       
        public string name { get; set; }//: "id labore ex et quam laborum",
        public string email { get; set; }//: "Eliseo@gardner.biz",
        public string body { get; set; }//: "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
    }
}