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

namespace WinFormsApp1
{
    public partial class _4RemoveForm: Form
    {
        public int MAX_LENGTH_ID = 15;
        public int MAX_LENGTH = 20;
        public _4RemoveForm()
        {
            InitializeComponent();
            LoadEvents();
        }
    
        private void LoadEvents() 
        {
            comboBox1.Items.Clear();
            foreach (var ev in EventManager.Events)
            {
                comboBox1.Items.Add(ev);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var selectedEvent = comboBox1.SelectedItem as Event;
            if (selectedEvent != null && EventManager.EventParticipants.TryGetValue(selectedEvent.EventID, out var participants))
            {
                foreach (var p in participants)
                {
                    var item = new ListViewItem(new[] { p.ParticipantID }); 
                    listView1.Items.Add(item);
                }
            }
        }

        private void buttonConfirmRemover_Click(object sender, EventArgs e) 
        {
            var EventID = textBox1.Text;
            if (EventID.Length > MAX_LENGTH)
            {
                MessageBox.Show($"Уникальный номер события не должен превышать {MAX_LENGTH} символов");
                return;
            }
            var ParticipantID = textBox2.Text;
            if (ParticipantID.Length > MAX_LENGTH_ID)
            {
                MessageBox.Show($"Уникальный номер участника не должен превышать {MAX_LENGTH_ID} символов");
                return;
            }
            EventManager.RemoveParticipant(EventID, ParticipantID);
            MessageBox.Show($"Участник удален");
            Close();
        }

    }
    }
}
