namespace imageDB
{
    partial class Form2
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
            this.buttonFetch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxFetch = new System.Windows.Forms.GroupBox();
            this.pictureBoxFetch = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadImage = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxFetch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFetch
            // 
            this.buttonFetch.Location = new System.Drawing.Point(359, 51);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(132, 53);
            this.buttonFetch.TabIndex = 3;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(68, 61);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(247, 29);
            this.textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 65);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // groupBoxFetch
            // 
            this.groupBoxFetch.Controls.Add(this.pictureBoxFetch);
            this.groupBoxFetch.Controls.Add(this.buttonFetch);
            this.groupBoxFetch.Controls.Add(this.textBoxID);
            this.groupBoxFetch.Controls.Add(this.labelID);
            this.groupBoxFetch.Location = new System.Drawing.Point(626, 70);
            this.groupBoxFetch.Name = "groupBoxFetch";
            this.groupBoxFetch.Size = new System.Drawing.Size(534, 507);
            this.groupBoxFetch.TabIndex = 10;
            this.groupBoxFetch.TabStop = false;
            this.groupBoxFetch.Text = "Fetch Image";
            // 
            // pictureBoxFetch
            // 
            this.pictureBoxFetch.Location = new System.Drawing.Point(34, 146);
            this.pictureBoxFetch.Name = "pictureBoxFetch";
            this.pictureBoxFetch.Size = new System.Drawing.Size(457, 340);
            this.pictureBoxFetch.TabIndex = 7;
            this.pictureBoxFetch.TabStop = false;
            // 
            // pictureBoxLoadImage
            // 
            this.pictureBoxLoadImage.Location = new System.Drawing.Point(51, 81);
            this.pictureBoxLoadImage.Name = "pictureBoxLoadImage";
            this.pictureBoxLoadImage.Size = new System.Drawing.Size(361, 301);
            this.pictureBoxLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadImage.TabIndex = 11;
            this.pictureBoxLoadImage.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(250, 417);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 53);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(74, 417);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(132, 53);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.pictureBoxLoadImage);
            this.groupBoxAdd.Controls.Add(this.buttonLoad);
            this.groupBoxAdd.Controls.Add(this.buttonSave);
            this.groupBoxAdd.Location = new System.Drawing.Point(68, 70);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(469, 507);
            this.groupBoxAdd.TabIndex = 12;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add/Load Image";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 688);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxFetch);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxFetch.ResumeLayout(false);
            this.groupBoxFetch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBoxFetch;
        private System.Windows.Forms.PictureBox pictureBoxFetch;
        private System.Windows.Forms.PictureBox pictureBoxLoadImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxAdd;
    }
}