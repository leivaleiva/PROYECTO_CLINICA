using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PROYECTO_CLINICA.Model;

namespace PROYECTO_CLINICA.View
{
    public partial class Reporteador : Form
    {
        int NumeroReporte = 0;
        public Reporteador()
        {
            InitializeComponent();
        }

        public Reporteador(int Reporte)
        {
            InitializeComponent();
            NumeroReporte = Reporte;
        }

        void Reporteria()
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            if (NumeroReporte == 1)
            {
                this.reportViewer1.LocalReport.ReportPath = @"..\..\Reportes\ReportePacientes.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto-Implantacion-tecnologias-2024.Reportes.ReportePacientes.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", PacientesModel.GetPaciente));
            }
            else
            {
                if(NumeroReporte == 2)
                {
                    this.reportViewer1.LocalReport.ReportPath = @"..\..\Reportes\ReporteCita.rdlc";
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto-Implantacion-tecnologias-2024.Reportes.ReporteCita.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", CitasModel.GetCita));
                }
                else
                {
                    if(NumeroReporte == 3)
                    {
                        this.reportViewer1.LocalReport.ReportPath = @"..\..\Reportes\ReporteImprimirReceta.rdlc";
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto-Implantacion-tecnologias-2024.Reportes.ReporteImprimirReceta.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", RecetasModel.getReceta));
                    }
                    else
                    {
                        if (NumeroReporte == 4)
                        {
                            this.reportViewer1.LocalReport.ReportPath = @"..\..\Reportes\ReporteUsuario.rdlc";
                            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto-Implantacion-tecnologias-2024.Reportes.ReporteUsuario.rdlc";
                            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", RecetasModel.getReceta));

                        }
                    }
                }
            }
            
        }
    


        private void Reporteador_Load(object sender, EventArgs e)
        {
            Reporteria();
            this.reportViewer1.RefreshReport();
        }
    }
}
