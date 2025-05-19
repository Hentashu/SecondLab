using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class _3RegistrationForm: Form
    {
        public int MAX_LENGHT_PHONENUM = 16;
        public int MAX_LENGTH_NAME = 50;
        public int MAX_LENGTH_EMAIL = 40;
        public int MAX_LENGTH_ID = 15;
        public int MAX_LENGTH = 20;
        public _3RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmReg_Click(object sender, EventArgs e) 
        {
            var ParticipantID = textBox4.Text;
            if (ParticipantID.Length > MAX_LENGTH_ID) 
            {
                MessageBox.Show($"Уникальный номер участника не должен превышать {MAX_LENGTH_ID} символов");
                return;
            }
            var Name = textBox1.Text;
            if (Name.Length > MAX_LENGTH_NAME)
            {
                MessageBox.Show($"Имя участника не должено превышать {MAX_LENGTH_ID} символов");
                return;
            }
            var Email = textBox2.Text;
            if (!Email.Contains("@"))
            {
                MessageBox.Show($"Неверный адрес электронной почты");
                return;
            }
            var PhoneNumber = textBox3.Text;
            if (PhoneNumber.Length > MAX_LENGHT_PHONENUM)
            {
                MessageBox.Show($"Номер телефона не должен превышать {MAX_LENGTH_ID} символов");
                return;
            }
            var eventIdRegistration = textBox5.Text;
            if (eventIdRegistration.Length > MAX_LENGTH)
            {
                MessageBox.Show($"Уникальный номер события не должен превышать {MAX_LENGTH_ID} символов");
                return;
            }
            Participant participant = new Participant(ParticipantID, Name, Email, PhoneNumber);
            EventManager.RegisterParticipant(eventIdRegistration, participant);
            MessageBox.Show($"Участник {Name} зарегистрирован на событие");
            Close();
        }




    }
}
