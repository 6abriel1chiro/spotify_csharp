using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace spotify
{
    public partial class frmPlaylist : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        string nomPlaylist="";

        public frmPlaylist()
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

        private void frmPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            DataSet dstPlaylist;

            string consulta = "select nomPlaylist,type from playlist where nomPlaylist like '" + materialSingleLineTextField1.Text + "%'"; // si no funciona % use *

            dstPlaylist = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            try 
            {
                dgdPlaylist.ReadOnly = true;
                dgdPlaylist.DataSource = dstPlaylist;
                dgdPlaylist.DataMember = dstPlaylist.Tables[0].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"No existe el nombre ingresado...");
                Close(); // equivale a this.Close(), que cierra el formulario actual
            }

        }

        private void dgdArtist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgdPlaylist.Rows[e.RowIndex];
                nomPlaylist = row.Cells["nomPlaylist"].Value.ToString();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            // para insertar un registro no necesitamos el dataset, 
            // simplemente insertamos el texto que hemos ingresado.
            StringBuilder strInsert = new StringBuilder();
            // para probar hacemos la consulta para ingresar sólo la sigla: 
            // insert into materia(sigla) values('inf-102') 
            strInsert.AppendFormat("insert into likedPl(nomPlaylist) values('{0}');", nomPlaylist);
            MessageBox.Show(strInsert.ToString());// para ver el sql generado 
            int cantPlaylistInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantPlaylistInsertadas.ToString() +
            "registro(s)", "Mensaje");
            Close();

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reproduciendo" + nomPlaylist);
        }
    }
}
