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
    public partial class frmAddPlaylist : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmAddPlaylist()
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

        private void frmAddPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void createPlaylistBtn_Click(object sender, EventArgs e)
        {

        
                // para insertar un registro no necesitamos el dataset, 
                // simplemente insertamos el texto que hemos ingresado.
                StringBuilder strInsert = new StringBuilder();
                // para probar hacemos la consulta para ingresar sólo la sigla: 
                // insert into materia(sigla) values('inf-102') 
                strInsert.AppendFormat("insert into playlist(nomPlaylist,type) values('{0}','{1}');",
                 materialSingleLineTextField2.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
                MessageBox.Show(strInsert.ToString());// para ver el sql generado 
                int cantPlaylistInsertadas =
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                MessageBox.Show("se ingresó " + cantPlaylistInsertadas.ToString() +
                "registro(s)", "Mensaje");
                Close();

          


        }
    }
}
