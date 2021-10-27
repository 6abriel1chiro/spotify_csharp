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

namespace spotify
{
    public partial class register : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public register()
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField4.Text == "")
            {
                MessageBox.Show("por favor ingrese un Id unico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField1.Focus();
                return;
            }

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
                StringBuilder strInsert = new StringBuilder();
                StringBuilder strInsert2 = new StringBuilder();
                // para probar hacemos la consulta para ingresar sólo la sigla: 
                // insert into materia(sigla) values('inf-102') 
                strInsert.AppendFormat("insert into [User](Id,name,mail,password) values('{0}','{1}','{2}','{3}');", materialSingleLineTextField4.Text, materialSingleLineTextField1.Text, materialSingleLineTextField2.Text, materialSingleLineTextField3.Text);
                strInsert2.AppendFormat("insert into [artist](Id,artistName) values('{0}','{1}');", materialSingleLineTextField4.Text,artistNameText.Text);
                MessageBox.Show(strInsert.ToString());// para ver el sql generado 
                int cantMatsInsertadas =
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert2.ToString());
                MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
                "registro(s)", "Mensaje");
          


                if (cantMatsInsertadas>0)
                {
                    MessageBox.Show("registro exitoso " + materialSingleLineTextField1.Text);
                    main frm = new main();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {

                    MessageBox.Show("registro fallido, intente de nuevo, posiblemente ese ID ya est en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    materialSingleLineTextField2.Clear();
                    materialSingleLineTextField3.Clear();
                    materialSingleLineTextField4.Clear();
                    materialSingleLineTextField4.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField4.Text == "")
            {
                MessageBox.Show("por favor ingrese un Id unico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField1.Focus();
                return;
            }

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
                StringBuilder strInsert = new StringBuilder();
                StringBuilder strInsert2 = new StringBuilder();
                // para probar hacemos la consulta para ingresar sólo la sigla: 
                // insert into materia(sigla) values('inf-102') 
                strInsert.AppendFormat("insert into [User](Id,name,mail,password) values('{0}','{1}','{2}','{3}');", materialSingleLineTextField4.Text, materialSingleLineTextField1.Text, materialSingleLineTextField2.Text, materialSingleLineTextField3.Text);
                strInsert2.AppendFormat("insert into [listener](Id,userName,plan) values('{0}','{1}','{2}');", materialSingleLineTextField4.Text, materialSingleLineTextField1.Text, comboBox1.SelectedItem.ToString());
                MessageBox.Show(strInsert.ToString());// para ver el sql generado 
                int cantMatsInsertadas =
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert2.ToString());
                MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
                "registro(s)", "Mensaje");



                if (cantMatsInsertadas > 0)
                {
                    MessageBox.Show("registro exitoso " + materialSingleLineTextField1.Text);
                    main frm = new main();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {

                    MessageBox.Show("registro fallido, intente de nuevo, posiblemente ese ID ya est en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    materialSingleLineTextField2.Clear();
                    materialSingleLineTextField3.Clear();
                    materialSingleLineTextField4.Clear();
                    materialSingleLineTextField4.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
