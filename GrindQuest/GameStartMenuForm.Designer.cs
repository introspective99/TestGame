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
            this.label1 = new System.Windows.Forms.Label();
            this.returnToMenuButton = new System.Windows.Forms.Button();
            this.confirmCharacterCreationButton = new System.Windows.Forms.Button();
            this.characterNameInputTextBox = new System.Windows.Forms.TextBox();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.specSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.rogueSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.warriorSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.mageSpecRadioButton = new System.Windows.Forms.RadioButton();
            this.characterCreationLabel = new System.Windows.Forms.Label();
            this.loadCharacterPanel = new System.Windows.Forms.Panel();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.slotFourGoldLabel = new System.Windows.Forms.Label();
            this.slotFourGoldTagLabel = new System.Windows.Forms.Label();
            this.slotFourLevelTagLabel = new System.Windows.Forms.Label();
            this.slotFourLevelLabel = new System.Windows.Forms.Label();
            this.slotFourNameLabel = new System.Windows.Forms.Label();
            this.loadSlotFourButton = new System.Windows.Forms.Button();
            this.slotThreeGoldLabel = new System.Windows.Forms.Label();
            this.slotThreeGoldTagLabel = new System.Windows.Forms.Label();
            this.slotThreeLevelTagLabel = new System.Windows.Forms.Label();
            this.slotThreeLevelLabel = new System.Windows.Forms.Label();
            this.slotThreeNameLabel = new System.Windows.Forms.Label();
            this.loadSlotThreeButton = new System.Windows.Forms.Button();
            this.slotTwoGoldLabel = new System.Windows.Forms.Label();
            this.slotTwoGoldTagLabel = new System.Windows.Forms.Label();
            this.slotTwoLevelTagLabel = new System.Windows.Forms.Label();
            this.slotTwoLevelLabel = new System.Windows.Forms.Label();
            this.slotTwoNameLabel = new System.Windows.Forms.Label();
            this.loadSlotTwoButton = new System.Windows.Forms.Button();
            this.slotOneGoldLabel = new System.Windows.Forms.Label();
            this.slotOneGoldTagLabel = new System.Windows.Forms.Label();
            this.slotOneLevelTagLabel = new System.Windows.Forms.Label();
            this.slotOneLevelLabel = new System.Windows.Forms.Label();
            this.slotOneNameLabel = new System.Windows.Forms.Label();
            this.loadSlotOneButton = new System.Windows.Forms.Button();
            this.loadCharacterLabel = new System.Windows.Forms.Label();
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
            this.startMenuPanel.Size = new System.Drawing.Size(259, 321);
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
            this.grindQuestTitleLabel.Size = new System.Drawing.Size(231, 18);
            this.grindQuestTitleLabel.TabIndex = 4;
            this.grindQuestTitleLabel.Text = "Welcome to GrindQuest";
            // 
            // loadGameButton
            // 
            this.loadGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadGameButton.Location = new System.Drawing.Point(3, 85);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(253, 30);
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
            this.newGameButton.Size = new System.Drawing.Size(253, 30);
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
            this.newCharacterPanel.Size = new System.Drawing.Size(259, 321);
            this.newCharacterPanel.TabIndex = 3;
            this.newCharacterPanel.Visible = false;
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
            this.confirmCharacterCreationButton.Click += new System.EventHandler(this.ConfirmCharacterCreationButton_Click);
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
            // loadCharacterPanel
            // 
            this.loadCharacterPanel.Controls.Add(this.backToMenuButton);
            this.loadCharacterPanel.Controls.Add(this.slotFourGoldLabel);
            this.loadCharacterPanel.Controls.Add(this.slotFourGoldTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotFourLevelTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotFourLevelLabel);
            this.loadCharacterPanel.Controls.Add(this.slotFourNameLabel);
            this.loadCharacterPanel.Controls.Add(this.loadSlotFourButton);
            this.loadCharacterPanel.Controls.Add(this.slotThreeGoldLabel);
            this.loadCharacterPanel.Controls.Add(this.slotThreeGoldTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotThreeLevelTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotThreeLevelLabel);
            this.loadCharacterPanel.Controls.Add(this.slotThreeNameLabel);
            this.loadCharacterPanel.Controls.Add(this.loadSlotThreeButton);
            this.loadCharacterPanel.Controls.Add(this.slotTwoGoldLabel);
            this.loadCharacterPanel.Controls.Add(this.slotTwoGoldTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotTwoLevelTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotTwoLevelLabel);
            this.loadCharacterPanel.Controls.Add(this.slotTwoNameLabel);
            this.loadCharacterPanel.Controls.Add(this.loadSlotTwoButton);
            this.loadCharacterPanel.Controls.Add(this.slotOneGoldLabel);
            this.loadCharacterPanel.Controls.Add(this.slotOneGoldTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotOneLevelTagLabel);
            this.loadCharacterPanel.Controls.Add(this.slotOneLevelLabel);
            this.loadCharacterPanel.Controls.Add(this.slotOneNameLabel);
            this.loadCharacterPanel.Controls.Add(this.loadSlotOneButton);
            this.loadCharacterPanel.Controls.Add(this.loadCharacterLabel);
            this.loadCharacterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCharacterPanel.Location = new System.Drawing.Point(0, 0);
            this.loadCharacterPanel.Name = "loadCharacterPanel";
            this.loadCharacterPanel.Size = new System.Drawing.Size(259, 321);
            this.loadCharacterPanel.TabIndex = 6;
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(163, 295);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(93, 23);
            this.backToMenuButton.TabIndex = 35;
            this.backToMenuButton.Text = "Return to menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // slotFourGoldLabel
            // 
            this.slotFourGoldLabel.AutoSize = true;
            this.slotFourGoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotFourGoldLabel.Location = new System.Drawing.Point(110, 264);
            this.slotFourGoldLabel.Name = "slotFourGoldLabel";
            this.slotFourGoldLabel.Size = new System.Drawing.Size(45, 20);
            this.slotFourGoldLabel.TabIndex = 34;
            this.slotFourGoldLabel.Text = "1111";
            // 
            // slotFourGoldTagLabel
            // 
            this.slotFourGoldTagLabel.AutoSize = true;
            this.slotFourGoldTagLabel.Location = new System.Drawing.Point(81, 268);
            this.slotFourGoldTagLabel.Name = "slotFourGoldTagLabel";
            this.slotFourGoldTagLabel.Size = new System.Drawing.Size(32, 13);
            this.slotFourGoldTagLabel.TabIndex = 33;
            this.slotFourGoldTagLabel.Text = "Gold:";
            // 
            // slotFourLevelTagLabel
            // 
            this.slotFourLevelTagLabel.AutoSize = true;
            this.slotFourLevelTagLabel.Location = new System.Drawing.Point(14, 268);
            this.slotFourLevelTagLabel.Name = "slotFourLevelTagLabel";
            this.slotFourLevelTagLabel.Size = new System.Drawing.Size(36, 13);
            this.slotFourLevelTagLabel.TabIndex = 32;
            this.slotFourLevelTagLabel.Text = "Level:";
            // 
            // slotFourLevelLabel
            // 
            this.slotFourLevelLabel.AutoSize = true;
            this.slotFourLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotFourLevelLabel.Location = new System.Drawing.Point(48, 264);
            this.slotFourLevelLabel.Name = "slotFourLevelLabel";
            this.slotFourLevelLabel.Size = new System.Drawing.Size(27, 20);
            this.slotFourLevelLabel.TabIndex = 31;
            this.slotFourLevelLabel.Text = "99";
            // 
            // slotFourNameLabel
            // 
            this.slotFourNameLabel.AutoSize = true;
            this.slotFourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotFourNameLabel.Location = new System.Drawing.Point(14, 242);
            this.slotFourNameLabel.Name = "slotFourNameLabel";
            this.slotFourNameLabel.Size = new System.Drawing.Size(118, 18);
            this.slotFourNameLabel.TabIndex = 30;
            this.slotFourNameLabel.Text = "XXXXXXXXXXX";
            // 
            // loadSlotFourButton
            // 
            this.loadSlotFourButton.Location = new System.Drawing.Point(183, 254);
            this.loadSlotFourButton.Name = "loadSlotFourButton";
            this.loadSlotFourButton.Size = new System.Drawing.Size(50, 30);
            this.loadSlotFourButton.TabIndex = 29;
            this.loadSlotFourButton.Text = "->";
            this.loadSlotFourButton.UseVisualStyleBackColor = true;
            // 
            // slotThreeGoldLabel
            // 
            this.slotThreeGoldLabel.AutoSize = true;
            this.slotThreeGoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotThreeGoldLabel.Location = new System.Drawing.Point(110, 201);
            this.slotThreeGoldLabel.Name = "slotThreeGoldLabel";
            this.slotThreeGoldLabel.Size = new System.Drawing.Size(45, 20);
            this.slotThreeGoldLabel.TabIndex = 28;
            this.slotThreeGoldLabel.Text = "1111";
            // 
            // slotThreeGoldTagLabel
            // 
            this.slotThreeGoldTagLabel.AutoSize = true;
            this.slotThreeGoldTagLabel.Location = new System.Drawing.Point(81, 205);
            this.slotThreeGoldTagLabel.Name = "slotThreeGoldTagLabel";
            this.slotThreeGoldTagLabel.Size = new System.Drawing.Size(32, 13);
            this.slotThreeGoldTagLabel.TabIndex = 27;
            this.slotThreeGoldTagLabel.Text = "Gold:";
            // 
            // slotThreeLevelTagLabel
            // 
            this.slotThreeLevelTagLabel.AutoSize = true;
            this.slotThreeLevelTagLabel.Location = new System.Drawing.Point(14, 205);
            this.slotThreeLevelTagLabel.Name = "slotThreeLevelTagLabel";
            this.slotThreeLevelTagLabel.Size = new System.Drawing.Size(36, 13);
            this.slotThreeLevelTagLabel.TabIndex = 26;
            this.slotThreeLevelTagLabel.Text = "Level:";
            // 
            // slotThreeLevelLabel
            // 
            this.slotThreeLevelLabel.AutoSize = true;
            this.slotThreeLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotThreeLevelLabel.Location = new System.Drawing.Point(48, 201);
            this.slotThreeLevelLabel.Name = "slotThreeLevelLabel";
            this.slotThreeLevelLabel.Size = new System.Drawing.Size(27, 20);
            this.slotThreeLevelLabel.TabIndex = 25;
            this.slotThreeLevelLabel.Text = "99";
            // 
            // slotThreeNameLabel
            // 
            this.slotThreeNameLabel.AutoSize = true;
            this.slotThreeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotThreeNameLabel.Location = new System.Drawing.Point(14, 179);
            this.slotThreeNameLabel.Name = "slotThreeNameLabel";
            this.slotThreeNameLabel.Size = new System.Drawing.Size(118, 18);
            this.slotThreeNameLabel.TabIndex = 24;
            this.slotThreeNameLabel.Text = "XXXXXXXXXXX";
            // 
            // loadSlotThreeButton
            // 
            this.loadSlotThreeButton.Location = new System.Drawing.Point(183, 191);
            this.loadSlotThreeButton.Name = "loadSlotThreeButton";
            this.loadSlotThreeButton.Size = new System.Drawing.Size(50, 30);
            this.loadSlotThreeButton.TabIndex = 23;
            this.loadSlotThreeButton.Text = "->";
            this.loadSlotThreeButton.UseVisualStyleBackColor = true;
            // 
            // slotTwoGoldLabel
            // 
            this.slotTwoGoldLabel.AutoSize = true;
            this.slotTwoGoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotTwoGoldLabel.Location = new System.Drawing.Point(110, 133);
            this.slotTwoGoldLabel.Name = "slotTwoGoldLabel";
            this.slotTwoGoldLabel.Size = new System.Drawing.Size(45, 20);
            this.slotTwoGoldLabel.TabIndex = 22;
            this.slotTwoGoldLabel.Text = "1111";
            // 
            // slotTwoGoldTagLabel
            // 
            this.slotTwoGoldTagLabel.AutoSize = true;
            this.slotTwoGoldTagLabel.Location = new System.Drawing.Point(81, 137);
            this.slotTwoGoldTagLabel.Name = "slotTwoGoldTagLabel";
            this.slotTwoGoldTagLabel.Size = new System.Drawing.Size(32, 13);
            this.slotTwoGoldTagLabel.TabIndex = 21;
            this.slotTwoGoldTagLabel.Text = "Gold:";
            // 
            // slotTwoLevelTagLabel
            // 
            this.slotTwoLevelTagLabel.AutoSize = true;
            this.slotTwoLevelTagLabel.Location = new System.Drawing.Point(14, 137);
            this.slotTwoLevelTagLabel.Name = "slotTwoLevelTagLabel";
            this.slotTwoLevelTagLabel.Size = new System.Drawing.Size(36, 13);
            this.slotTwoLevelTagLabel.TabIndex = 20;
            this.slotTwoLevelTagLabel.Text = "Level:";
            // 
            // slotTwoLevelLabel
            // 
            this.slotTwoLevelLabel.AutoSize = true;
            this.slotTwoLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotTwoLevelLabel.Location = new System.Drawing.Point(48, 133);
            this.slotTwoLevelLabel.Name = "slotTwoLevelLabel";
            this.slotTwoLevelLabel.Size = new System.Drawing.Size(27, 20);
            this.slotTwoLevelLabel.TabIndex = 19;
            this.slotTwoLevelLabel.Text = "99";
            // 
            // slotTwoNameLabel
            // 
            this.slotTwoNameLabel.AutoSize = true;
            this.slotTwoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotTwoNameLabel.Location = new System.Drawing.Point(14, 111);
            this.slotTwoNameLabel.Name = "slotTwoNameLabel";
            this.slotTwoNameLabel.Size = new System.Drawing.Size(118, 18);
            this.slotTwoNameLabel.TabIndex = 18;
            this.slotTwoNameLabel.Text = "XXXXXXXXXXX";
            // 
            // loadSlotTwoButton
            // 
            this.loadSlotTwoButton.Location = new System.Drawing.Point(183, 123);
            this.loadSlotTwoButton.Name = "loadSlotTwoButton";
            this.loadSlotTwoButton.Size = new System.Drawing.Size(50, 30);
            this.loadSlotTwoButton.TabIndex = 17;
            this.loadSlotTwoButton.Text = "->";
            this.loadSlotTwoButton.UseVisualStyleBackColor = true;
            // 
            // slotOneGoldLabel
            // 
            this.slotOneGoldLabel.AutoSize = true;
            this.slotOneGoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotOneGoldLabel.Location = new System.Drawing.Point(110, 68);
            this.slotOneGoldLabel.Name = "slotOneGoldLabel";
            this.slotOneGoldLabel.Size = new System.Drawing.Size(45, 20);
            this.slotOneGoldLabel.TabIndex = 16;
            this.slotOneGoldLabel.Text = "1111";
            // 
            // slotOneGoldTagLabel
            // 
            this.slotOneGoldTagLabel.AutoSize = true;
            this.slotOneGoldTagLabel.Location = new System.Drawing.Point(81, 72);
            this.slotOneGoldTagLabel.Name = "slotOneGoldTagLabel";
            this.slotOneGoldTagLabel.Size = new System.Drawing.Size(32, 13);
            this.slotOneGoldTagLabel.TabIndex = 15;
            this.slotOneGoldTagLabel.Text = "Gold:";
            // 
            // slotOneLevelTagLabel
            // 
            this.slotOneLevelTagLabel.AutoSize = true;
            this.slotOneLevelTagLabel.Location = new System.Drawing.Point(14, 72);
            this.slotOneLevelTagLabel.Name = "slotOneLevelTagLabel";
            this.slotOneLevelTagLabel.Size = new System.Drawing.Size(36, 13);
            this.slotOneLevelTagLabel.TabIndex = 14;
            this.slotOneLevelTagLabel.Text = "Level:";
            // 
            // slotOneLevelLabel
            // 
            this.slotOneLevelLabel.AutoSize = true;
            this.slotOneLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotOneLevelLabel.Location = new System.Drawing.Point(48, 68);
            this.slotOneLevelLabel.Name = "slotOneLevelLabel";
            this.slotOneLevelLabel.Size = new System.Drawing.Size(27, 20);
            this.slotOneLevelLabel.TabIndex = 10;
            this.slotOneLevelLabel.Text = "99";
            // 
            // slotOneNameLabel
            // 
            this.slotOneNameLabel.AutoSize = true;
            this.slotOneNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotOneNameLabel.Location = new System.Drawing.Point(14, 46);
            this.slotOneNameLabel.Name = "slotOneNameLabel";
            this.slotOneNameLabel.Size = new System.Drawing.Size(118, 18);
            this.slotOneNameLabel.TabIndex = 6;
            this.slotOneNameLabel.Text = "XXXXXXXXXXX";
            // 
            // loadSlotOneButton
            // 
            this.loadSlotOneButton.Location = new System.Drawing.Point(183, 58);
            this.loadSlotOneButton.Name = "loadSlotOneButton";
            this.loadSlotOneButton.Size = new System.Drawing.Size(50, 30);
            this.loadSlotOneButton.TabIndex = 1;
            this.loadSlotOneButton.Text = "->";
            this.loadSlotOneButton.UseVisualStyleBackColor = true;
            // 
            // loadCharacterLabel
            // 
            this.loadCharacterLabel.AutoSize = true;
            this.loadCharacterLabel.Location = new System.Drawing.Point(14, 14);
            this.loadCharacterLabel.Name = "loadCharacterLabel";
            this.loadCharacterLabel.Size = new System.Drawing.Size(131, 13);
            this.loadCharacterLabel.TabIndex = 0;
            this.loadCharacterLabel.Text = "Choose Character to Load";
            // 
            // GameStartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 321);
            this.Controls.Add(this.startMenuPanel);
            this.Controls.Add(this.loadCharacterPanel);
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
        private System.Windows.Forms.Label slotOneNameLabel;
        private System.Windows.Forms.Button loadSlotOneButton;
        private System.Windows.Forms.Label slotOneLevelLabel;
        private System.Windows.Forms.Label slotFourGoldLabel;
        private System.Windows.Forms.Label slotFourGoldTagLabel;
        private System.Windows.Forms.Label slotFourLevelTagLabel;
        private System.Windows.Forms.Label slotFourLevelLabel;
        private System.Windows.Forms.Label slotFourNameLabel;
        private System.Windows.Forms.Button loadSlotFourButton;
        private System.Windows.Forms.Label slotThreeGoldLabel;
        private System.Windows.Forms.Label slotThreeGoldTagLabel;
        private System.Windows.Forms.Label slotThreeLevelTagLabel;
        private System.Windows.Forms.Label slotThreeLevelLabel;
        private System.Windows.Forms.Label slotThreeNameLabel;
        private System.Windows.Forms.Button loadSlotThreeButton;
        private System.Windows.Forms.Label slotTwoGoldLabel;
        private System.Windows.Forms.Label slotTwoGoldTagLabel;
        private System.Windows.Forms.Label slotTwoLevelTagLabel;
        private System.Windows.Forms.Label slotTwoLevelLabel;
        private System.Windows.Forms.Label slotTwoNameLabel;
        private System.Windows.Forms.Button loadSlotTwoButton;
        private System.Windows.Forms.Label slotOneGoldLabel;
        private System.Windows.Forms.Label slotOneGoldTagLabel;
        private System.Windows.Forms.Label slotOneLevelTagLabel;
        private System.Windows.Forms.Button backToMenuButton;
    }
}