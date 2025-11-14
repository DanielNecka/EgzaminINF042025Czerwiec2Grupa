using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace EgzaminINF042025Czerwiec2Grupa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            CaesarsCipher cezar = new CaesarsCipher(int.Parse(keyValue.Text), input.Text);

            Label result = new Label();
            result.Text = $"Wynik: {cezar.SchowResult()}";
            result.Font = new Font("Microsoft Sans Serif", 16);
            result.AutoSize = true;
            result.Location = new Point(18, 190);
            this.Controls.Add(result);

            string downloadsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );

            string filePath = Path.Combine(downloadsPath, "result.txt");

            File.WriteAllText(filePath, cezar.SchowResult());
        }
    }
}
