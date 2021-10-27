using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MaterialSkin.Animations;

namespace spotify
{
    public partial class Login : MaterialForm
    {

        string connString = GestorDeBaseDeDatos.Instance.MyConnectionString;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green400, Primary.Green500,
             Primary.Green500, Accent.Lime400,
            TextShade.WHITE);



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            if (materialSingleLineTextField1.Text == "")
            {
                MessageBox.Show("por favor ingrese un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField1.Focus();
                return;
            }
            if (materialSingleLineTextField2.Text == "")
            {
                MessageBox.Show("por favor ingrese correo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField2.Focus();
                return;
            }
            if (materialSingleLineTextField3.Text == "")
            {
                MessageBox.Show("por favor ingrese password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField3.Focus();
                return;
            }
            try
            {
                SqlConnection myConn = default(SqlConnection);
                myConn = new SqlConnection(connString);
                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("SELECT Id,mail,password  from [User] where Id = @name AND mail = @mail AND password = @password", myConn);
                SqlParameter uName = new SqlParameter("@name", SqlDbType.Char);
                SqlParameter umail = new SqlParameter("@mail", SqlDbType.Char);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.Char);
                uName.Value = materialSingleLineTextField1.Text;
                umail.Value = materialSingleLineTextField2.Text;
                uPassword.Value = materialSingleLineTextField3.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(umail);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read())
                {
                    MessageBox.Show("ingreso exitoso " + materialSingleLineTextField1.Text);
                    main frm = new main();
                    this.Hide();

                    frm.ShowDialog();
                    

                }
                else
                {

                    MessageBox.Show("login fallido, intente de nuevo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    materialSingleLineTextField1.Clear();
                    materialSingleLineTextField3.Clear();
                    materialSingleLineTextField1.Focus();
                }
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }





        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            register frm = new register();
            this.Hide();

            frm.ShowDialog();
        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
