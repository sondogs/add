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

namespace Practice2
{
    public partial class SettingsForm : Form
    {
        public bool english;

        public SettingsForm(bool english)
        {
            InitializeComponent();
            this.english = english;
        }

        private void ChangeLanguage(string newLanguage)
        {
            var resources = new ComponentResourceManager(typeof(SettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(newLanguage);

            foreach (Control i in this.Controls)
                resources.ApplyResources(i, i.Name, newCultureInfo);

            foreach (Control i in this.gbInterval.Controls)
                resources.ApplyResources(i, i.Name, newCultureInfo);

            resources.ApplyResources(this, "$this", newCultureInfo);
        }

        public List<Settings> settings = new List<Settings>();

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (english)
            {
                ChangeLanguage("en");
            }

            if (System.IO.File.Exists("settings.xml"))
            {
                Serialize.FromXml<List<Settings>>(ref settings, "settings.xml");

                if (settings.Last().deserializeFrom == "XML")
                    rbXml.Checked = true;
                else if (settings.Last().deserializeFrom == "JSON")
                    rbJson.Checked = true;

                numInterval.Value = settings.Last().timerInterval;
            }
            else
            {
                rbXml.Checked = true;
                numInterval.Value = 10;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            if (rbXml.Checked)
            {
                obj.timerInterval = Convert.ToInt32(numInterval.Value);
                settings.Add(obj);
                Serialize.ToXml<List<Settings>>(ref settings, "settings.xml");
            }
            if (rbJson.Checked)
            {
                obj.deserializeFrom = "JSON";
                obj.timerInterval = Convert.ToInt32(numInterval.Value);
                settings.Add(obj);
                Serialize.ToXml<List<Settings>>(ref settings, "settings.xml");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
