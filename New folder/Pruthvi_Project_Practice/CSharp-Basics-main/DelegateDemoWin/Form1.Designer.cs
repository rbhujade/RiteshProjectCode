namespace DelegateDemoWin
{
    partial class Form1
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
            peopleListBox = new ListBox();
            rdbFirstName = new RadioButton();
            rdbLastName = new RadioButton();
            rdbFullName = new RadioButton();
            rdbDefault = new RadioButton();
            btnFilterData = new Button();
            chkBoxAction = new CheckBox();
            chkBoxAvgRating = new CheckBox();
            chkBoxMinRating = new CheckBox();
            chkBoxMaxRating = new CheckBox();
            SuspendLayout();
            // 
            // peopleListBox
            // 
            peopleListBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            peopleListBox.FormattingEnabled = true;
            peopleListBox.ItemHeight = 21;
            peopleListBox.Location = new Point(405, 8);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(365, 424);
            peopleListBox.TabIndex = 0;
            // 
            // rdbFirstName
            // 
            rdbFirstName.AutoSize = true;
            rdbFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdbFirstName.Location = new Point(59, 26);
            rdbFirstName.Name = "rdbFirstName";
            rdbFirstName.Size = new Size(110, 25);
            rdbFirstName.TabIndex = 1;
            rdbFirstName.TabStop = true;
            rdbFirstName.Text = "First Name";
            rdbFirstName.UseVisualStyleBackColor = true;
            // 
            // rdbLastName
            // 
            rdbLastName.AutoSize = true;
            rdbLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdbLastName.Location = new Point(59, 51);
            rdbLastName.Name = "rdbLastName";
            rdbLastName.Size = new Size(108, 25);
            rdbLastName.TabIndex = 2;
            rdbLastName.TabStop = true;
            rdbLastName.Text = "Last Name";
            rdbLastName.UseVisualStyleBackColor = true;
            // 
            // rdbFullName
            // 
            rdbFullName.AutoSize = true;
            rdbFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdbFullName.Location = new Point(59, 77);
            rdbFullName.Name = "rdbFullName";
            rdbFullName.Size = new Size(106, 25);
            rdbFullName.TabIndex = 3;
            rdbFullName.TabStop = true;
            rdbFullName.Text = "Full Name";
            rdbFullName.UseVisualStyleBackColor = true;
            // 
            // rdbDefault
            // 
            rdbDefault.AutoSize = true;
            rdbDefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdbDefault.Location = new Point(59, 102);
            rdbDefault.Name = "rdbDefault";
            rdbDefault.Size = new Size(85, 25);
            rdbDefault.TabIndex = 4;
            rdbDefault.TabStop = true;
            rdbDefault.Text = "Default";
            rdbDefault.UseVisualStyleBackColor = true;
            // 
            // btnFilterData
            // 
            btnFilterData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilterData.Location = new Point(38, 343);
            btnFilterData.Name = "btnFilterData";
            btnFilterData.Size = new Size(161, 59);
            btnFilterData.TabIndex = 5;
            btnFilterData.Text = "Filter Data";
            btnFilterData.UseVisualStyleBackColor = true;
            btnFilterData.Click += btnFilterData_Click;
            // 
            // chkBoxAction
            // 
            chkBoxAction.AutoSize = true;
            chkBoxAction.Location = new Point(59, 161);
            chkBoxAction.Name = "chkBoxAction";
            chkBoxAction.Size = new Size(69, 19);
            chkBoxAction.TabIndex = 6;
            chkBoxAction.Text = "ACTION";
            chkBoxAction.UseVisualStyleBackColor = true;
            // 
            // chkBoxAvgRating
            // 
            chkBoxAvgRating.AutoSize = true;
            chkBoxAvgRating.Location = new Point(59, 203);
            chkBoxAvgRating.Name = "chkBoxAvgRating";
            chkBoxAvgRating.Size = new Size(84, 19);
            chkBoxAvgRating.TabIndex = 7;
            chkBoxAvgRating.Text = "Avg Rating";
            chkBoxAvgRating.UseVisualStyleBackColor = true;
            // 
            // chkBoxMinRating
            // 
            chkBoxMinRating.AutoSize = true;
            chkBoxMinRating.Location = new Point(59, 228);
            chkBoxMinRating.Name = "chkBoxMinRating";
            chkBoxMinRating.Size = new Size(84, 19);
            chkBoxMinRating.TabIndex = 8;
            chkBoxMinRating.Text = "Min Rating";
            chkBoxMinRating.UseVisualStyleBackColor = true;
            // 
            // chkBoxMaxRating
            // 
            chkBoxMaxRating.AutoSize = true;
            chkBoxMaxRating.Location = new Point(60, 256);
            chkBoxMaxRating.Name = "chkBoxMaxRating";
            chkBoxMaxRating.Size = new Size(86, 19);
            chkBoxMaxRating.TabIndex = 9;
            chkBoxMaxRating.Text = "Max Rating";
            chkBoxMaxRating.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkBoxMaxRating);
            Controls.Add(chkBoxMinRating);
            Controls.Add(chkBoxAvgRating);
            Controls.Add(chkBoxAction);
            Controls.Add(btnFilterData);
            Controls.Add(rdbDefault);
            Controls.Add(rdbFullName);
            Controls.Add(rdbLastName);
            Controls.Add(rdbFirstName);
            Controls.Add(peopleListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox peopleListBox;
        private RadioButton rdbFirstName;
        private RadioButton rdbLastName;
        private RadioButton rdbFullName;
        private RadioButton rdbDefault;
        private Button btnFilterData;
        private CheckBox chkBoxAction;
        private CheckBox chkBoxAvgRating;
        private CheckBox chkBoxMinRating;
        private CheckBox chkBoxMaxRating;
    }
}
