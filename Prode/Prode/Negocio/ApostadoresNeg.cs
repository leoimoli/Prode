﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;
using System.Windows.Forms;

namespace Prode.Negocio
{
    public class ApostadoresNeg
    {
        public static bool GuardarApostador(Apostadores _apostador)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_apostador);
                exito = ApostadoresDao.GuardarApostador(_apostador);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatos(Apostadores _apostador)
        {
            if (String.IsNullOrEmpty(_apostador.Apellido))
            {
                const string message = "El campo Apellido es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_apostador.Nombre))
            {
                const string message = "El campo Nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_apostador.Dni))
            {
                const string message = "El campo DNI es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (_apostador.Sexo == "Seleccione" || _apostador.Sexo == null)
            {
                const string message = "El campo Sexo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static List<Apostadores> BuscarApostadorPorApellidoYNombre(string apellidoNombre)
        {
            List<Apostadores> _listaApostadores = new List<Apostadores>();
            try
            {
                _listaApostadores = ApostadoresDao.BuscarApostadorPorApellidoYNombre(apellidoNombre);
            }
            catch (Exception ex)
            {
               
            }
            return _listaApostadores;
        }

        public static List<ResultadoApuestas> BuscarAciertos(string torneo, string temporada, string nroFecha,string Liga)
        {
            List<ResultadoApuestas> _listaAciertos = new List<ResultadoApuestas>();
            try
            {
                _listaAciertos = ApostadoresDao.BuscarAciertos(torneo, temporada, nroFecha, Liga);
            }
            catch (Exception ex)
            {
              
            }
            return _listaAciertos;
        }

        public static List<EstadisticasApuestas> BuscarEstadisticaGral(string torneo, string temporada, string nroFecha, string Liga)
        {
            List<EstadisticasApuestas> _lista = new List<EstadisticasApuestas>();
            try
            {
                _lista = ApostadoresDao.BuscarEstadisticaGral(torneo, temporada, nroFecha, Liga);
            }
            catch (Exception ex)
            {

            }
            return _lista;
        }
    }
}
