using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
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
    public partial class ArtistInterface : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        string nomArtist = "";
        DataSet dstArtist;



        public ArtistInterface()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdArtist.Rows[e.RowIndex];
                nomArtist= row.Cells["artistName"].Value.ToString();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
          
            addAlbum frm = new addAlbum(nomArtist);
            frm.ShowDialog();
            this.Close();
            this.Dispose();

        }

        private void ArtistInterface_Load(object sender, EventArgs e)
        {
           // dstArtist =
            //GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from Artist");
           // dgdArtist.DataSource = dstArtist;
           // dgdArtist.DataMember = dstArtist.Tables[0].ToString();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            string sql = "select artistName,followers from artist where artistName like '" + materialSingleLineTextField1.Text+ "%'"; // si no funciona % use *
            dstArtist = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdArtist.DataSource = dstArtist;
                dgdArtist.DataMember = dstArtist.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            addSong frm = new addSong(nomArtist);
            frm.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
  
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            string sql = "select name,release from album where artist like '" + nomArtist + "%'"; // si no funciona % use *
            dstArtist = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdAlbums.DataSource = dstArtist;
                dgdAlbums.DataMember = dstArtist.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgdAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("ahora sigues a " + nomArtist) ;
            Close();
        }
    }
}
