using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace spotify
{

    public partial class albumInterface : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public albumInterface()
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            DataSet dstInterface;
            string sql = "select name,release,artist from album where name like '" + materialSingleLineTextField1.Text + "%'"; // si no funciona % use *
                                                                                                              //string sql = "select * from alumno where nom = '" + txtAlumno.Text + "'";
            dstInterface = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdAlbum.DataSource = dstInterface;
                dgdAlbum.DataMember = dstInterface.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
