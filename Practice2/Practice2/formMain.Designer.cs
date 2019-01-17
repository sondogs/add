namespace Practice2
{
    partial class formMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cosName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAtribute = new System.Windows.Forms.GroupBox();
            this.gbSer = new System.Windows.Forms.GroupBox();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSDD_Language = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_English = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Russian = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.gbAtribute.SuspendLayout();
            this.gbSer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lbType
            // 
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Name = "lbPrice";
            // 
            // tbPrice
            // 
            resources.ApplyResources(this.tbPrice, "tbPrice");
            this.tbPrice.Name = "tbPrice";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            resources.ApplyResources(this.cmbType, "cmbType");
            this.cmbType.Name = "cmbType";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cosName,
            this.Type,
            this.Price});
            this.dgvMain.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.dgvMain, "dgvMain");
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 24;
            // 
            // cosName
            // 
            this.cosName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cosName.Frozen = true;
            resources.ApplyResources(this.cosName, "cosName");
            this.cosName.Name = "cosName";
            this.cosName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Type.Frozen = true;
            resources.ApplyResources(this.Type, "Type");
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.Frozen = true;
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // settingsMenu
            // 
            this.settingsMenu.Name = "settingsMenu";
            resources.ApplyResources(this.settingsMenu, "settingsMenu");
            this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
            // 
            // gbAtribute
            // 
            this.gbAtribute.Controls.Add(this.lbName);
            this.gbAtribute.Controls.Add(this.tbName);
            this.gbAtribute.Controls.Add(this.lbType);
            this.gbAtribute.Controls.Add(this.cmbType);
            this.gbAtribute.Controls.Add(this.tbPrice);
            this.gbAtribute.Controls.Add(this.lbPrice);
            resources.ApplyResources(this.gbAtribute, "gbAtribute");
            this.gbAtribute.Name = "gbAtribute";
            this.gbAtribute.TabStop = false;
            // 
            // gbSer
            // 
            this.gbSer.Controls.Add(this.rbJson);
            this.gbSer.Controls.Add(this.rbXml);
            resources.ApplyResources(this.gbSer, "gbSer");
            this.gbSer.Name = "gbSer";
            this.gbSer.TabStop = false;
            // 
            // rbJson
            // 
            resources.ApplyResources(this.rbJson, "rbJson");
            this.rbJson.Name = "rbJson";
            this.rbJson.UseVisualStyleBackColor = true;
            // 
            // rbXml
            // 
            resources.ApplyResources(this.rbXml, "rbXml");
            this.rbXml.Checked = true;
            this.rbXml.Name = "rbXml";
            this.rbXml.TabStop = true;
            this.rbXml.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TSDD_Language});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // TSDD_Language
            // 
            this.TSDD_Language.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDD_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_English,
            this.TSMI_Russian});
            this.TSDD_Language.Name = "TSDD_Language";
            resources.ApplyResources(this.TSDD_Language, "TSDD_Language");
            // 
            // TSMI_English
            // 
            this.TSMI_English.Name = "TSMI_English";
            resources.ApplyResources(this.TSMI_English, "TSMI_English");
            this.TSMI_English.Click += new System.EventHandler(this.TSMI_English_Click);
            // 
            // TSMI_Russian
            // 
            this.TSMI_Russian.Name = "TSMI_Russian";
            resources.ApplyResources(this.TSMI_Russian, "TSMI_Russian");
            this.TSMI_Russian.Click += new System.EventHandler(this.TSMI_Russian_Click);
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // formMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbSer);
            this.Controls.Add(this.gbAtribute);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbAtribute.ResumeLayout(false);
            this.gbAtribute.PerformLayout();
            this.gbSer.ResumeLayout(false);
            this.gbSer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.GroupBox gbAtribute;
        private System.Windows.Forms.GroupBox gbSer;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton TSDD_Language;
        private System.Windows.Forms.ToolStripMenuItem TSMI_English;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Russian;
        private System.Windows.Forms.Button btnReport;
    }
}

