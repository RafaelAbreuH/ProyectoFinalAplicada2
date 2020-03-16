﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = " Nombre no puede estar vacío")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Usuario no puede estar vacío")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "La Contraseña no puede estar vacío")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "La Contraseña No Coincide ")]
        public string RepeatContraseña { get; set; }


        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "El Tipo Usuario no puede estar vacío")]
        public string TipodeUsuario { get; set; }
        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            TipodeUsuario = string.Empty;
        }
    }
}
