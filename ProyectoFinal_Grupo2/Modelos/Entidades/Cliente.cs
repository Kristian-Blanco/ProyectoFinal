﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo2.Modelos.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public byte[] Foto { get; set; }
    }
}
