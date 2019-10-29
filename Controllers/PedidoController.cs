﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agapea_MVC_NetCore.Interfaces;
using Agapea_MVC_NetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Agapea_MVC_NetCore.Controllers
{
    public class PedidoController : Controller
    {
        private IDBAccess __accesoDB;

        //private IHttpContextAccessor __httpContext; // <---- se recibe la inyección por parte del DI

        public PedidoController(/*IHttpContextAccessor _httpContext,*/ IDBAccess objetoAccesoDB)
        {
            //this.__httpContext = _httpContext;

            this.__accesoDB = objetoAccesoDB;
        }


        public IActionResult AddLibro(String id)
        {

            Dictionary<Libro, int> dicLibros = new Dictionary<Libro, int>();
            List<Libro> listLibros;
            Libro libroNuevo = __accesoDB.DevolverLibroPorISBN(id);
            String cookieLibros = HttpContext.Session.GetString("Libros");

            if (cookieLibros == null)
            {
                //no hay pedido
                
                dicLibros.Add(libroNuevo, 1);
                listLibros = new List<Libro>(dicLibros.Keys);

                HttpContext.Session.SetString("Libros", JsonConvert.SerializeObject(listLibros));
            }
            else
            {

                listLibros = JsonConvert.DeserializeObject<List<Libro>>(cookieLibros);
                listLibros.Add(libroNuevo);

                foreach (Libro libro in listLibros)
                {
                    if (dicLibros.ContainsKey(libro))
                    {
                        dicLibros[libro] += 1;
                    }
                    else
                    {
                        dicLibros.Add(libro, 1);
                    }
                }

                HttpContext.Session.SetString("Libros", JsonConvert.SerializeObject(listLibros));

            }

            return View("Carrito", dicLibros);
        }

        public IActionResult DropLibro(String id)
        {
            Dictionary<Libro, int> dicLibros = new Dictionary<Libro, int>();
            List<Libro> listLibros;
            Libro libroABorrar = __accesoDB.DevolverLibroPorISBN(id);
            String cookieLibros = HttpContext.Session.GetString("Libros");

            if (cookieLibros!=null)
            {
                listLibros = JsonConvert.DeserializeObject<List<Libro>>(cookieLibros);
                listLibros.Remove(libroABorrar);

                foreach (Libro libro in listLibros)
                {
                    if (dicLibros.ContainsKey(libro))
                    {
                        dicLibros[libro] += 1;
                    }
                    else
                    {
                        dicLibros.Add(libro, 1);
                    }
                }
            }

            return View("Carrito",dicLibros);
        }
    }
}