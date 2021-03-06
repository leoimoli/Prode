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
        public static List<JugadorEstadisticaPartido> BuscarEstadisticaGeneralPorJugador(int idJugador)
        {
            List<JugadorEstadisticaPartido> _listaEstadistica = new List<JugadorEstadisticaPartido>();
            try
            {
                _listaEstadistica = JugadoresDao.BuscarEstadisticaGeneralPorJugador(idJugador);
            }
            catch (Exception ex)
            {

            }
            return _listaEstadistica;
        }
        public static List<Jugadores> BuscarJugadoresPorId(int idJugadorStatic)
        {
            List<Jugadores> _listaJugadores = new List<Jugadores>();
            try
            {
                _listaJugadores = JugadoresDao.BuscarJugadoresPorId(idJugadorStatic);
            }
            catch (Exception ex)
            {

            }
            return _listaJugadores;
        }
        public static bool GuardarFichaTecnicaJugador(FichaTecnica _fichaJugadores)
        {
            bool Exito = false;
            try
            {
                ValidarFichaTecnica(_fichaJugadores);
                Exito = JugadoresDao.AltaFichaTecnica(_fichaJugadores);
            }
            catch (Exception ex)
            {

            }
            return Exito;
        }
        private static void ValidarFichaTecnica(FichaTecnica _fichaJugadores)
        {
            if (_fichaJugadores.IdJugador <= 0)
            {
                const string message = "Atención, operación invalida falta el identificador del jugador..";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static bool EditarFichaTecnicaJugador(FichaTecnica _fichaJugadores)
        {
            bool Exito = false;
            try
            {
                Exito = JugadoresDao.EditarFichaTecnicaJugador(_fichaJugadores);
            }
            catch (Exception ex)
            {

            }
            return Exito;
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
        public static List<FichaTecnica> BuscarFichaTecnica(int idJugador)
        {
            List<FichaTecnica> _listaJugadores = new List<FichaTecnica>();
            try
            {
                _listaJugadores = JugadoresDao.BuscarFichaTecnicaPorIdJugador(idJugador);
            }
            catch (Exception ex)
            {

            }
            return _listaJugadores;
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
        public static List<string> CargarComboPuestos()
        {
            List<string> lista = new List<string>();
            lista = JugadoresDao.CargarComboPuestos();
            return lista;
        }
        public static List<string> BuscarPosicionesPorPuestoSeleccionado(string puesto)
        {
            List<string> lista = new List<string>();
            lista = JugadoresDao.CargarComboPosiciones(puesto);
            return lista;
        }
        public static byte[] BuscarImagenJugador(int idJugador)
        {
            byte[] Imagen = new Byte[10]; ;
            try
            {
                Imagen = JugadoresDao.BuscarImagenJugador(idJugador);
            }
            catch (Exception ex)
            {

            }
            return Imagen;
        }
        public static List<AlineacionEquipo> BuscarJugadoresSinAsignar()
        {
            List<AlineacionEquipo> _listaJugadores = new List<AlineacionEquipo>();
            try
            {
                _listaJugadores = JugadoresDao.BuscarJugadoresSinAsignar();
            }
            catch (Exception ex)
            {

            }
            return _listaJugadores;
        }

        public static List<JugadorEstadisticaPartido> BuscarEstadisticPorTorneoPorJugador(int idJugador, string torneoFinal, string ligaFinal, string temporadaFinal)
        {
            List<JugadorEstadisticaPartido> _listaEstadistica = new List<JugadorEstadisticaPartido>();
            try
            {
                _listaEstadistica = JugadoresDao.BuscarEstadisticPorTorneoPorJugador(idJugador, torneoFinal, ligaFinal, temporadaFinal);
            }
            catch (Exception ex)
            {

            }
            return _listaEstadistica;
        }

        public static List<JugadorEstadisticaPartido> BuscarEstadisticPorEquipoPorJugador(int idJugador, string equipo)
        {
            List<JugadorEstadisticaPartido> _listaEstadistica = new List<JugadorEstadisticaPartido>();
            try
            {
                _listaEstadistica = JugadoresDao.BuscarEstadisticaPorEquipoPorJugador(idJugador, equipo);
            }
            catch (Exception ex)
            {

            }
            return _listaEstadistica;
        }

        public static List<JugadorEstadisticaPartido> BuscarEstadisticaEntrenamientoPorJugador(int idJugador)
        {
            List<JugadorEstadisticaPartido> _listaEstadistica = new List<JugadorEstadisticaPartido>();
            try
            {
                _listaEstadistica = JugadoresDao.BuscarEstadisticaEntrenamientoPorJugador(idJugador);
            }
            catch (Exception ex)
            {

            }
            return _listaEstadistica;
        }
    }
}
