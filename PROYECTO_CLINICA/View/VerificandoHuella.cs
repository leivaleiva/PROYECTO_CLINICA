using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Model;
using PROYECTO_CLINICA.Controller;
using DPFP;

namespace PROYECTO_CLINICA.View
{
    public partial class VerificandoHuella : CaptureForm
    {
        private DPFP.Verification.Verification Verificator;
        //UsuariosController Con;
        UsuariosModel Usuario = new UsuariosModel();

        public PantallaLogin Padre;
        public VerificandoHuella()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificando Huella deUsuario";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }

        private void UpdateStatus(int Far)
        {
            SetStatus(String.Format("False Accept rate Far : {0}", Far));

        }

        protected override void Process(Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet Feature = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            try
            {
                if (Feature != null)
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Template Template = new Template();
                    Byte[] Huella = null;

                    foreach (DataRow Fila in UsuariosModel.GetUsuarios.Rows)
                    {
                        if (Fila["HUELLA"].ToString().Length > 0)
                        {
                            Huella = (Byte[])Fila["HUELLA"];
                            if (Huella.Length > 100)
                            {
                                Template.DeSerialize(Huella);
                                Verificator.Verify(Feature, Template, ref result);
                                UpdateStatus(result.FARAchieved);
                                if (result.Verified)
                                {
                                    MakeReport("Huella ha sido verificada correctamente");
                                    MessageBox.Show("Huella ha sido verificada correctamente" + Fila["ID_USUARIO"].ToString());
                                    //Padre.ID_USUARIO = Fila["ID_USUARIO"].ToString();
                                    //Padre.CONTRASENA = Fila["CONTRASENA"].ToString();
                                    Feature = null;
                                    Template = null;
                                    Stop();
                                    this.Close();
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void VerificandoHuella_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            new UsuariosController().ListarUsuarios();
        }
    }
}
