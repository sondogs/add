namespace Practice2
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.gbDes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.gbDes.SuspendLayout();
            this.gbInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // numInterval
            // 
            resources.ApplyResources(this.numInterval, "numInterval");
            this.numInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbXml
            // 
            resources.ApplyResources(this.rbXml, "rbXml");
            this.rbXml.Name = "rbXml";
            this.rbXml.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            resources.ApplyResources(this.rbJson, "rbJson");
            this.rbJson.Name = "rbJson";
            this.rbJson.UseVisualStyleBackColor = true;
            // 
            // gbDes
            // 
            resources.ApplyResources(this.gbDes, "gbDes");
            this.gbDes.Controls.Add(this.rbXml);
            this.gbDes.Controls.Add(this.rbJson);
            this.gbDes.Name = "gbDes";
            this.gbDes.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbInterval
            // 
            resources.ApplyResources(this.gbInterval, "gbInterval");
            this.gbInterval.Controls.Add(this.numInterval);
            this.gbInterval.Controls.Add(this.label1);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.TabStop = false;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ControlBox = false;
            this.Controls.Add(this.gbInterval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbDes);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.gbDes.ResumeLayout(false);
            this.gbDes.PerformLayout();
            this.gbInterval.ResumeLayout(false);
            this.gbInterval.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.GroupBox gbDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbInterval;
    }
}