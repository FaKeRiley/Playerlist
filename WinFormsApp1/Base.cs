using System;
using System.Drawing;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Base : Form
    {
        private Playerlist Playerlist1;
        private Worldlist Worldlist1;

        private bool isDragging = false;
        private Point offset;

        public Base()
        {
            InitializeComponent();
            // Event-Handler für das Panel hinzufügen
            this.panel1.MouseDown += new MouseEventHandler(MouseDown1);
            this.panel1.MouseMove += new MouseEventHandler(MouseMove1);
            this.panel1.MouseUp += new MouseEventHandler(MouseUp1);
        }

        private void Base_Load(object sender, EventArgs e)
        {
            // Falls weitere Initialisierungen erforderlich sind
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Playerlist1 == null || Playerlist1.IsDisposed)
            {
                // Öffne Playerlist
                Playerlist1 = new Playerlist();
                Playerlist1.Show();
            }
            else
            {
                // Schließe Playerlist
                Playerlist1.Close();
                Playerlist1 = null; // Setze die Referenz zurück
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Worldlist1 == null || Worldlist1.IsDisposed)
            {
                // Öffne Worldlist
                Worldlist1 = new Worldlist();
                Worldlist1.Show();
            }
            else
            {
                // Schließe Worldlist
                Worldlist1.Close();
                Worldlist1 = null; // Setze die Referenz zurück
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Falls weitere Zeichenoperationen erforderlich sind
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Falls weitere Zeichenoperationen erforderlich sind
        }

        private void MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                // Berechne den Offset relativ zur oberen linken Ecke des Panels
                offset = e.Location;
            }
        }

        private void MouseMove1(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Berechne die aktuelle Bildschirmposition des Mauszeigers
                Point mouseScreenPos = Control.MousePosition;

                // Berechne die neue Position der Form
                this.Location = new Point(
                    mouseScreenPos.X - offset.X,
                    mouseScreenPos.Y - offset.Y
                );
            }
        }

        
        private void MouseUp1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
