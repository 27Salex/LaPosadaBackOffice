namespace LaPosadaBackOffice
{
    partial class AbrirTurnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirTurnoForm));
            this.btnAbrirNuevoTurno = new DevExpress.XtraEditors.SimpleButton();
            this.dateNavTurno = new DevExpress.XtraScheduler.DateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavTurno.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirNuevoTurno
            // 
            this.btnAbrirNuevoTurno.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirNuevoTurno.Appearance.Options.UseFont = true;
            this.btnAbrirNuevoTurno.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAbrirNuevoTurno.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirNuevoTurno.Name = "btnAbrirNuevoTurno";
            this.btnAbrirNuevoTurno.Size = new System.Drawing.Size(250, 41);
            this.btnAbrirNuevoTurno.TabIndex = 0;
            this.btnAbrirNuevoTurno.Text = "Abrir turno";
            this.btnAbrirNuevoTurno.Click += new System.EventHandler(this.btnAbrirNuevoTurno_Click);
            // 
            // dateNavTurno
            // 
            this.dateNavTurno.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavTurno.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavTurno.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavTurno.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateNavTurno.EditValue = "01/07/2024 0:00:00";
            this.dateNavTurno.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavTurno.Location = new System.Drawing.Point(12, 59);
            this.dateNavTurno.Name = "dateNavTurno";
            this.dateNavTurno.Size = new System.Drawing.Size(250, 233);
            this.dateNavTurno.TabIndex = 1;
            // 
            // AbrirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 307);
            this.Controls.Add(this.dateNavTurno);
            this.Controls.Add(this.btnAbrirNuevoTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AbrirTurnoForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbrirTurnoForm";
            this.Text = "Backend la posada - Abrir Turno";
            this.Load += new System.EventHandler(this.AbrirTurnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavTurno.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAbrirNuevoTurno;
        private DevExpress.XtraScheduler.DateNavigator dateNavTurno;
    }
}