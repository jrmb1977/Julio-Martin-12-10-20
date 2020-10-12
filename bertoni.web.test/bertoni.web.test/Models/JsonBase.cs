using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace bertoni.web.test.Models
{
    public class JsonBase
    {
        public static RespuestaAlbums GetAlbums()
        {
            string Codigo = "0";
            string Mensaje = "OK";
            List<Album> ListaAlbums = new List<Album>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    //string urlComments= "https://jsonplaceholder.typicode.com/comments";
                    //var jsonComments = wc.DownloadString(urlComments);

                    string urlAlbums = "https://jsonplaceholder.typicode.com/albums";
                    var jsonAlbums = wc.DownloadString(urlAlbums);
                    ListaAlbums = JsonConvert.DeserializeObject<List<Album>>(jsonAlbums);                    
                }
            }
            catch (Exception exc)
            {
                Codigo = "9";
                Mensaje = String.Format("Error. Detalles: {0}", exc.Message);
            }

            RespuestaAlbums respuesta = new RespuestaAlbums { 
                Codigo = Codigo, 
                Mensaje = Mensaje,
                Data = ListaAlbums
            };
            return respuesta;
        }

        public static RespuestaFotos GetFotos()
        {
            string Codigo = "0";
            string Mensaje = "OK";
            List<Photo> ListaFotos = new List<Photo>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string urlPhotos = "https://jsonplaceholder.typicode.com/photos";
                    var jsonPhotos = wc.DownloadString(urlPhotos);
                    ListaFotos = JsonConvert.DeserializeObject<List<Photo>>(jsonPhotos);                   
                }
            }
            catch (Exception exc)
            {
                Codigo = "9";
                Mensaje = String.Format("Error. Detalles: {0}", exc.Message);
            }
            RespuestaFotos respuesta = new RespuestaFotos
            {
                Codigo = Codigo,
                Mensaje = Mensaje,
                Data = ListaFotos
            };
            return respuesta;
        }

        public static RespuestaComments GetComments()
        {
            string Codigo = "0";
            string Mensaje = "OK";
            List<Comment> ListaComments = new List<Comment>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string urlComments= "https://jsonplaceholder.typicode.com/comments";
                    var jsonComments = wc.DownloadString(urlComments);
                    ListaComments = JsonConvert.DeserializeObject<List<Comment>>(jsonComments);
                }
            }
            catch (Exception exc)
            {
                Codigo = "9";
                Mensaje = String.Format("Error. Detalles: {0}", exc.Message);
            }

            RespuestaComments respuesta = new RespuestaComments
            {
                Codigo = Codigo,
                Mensaje = Mensaje,
                Data = ListaComments
            };
            return respuesta;
        }

        public static RespuestaFotos GetFotos(int album)
        {
            string Codigo = "0";
            string Mensaje = "OK";
            List<Photo> ListaFotos = new List<Photo>();
            RespuestaFotos respuesta = GetFotos();
            bool GetFotosOK = respuesta.Codigo == "0";
            if (GetFotosOK)
            {
                ListaFotos = respuesta.Data;
                try
                {
                    ListaFotos = ListaFotos.Where(i => i.albumId == album).ToList();
                    respuesta.Data = ListaFotos;
                }
                catch (Exception exc)
                {
                    Codigo = "9";
                    Mensaje = String.Format("Error. Detalles: {0}", exc.Message);
                    respuesta.Codigo = Codigo;
                    respuesta.Mensaje = Mensaje;
                }
            }
            return respuesta;
        }

        public static RespuestaComments GetComments(int foto)
        {
            string Codigo = "0";
            string Mensaje = "OK";
            List<Comment> ListaComments = new List<Comment>();
            RespuestaComments respuesta = GetComments();
            bool GetFotosOK = respuesta.Codigo == "0";
            if (GetFotosOK)
            {
                ListaComments = respuesta.Data;
                try
                {
                    ListaComments = ListaComments.Where(i => i.postId == foto).ToList();
                    respuesta.Data = ListaComments;
                }
                catch (Exception exc)
                {
                    Codigo = "9";
                    Mensaje = String.Format("Error. Detalles: {0}", exc.Message);
                    respuesta.Codigo = Codigo;
                    respuesta.Mensaje = Mensaje;
                }
            }
            return respuesta;
        }
    }
}