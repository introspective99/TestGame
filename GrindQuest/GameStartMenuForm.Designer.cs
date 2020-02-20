namespace GrindQuest
{
    partial class GameStartMenuForm
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
            this.startMenuPanel = new System.Windows.Forms.Panel();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.grindQuestTitleLabel = new System.Windows.Forms.Label();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.newCharacterPanel = new System.Windows.Forms.Panel();
            this.returnToMenuButton = new System.Windows.Forms.Button();
            this.confirmCharacterCreationButton = new System.Windows.Forms.Button();
            this.characterNameInputTextBox = new System.Windows.Forms.TextBox();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.specSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.rogueSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.warriorSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.mageSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.characterCreationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadCharacterPanel = new System.Windows.Forms.Panel();
            this.loadCharacterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startMenuPanel.SuspendLayout();
            this.newCharacterPanel.SuspendLayout();
            this.specSelectionGroupBox.SuspendLayout();
            this.loadCharacterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startMenuPanel
            // 
            this.startMenuPanel.Controls.Add(this.creditsLabel);
            this.startMenuPanel.Controls.Add(this.grindQuestTitleLabel);
            this.startMenuPanel.Controls.Add(this.loadGameButton);
            this.startMenuPanel.Controls.Add(this.newGameButton);
            this.startMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.startMenuPanel.Name = "startMenuPanel";
            this.startMenuPanel.Size = new System.Drawing.Size(358, 409);
            this.startMenuPanel.TabIndex = 3;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(12, 229);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(108, 13);
            this.creditsLabel.TabIndex = 5;
            this.creditsLabel.Text = "Created by Claire M :)";
            // 
            // grindQuestTitleLabel
            // 
            this.grindQuestTitleLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grindQuestTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grindQuestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindQuestTitleLabel.Location = new System.Drawing.Point(10, 9);
            this.grindQuestTitleLabel.Name = "grindQuestTitleLabel";
            this.grindQuestTitleLabel.Size = new System.Drawing.Size(330, 18);
            this.grindQuestTitleLabel.TabIndex = 4;
            this.grindQuestTitleLabel.Text = "Welcome to GrindQuest";
            // 
            // loadGameButton
            // 
            this.loadGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadGameButton.Location = new System.Drawing.Point(3, 85);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(352, 30);
            this.loadGameButton.TabIndex = 2;
            this.loadGameButton.Text = "Load Game";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameButton.Location = new System.Drawing.Point(3, 49);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(352, 30);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // newCharacterPanel
            // 
            this.newCharacterPanel.Controls.Add(this.label1);
            this.newCharacterPanel.Controls.Add(this.returnToMenuButton);
            this.newCharacterPanel.Controls.Add(this.confirmCharacterCreationButton);
            this.newCharacterPanel.Controls.Add(this.characterNameInputTextBox);
            this.newCharacterPanel.Controls.Add(this.characterNameLabel);
            this.newCharacterPanel.Controls.Add(this.specSelectionGroupBox);
            this.newCharacterPanel.Controls.Add(this.characterCreationLabel);
            this.newCharacterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCharacterPanel.Location = new System.Drawing.Point(0, 0);
            this.newCharacterPanel.Name = "newCharacterPanel";
            this.newCharacterPanel.Size = new System.Drawing.Size(358, 409);
            this.newCharacterPanel.TabIndex = 3;
            this.newCharacterPanel.Visible = false;
            // 
            // returnToMenuButton
            // 
            this.returnToMenuButton.Location = new System.Drawing.Point(17, 122);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(93, 23);
            this.returnToMenuButton.TabIndex = 13;
            this.returnToMenuButton.Text = "return to menu";
            this.returnToMenuButton.UseVisualStyleBackColor = true;
            this.returnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // confirmCharacterCreationButton
            // 
            this.confirmCharacterCreationButton.Location = new System.Drawing.Point(116, 111);
            this.confirmCharacterCreationButton.Name = "confirmCharacterCreationButton";
            this.confirmCharacterCreationButton.Size = new System.Drawing.Size(126, 44);
            this.confirmCharacterCreationButton.TabIndex = 12;
            this.confirmCharacterCreationButton.Text = "Create!";
            this.confirmCharacterCreationButton.UseVisualStyleBackColor = true;
            // 
            // characterNameInputTextBox
            // 
            this.characterNameInputTextBox.Location = new System.Drawing.Point(126, 30);
            this.characterNameInputTextBox.MaxLength = 12;
            this.characterNameInputTextBox.Name = "characterNameInputTextBox";
            this.characterNameInputTextBox.Size = new System.Drawing.Size(114, 20);
            this.characterNameInputTextBox.TabIndex = 11;
            this.characterNameInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterNameInputTextBox_KeyPress);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(10, 33);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(110, 13);
            this.characterNameLabel.TabIndex = 10;
            this.characterNameLabel.Text = "Name your Character:";
            // 
            // specSelectionGroupBox
            // 
            this.specSelectionGroupBox.Controls.Add(this.rogueSpecRadioButton);
            this.specSelectionGroupBox.Controls.Add(this.warriorSpecRadioButton);
            this.specSelectionGroupBox.Controls.Add(this.mageSpecRadioButton);
            this.specSelectionGroupBox.Location = new System.Drawing.Point(85, 56);
            this.specSelectionGroupBox.Name = "specSelectionGroupBox";
            this.specSelectionGroupBox.Size = new System.Drawing.Size(193, 49);
            this.specSelectionGroupBox.TabIndex = 9;
            this.specSelectionGroupBox.TabStop = false;
            this.specSelectionGroupBox.Text = "Choose your class:";
            // 
            // rogueSpecRadioButton
            // 
            this.rogueSpecRadioButton.AutoSize = true;
            this.rogueSpecRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rogueSpecRadioButton.Name = "rogueSpecRadioButton";
            this.rogueSpecRadioButton.Size = new System.Drawing.Size(57, 17);
            this.rogueSpecRadioButton.TabIndex = 1;
            this.rogueSpecRadioButton.TabStop = true;
            this.rogueSpecRadioButton.Text = "Rogue";
            this.rogueSpecRadioButton.UseVisualStyleBackColor = true;
            // 
            // warriorSpecRadioButton
            // 
            this.warriorSpecRadioButton.AutoSize = true;
            this.warriorSpecRadioButton.Location = new System.Drawing.Point(127, 19);
            this.warriorSpecRadioButton.Name = "warriorSpecRadioButton";
            this.warriorSpecRadioButton.Size = new System.Drawing.Size(59, 17);
            this.warriorSpecRadioButton.TabIndex = 3;
            this.warriorSpecRadioButton.TabStop = true;
            this.warriorSpecRadioButton.Text = "Warrior";
            this.warriorSpecRadioButton.UseVisualStyleBackColor = true;
            // 
            // mageSpecRadioButton
            // 
            this.mageSpecRadioButton.AutoSize = true;
            this.mageSpecRadioButton.Location = new System.Drawing.Point(69, 19);
            this.mageSpecRadioButton.Name = "mageSpecRadioButton";
            this.mageSpecRadioButton.Size = new System.Drawing.Size(52, 17);
            this.mageSpecRadioButton.TabIndex = 2;
            this.mageSpecRadioButton.TabStop = true;
            this.mageSpecRadioButton.Text = "Mage";
            this.mageSpecRadioButton.UseVisualStyleBackColor = true;
            // 
            // characterCreationLabel
            // 
            this.characterCreationLabel.AutoSize = true;
            this.characterCreationLabel.Location = new System.Drawing.Point(111, 9);
            this.characterCreationLabel.Name = "characterCreationLabel";
            this.characterCreationLabel.Size = new System.Drawing.Size(113, 13);
            this.characterCreationLabel.TabIndex = 8;
            this.characterCreationLabel.Text = "Create your Character!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "(max 12 letters)";
            // 
            // loadCharacterPanel
            // 
            this.loadCharacterPanel.Controls.Add(this.label7);
            this.loadCharacterPanel.Controls.Add(this.label6);
            this.loadCharacterPanel.Controls.Add(this.label5);
            this.loadCharacterPanel.Controls.Add(this.label4);
            this.loadCharacterPanel.Controls.Add(this.label3);
            this.loadCharacterPanel.Controls.Add(this.label2);
            this.loadCharacterPanel.Controls.Add(this.button5);
            this.loadCharacterPanel.Controls.Add(this.button4);
            this.loadCharacterPanel.Controls.Add(this.button3);
            this.loadCharacterPanel.Controls.Add(this.button2);
            this.loadCharacterPanel.Controls.Add(this.button1);
            this.loadCharacterPanel.Controls.Add(this.loadCharacterLabel);
            this.loadCharacterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCharacterPanel.Location = new System.Drawing.Point(0, 0);
            this.loadCharacterPanel.Name = "loadCharacterPanel";
            this.loadCharacterPanel.Size = new System.Drawing.Size(358, 409);
            this.loadCharacterPanel.TabIndex = 6;
            // 
            // loadCharacterLabel
            // 
            this.loadCharacterLabel.AutoSize = true;
            this.loadCharacterLabel.Location = new System.Drawing.Point(15, 13);
            this.loadCharacterLabel.Name = "loadCharacterLabel";
            this.loadCharacterLabel.Size = new System.Drawing.Size(131, 13);
            this.loadCharacterLabel.TabIndex = 0;
            this.loadCharacterLabel.Text = "Choose Character to Load";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(212, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // GameStartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 409);
            this.Controls.Add(this.loadCharacterPanel);
            this.Controls.Add(this.startMenuPanel);
            this.Controls.Add(this.newCharacterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameStartMenuForm";
            this.Text = "GameStartMenuForm";
            this.startMenuPanel.ResumeLayout(false);
            this.startMenuPanel.PerformLayout();
            this.newCharacterPanel.ResumeLayout(false);
            this.newCharacterPanel.PerformLayout();
            this.specSelectionGroupBox.ResumeLayout(false);
            this.specSelectionGroupBox.PerformLayout();
            this.loadCharacterPanel.ResumeLayout(false);
            this.loadCharacterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Panel startMenuPanel;
        private System.Windows.Forms.Panel newCharacterPanel;
        private System.Windows.Forms.Button confirmCharacterCreationButton;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.GroupBox specSelectionGroupBox;
        private System.Windows.Forms.RadioButton rogueSpecRadioButton;
        private System.Windows.Forms.RadioButton warriorSpecRadioButton;
        private System.Windows.Forms.RadioButton mageSpecRadioButton;
        private System.Windows.Forms.Label characterCreationLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label grindQuestTitleLabel;
        private System.Windows.Forms.Button returnToMenuButton;
        private System.Windows.Forms.TextBox characterNameInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadCharacterPanel;
        private System.Windows.Forms.Label loadCharacterLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}