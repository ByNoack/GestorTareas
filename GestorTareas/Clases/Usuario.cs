﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorTareas.Clases
{
    internal class Usuario
    {
        private int userId;
        private string username;
        private string email;
        private string password;

        public Usuario(string username, string email, string password)
        {
            UserId = GenerarIdAleatorio();
            Username = username;
            Email = email;
            Password = password;
        }

        public int UserId { get => userId; private set => userId = value; }

        public string Username
        {
            get => username;
            set
            {
                if (value.Length >= 3)
                    username = value;
                else
                    throw new ArgumentException("El nombre de usuario debe " +
                        "tener al menos 3 caracteres.");
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (value.Contains("@"))
                    email = value;
                else
                    throw new ArgumentException("Esto no es un email válido.");
            }
        }

        public string Password { get => password;
            set => password = value; }

        private int GenerarIdAleatorio()
        {
            try
            {
                Random random = new Random();
                // Generar un ID aleatorio de 4 dígitos
                //que esté entre 1000 y 9999
                return random.Next(1000, 10000);
            }
            catch(Exception e)
            {
                return -1;
            }
            
            
        }

    }
}
