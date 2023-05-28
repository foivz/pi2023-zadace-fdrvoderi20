namespace ERA_Manager
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.lblValidName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPreference = new System.Windows.Forms.Label();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPreference = new System.Windows.Forms.TextBox();
            this.txtMotivation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValidName
            // 
            this.lblValidName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValidName.AutoSize = true;
            this.lblValidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValidName.Location = new System.Drawing.Point(140, 9);
            this.lblValidName.Name = "lblValidName";
            this.lblValidName.Size = new System.Drawing.Size(231, 39);
            this.lblValidName.TabIndex = 5;
            this.lblValidName.Text = "ERA Manager";
            this.lblValidName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFirstName.Location = new System.Drawing.Point(70, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLastName.Location = new System.Drawing.Point(69, 165);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 17);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last name:";
            // 
            // lblPreference
            // 
            this.lblPreference.AutoSize = true;
            this.lblPreference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPreference.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPreference.Location = new System.Drawing.Point(70, 210);
            this.lblPreference.Name = "lblPreference";
            this.lblPreference.Size = new System.Drawing.Size(86, 17);
            this.lblPreference.TabIndex = 8;
            this.lblPreference.Text = "Preference: ";
            // 
            // lblMotivation
            // 
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblMotivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMotivation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMotivation.Location = new System.Drawing.Point(69, 256);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(76, 17);
            this.lblMotivation.TabIndex = 9;
            this.lblMotivation.Text = "Motivation:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 162);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(295, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtPreference
            // 
            this.txtPreference.Location = new System.Drawing.Point(166, 207);
            this.txtPreference.Name = "txtPreference";
            this.txtPreference.Size = new System.Drawing.Size(295, 20);
            this.txtPreference.TabIndex = 12;
            // 
            // txtMotivation
            // 
            this.txtMotivation.Location = new System.Drawing.Point(72, 275);
            this.txtMotivation.MaxLength = 450;
            this.txtMotivation.Multiline = true;
            this.txtMotivation.Name = "txtMotivation";
            this.txtMotivation.Size = new System.Drawing.Size(389, 161);
            this.txtMotivation.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(73, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(368, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 39);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 555);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMotivation);
            this.Controls.Add(this.txtPreference);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMotivation);
            this.Controls.Add(this.lblPreference);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblValidName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPreference;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPreference;
        private System.Windows.Forms.TextBox txtMotivation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}