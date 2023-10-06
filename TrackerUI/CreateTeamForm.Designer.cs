namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addMemberButton = new Button();
            selectMemberDropdown = new ComboBox();
            selectMemberLabel = new Label();
            addNewMemberGroupbox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            TeamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(38, 151);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(424, 41);
            teamNameValue.TabIndex = 16;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(38, 93);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(197, 46);
            teamNameLabel.TabIndex = 15;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(20, 11);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(272, 62);
            headerLabel.TabIndex = 14;
            headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(113, 332);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(252, 60);
            addMemberButton.TabIndex = 22;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectMemberDropdown
            // 
            selectMemberDropdown.FormattingEnabled = true;
            selectMemberDropdown.Location = new Point(38, 262);
            selectMemberDropdown.Name = "selectMemberDropdown";
            selectMemberDropdown.Size = new Size(424, 43);
            selectMemberDropdown.TabIndex = 21;
            // 
            // selectMemberLabel
            // 
            selectMemberLabel.AutoSize = true;
            selectMemberLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectMemberLabel.Location = new Point(38, 213);
            selectMemberLabel.Name = "selectMemberLabel";
            selectMemberLabel.Size = new Size(335, 46);
            selectMemberLabel.TabIndex = 20;
            selectMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupbox
            // 
            addNewMemberGroupbox.Controls.Add(createMemberButton);
            addNewMemberGroupbox.Controls.Add(cellphoneValue);
            addNewMemberGroupbox.Controls.Add(cellphoneLabel);
            addNewMemberGroupbox.Controls.Add(emailValue);
            addNewMemberGroupbox.Controls.Add(emailLabel);
            addNewMemberGroupbox.Controls.Add(lastNameValue);
            addNewMemberGroupbox.Controls.Add(lastNameLabel);
            addNewMemberGroupbox.Controls.Add(firstNameValue);
            addNewMemberGroupbox.Controls.Add(firstNameLabel);
            addNewMemberGroupbox.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupbox.ForeColor = Color.FromArgb(51, 153, 255);
            addNewMemberGroupbox.Location = new Point(20, 409);
            addNewMemberGroupbox.Name = "addNewMemberGroupbox";
            addNewMemberGroupbox.Size = new Size(442, 369);
            addNewMemberGroupbox.TabIndex = 23;
            addNewMemberGroupbox.TabStop = false;
            addNewMemberGroupbox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(171, 46);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(253, 50);
            firstNameValue.TabIndex = 13;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(12, 50);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(171, 108);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(253, 50);
            lastNameValue.TabIndex = 15;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(12, 112);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(171, 171);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(253, 50);
            emailValue.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(72, 171);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(171, 230);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(253, 50);
            cellphoneValue.TabIndex = 19;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellphoneLabel.Location = new Point(18, 232);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(138, 37);
            cellphoneLabel.TabIndex = 18;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(93, 290);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(279, 60);
            createMemberButton.TabIndex = 23;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 35;
            TeamMembersListBox.Location = new Point(488, 151);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(336, 632);
            TeamMembersListBox.TabIndex = 25;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedMemberButton.Location = new Point(830, 409);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(135, 85);
            deleteSelectedMemberButton.TabIndex = 26;
            deleteSelectedMemberButton.Text = "Delete Selected ";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(304, 834);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(361, 81);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 950);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(addNewMemberGroupbox);
            Controls.Add(addMemberButton);
            Controls.Add(selectMemberDropdown);
            Controls.Add(selectMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupbox.ResumeLayout(false);
            addNewMemberGroupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox selectMemberDropdown;
        private Label selectMemberLabel;
        private GroupBox addNewMemberGroupbox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox TeamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}