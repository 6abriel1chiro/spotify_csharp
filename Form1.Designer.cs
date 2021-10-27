
namespace spotify
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.canciones = new System.Windows.Forms.TabPage();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.albumes = new System.Windows.Forms.TabPage();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.artistas = new System.Windows.Forms.TabPage();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.playlists = new System.Windows.Forms.TabPage();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton11 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.canciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.albumes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.artistas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.playlists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.canciones);
            this.materialTabControl1.Controls.Add(this.albumes);
            this.materialTabControl1.Controls.Add(this.artistas);
            this.materialTabControl1.Controls.Add(this.playlists);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 93);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1132, 448);
            this.materialTabControl1.TabIndex = 0;
            // 
            // canciones
            // 
            this.canciones.BackColor = System.Drawing.Color.LightGray;
            this.canciones.Controls.Add(this.materialFlatButton10);
            this.canciones.Controls.Add(this.materialFlatButton8);
            this.canciones.Controls.Add(this.materialFlatButton1);
            this.canciones.Controls.Add(this.dataGridView1);
            this.canciones.ImageKey = "—Pngtree—love song icon_5273877.png";
            this.canciones.Location = new System.Drawing.Point(4, 23);
            this.canciones.Name = "canciones";
            this.canciones.Padding = new System.Windows.Forms.Padding(3);
            this.canciones.Size = new System.Drawing.Size(1124, 421);
            this.canciones.TabIndex = 0;
            this.canciones.Text = "canciones";
            this.canciones.Click += new System.EventHandler(this.canciones_Click);
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(291, 220);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(128, 36);
            this.materialFlatButton8.TabIndex = 4;
            this.materialFlatButton8.Text = "buscar cancion";
            this.materialFlatButton8.UseVisualStyleBackColor = false;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(29, 220);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(232, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "mostrar todas las canciones";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1132, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // albumes
            // 
            this.albumes.BackColor = System.Drawing.Color.LightGray;
            this.albumes.Controls.Add(this.materialFlatButton5);
            this.albumes.Controls.Add(this.materialFlatButton2);
            this.albumes.Controls.Add(this.dataGridView2);
            this.albumes.ImageKey = "compact-disc-with-glare.png";
            this.albumes.Location = new System.Drawing.Point(4, 23);
            this.albumes.Name = "albumes";
            this.albumes.Padding = new System.Windows.Forms.Padding(3);
            this.albumes.Size = new System.Drawing.Size(1124, 421);
            this.albumes.TabIndex = 1;
            this.albumes.Text = "albumes";
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(295, 230);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(114, 36);
            this.materialFlatButton5.TabIndex = 3;
            this.materialFlatButton5.Text = "buscar album";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(52, 230);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(142, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "mostrar Albumes";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1132, 208);
            this.dataGridView2.TabIndex = 1;
            // 
            // artistas
            // 
            this.artistas.BackColor = System.Drawing.Color.LightGray;
            this.artistas.Controls.Add(this.materialFlatButton7);
            this.artistas.Controls.Add(this.materialFlatButton3);
            this.artistas.Controls.Add(this.dataGridView3);
            this.artistas.ImageKey = "profile-user.png";
            this.artistas.Location = new System.Drawing.Point(4, 23);
            this.artistas.Name = "artistas";
            this.artistas.Size = new System.Drawing.Size(1124, 421);
            this.artistas.TabIndex = 2;
            this.artistas.Text = "artistas";
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Location = new System.Drawing.Point(269, 234);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(132, 36);
            this.materialFlatButton7.TabIndex = 3;
            this.materialFlatButton7.Text = "buscar artistas";
            this.materialFlatButton7.UseVisualStyleBackColor = false;
            this.materialFlatButton7.Click += new System.EventHandler(this.materialFlatButton7_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(35, 234);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(144, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "mostrar artistas";
            this.materialFlatButton3.UseVisualStyleBackColor = false;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1132, 208);
            this.dataGridView3.TabIndex = 1;
            // 
            // playlists
            // 
            this.playlists.BackColor = System.Drawing.Color.LightGray;
            this.playlists.Controls.Add(this.materialFlatButton11);
            this.playlists.Controls.Add(this.materialFlatButton9);
            this.playlists.Controls.Add(this.materialFlatButton6);
            this.playlists.Controls.Add(this.materialFlatButton4);
            this.playlists.Controls.Add(this.dataGridView4);
            this.playlists.ImageKey = "list-interface-symbol.png";
            this.playlists.Location = new System.Drawing.Point(4, 23);
            this.playlists.Name = "playlists";
            this.playlists.Size = new System.Drawing.Size(1124, 421);
            this.playlists.TabIndex = 3;
            this.playlists.Text = "playlists";
            this.playlists.Click += new System.EventHandler(this.playlists_Click);
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Location = new System.Drawing.Point(512, 236);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(130, 36);
            this.materialFlatButton9.TabIndex = 5;
            this.materialFlatButton9.Text = "buscar playlist";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            this.materialFlatButton9.Click += new System.EventHandler(this.materialFlatButton9_Click);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(294, 236);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton6.TabIndex = 4;
            this.materialFlatButton6.Text = "crear playlist";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(54, 236);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(141, 36);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "mostrar playlist";
            this.materialFlatButton4.UseVisualStyleBackColor = false;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1132, 208);
            this.dataGridView4.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "compact-disc-with-glare.png");
            this.imageList1.Images.SetKeyName(1, "list-interface-symbol.png");
            this.imageList1.Images.SetKeyName(2, "—Pngtree—love song icon_5273877.png");
            this.imageList1.Images.SetKeyName(3, "profile-user.png");
            this.imageList1.Images.SetKeyName(4, "Spotify_23464.ico");
            this.imageList1.Images.SetKeyName(5, "spotify_icon-icons.com_62652.ico");
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1132, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit.Depth = 0;
            this.exit.Image = global::spotify.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.exit.Location = new System.Drawing.Point(1062, 48);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit.Name = "exit";
            this.exit.Primary = false;
            this.exit.Size = new System.Drawing.Size(41, 36);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Location = new System.Drawing.Point(29, 284);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(232, 36);
            this.materialFlatButton10.TabIndex = 5;
            this.materialFlatButton10.Text = "mostrar canciones favoritas";
            this.materialFlatButton10.UseVisualStyleBackColor = false;
            this.materialFlatButton10.Click += new System.EventHandler(this.materialFlatButton10_Click);
            // 
            // materialFlatButton11
            // 
            this.materialFlatButton11.AutoSize = true;
            this.materialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton11.BackColor = System.Drawing.Color.DarkGreen;
            this.materialFlatButton11.Depth = 0;
            this.materialFlatButton11.Location = new System.Drawing.Point(54, 318);
            this.materialFlatButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton11.Name = "materialFlatButton11";
            this.materialFlatButton11.Primary = false;
            this.materialFlatButton11.Size = new System.Drawing.Size(218, 36);
            this.materialFlatButton11.TabIndex = 6;
            this.materialFlatButton11.Text = "mostrar playlist favoritas";
            this.materialFlatButton11.UseVisualStyleBackColor = false;
            this.materialFlatButton11.Click += new System.EventHandler(this.materialFlatButton11_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 543);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "spotify";
            this.Load += new System.EventHandler(this.main_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.canciones.ResumeLayout(false);
            this.canciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.albumes.ResumeLayout(false);
            this.albumes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.artistas.ResumeLayout(false);
            this.artistas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.playlists.ResumeLayout(false);
            this.playlists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage canciones;
        private System.Windows.Forms.TabPage albumes;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage artistas;
        private System.Windows.Forms.TabPage playlists;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private MaterialSkin.Controls.MaterialFlatButton exit;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton10;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton11;
    }
}

