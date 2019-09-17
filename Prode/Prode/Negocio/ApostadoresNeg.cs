using System;
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
            if (_apostador.Sexo != "Seleccione")
            {
                const string message = "El campo Sexo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
    }
}
