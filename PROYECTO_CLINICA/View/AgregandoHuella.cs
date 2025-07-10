using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;

namespace PROYECTO_CLINICA.View
{
    public partial class AgregandoHuella : CaptureForm
    {
        public delegate void OnTemplateEvenhandler(DPFP.Template Template);
        public event OnTemplateEvenhandler OnTemplate;
        public DPFP.Processing.Enrollment Enroller;
        public AgregandoHuella()
        {
            InitializeComponent();
        }

        //Sobreescribimos el metodo Init() de la clase capture form
        protected override void Init()
        {
            base.Init();
            base.Text = "Dar de alta a huella de usuario";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            SetStatus(String.Format("Finger Print Samples Nedeed : {0}", Enroller.FeaturesNeeded));

        }

        protected override void Process(Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet Feature = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            try
            {
                if (Feature != null) try
                    {
                        MakeReport("The finger print Feauture set was Create");
                        Enroller.AddFeatures(Feature);
                    }

                    finally
                    {
                        UpdateStatus();
                        switch (Enroller.TemplateStatus)
                        {
                            case DPFP.Processing.Enrollment.Status.Ready:

                                OnTemplate(Enroller.Template);
                                SetPrompt("Click close and the finger Verification");
                                MessageBox.Show("Huella Capturada exitosamente..!");
                                Stop();
                                this.Close();
                                break;

                            case DPFP.Processing.Enrollment.Status.Failed:
                                MessageBox.Show("Error al capturar huella..!");
                                Enroller.Clear();
                                Stop();
                                UpdateStatus();
                                OnTemplate(null);
                                Start();
                                break;

                        }

                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AgregandoHuella_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
