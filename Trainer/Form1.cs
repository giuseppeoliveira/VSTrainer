using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer
{
    public partial class Form1 : Form
    {

        public FileManagerClass fileManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileManager = new FileManagerClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string fileName = "main.bundle.js";
            string sourcePath = @"\resources\app\.webpack\renderer";
            string targetPath = @"\resources\app\.webpack\renderer\Backup";

            1 - C:\Users\giuseppe_oliveira\Downloads\typescript-curso-1-arquivos-iniciais
            2 - \resources\app\.webpack\renderer
           
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.Directory.CreateDirectory(targetPath);
            System.IO.File.Copy(sourceFile, destFile, true);
            */


            fileManager.CriarBackup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop\Backup";
            string targetPath = @"C:\Users\giuseppe_oliveira\Desktop";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.File.Copy(sourceFile, destFile, true);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string power1 = fileRead.Replace("'power':0x", "'power':0x9999999");
            string power2 = fileRead.Replace("'power':0.1", "'power':0.9999999");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string amount = fileRead.Replace("'amount':0x", "'amount':0x9999999");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string magnet = fileRead.Replace("'magnet':0x", "'magnet':0x99999991");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string armor = fileRead.Replace("''armor':0x", "''armor':0x99999991");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string maxHp = fileRead.Replace("''maxHp':0x", "'maxHp':0x99999991");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string regenHp = fileRead.Replace("'regen':0x", "'regen':0x99999991");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string luck = fileRead.Replace("'luck':0x", "'luck':0x99999991");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string greed = fileRead.Replace("'greed':0x", "'greed':0x99999991");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = "main.bundle.js";
            string sourcePath = @"C:\Users\giuseppe_oliveira\Desktop";

            var fileRead = File.ReadAllText(sourcePath + '/' + fileName);
            string moveSpeed = fileRead.Replace("'moveSpeed':0x", "'moveSpeed':0x99999991");
        }
    }
}
