namespace ERA_Manager
{
    partial class FrmValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidation));
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.lblPreference = new System.Windows.Forms.Label();
            this.lblPossibleDestinations = new System.Windows.Forms.Label();
            this.lblValidatedBy = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtValidatedBy = new System.Windows.Forms.TextBox();
            this.txtPreference = new System.Windows.Forms.TextBox();
            this.txtMotivation = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPossibleDestinations = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblName.Location = new System.Drawing.Point(142, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(231, 39);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ERA Manager";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblFirstName.TabIndex = 5;
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
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last name:";
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
            this.lblMotivation.TabIndex = 7;
            this.lblMotivation.Text = "Motivation:";
            // 
            // lblPreference
            // 
            this.lblPreference.AutoSize = true;
            this.lblPreference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPreference.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPreference.Location = new System.Drawing.Point(70, 210);
            this.lblPreference.Name = "lblPreference";
            this.lblPreference.Size = new System.Drawing.Size(82, 17);
            this.lblPreference.TabIndex = 8;
            this.lblPreference.Text = "Preference:";
            // 
            // lblPossibleDestinations
            // 
            this.lblPossibleDestinations.AutoSize = true;
            this.lblPossibleDestinations.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPossibleDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPossibleDestinations.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPossibleDestinations.Location = new System.Drawing.Point(70, 473);
            this.lblPossibleDestinations.Name = "lblPossibleDestinations";
            this.lblPossibleDestinations.Size = new System.Drawing.Size(173, 17);
            this.lblPossibleDestinations.TabIndex = 9;
            this.lblPossibleDestinations.Text = "Add possible destinations:";
            // 
            // lblValidatedBy
            // 
            this.lblValidatedBy.AutoSize = true;
            this.lblValidatedBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblValidatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidatedBy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValidatedBy.Location = new System.Drawing.Point(69, 603);
            this.lblValidatedBy.Name = "lblValidatedBy";
            this.lblValidatedBy.Size = new System.Drawing.Size(90, 17);
            this.lblValidatedBy.TabIndex = 10;
            this.lblValidatedBy.Text = "Validated by:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtValidatedBy
            // 
            this.txtValidatedBy.CausesValidation = false;
            this.txtValidatedBy.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValidatedBy.Location = new System.Drawing.Point(166, 600);
            this.txtValidatedBy.Name = "txtValidatedBy";
            this.txtValidatedBy.ReadOnly = true;
            this.txtValidatedBy.Size = new System.Drawing.Size(295, 20);
            this.txtValidatedBy.TabIndex = 12;
            // 
            // txtPreference
            // 
            this.txtPreference.Location = new System.Drawing.Point(166, 207);
            this.txtPreference.Name = "txtPreference";
            this.txtPreference.Size = new System.Drawing.Size(295, 20);
            this.txtPreference.TabIndex = 13;
            // 
            // txtMotivation
            // 
            this.txtMotivation.Location = new System.Drawing.Point(72, 275);
            this.txtMotivation.Multiline = true;
            this.txtMotivation.Name = "txtMotivation";
            this.txtMotivation.Size = new System.Drawing.Size(389, 161);
            this.txtMotivation.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 162);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(295, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // txtPossibleDestinations
            // 
            this.txtPossibleDestinations.Location = new System.Drawing.Point(73, 493);
            this.txtPossibleDestinations.Multiline = true;
            this.txtPossibleDestinations.Name = "txtPossibleDestinations";
            this.txtPossibleDestinations.Size = new System.Drawing.Size(388, 86);
            this.txtPossibleDestinations.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(73, 684);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnValidate.Location = new System.Drawing.Point(386, 684);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 18;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // FrmValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 743);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPossibleDestinations);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMotivation);
            this.Controls.Add(this.txtPreference);
            this.Controls.Add(this.txtValidatedBy);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblValidatedBy);
            this.Controls.Add(this.lblPossibleDestinations);
            this.Controls.Add(this.lblPreference);
            this.Controls.Add(this.lblMotivation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidation";
            this.Load += new System.EventHandler(this.FrmValidation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.Label lblPreference;
        private System.Windows.Forms.Label lblPossibleDestinations;
        private System.Windows.Forms.Label lblValidatedBy;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtValidatedBy;
        private System.Windows.Forms.TextBox txtPreference;
        private System.Windows.Forms.TextBox txtMotivation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPossibleDestinations;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
    }
}