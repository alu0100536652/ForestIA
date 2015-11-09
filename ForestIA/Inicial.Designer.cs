namespace ForestIA
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarDimensionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obstaculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protagonistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerView = new System.Windows.Forms.PictureBox();
            this.desplazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mapaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jugarToolStripMenuItem.Text = "Jugar";
            this.jugarToolStripMenuItem.Click += new System.EventHandler(this.jugarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mapaToolStripMenuItem
            // 
            this.mapaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarDimensionesToolStripMenuItem,
            this.obstaculosToolStripMenuItem,
            this.protagonistaToolStripMenuItem,
            this.objetivoToolStripMenuItem,
            this.desplazarToolStripMenuItem});
            this.mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            this.mapaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.mapaToolStripMenuItem.Text = "Mapa";
            // 
            // seleccionarDimensionesToolStripMenuItem
            // 
            this.seleccionarDimensionesToolStripMenuItem.Name = "seleccionarDimensionesToolStripMenuItem";
            this.seleccionarDimensionesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.seleccionarDimensionesToolStripMenuItem.Text = "Seleccionar dimensiones";
            this.seleccionarDimensionesToolStripMenuItem.Click += new System.EventHandler(this.seleccionarDimensionesToolStripMenuItem_Click);
            // 
            // obstaculosToolStripMenuItem
            // 
            this.obstaculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatoriosToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.obstaculosToolStripMenuItem.Name = "obstaculosToolStripMenuItem";
            this.obstaculosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.obstaculosToolStripMenuItem.Text = "Obstaculos";
            // 
            // aleatoriosToolStripMenuItem
            // 
            this.aleatoriosToolStripMenuItem.Name = "aleatoriosToolStripMenuItem";
            this.aleatoriosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aleatoriosToolStripMenuItem.Text = "Aleatorios";
            this.aleatoriosToolStripMenuItem.Click += new System.EventHandler(this.aleatoriosToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // protagonistaToolStripMenuItem
            // 
            this.protagonistaToolStripMenuItem.Name = "protagonistaToolStripMenuItem";
            this.protagonistaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.protagonistaToolStripMenuItem.Text = "Protagonista";
            this.protagonistaToolStripMenuItem.Click += new System.EventHandler(this.protagonistaToolStripMenuItem_Click);
            // 
            // objetivoToolStripMenuItem
            // 
            this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
            this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.objetivoToolStripMenuItem.Text = "Objetivo";
            this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.objetivoToolStripMenuItem_Click);
            // 
            // containerView
            // 
            this.containerView.Location = new System.Drawing.Point(0, 27);
            this.containerView.Name = "containerView";
            this.containerView.Size = new System.Drawing.Size(480, 480);
            this.containerView.TabIndex = 1;
            this.containerView.TabStop = false;
            this.containerView.Click += new System.EventHandler(this.containerView_Click);
            // 
            // desplazarToolStripMenuItem
            // 
            this.desplazarToolStripMenuItem.Name = "desplazarToolStripMenuItem";
            this.desplazarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.desplazarToolStripMenuItem.Text = "Desplazar";
            this.desplazarToolStripMenuItem.Click += new System.EventHandler(this.desplazarToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 506);
            this.Controls.Add(this.containerView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarDimensionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox containerView;
        private System.Windows.Forms.ToolStripMenuItem obstaculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protagonistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplazarToolStripMenuItem;
    }
}

