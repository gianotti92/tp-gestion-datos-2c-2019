using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Utils;
using FrbaCrucero.Service;
using FrbaCrucero.Entities;

namespace FrbaCrucero
{
    public partial class Form1 : Form
    {
        public SavePersonService savePersonService {get; set;}
        public static FrbaCrucero.PagoReserva.Form1 PAGO_RESERVA_FORM = new FrbaCrucero.PagoReserva.Form1();

        public Form1(SavePersonService SavePersonService)
        {
            savePersonService = SavePersonService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsUtil.openNewForm(PAGO_RESERVA_FORM, this);
            Person person = new Person(1L, "37015791", "Lucas", "Gianotti", 26);
            savePersonService.save(person);
        }
    }
}