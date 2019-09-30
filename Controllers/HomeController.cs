﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agapea_MVC_NetCore.Models;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Agapea_MVC_NetCore.Interfaces;

namespace Agapea_MVC_NetCore.Controllers
{
    public class HomeController : Controller
    {
        // inyecto en el contructor un objeto que implemente interface IDBAccess: objetoAccesoBD
        //ese objeto va a ser acesivle a todos los metodos de accion de mi controlador por variavle privada: __accesoDB

        private IDBAccess __accesoDB;
        public HomeController(IDBAccess objetoAccesoDB) 
        {
            this.__accesoDB = objetoAccesoDB;
        }

        #region "metodos de accion del controlador"
        public IActionResult Index(int id)
        {
            if (id == null) id = 0;
            return View(this.__accesoDB.DevolverLibros(id));
        }
        #endregion
    }
}



