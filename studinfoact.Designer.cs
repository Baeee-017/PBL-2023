namespace LabActivity
{
    partial class frmStudMaintenance
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "COLUMBRES",
            "MARY ROSE",
            "CARBONNEL",
            "20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "PLAN",
            "JOMARISS",
            "BACCAY",
            "20"}, -1);
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvStudInfo = new System.Windows.Forms.ListView();
            this.StudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblStudID
            // 
            this.lblStudID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudID.Location = new System.Drawing.Point(14, 11);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(100, 23);
            this.lblStudID.TabIndex = 0;
            this.lblStudID.Text = "Student ID";
            this.lblStudID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStudID.Click += new System.EventHandler(this.lblStudID_Click);
            // 
            // lblLName
            // 
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLName.Location = new System.Drawing.Point(14, 43);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(100, 23);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFName
            // 
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFName.Location = new System.Drawing.Point(14, 75);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(100, 23);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMName
            // 
            this.lblMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMName.Location = new System.Drawing.Point(14, 108);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(100, 23);
            this.lblMName.TabIndex = 3;
            this.lblMName.Text = "Middle Name";
            this.lblMName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Location = new System.Drawing.Point(14, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 23);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(120, 12);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(348, 20);
            this.txtStudID.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(120, 43);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(348, 20);
            this.txtLName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(120, 78);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(348, 20);
            this.txtFName.TabIndex = 7;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(120, 108);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(348, 20);
            this.txtMName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 143);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 20);
            this.txtAge.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(474, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(474, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 27);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(474, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 26);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(474, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lvStudInfo
            // 
            this.lvStudInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lvStudInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudID,
            this.LName,
            this.FName,
            this.MName,
            this.Age});
            this.lvStudInfo.FullRowSelect = true;
            this.lvStudInfo.GridLines = true;
            this.lvStudInfo.HideSelection = false;
            this.lvStudInfo.HoverSelection = true;
            this.lvStudInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvStudInfo.LabelEdit = true;
            this.lvStudInfo.Location = new System.Drawing.Point(14, 169);
            this.lvStudInfo.Name = "lvStudInfo";
            this.lvStudInfo.Size = new System.Drawing.Size(589, 214);
            this.lvStudInfo.TabIndex = 14;
            this.lvStudInfo.UseCompatibleStateImageBehavior = false;
            this.lvStudInfo.View = System.Windows.Forms.View.Details;
            this.lvStudInfo.SelectedIndexChanged += new System.EventHandler(this.lvStudInfo_SelectedIndexChanged);
            // 
            // StudID
            // 
            this.StudID.Tag = "wdmlkd";
            this.StudID.Text = "Student ID";
            this.StudID.Width = 102;
            // 
            // LName
            // 
            this.LName.Text = "Last Name";
            this.LName.Width = 109;
            // 
            // FName
            // 
            this.FName.Text = "First Name";
            this.FName.Width = 113;
            // 
            // MName
            // 
            this.MName.Text = "Middle Name";
            this.MName.Width = 102;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 81;
            // 
            // frmStudMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.lvStudInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblStudID);
            this.Name = "frmStudMaintenance";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.frmStudMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvStudInfo;
        private System.Windows.Forms.ColumnHeader StudID;
        private System.Windows.Forms.ColumnHeader LName;
        private System.Windows.Forms.ColumnHeader FName;
        private System.Windows.Forms.ColumnHeader MName;
        private System.Windows.Forms.ColumnHeader Age;
    }
}

