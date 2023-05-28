using System.Runtime.CompilerServices;

namespace ERA_Manager
{
    partial class FrmValidatedStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidatedStudents));
            this.lblValidName = new System.Windows.Forms.Label();
            this.dgvValidatedStudents = new System.Windows.Forms.DataGridView();
            this.lblValidList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidatedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValidName
            // 
            this.lblValidName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValidName.AutoSize = true;
            this.lblValidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValidName.Location = new System.Drawing.Point(439, 9);
            this.lblValidName.Name = "lblValidName";
            this.lblValidName.Size = new System.Drawing.Size(231, 39);
            this.lblValidName.TabIndex = 4;
            this.lblValidName.Text = "ERA Manager";
            this.lblValidName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvValidatedStudents
            // 
            this.dgvValidatedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidatedStudents.Location = new System.Drawing.Point(34, 125);
            this.dgvValidatedStudents.Name = "dgvValidatedStudents";
            this.dgvValidatedStudents.Size = new System.Drawing.Size(926, 357);
            this.dgvValidatedStudents.TabIndex = 5;
            // 
            // lblValidList
            // 
            this.lblValidList.AutoSize = true;
            this.lblValidList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValidList.Location = new System.Drawing.Point(28, 82);
            this.lblValidList.Name = "lblValidList";
            this.lblValidList.Size = new System.Drawing.Size(340, 31);
            this.lblValidList.TabIndex = 6;
            this.lblValidList.Text = "List of Validated Applicants";
            this.lblValidList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1001, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 57);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete selected student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1001, 214);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 57);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmValidatedStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 521);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblValidList);
            this.Controls.Add(this.dgvValidatedStudents);
            this.Controls.Add(this.lblValidName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmValidatedStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidatedStudents";
            this.Load += new System.EventHandler(this.FrmValidatedStudents_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidatedStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidName;
        private System.Windows.Forms.DataGridView dgvValidatedStudents;
        private System.Windows.Forms.Label lblValidList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}