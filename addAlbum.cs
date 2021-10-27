using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace spotify
{


    public partial class addAlbum : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public addAlbum(string artistName)
        {
            string Name = "";

            Name = artistName;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green400, Primary.Green500,
            Primary.Green500, Accent.Lime400,
           TextShade.WHITE);


            InitializeComponent();
        }

        private void addAlbum_Load(object sender, EventArgs e)
        {

        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // para insertar un registro no necesitamos el dataset, 
            // simplemente insertamos el texto que hemos ingresado.
            StringBuilder strInsert = new StringBuilder();
            // para probar hacemos la consulta para ingresar sólo la sigla: 
            // insert into materia(sigla) values('inf-102') 
            strInsert.AppendFormat("insert into album(name,release,artist) values('{0}','{1}','{2}');",
             materialSingleLineTextField1.Text, DateTime.Today.ToString(), Name);
            MessageBox.Show(strInsert.ToString());// para ver el sql generado 
            int cantPlaylistInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantPlaylistInsertadas.ToString() +
            "registro(s)", "Mensaje");
            Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
   
        }
    }
}
