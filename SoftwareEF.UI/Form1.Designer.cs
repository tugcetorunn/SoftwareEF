namespace SoftwareEF.UI
{
    partial class Form1
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
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewSoftwareList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftwareList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(237, 76);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(227, 36);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "Dilleri listele";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridViewSoftwareList
            // 
            this.dataGridViewSoftwareList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoftwareList.Location = new System.Drawing.Point(34, 162);
            this.dataGridViewSoftwareList.Name = "dataGridViewSoftwareList";
            this.dataGridViewSoftwareList.Size = new System.Drawing.Size(664, 204);
            this.dataGridViewSoftwareList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSoftwareList);
            this.Controls.Add(this.buttonList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftwareList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridViewSoftwareList;
    }
}

