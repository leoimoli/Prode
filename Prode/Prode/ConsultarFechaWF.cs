using Prode.Entidades;
using Prode.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Prode
{
    public partial class ConsultarFechaWF : MasterWF
    {
        public ConsultarFechaWF()
        {
            InitializeComponent();
        }

        private void ConsultarFechaWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
            CargarCombos();
        }
        #region Botones
        private void btnExcel_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            //Open an excel instance and paste the copied data
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fecha> _fecha = new List<Fecha>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha);
                if (_fecha.Count > 0)
                {

                    dataGridView1.Visible = true;
                    for (int i = 0; i < _fecha.Count; i++)
                    {
                        lblValor.Text = Convert.ToString(_fecha[i].ValorJugada);
                        dataGridView1.Rows.Add(_fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, " ", _fecha[i].EquipoVisitante, " ");
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            ProgressBar();
            BloquearPantalla();
            //Document documentoPDF = new Document();
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 70;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                    }
                    else
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }
            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + cmbTorneo.Text + "Fecha N°" + txtFecha.Text, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                Paragraph p1 = new Paragraph("Competencia:" + cmbLiga.Text + "                  " + "Torneo:" + cmbTorneo.Text + "                                  " + "Fecha N°" + txtFecha.Text + "                                  " + "Valor De la Jugada: $" + lblValor.Text, FontFactory.GetFont(FontFactory.TIMES, 15, iTextSharp.text.Font.NORMAL));
                Paragraph pEspacio1 = new Paragraph("   ", FontFactory.GetFont(FontFactory.TIMES, 15, iTextSharp.text.Font.NORMAL));
                Paragraph pNotaDePie = new Paragraph("Por favor marcar con una x el resultado del partido. Solo se acepta un resultado por partido.", FontFactory.GetFont(FontFactory.TIMES, 10, iTextSharp.text.Font.NORMAL));
                Paragraph pDatosPersonales = new Paragraph("Dni:__________" + "Apellido:__________" + "Nombre:__________" + "Teléfono:____________________" + "Email:____________________", FontFactory.GetFont(FontFactory.TIMES, 15, iTextSharp.text.Font.NORMAL));
                Paragraph pTextoParaApostador = new Paragraph("Usted debe quedarse con este comprobante.", FontFactory.GetFont(FontFactory.TIMES, 10, iTextSharp.text.Font.NORMAL));
                ///// Primer recuadro
                pdfDoc.Add(p1);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pDatosPersonales);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(pNotaDePie);

                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pEspacio1);

                ///// Segundo recuadro
                pdfDoc.Add(p1);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pDatosPersonales);
                pdfDoc.Add(pEspacio1);
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(pTextoParaApostador);
                pdfDoc.Close();
                stream.Close();
            }
            const string message2 = "El archivo PDF se genero exitosamente.";
            const string caption2 = "Éxito";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk); LimpiarTodo();
            LimpiarTodo();
        }
        private List<Fecha> ObtenerDatosParaPdf()
        {
            List<Fecha> _lista = new List<Fecha>();
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                Fecha _jugada = new Fecha();
                string idPartido = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                string Fecha = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                string Estadio = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                string Local = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                string EquipoLocal = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                string Empate = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                string EquipoVisitante = dataGridView1.Rows[fila].Cells[6].Value.ToString();
                string Visitante = dataGridView1.Rows[fila].Cells[7].Value.ToString();
                _jugada.idPartido = Convert.ToInt32(idPartido);
                _jugada.Dia = Convert.ToDateTime(Fecha);
                _jugada.Estadio = Estadio;
                _jugada.CondicionLocal = Local;
                _jugada.EquipoLocal = EquipoLocal;
                _jugada.CondicionEmpate = Empate;
                _jugada.EquipoVisitante = EquipoVisitante;
                _jugada.CondicionVisitante = Visitante;
                _lista.Add(_jugada);

            }
            return _lista;
        }
        #endregion
        #region Funciones    
        private void LimpiarTodo()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            dataGridView1.Rows.Clear();
            groupBox2.Enabled = true;
            txtFecha.Clear();
            CargarCombos();
            dataGridView1.Visible = false;
            cmbTorneo.Text = "Seleccione";
        }
        private void BloquearPantalla()
        {
            groupBox2.Enabled = false;
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void CargarCombos()
        {
            List<string> Liga = new List<string>();
            Liga = TorneoNeg.CargarComboLiga();
            cmbLiga.Items.Clear();
            cmbLiga.Text = "Seleccione";
            cmbLiga.Items.Add("Seleccione");
            foreach (string item in Liga)
            {
                cmbLiga.Text = "Seleccione";
                cmbLiga.Items.Add(item);
            }
        }
        private void FuncionesBotonHabilitarBuscar()
        {
            cmbTorneo.Focus();
        }
        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    List<Fecha> _fecha = new List<Fecha>();
                    var torneo = cmbTorneo.Text;
                    string var = torneo;
                    string Torneo = var.Split('-')[0];
                    string Temporada = var.Split('-')[1];
                    string NroFecha = txtFecha.Text;
                    _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha);
                    if (_fecha.Count > 0)
                    {

                        dataGridView1.Visible = true;
                        for (int i = 0; i < _fecha.Count; i++)
                        {
                            lblValor.Text = Convert.ToString(_fecha[i].ValorJugada);
                            dataGridView1.Rows.Add(_fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, " ", _fecha[i].EquipoVisitante, " ");
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private void CargarComboTorneo(string Liga)
        {
            List<string> Torneo = new List<string>();
            Torneo = TorneoNeg.CargarComboTorneos(Liga);
            cmbTorneo.Items.Clear();
            cmbTorneo.Text = "Seleccione";
            cmbTorneo.Items.Add("Seleccione");
            foreach (string item in Torneo)
            {
                cmbTorneo.Text = "Seleccione";
                cmbTorneo.Items.Add(item);
            }
            cmbTorneo.Enabled = true;
        }
        private void cmbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Liga = cmbLiga.Text;
            if (Liga != "Seleccione")
            {
                CargarComboTorneo(Liga);
            }
            else
            {
                cmbTorneo.Enabled = false;
            }
        }
        #endregion

    }
}
