using System;
using System.Threading;
using System.Windows.Forms;

namespace ScreenCoordinate
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            Thread tracer = new Thread(Tracer);
            tracer.Start();
        }

        private void Tracer()
        {
            while (true)
            {
                HorizontalValue.Text = MousePosition.X.ToString();
                VerticalValue.Text = MousePosition.Y.ToString();
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
