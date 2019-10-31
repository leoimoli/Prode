﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using System.Windows.Forms;
using Prode.Dao;

namespace Prode.Negocio
{
    public class JugadoresNeg
    {
        public static int GuardarJugador(Jugadores _jugadores)
        {
            int idJugador = 0;
            try
            {
                ValidarDatos(_jugadores);
                //bool JugadorExistente = ValidarJugadorExistente(_equipo.NombreEquipo);
                idJugador = JugadoresDao.InsertJugador(_jugadores);
            }
            catch (Exception ex)
            {

            }
            return idJugador;
        }

        private static void ValidarDatos(Jugadores _jugadores)
        {
            if (String.IsNullOrEmpty(_jugadores.Apellido))
            {
                const string message = "El campo Apellido es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_jugadores.Nombre))
            {
                const string message = "El campo Nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }

            if (String.IsNullOrEmpty(_jugadores.Sexo))
            {
                const string message = "El campo Sexo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static bool EditarJugador(Jugadores _jugadores, int idJugador)
        {
            bool Exito = false;
            try
            {
                ValidarDatos(_jugadores);
                Exito = JugadoresDao.EditarJugador(_jugadores, idJugador);
            }
            catch (Exception ex)
            {

            }
            return Exito;
        }

        public static bool EliminarJugador(int idjugador)
        {
            bool Exito = false;
            try
            {
                Exito = JugadoresDao.EliminarJugador(idjugador);
            }
            catch (Exception ex)
            {

            }
            return Exito;
        }
        public static List<Jugadores> BuscarJugadoresPorApellidoYNombre(string apellidoNombre)
        {
            List<Jugadores> _listaJugadores = new List<Jugadores>();
            try
            {
                _listaJugadores = JugadoresDao.BuscarJugadoresPorApellidoYNombre(apellidoNombre);
            }
            catch (Exception ex)
            {

            }
            return _listaJugadores;
        }
    }
}