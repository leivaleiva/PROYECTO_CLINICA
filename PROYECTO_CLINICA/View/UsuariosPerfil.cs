using PROYECTO_CLINICA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Controller;
using DPFP;
using System.Data.SqlClient;
using System.Configuration;

namespace PROYECTO_CLINICA.View
{
    public partial class UsuariosPerfil : Form
    {
        UsuariosModel Modelo;
        string Modo = "";
        public UsuariosLista Padre;
        private DPFP.Template Template;
        public UsuariosPerfil()
        {
            InitializeComponent();
            Modo = "Agregando";
        }

        public UsuariosPerfil(string ID_USUARIO)
        {
            InitializeComponent();
            Modo = "Actualizando";
            txtIdUsuario.Text = ID_USUARIO;
            txtIdUsuario.Enabled = false;

            foreach (DataRow Fila in UsuariosModel.GetUsuarios.Rows)
            {
                if (Fila["ID_USUARIO"].ToString() == ID_USUARIO)
                {
                    txtNombre.Text = Fila["NOMBRE"].ToString();
                    txtApellido.Text = Fila["APELLIDO"].ToString();
                    txtPassword.Text = Fila["CONTRASENA"].ToString();
                    cmbNivelUsuario.SelectedText = Fila["ID_NIVEL_USUARIO"].ToString();
                    txtEmail.Text = Fila["EMAIL"].ToString();
                    cmbRolUsuario.SelectedText = Fila["ID_ROL_USUARIO"].ToString();
                    cmbMedico.SelectedText = Fila["ID_DOCTOR"].ToString();
                    chkActivo.Checked = Boolean.Parse(Fila["Activo"].ToString());

                    break;
                }

            }

        }


        void Salvar()
        {
            Modelo = new UsuariosModel();

            Modelo.ID_USUARIO = txtIdUsuario.Text;
            Modelo.NOMBRE = txtNombre.Text;
            Modelo.APELLIDO = txtApellido.Text;
            Modelo.CONTRASENA = txtPassword.Text;
            Modelo.ID_NIVEL_USUARIO = int.Parse(cmbNivelUsuario.SelectedValue.ToString());
            Modelo.EMAIL = txtEmail.Text;
            Modelo.ID_ROL_USUARIO = int.Parse(cmbRolUsuario.SelectedValue.ToString());
            Modelo.ID_DOCTOR = int.Parse(cmbMedico.SelectedValue.ToString());
            Modelo.ACTIVO = chkActivo.Checked;
            Modelo.USER_CREACION = "REDMART";
            Modelo.USER_UPDATE = "REDMART";

            if (Modo == "Agregando")
            {
                if (new UsuariosController().CrearUsuarios(Modelo) == true)
                {
                    Padre.CargarDatos();
                    MessageBox.Show("Registro Agregado exitosamente..!!");
                    this.Close();
                }
            }
            else
            {
                if (new UsuariosController().ActualizarUsuarios(Modelo) == true)
                {
                    Padre.CargarDatos();
                    MessageBox.Show("Registro Editado exitosamente..!!");
                    this.Close();
                }
            }
        }

        Boolean Validando()
        {
            Boolean Valida = true;
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                Valida = false;
                txtIdUsuario.Focus();
                MessageBox.Show("IdUsuario no debe quedar vacio..!!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    Valida = false;
                    txtNombre.Focus();
                    MessageBox.Show("Nombre no debe quedar vacio..!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        Valida = false;
                        txtPassword.Focus();
                        MessageBox.Show("Password no debe quedar vacio..!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cmbNivelUsuario.Text))
                        {
                            Valida = false;
                            cmbNivelUsuario.Focus();
                            MessageBox.Show("Valide el Nivel del usuario..!!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtEmail.Text))
                            {
                                Valida = false;
                                txtEmail.Focus();
                                MessageBox.Show("Email no debe quedar vacio..!!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cmbRolUsuario.Text))
                                {
                                    Valida = false;
                                    cmbRolUsuario.Focus();
                                    MessageBox.Show("Valide el rol del usuario..!!");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(cmbMedico.Text))
                                    {
                                        Valida = false;
                                        cmbMedico.Focus();
                                        MessageBox.Show("Valide el Nombre del Medico..!!");
                                    }

                                }

                            }

                        }

                    }

                }

            }

            return Valida;
        }

        //aqui llenamos combo con el nivel del usuario
        public DataTable llenar_usuario_nivel() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_NIVEL_USUARIO, DESCRIPCION_NIVEL_USUARIO from NIVEL_USUARIO";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void llenar_combo_nivel_usuario() /// llenamos el combo con los datos del datatable
        {
            UsuariosPerfil opcar = new UsuariosPerfil();
            var dt = opcar.llenar_usuario_nivel();

            cmbNivelUsuario.ValueMember = "ID_NIVEL_USUARIO";
            cmbNivelUsuario.DisplayMember = "DESCRIPCION_NIVEL_USUARIO";
            cmbNivelUsuario.DataSource = dt;
            cmbNivelUsuario.SelectedIndex = 0;
        }

        //aqui llenamos combo con el rol del usuario
        public DataTable llenar_usuario_rol() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_ROL_USUARIO, DESCRIPCION_ROL_USUARIO from ROL_USUARIO";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void llenar_combo_rol_usuario() /// llenamos el combo con los datos del datatable
        {
            UsuariosPerfil opcar = new UsuariosPerfil();
            var dt = opcar.llenar_usuario_rol();

            cmbRolUsuario.ValueMember = "ID_ROL_USUARIO";
            cmbRolUsuario.DisplayMember = "DESCRIPCION_ROL_USUARIO";
            cmbRolUsuario.DataSource = dt;
            cmbRolUsuario.SelectedIndex = 0;
        }

        //aqui llenamos combo con el rol del usuario
        public DataTable llenar_medico() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "SELECT ID_DOCTOR, NOMBRE + ' ' + APELLIDO AS NOMBRE_COMPLETO FROM CATALOGO_DOCTORES";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void llenar_combo_medico() /// llenamos el combo con los datos del datatable
        {
            UsuariosPerfil opcar = new UsuariosPerfil();
            var dt = opcar.llenar_medico();

            cmbMedico.ValueMember = "ID_DOCTOR";
            cmbMedico.DisplayMember = "NOMBRE_COMPLETO";
            cmbMedico.DataSource = dt;
            cmbMedico.SelectedIndex = 0;
        }


        void AñadirHuella()
        {
            AgregandoHuella Reg = new AgregandoHuella();
            Reg.OnTemplate += this.OnTemplate;
            Reg.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                if (Template != null)
                {
                    lblMensajeHuella.Text = "Huella Creada Exitosamente";
                    lblMensajeHuella.ForeColor = Color.Green;

                    new UsuariosController().ActualizaHuellaUsuario(txtIdUsuario.Text, template);
                }
                else
                {
                    lblMensajeHuella.Text = "Error al crear la huella";
                    lblMensajeHuella.ForeColor = Color.Red;
                }
            }
            ));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Validando() == true)
            {
                Salvar();
            }
        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            AñadirHuella();
        }

        private void UsuariosPerfil_Load(object sender, EventArgs e)
        {
            llenar_combo_rol_usuario();
            llenar_combo_nivel_usuario();
            llenar_combo_medico();
        }
    }
}
