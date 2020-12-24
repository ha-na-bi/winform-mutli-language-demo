using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = LangUtil.SupportLanguages;
            comboBox1.SelectedItem = CultureInfo.CurrentCulture.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LangUtil.SetDefaultLang(comboBox1.SelectedItem.ToString());

            // 询问是否重启
            DialogResult result = MessageBox.Show(
                text: LangResx.Common.DONE + LangResx.Common.RESTART_NOW, caption: "",
                buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
