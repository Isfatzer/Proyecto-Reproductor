namespace Proyecto_Reproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.ListaCanciones = new System.Windows.Forms.ListBox();
            this.Volumen = new XComponent.SliderBar.MACTrackBar();
            this.DuracionCancion = new XComponent.SliderBar.MACTrackBar();
            this.Agregar_Canciones = new System.Windows.Forms.PictureBox();
            this.Borrar = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Agregar_Cancion = new System.Windows.Forms.PictureBox();
            this.Aleatorio = new System.Windows.Forms.PictureBox();
            this.Adelantar = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.Anterior = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar_Cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adelantar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(12, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(488, 301);
            this.Reproductor.TabIndex = 11;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // ListaCanciones
            // 
            this.ListaCanciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListaCanciones.FormattingEnabled = true;
            this.ListaCanciones.Location = new System.Drawing.Point(506, 12);
            this.ListaCanciones.Name = "ListaCanciones";
            this.ListaCanciones.Size = new System.Drawing.Size(213, 303);
            this.ListaCanciones.TabIndex = 12;
            this.ListaCanciones.SelectedIndexChanged += new System.EventHandler(this.ListaCanciones_SelectedIndexChanged);
            // 
            // Volumen
            // 
            this.Volumen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Volumen.BackColor = System.Drawing.Color.Transparent;
            this.Volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Volumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Volumen.IndentHeight = 6;
            this.Volumen.Location = new System.Drawing.Point(370, 389);
            this.Volumen.Maximum = 10;
            this.Volumen.Minimum = 0;
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(130, 22);
            this.Volumen.TabIndex = 13;
            this.Volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Volumen.TickHeight = 4;
            this.Volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Volumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.Volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Volumen.TrackLineHeight = 3;
            this.Volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volumen.Value = 0;
            this.Volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Volumen_ValueChanged);
            // 
            // DuracionCancion
            // 
            this.DuracionCancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DuracionCancion.BackColor = System.Drawing.Color.Transparent;
            this.DuracionCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.DuracionCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DuracionCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuracionCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.DuracionCancion.IndentHeight = 6;
            this.DuracionCancion.Location = new System.Drawing.Point(12, 319);
            this.DuracionCancion.Maximum = 100;
            this.DuracionCancion.Minimum = 0;
            this.DuracionCancion.Name = "DuracionCancion";
            this.DuracionCancion.Size = new System.Drawing.Size(488, 22);
            this.DuracionCancion.TabIndex = 14;
            this.DuracionCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.DuracionCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DuracionCancion.TickHeight = 4;
            this.DuracionCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DuracionCancion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DuracionCancion.TrackerSize = new System.Drawing.Size(10, 10);
            this.DuracionCancion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DuracionCancion.TrackLineHeight = 3;
            this.DuracionCancion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.DuracionCancion.Value = 0;
            // 
            // Agregar_Canciones
            // 
            this.Agregar_Canciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregar_Canciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar_Canciones.Image = global::Proyecto_Reproductor.Properties.Resources.carpeta;
            this.Agregar_Canciones.Location = new System.Drawing.Point(669, 319);
            this.Agregar_Canciones.Name = "Agregar_Canciones";
            this.Agregar_Canciones.Size = new System.Drawing.Size(22, 22);
            this.Agregar_Canciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agregar_Canciones.TabIndex = 10;
            this.Agregar_Canciones.TabStop = false;
            // 
            // Borrar
            // 
            this.Borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Borrar.Image = global::Proyecto_Reproductor.Properties.Resources.basura;
            this.Borrar.Location = new System.Drawing.Point(697, 319);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(22, 22);
            this.Borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Borrar.TabIndex = 9;
            this.Borrar.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::Proyecto_Reproductor.Properties.Resources.altavoz;
            this.pictureBox9.Location = new System.Drawing.Point(334, 380);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // Agregar_Cancion
            // 
            this.Agregar_Cancion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregar_Cancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar_Cancion.Image = global::Proyecto_Reproductor.Properties.Resources.mas;
            this.Agregar_Cancion.Location = new System.Drawing.Point(641, 319);
            this.Agregar_Cancion.Name = "Agregar_Cancion";
            this.Agregar_Cancion.Size = new System.Drawing.Size(22, 22);
            this.Agregar_Cancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agregar_Cancion.TabIndex = 7;
            this.Agregar_Cancion.TabStop = false;
            this.Agregar_Cancion.Click += new System.EventHandler(this.Agregar_Cancion_Click);
            // 
            // Aleatorio
            // 
            this.Aleatorio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Aleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aleatorio.Image = global::Proyecto_Reproductor.Properties.Resources.aleatorio;
            this.Aleatorio.Location = new System.Drawing.Point(290, 380);
            this.Aleatorio.Name = "Aleatorio";
            this.Aleatorio.Size = new System.Drawing.Size(32, 31);
            this.Aleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aleatorio.TabIndex = 5;
            this.Aleatorio.TabStop = false;
            // 
            // Adelantar
            // 
            this.Adelantar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Adelantar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adelantar.Image = global::Proyecto_Reproductor.Properties.Resources.proximo;
            this.Adelantar.Location = new System.Drawing.Point(220, 347);
            this.Adelantar.Name = "Adelantar";
            this.Adelantar.Size = new System.Drawing.Size(64, 64);
            this.Adelantar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Adelantar.TabIndex = 3;
            this.Adelantar.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Image = global::Proyecto_Reproductor.Properties.Resources.detener1;
            this.Stop.Location = new System.Drawing.Point(12, 347);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(64, 64);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Stop.TabIndex = 2;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Anterior
            // 
            this.Anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anterior.Image = global::Proyecto_Reproductor.Properties.Resources.anterior;
            this.Anterior.Location = new System.Drawing.Point(81, 347);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(64, 64);
            this.Anterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Anterior.TabIndex = 1;
            this.Anterior.TabStop = false;
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::Proyecto_Reproductor.Properties.Resources.pausasss;
            this.Play.Location = new System.Drawing.Point(150, 347);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(64, 64);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Play.TabIndex = 0;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.Controls.Add(this.DuracionCancion);
            this.Controls.Add(this.Volumen);
            this.Controls.Add(this.ListaCanciones);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.Agregar_Canciones);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Agregar_Cancion);
            this.Controls.Add(this.Aleatorio);
            this.Controls.Add(this.Adelantar);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar_Cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adelantar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Anterior;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox Adelantar;
        private System.Windows.Forms.PictureBox Aleatorio;
        private System.Windows.Forms.PictureBox Agregar_Cancion;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox Borrar;
        private System.Windows.Forms.PictureBox Agregar_Canciones;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox ListaCanciones;
        private XComponent.SliderBar.MACTrackBar Volumen;
        private XComponent.SliderBar.MACTrackBar DuracionCancion;
        private System.Windows.Forms.Timer timer1;
    }
}

