namespace InvMgmt.UI.Forms
{
    partial class frmMain
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
            this.btnAddMLPart = new System.Windows.Forms.Button();
            this.btnMLPen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMLPart
            // 
            this.btnAddMLPart.Location = new System.Drawing.Point(44, 44);
            this.btnAddMLPart.Name = "btnAddMLPart";
            this.btnAddMLPart.Size = new System.Drawing.Size(90, 25);
            this.btnAddMLPart.TabIndex = 0;
            this.btnAddMLPart.Text = "ML Part";
            this.btnAddMLPart.UseVisualStyleBackColor = true;
            this.btnAddMLPart.Click += new System.EventHandler(this.btnAddMLPart_Click);
            // 
            // btnMLPen
            // 
            this.btnMLPen.Location = new System.Drawing.Point(44, 75);
            this.btnMLPen.Name = "btnMLPen";
            this.btnMLPen.Size = new System.Drawing.Size(90, 25);
            this.btnMLPen.TabIndex = 1;
            this.btnMLPen.Text = "ML Pen";
            this.btnMLPen.UseVisualStyleBackColor = true;
            this.btnMLPen.Click += new System.EventHandler(this.btnMLPen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 349);
            this.Controls.Add(this.btnMLPen);
            this.Controls.Add(this.btnAddMLPart);
            this.Name = "frmMain";
            this.Text = "Inventory Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMLPart;
        private System.Windows.Forms.Button btnMLPen;
    }
}

