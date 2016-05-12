using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSerilog
{
    public partial class Form1 : Form
    {
        ILogger _log;

        public Form1()
        {
            _log = new LoggerConfiguration()
                .WriteTo.LiterateConsole()
                .CreateLogger();

            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            _log.Information("Moved to {@Location}", Location);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _log.Information("Resized to {@Size}", Size);
        }
    }
}
