namespace LabActivitypt2
{
    partial class FormControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            groupGender = new GroupBox();
            groupSubjects = new GroupBox();
            CBSub3 = new CheckBox();
            CBSub2 = new CheckBox();
            CBSub1 = new CheckBox();
            lblSemester = new Label();
            ListBoxPlaces = new ListBox();
            comBoxSemester = new ComboBox();
            lblSelectPlace = new Label();
            lblDisplayPlace = new Label();
            btnClear = new Button();
            groupGender.SuspendLayout();
            groupSubjects.SuspendLayout();
            SuspendLayout();
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(19, 31);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(51, 19);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(19, 56);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(63, 19);
            rdFemale.TabIndex = 1;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // groupGender
            // 
            groupGender.Controls.Add(rdMale);
            groupGender.Controls.Add(rdFemale);
            groupGender.Location = new Point(12, 12);
            groupGender.Name = "groupGender";
            groupGender.Size = new Size(200, 118);
            groupGender.TabIndex = 2;
            groupGender.TabStop = false;
            groupGender.Text = "Gender";
            // 
            // groupSubjects
            // 
            groupSubjects.Controls.Add(CBSub3);
            groupSubjects.Controls.Add(CBSub2);
            groupSubjects.Controls.Add(CBSub1);
            groupSubjects.Location = new Point(218, 12);
            groupSubjects.Name = "groupSubjects";
            groupSubjects.Size = new Size(200, 118);
            groupSubjects.TabIndex = 3;
            groupSubjects.TabStop = false;
            groupSubjects.Text = "Subjects";
            // 
            // CBSub3
            // 
            CBSub3.AutoSize = true;
            CBSub3.Location = new Point(17, 73);
            CBSub3.Name = "CBSub3";
            CBSub3.Size = new Size(73, 19);
            CBSub3.TabIndex = 2;
            CBSub3.Text = "PROSTAT";
            CBSub3.UseVisualStyleBackColor = true;
            // 
            // CBSub2
            // 
            CBSub2.AutoSize = true;
            CBSub2.Location = new Point(17, 48);
            CBSub2.Name = "CBSub2";
            CBSub2.Size = new Size(80, 19);
            CBSub2.TabIndex = 1;
            CBSub2.Text = "COMART3";
            CBSub2.UseVisualStyleBackColor = true;
            // 
            // CBSub1
            // 
            CBSub1.AutoSize = true;
            CBSub1.Location = new Point(17, 23);
            CBSub1.Name = "CBSub1";
            CBSub1.Size = new Size(72, 19);
            CBSub1.TabIndex = 0;
            CBSub1.Text = "COPRO3";
            CBSub1.UseVisualStyleBackColor = true;
            // 
            // lblSemester
            // 
            lblSemester.BorderStyle = BorderStyle.FixedSingle;
            lblSemester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSemester.Location = new Point(424, 55);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(100, 40);
            lblSemester.TabIndex = 4;
            lblSemester.Text = "SEMESTER:";
            lblSemester.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListBoxPlaces
            // 
            ListBoxPlaces.FormattingEnabled = true;
            ListBoxPlaces.ItemHeight = 15;
            ListBoxPlaces.Items.AddRange(new object[] { "SAN JOSE DEL MONTE BULACAN", "LAGRO", "FAIRVIEW", "BAGONG SILANG", "ALMAR", "LITEX", "BATASAN", "CIRCLE" });
            ListBoxPlaces.Location = new Point(12, 181);
            ListBoxPlaces.Name = "ListBoxPlaces";
            ListBoxPlaces.Size = new Size(216, 124);
            ListBoxPlaces.TabIndex = 5;
            ListBoxPlaces.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comBoxSemester
            // 
            comBoxSemester.FormattingEnabled = true;
            comBoxSemester.Items.AddRange(new object[] { "1ST", "2ND" });
            comBoxSemester.Location = new Point(534, 66);
            comBoxSemester.Name = "comBoxSemester";
            comBoxSemester.Size = new Size(121, 23);
            comBoxSemester.TabIndex = 6;
            comBoxSemester.Text = "1ST";
            // 
            // lblSelectPlace
            // 
            lblSelectPlace.AutoSize = true;
            lblSelectPlace.BorderStyle = BorderStyle.FixedSingle;
            lblSelectPlace.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectPlace.Location = new Point(12, 133);
            lblSelectPlace.Name = "lblSelectPlace";
            lblSelectPlace.Padding = new Padding(10);
            lblSelectPlace.Size = new Size(216, 45);
            lblSelectPlace.TabIndex = 7;
            lblSelectPlace.Text = "Please select your place.";
            lblSelectPlace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDisplayPlace
            // 
            lblDisplayPlace.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayPlace.Location = new Point(234, 133);
            lblDisplayPlace.Name = "lblDisplayPlace";
            lblDisplayPlace.Size = new Size(444, 140);
            lblDisplayPlace.TabIndex = 8;
            lblDisplayPlace.Text = "LAGRO";
            lblDisplayPlace.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplayPlace.Click += lblDisplayPlace_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(234, 276);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(444, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 358);
            Controls.Add(btnClear);
            Controls.Add(lblDisplayPlace);
            Controls.Add(lblSelectPlace);
            Controls.Add(comBoxSemester);
            Controls.Add(ListBoxPlaces);
            Controls.Add(lblSemester);
            Controls.Add(groupSubjects);
            Controls.Add(groupGender);
            Name = "Form1";
            Text = "CONTROL";
            groupGender.ResumeLayout(false);
            groupGender.PerformLayout();
            groupSubjects.ResumeLayout(false);
            groupSubjects.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdMale;
        private RadioButton rdFemale;
        private GroupBox groupGender;
        private GroupBox groupSubjects;
        private CheckBox CBSub3;
        private CheckBox CBSub2;
        private CheckBox CBSub1;
        private Label lblSemester;
        private ListBox ListBoxPlaces;
        private ComboBox comBoxSemester;
        private Label lblSelectPlace;
        private Label lblDisplayPlace;
        private Button btnClear;
    }
}