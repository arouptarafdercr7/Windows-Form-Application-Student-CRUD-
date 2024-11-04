namespace Lesson_12
{
    partial class frmStudent
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
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.txtisActive = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDID = new System.Windows.Forms.Label();
            this.lblisActive = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.grpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.txtDId);
            this.grpStudent.Controls.Add(this.txtisActive);
            this.grpStudent.Controls.Add(this.txtDOB);
            this.grpStudent.Controls.Add(this.txtFees);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.txtId);
            this.grpStudent.Controls.Add(this.lblDID);
            this.grpStudent.Controls.Add(this.lblisActive);
            this.grpStudent.Controls.Add(this.lblDOB);
            this.grpStudent.Controls.Add(this.lblFees);
            this.grpStudent.Controls.Add(this.lblName);
            this.grpStudent.Controls.Add(this.lblID);
            this.grpStudent.Location = new System.Drawing.Point(23, 21);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(707, 493);
            this.grpStudent.TabIndex = 0;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student";
            // 
            // txtDId
            // 
            this.txtDId.Location = new System.Drawing.Point(297, 400);
            this.txtDId.Name = "txtDId";
            this.txtDId.Size = new System.Drawing.Size(280, 38);
            this.txtDId.TabIndex = 1;
            // 
            // txtisActive
            // 
            this.txtisActive.Location = new System.Drawing.Point(297, 333);
            this.txtisActive.Name = "txtisActive";
            this.txtisActive.Size = new System.Drawing.Size(280, 38);
            this.txtisActive.TabIndex = 1;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(297, 267);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(280, 38);
            this.txtDOB.TabIndex = 1;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(297, 204);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(280, 38);
            this.txtFees.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(297, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 38);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(297, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(280, 38);
            this.txtId.TabIndex = 1;
            // 
            // lblDID
            // 
            this.lblDID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDID.Location = new System.Drawing.Point(124, 398);
            this.lblDID.Name = "lblDID";
            this.lblDID.Size = new System.Drawing.Size(141, 40);
            this.lblDID.TabIndex = 0;
            this.lblDID.Text = "DID";
            this.lblDID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblisActive
            // 
            this.lblisActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblisActive.Location = new System.Drawing.Point(124, 331);
            this.lblisActive.Name = "lblisActive";
            this.lblisActive.Size = new System.Drawing.Size(141, 40);
            this.lblisActive.TabIndex = 0;
            this.lblisActive.Text = "isActive";
            this.lblisActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDOB
            // 
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDOB.Location = new System.Drawing.Point(124, 265);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(141, 40);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "DOB";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFees
            // 
            this.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFees.Location = new System.Drawing.Point(124, 202);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(141, 40);
            this.lblFees.TabIndex = 0;
            this.lblFees.Text = "Fees";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(124, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 40);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(124, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(141, 40);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(100, 540);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(215, 87);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 540);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 87);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 673);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 87);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 673);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 87);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Location = new System.Drawing.Point(862, 128);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(190, 115);
            this.btnShowStudent.TabIndex = 2;
            this.btnShowStudent.Text = "Show Student";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 1021);
            this.Controls.Add(this.btnShowStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grpStudent);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.TextBox txtisActive;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDID;
        private System.Windows.Forms.Label lblisActive;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowStudent;
    }
}