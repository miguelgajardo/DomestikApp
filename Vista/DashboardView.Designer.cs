namespace DomestikApp.Vista
{
    partial class DashboardView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajerosToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.reservasToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1215, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPasajerosToolStripMenuItem});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(131, 38);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            // 
            // gestionarPasajerosToolStripMenuItem
            // 
            this.gestionarPasajerosToolStripMenuItem.Name = "gestionarPasajerosToolStripMenuItem";
            this.gestionarPasajerosToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.gestionarPasajerosToolStripMenuItem.Text = "Gestionar Pasajeros";
            this.gestionarPasajerosToolStripMenuItem.Click += new System.EventHandler(this.gestionarPasajerosToolStripMenuItem_Click);
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarVuelosToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(105, 38);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            // 
            // gestionarVuelosToolStripMenuItem
            // 
            this.gestionarVuelosToolStripMenuItem.Name = "gestionarVuelosToolStripMenuItem";
            this.gestionarVuelosToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.gestionarVuelosToolStripMenuItem.Text = "Gestionar Vuelos";
            this.gestionarVuelosToolStripMenuItem.Click += new System.EventHandler(this.gestionarVuelosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(125, 38);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // gestionarReservasToolStripMenuItem
            // 
            this.gestionarReservasToolStripMenuItem.Name = "gestionarReservasToolStripMenuItem";
            this.gestionarReservasToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.gestionarReservasToolStripMenuItem.Text = "Gestionar Reservas";
            this.gestionarReservasToolStripMenuItem.Click += new System.EventHandler(this.gestionarReservasToolStripMenuItem_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardView";
            this.Text = "Panel de Control - DomestikApp";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarReservasToolStripMenuItem;
    }
}