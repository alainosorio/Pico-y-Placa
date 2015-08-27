using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicoPlaca
{
    public partial class PicoPlaca : Form
    {
        Schedule.Schedule schedule = null;
        
        Registration.Registration vehicle = null;

        
        public PicoPlaca()
        {
            InitializeComponent();

            comboBoxCountry.SelectedIndex = 2;

            dateTimePicker.MinDate = DateTime.Now;
        }

        public String ValidateSchedule(Schedule.Schedule schedule, Registration.Registration vehicle)
        {
            String information = "";
            
            try
            {

                if (comboBoxCountry.SelectedItem.ToString() == Registration.Country.country_name.Ecuador.ToString())
                {
                    vehicle = new Registration.EcuadorRegistration(this.textBoxRegistration.Text);

                    schedule = new Schedule.EcuadorSchedule();

                    DateTime dt = new DateTime();

                    dt = Convert.ToDateTime(dateTimePicker.Text);

                    if (!(schedule as Schedule.EcuadorSchedule).EcuadorValidator(vehicle, dt))

                        information = "El vehículo con matrícula " + vehicle.Number + " no puede conducir en la ciudad de Quito entre las las 7:00 y las 9:30 en la mañana y entre las 16:00 y las 19:30 en la tarde y noche.";
                    else
                        information = "El vehículo con matrícula " + vehicle.Number + " puede conducir libremente en la ciudad de Quito en la fecha seleccionada.";
                }
                else
                    information = "Información solo disponible para " + Registration.Country.country_name.Ecuador.ToString();
                
            }
            catch (Exception exception)
            {
                information = exception.Message;
            }

            return information;
        }

        private void buttonAcept_Click(object sender, EventArgs e)
        {
            String information = this.ValidateSchedule(this.schedule, this.vehicle);

            MessageBox.Show(information, "Horario Pico & Placa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
