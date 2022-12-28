﻿using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Perfile? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new PerfileBC().obtenerPerfile(db, id);
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="operfile"></param>
        [HttpPost]
        public void Post([FromBody] Perfile operfile)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new PerfileBC().agregarPerfile(db, operfile);

            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Usuario"></param>
        /// <param name="Contraseña"></param>
        [HttpPut("{id}")]
        public void Put(int id, string Usuario, string Contraseña)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new PerfileBC().modificarPerfile(db, id, Usuario, Contraseña);
            }

        }
    }
}
