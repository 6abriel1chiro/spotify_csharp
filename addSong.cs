﻿using System;
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
    public partial class addSong : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        string codAlbum = "";
        string nomArtist = "";
        DataSet dstAlbum;


        public addSong(string nom)
        {
            nomArtist = nom;

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green400, Primary.Green500,
            Primary.Green500, Accent.Lime400,
           TextShade.WHITE);

        }

        private void addSong_Load(object sender, EventArgs e)
        {
            dstAlbum =
GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from album where artist like '" + nomArtist + "%'");
            dataGridView1.DataSource = dstAlbum;
            dataGridView1.DataMember = dstAlbum.Tables[0].ToString();

        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // para insertar un registro no necesitamos el dataset, 
            // simplemente insertamos el texto que hemos ingresado.
            StringBuilder strInsert = new StringBuilder();
            // para probar hacemos la consulta para ingresar sólo la sigla: 
            // insert into materia(sigla) values('inf-102') 
            strInsert.AppendFormat("insert into song(songName,codAlbum,genre) values('{0}','{1}','{2}');",
             materialSingleLineTextField1.Text, Convert.ToInt16(codAlbum), materialSingleLineTextField3.Text);
            MessageBox.Show(strInsert.ToString());// para ver el sql generado 
            int cantPlaylistInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantPlaylistInsertadas.ToString() +
            "registro(s)", "Mensaje");
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                codAlbum=row.Cells["Id"].Value.ToString();

            }

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
