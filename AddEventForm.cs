using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using ConsoleApp1;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public int MAX_LENGTH_DESCRIPTION = 1000;
        public int MAX_LENGTH = 20;
        public int MAX_LENGHT_LOCATION = 75;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            var EventID = textBox2.Text;
            if (EventID.Length > MAX_LENGTH)
            { MessageBox.Show($"Специальный номер не должен превышать {MAX_LENGTH} символов");
                return;
            }
                
            var Title = textBox1.Text;
            if (EventID.Length > MAX_LENGTH)
            {
                MessageBox.Show($"Имя события не должено превышать {MAX_LENGTH} символов");
                return;
            }
            var Date = textBox4.Text;
            
            var Location = textBox3.Text;
            if (EventID.Length > MAX_LENGHT_LOCATION)
            {
                MessageBox.Show($"Место проведения мероприятия не должено превышать {MAX_LENGHT_LOCATION} символов");
                return;
            }
            var Description = textBox5.Text;
            if (EventID.Length > MAX_LENGTH_DESCRIPTION)
            {
                MessageBox.Show($"Описание не должено превышать {MAX_LENGTH_DESCRIPTION} символов");
                return;
            }
            Event conference = new Event(EventID, Title, DateTime.Now.AddDays(int.Parse(Date)), Location, Description);
            EventManager.AddEvent(conference);
            MessageBox.Show($"Событие {Title} добавлено в список");
            Close();
        }
    }
}
