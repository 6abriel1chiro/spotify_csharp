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
    public partial class main : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public main()
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

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        void loadDatagrid(DataGridView dgv, string query)
        {
            try {
                string myConnectionString;
                myConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\clases +\\SEM III\\BASES DE DATOS\\PROYECTO FINAL SPOTIFY\\vs\\spotify\\spotify\\spotyBase.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(myConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable auxTable = new DataTable();

                adapter.Fill(auxTable);
                dgv.DataSource = auxTable;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo cargar DatagridView",e.Message);
            }
        
        
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string query;
            query = "select * from songNames";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView1, query);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            string query;
            query = "select name,release,artist from Album";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView2, query);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string query;
            query = "select artistName,followers from Artist";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView3, query);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            string query;
            query = "select nomPlaylist,type from playlist";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView4, query);
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            albumInterface frm = new albumInterface();
            frm.ShowDialog();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            frmAddPlaylist frm = new frmAddPlaylist();
            frm.ShowDialog();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
           ArtistInterface frm = new ArtistInterface();
            frm.ShowDialog();

        }

        private void playlists_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            frmPlaylist frm = new frmPlaylist();
            frm.ShowDialog();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            songInterface frm = new songInterface();
            frm.ShowDialog();
        }

        private void canciones_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            string query;
            query = "select * from likedSongs";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView1, query);
        }

        private void materialFlatButton11_Click(object sender, EventArgs e)
        {
            string query;
            query = "select * from likedPl";
            dataGridView1.Visible = true;
            loadDatagrid(dataGridView4, query);
        }
    }
}
