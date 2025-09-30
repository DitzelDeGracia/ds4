﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8;

namespace Laboratorio8
{
    class Trabajador : Persona
        {
            // Campo de cada objeto Trabajador que almacena cuánto gana
            public int Sueldo;

            public Trabajador(string nombre, int edad, string nif, int sueldo)
                : base(nombre, edad, nif)
            {
                // Inicializamos cada Trabajador en base al constructor de Persona
                Sueldo = sueldo;
            }
        }
}
