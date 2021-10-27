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
    public partial class songInterface : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        string songName = "";
        string genre = "";

        public songInterface()
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

        private void songInterface_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            DataSet dstSong;

            string sql = "select songName, genre from song where songName like '" + materialSingleLineTextField1.Text + "%'"; // si no funciona % use *
                                                                                                                          //string sql = "select * from alumno where nom = '" + txtAlumno.Text + "'";
            dstSong = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdSong.DataSource = dstSong;
                dgdSong.DataMember = dstSong.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            // para insertar un registro no necesitamos el dataset, 
            // simplemente insertamos el texto que hemos ingresado.
            StringBuilder strInsert = new StringBuilder();
            // para probar hacemos la consulta para ingresar sólo la sigla: 
            // insert into materia(sigla) values('inf-102') 
            strInsert.AppendFormat("insert into likedSongs(songName, genre) values('{0}','{1}');", songName,genre);
            MessageBox.Show(strInsert.ToString());// para ver el sql generado 
            int cantPlaylistInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantPlaylistInsertadas.ToString() +
            "registro(s)", "Mensaje");
            Close();
        }

        private void dgdSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgdSong.Rows[e.RowIndex];
                songName = row.Cells["songName"].Value.ToString();
                genre = row.Cells["genre"].Value.ToString();

            }



        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reproduciendo" + songName);
        }
    }
}
