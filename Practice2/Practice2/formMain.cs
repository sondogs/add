using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Practice2
{
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
        }

        private void ChangeLanguage(string newLanguage)
        {
            var resources = new ComponentResourceManager(typeof(formMain));
            CultureInfo newCultureInfo = new CultureInfo(newLanguage);

            foreach (Control i in this.Controls)
                resources.ApplyResources(i, i.Name, newCultureInfo);
            foreach (Control i in this.gbAtribute.Controls)
                resources.ApplyResources(i, i.Name, newCultureInfo);
            foreach (ToolStripItem i in this.menuStrip.Items)
                resources.ApplyResources(i, i.Name, newCultureInfo);
            foreach (DataGridViewColumn i in this.dgvMain.Columns)
                resources.ApplyResources(i, i.Name, newCultureInfo);

            resources.ApplyResources(this, "$this", newCultureInfo);

            foreach (var item in statusStrip.Items.Cast<ToolStripItem>().Where(item => (item is ToolStripStatusLabel) != false))
                resources.ApplyResources(item, item.Name, newCultureInfo);

            TSDD_Language.Text = newCultureInfo.NativeName;
            SetCurrentLanguageButtonChecked();
        }

        private void SetCurrentLanguageButtonChecked()
        {
            foreach (ToolStripMenuItem languageButton in TSDD_Language.DropDownItems)
                languageButton.Checked = (languageButton.Text == TSDD_Language.Text);
        }

        public List<Cosmetic> shop = new List<Cosmetic>();
        public List<Settings> settings = new List<Settings>();

        private void formMain_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("settings.xml"))
            {
                Serialize.FromXml<List<Settings>>(ref settings, "settings.xml");

                if (settings.Last().deserializeFrom == "XML")
                    Serialize.FromXml<List<Cosmetic>>(ref shop, "shop.xml");
                else if (settings.Last().deserializeFrom == "JSON")
                    Serialize.FromJson<List<Cosmetic>>(ref shop, "shop.json");

                foreach (var i in shop)
                    dgvMain.Rows.Add(i.name, i.type, i.price.ToString());

                timer.Interval = settings.Last().timerInterval * 60 * 1000;
            }
            else
            {
                timer.Interval = 10 * 60 * 1000;
            }
            timer.Start();

            SetCurrentLanguageButtonChecked();

            cmbType.Items.Add("Male");
            cmbType.Items.Add("Female");
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rbJson.Checked)
                Serialize.ToJson<List<Cosmetic>>(ref shop, "shop.json");
            else
                Serialize.ToXml<List<Cosmetic>>(ref shop, "shop.xml");
        }

        public string patternName = "(^[А-ЯЁ]{1}[а-яё]{1,29})";
        public string patternPrice = "([0-9])";

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "") || (cmbType.SelectedIndex == -1) || (tbPrice.Text == ""))
                MessageBox.Show("Введите данные");
            else if ((!Regex.IsMatch(tbName.Text, patternName)) || (!Regex.IsMatch(tbPrice.Text, patternPrice)))
            {
                tbName.Text = "";
                cmbType.SelectedIndex = -1;
                tbPrice.Text = "";

                MessageBox.Show("Данные введены некоректно!");
            }
            else
            {
                Cosmetic obj = new Cosmetic();
                obj.name = tbName.Text;
                obj.type = cmbType.Text;
                obj.price = Convert.ToInt32(tbPrice.Text);
                shop.Add(obj);

                tbName.Text = "";
                cmbType.SelectedIndex = -1;
                tbPrice.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbJson.Checked)
                Serialize.ToJson<List<Cosmetic>>(ref shop, "shop.json");
            else if (rbXml.Checked)
                Serialize.ToXml<List<Cosmetic>>(ref shop, "shop.xml");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (rbJson.Checked)
                Serialize.ToJson<List<Cosmetic>>(ref shop, "shop.json");
            else if (rbXml.Checked)
                Serialize.ToXml<List<Cosmetic>>(ref shop, "shop.xml");
        }

        private void settingsMenu_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm;
            if (TSMI_English.Checked)
                settingsForm = new SettingsForm(true);
            else
                settingsForm = new SettingsForm(false);

            settingsForm.ShowDialog();
        }

        private void TSMI_Russian_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru");
        }

        private void TSMI_English_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            formCreateReport formCreateReport = new formCreateReport();
            formCreateReport.Show();
        }
    }
}