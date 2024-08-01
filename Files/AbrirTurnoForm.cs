using LaPosadaDAL.Models;
using LaPosadaDAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPosadaBackOffice
{
    public partial class AbrirTurnoForm : DevExpress.XtraEditors.XtraForm
    {
        private AbrirTurnoForm()
        {
            InitializeComponent();
        }

        public static Turno AbrirTurno()
        {
            DateTime? fechaTurno = null;
            AbrirTurnoForm abrirTurnoForm = new AbrirTurnoForm();
            var dialogResult = abrirTurnoForm.ShowDialog();

            if (dialogResult == DialogResult.Yes)
                fechaTurno = abrirTurnoForm.dateNavTurno.DateTime;
            
            abrirTurnoForm.Dispose();

            TurnoDAL turnoDAL = new TurnoDAL();

            Turno turno = null;

            if (fechaTurno != null)
            {
                 turno = turnoDAL.BuscarPorFechaInicio(fechaTurno.Value);

                if (turno == null)
                {
                    turno = new Turno();
                    turno.Save();
                    turno = turnoDAL.GetByKey(turno.IdTurno);
                }
            }

            return turno;
        }

        private void AbrirTurnoForm_Load(object sender, EventArgs e)
        {
            dateNavTurno.DateTime = DateTime.Today;
        }

        private void btnAbrirNuevoTurno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
