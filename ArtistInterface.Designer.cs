
namespace spotify
{
    partial class ArtistInterface
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
            this.dgdArtist = new System.Windows.Forms.DataGridView();
            this.buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgdAlbums = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdArtist
            // 
            this.dgdArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdArtist.Location = new System.Drawing.Point(94, 172);
            this.dgdArtist.Name = "dgdArtist";
            this.dgdArtist.Size = new System.Drawing.Size(503, 93);
            this.dgdArtist.TabIndex = 1;
            this.dgdArtist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buscar
            // 
            this.buscar.Depth = 0;
            this.buscar.Location = new System.Drawing.Point(388, 508);
            this.buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscar.Name = "buscar";
            this.buscar.Primary = true;
            this.buscar.Size = new System.Drawing.Size(97, 47);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "add album";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(517, 508);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(97, 47);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "add song";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(357, 36);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(206, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Artist:";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(619, 23);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(86, 36);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "buscar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(429, 486);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "tu eres este artista?";
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(291, 294);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(97, 47);
            this.materialRaisedButton4.TabIndex = 9;
            this.materialRaisedButton4.Text = "ver albumes";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // dgdAlbums
            // 
            this.dgdAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAlbums.Location = new System.Drawing.Point(687, 172);
            this.dgdAlbums.Name = "dgdAlbums";
            this.dgdAlbums.Size = new System.Drawing.Size(422, 209);
            this.dgdAlbums.TabIndex = 11;
            this.dgdAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAlbums_CellContentClick);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 435);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1137, 10);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(291, 368);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(97, 47);
            this.materialRaisedButton3.TabIndex = 13;
            this.materialRaisedButton3.Text = "seguir";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click_1);
            // 
            // ArtistInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 617);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.dgdAlbums);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.dgdArtist);
            this.Name = "ArtistInterface";
            this.Text = "ArtistInterface";
            this.Load += new System.EventHandler(this.ArtistInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgdArtist;
        private MaterialSkin.Controls.MaterialRaisedButton buscar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private System.Windows.Forms.DataGridView dgdAlbums;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}