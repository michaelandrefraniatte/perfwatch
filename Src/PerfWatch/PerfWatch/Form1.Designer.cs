
namespace PerfWatch
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSensorCount = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.chkHDD = new System.Windows.Forms.CheckBox();
            this.chkRAM = new System.Windows.Forms.CheckBox();
            this.chkCPU = new System.Windows.Forms.CheckBox();
            this.chkGPU = new System.Windows.Forms.CheckBox();
            this.chkFan = new System.Windows.Forms.CheckBox();
            this.chkMain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSensorCount
            // 
            this.lblSensorCount.AutoSize = true;
            this.lblSensorCount.Location = new System.Drawing.Point(14, 44);
            this.lblSensorCount.Name = "lblSensorCount";
            this.lblSensorCount.Size = new System.Drawing.Size(45, 13);
            this.lblSensorCount.TabIndex = 17;
            this.lblSensorCount.Text = "Sensors";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(14, 20);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(58, 13);
            this.lblNodeCount.TabIndex = 16;
            this.lblNodeCount.Text = "Hardwares";
            // 
            // chkHDD
            // 
            this.chkHDD.AutoSize = true;
            this.chkHDD.Checked = true;
            this.chkHDD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHDD.Location = new System.Drawing.Point(17, 123);
            this.chkHDD.Name = "chkHDD";
            this.chkHDD.Size = new System.Drawing.Size(50, 17);
            this.chkHDD.TabIndex = 15;
            this.chkHDD.Text = "HDD";
            this.chkHDD.UseVisualStyleBackColor = true;
            this.chkHDD.CheckedChanged += new System.EventHandler(this.chkHDD_CheckedChanged);
            // 
            // chkRAM
            // 
            this.chkRAM.AutoSize = true;
            this.chkRAM.Checked = true;
            this.chkRAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRAM.Location = new System.Drawing.Point(124, 123);
            this.chkRAM.Name = "chkRAM";
            this.chkRAM.Size = new System.Drawing.Size(50, 17);
            this.chkRAM.TabIndex = 14;
            this.chkRAM.Text = "RAM";
            this.chkRAM.UseVisualStyleBackColor = true;
            this.chkRAM.CheckedChanged += new System.EventHandler(this.chkRAM_CheckedChanged);
            // 
            // chkCPU
            // 
            this.chkCPU.AutoSize = true;
            this.chkCPU.Checked = true;
            this.chkCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCPU.Location = new System.Drawing.Point(124, 100);
            this.chkCPU.Name = "chkCPU";
            this.chkCPU.Size = new System.Drawing.Size(48, 17);
            this.chkCPU.TabIndex = 13;
            this.chkCPU.Text = "CPU";
            this.chkCPU.UseVisualStyleBackColor = true;
            this.chkCPU.CheckedChanged += new System.EventHandler(this.chkCPU_CheckedChanged);
            // 
            // chkGPU
            // 
            this.chkGPU.AutoSize = true;
            this.chkGPU.Checked = true;
            this.chkGPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGPU.Location = new System.Drawing.Point(124, 77);
            this.chkGPU.Name = "chkGPU";
            this.chkGPU.Size = new System.Drawing.Size(49, 17);
            this.chkGPU.TabIndex = 12;
            this.chkGPU.Text = "GPU";
            this.chkGPU.UseVisualStyleBackColor = true;
            this.chkGPU.CheckedChanged += new System.EventHandler(this.chkGPU_CheckedChanged);
            // 
            // chkFan
            // 
            this.chkFan.AutoSize = true;
            this.chkFan.Checked = true;
            this.chkFan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFan.Location = new System.Drawing.Point(17, 100);
            this.chkFan.Name = "chkFan";
            this.chkFan.Size = new System.Drawing.Size(91, 17);
            this.chkFan.TabIndex = 11;
            this.chkFan.Text = "Fan Controller";
            this.chkFan.UseVisualStyleBackColor = true;
            this.chkFan.CheckedChanged += new System.EventHandler(this.chkFan_CheckedChanged);
            // 
            // chkMain
            // 
            this.chkMain.AutoSize = true;
            this.chkMain.Checked = true;
            this.chkMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMain.Location = new System.Drawing.Point(17, 77);
            this.chkMain.Name = "chkMain";
            this.chkMain.Size = new System.Drawing.Size(90, 17);
            this.chkMain.TabIndex = 10;
            this.chkMain.Text = "Mother Board";
            this.chkMain.UseVisualStyleBackColor = true;
            this.chkMain.CheckedChanged += new System.EventHandler(this.chkMain_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 158);
            this.Controls.Add(this.lblSensorCount);
            this.Controls.Add(this.lblNodeCount);
            this.Controls.Add(this.chkHDD);
            this.Controls.Add(this.chkRAM);
            this.Controls.Add(this.chkCPU);
            this.Controls.Add(this.chkGPU);
            this.Controls.Add(this.chkFan);
            this.Controls.Add(this.chkMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfWatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox chkHDD;
        public System.Windows.Forms.CheckBox chkRAM;
        public System.Windows.Forms.CheckBox chkCPU;
        public System.Windows.Forms.CheckBox chkGPU;
        public System.Windows.Forms.CheckBox chkFan;
        public System.Windows.Forms.CheckBox chkMain;
        public System.Windows.Forms.Label lblSensorCount;
        public System.Windows.Forms.Label lblNodeCount;
    }
}

