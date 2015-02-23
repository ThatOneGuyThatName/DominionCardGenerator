namespace Dominion
{
    partial class DominionGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DominionGenerator));
            this.cardsOnField = new System.Windows.Forms.ListBox();
            this.AddListings = new System.Windows.Forms.Button();
            this.numOfCardsInc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterOutLabel = new System.Windows.Forms.Label();
            this.BaseCheck = new System.Windows.Forms.CheckBox();
            this.IntrigueCheck = new System.Windows.Forms.CheckBox();
            this.SeasideCheck = new System.Windows.Forms.CheckBox();
            this.HinterlandsCheck = new System.Windows.Forms.CheckBox();
            this.DarkAgesCheck = new System.Windows.Forms.CheckBox();
            this.ProsperityCheck = new System.Windows.Forms.CheckBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FilterOutShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.CardDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CardNameBox = new System.Windows.Forms.TextBox();
            this.CardCostBox = new System.Windows.Forms.TextBox();
            this.CardTypeBox = new System.Windows.Forms.TextBox();
            this.CardSetBox = new System.Windows.Forms.TextBox();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardCostLabel = new System.Windows.Forms.Label();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.CardSetLabel = new System.Windows.Forms.Label();
            this.CardDescriptionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPromoCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlchemyCheck = new System.Windows.Forms.CheckBox();
            this.CornucopiaCheck = new System.Windows.Forms.CheckBox();
            this.GuildsCheck = new System.Windows.Forms.CheckBox();
            this.PromoCheck = new System.Windows.Forms.CheckBox();
            this.additionalCards = new System.Windows.Forms.ListBox();
            this.additionalCardsLabel = new System.Windows.Forms.Label();
            this.AddPromoCardButton = new System.Windows.Forms.Button();
            this.CheckChange = new System.Windows.Forms.CheckBox();
            this.Replace = new System.Windows.Forms.Button();
            this.AddCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfCardsInc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardsOnField
            // 
            this.cardsOnField.FormattingEnabled = true;
            this.cardsOnField.Location = new System.Drawing.Point(10, 25);
            this.cardsOnField.Name = "cardsOnField";
            this.cardsOnField.Size = new System.Drawing.Size(120, 316);
            this.cardsOnField.TabIndex = 0;
            this.cardsOnField.SelectedIndexChanged += new System.EventHandler(this.cardsOnField_SelectedIndexChanged);
            // 
            // AddListings
            // 
            this.AddListings.Location = new System.Drawing.Point(135, 25);
            this.AddListings.Name = "AddListings";
            this.AddListings.Size = new System.Drawing.Size(120, 23);
            this.AddListings.TabIndex = 3;
            this.AddListings.Text = "Generate 10 Cards";
            this.AddListings.UseVisualStyleBackColor = true;
            this.AddListings.Click += new System.EventHandler(this.AddListings_Click);
            // 
            // numOfCardsInc
            // 
            this.numOfCardsInc.Location = new System.Drawing.Point(142, 57);
            this.numOfCardsInc.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOfCardsInc.Name = "numOfCardsInc";
            this.numOfCardsInc.Size = new System.Drawing.Size(43, 20);
            this.numOfCardsInc.TabIndex = 8;
            this.numOfCardsInc.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOfCardsInc.ValueChanged += new System.EventHandler(this.numOfCardsInc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of cards";
            // 
            // FilterOutLabel
            // 
            this.FilterOutLabel.AutoSize = true;
            this.FilterOutLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterOutLabel.Location = new System.Drawing.Point(185, 100);
            this.FilterOutLabel.Name = "FilterOutLabel";
            this.FilterOutLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterOutLabel.TabIndex = 10;
            this.FilterOutLabel.Text = "Filter";
            // 
            // BaseCheck
            // 
            this.BaseCheck.AutoSize = true;
            this.BaseCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BaseCheck.Checked = true;
            this.BaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BaseCheck.Location = new System.Drawing.Point(140, 120);
            this.BaseCheck.Name = "BaseCheck";
            this.BaseCheck.Size = new System.Drawing.Size(122, 17);
            this.BaseCheck.TabIndex = 11;
            this.BaseCheck.Text = "Base Set (Dominion)";
            this.BaseCheck.UseVisualStyleBackColor = false;
            // 
            // IntrigueCheck
            // 
            this.IntrigueCheck.AutoSize = true;
            this.IntrigueCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IntrigueCheck.Checked = true;
            this.IntrigueCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IntrigueCheck.Location = new System.Drawing.Point(140, 145);
            this.IntrigueCheck.Name = "IntrigueCheck";
            this.IntrigueCheck.Size = new System.Drawing.Size(61, 17);
            this.IntrigueCheck.TabIndex = 12;
            this.IntrigueCheck.Text = "Intrigue";
            this.IntrigueCheck.UseVisualStyleBackColor = false;
            // 
            // SeasideCheck
            // 
            this.SeasideCheck.AutoSize = true;
            this.SeasideCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeasideCheck.Checked = true;
            this.SeasideCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SeasideCheck.Location = new System.Drawing.Point(140, 170);
            this.SeasideCheck.Name = "SeasideCheck";
            this.SeasideCheck.Size = new System.Drawing.Size(64, 17);
            this.SeasideCheck.TabIndex = 13;
            this.SeasideCheck.Text = "Seaside";
            this.SeasideCheck.UseVisualStyleBackColor = false;
            // 
            // HinterlandsCheck
            // 
            this.HinterlandsCheck.AutoSize = true;
            this.HinterlandsCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HinterlandsCheck.Checked = true;
            this.HinterlandsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HinterlandsCheck.Location = new System.Drawing.Point(140, 220);
            this.HinterlandsCheck.Name = "HinterlandsCheck";
            this.HinterlandsCheck.Size = new System.Drawing.Size(79, 17);
            this.HinterlandsCheck.TabIndex = 14;
            this.HinterlandsCheck.Text = "Hinterlands";
            this.HinterlandsCheck.UseVisualStyleBackColor = false;
            // 
            // DarkAgesCheck
            // 
            this.DarkAgesCheck.AutoSize = true;
            this.DarkAgesCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DarkAgesCheck.Checked = true;
            this.DarkAgesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DarkAgesCheck.Location = new System.Drawing.Point(140, 245);
            this.DarkAgesCheck.Name = "DarkAgesCheck";
            this.DarkAgesCheck.Size = new System.Drawing.Size(76, 17);
            this.DarkAgesCheck.TabIndex = 15;
            this.DarkAgesCheck.Text = "Dark Ages";
            this.DarkAgesCheck.UseVisualStyleBackColor = false;
            // 
            // ProsperityCheck
            // 
            this.ProsperityCheck.AutoSize = true;
            this.ProsperityCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProsperityCheck.Checked = true;
            this.ProsperityCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProsperityCheck.Location = new System.Drawing.Point(140, 195);
            this.ProsperityCheck.Name = "ProsperityCheck";
            this.ProsperityCheck.Size = new System.Drawing.Size(72, 17);
            this.ProsperityCheck.TabIndex = 16;
            this.ProsperityCheck.Text = "Prosperity";
            this.ProsperityCheck.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.FilterOutShape,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(749, 397);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 605;
            this.lineShape2.X2 = 605;
            this.lineShape2.Y1 = 30;
            this.lineShape2.Y2 = 350;
            // 
            // FilterOutShape
            // 
            this.FilterOutShape.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterOutShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.FilterOutShape.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.FilterOutShape.FillColor = System.Drawing.SystemColors.ControlDark;
            this.FilterOutShape.FillGradientColor = System.Drawing.SystemColors.ControlDark;
            this.FilterOutShape.Location = new System.Drawing.Point(135, 90);
            this.FilterOutShape.Name = "FilterOutShape";
            this.FilterOutShape.Size = new System.Drawing.Size(135, 300);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 305;
            this.lineShape1.X2 = 305;
            this.lineShape1.Y1 = 30;
            this.lineShape1.Y2 = 350;
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(10, 343);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(120, 25);
            this.RemoveItem.TabIndex = 18;
            this.RemoveItem.Text = "Remove Item";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // CardDescriptionBox
            // 
            this.CardDescriptionBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardDescriptionBox.Location = new System.Drawing.Point(345, 230);
            this.CardDescriptionBox.Name = "CardDescriptionBox";
            this.CardDescriptionBox.ReadOnly = true;
            this.CardDescriptionBox.Size = new System.Drawing.Size(225, 130);
            this.CardDescriptionBox.TabIndex = 20;
            this.CardDescriptionBox.Text = "";
            // 
            // CardNameBox
            // 
            this.CardNameBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CardNameBox.Location = new System.Drawing.Point(410, 105);
            this.CardNameBox.Name = "CardNameBox";
            this.CardNameBox.ReadOnly = true;
            this.CardNameBox.Size = new System.Drawing.Size(160, 20);
            this.CardNameBox.TabIndex = 21;
            // 
            // CardCostBox
            // 
            this.CardCostBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardCostBox.Location = new System.Drawing.Point(410, 130);
            this.CardCostBox.Name = "CardCostBox";
            this.CardCostBox.ReadOnly = true;
            this.CardCostBox.Size = new System.Drawing.Size(160, 20);
            this.CardCostBox.TabIndex = 22;
            // 
            // CardTypeBox
            // 
            this.CardTypeBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardTypeBox.Location = new System.Drawing.Point(410, 155);
            this.CardTypeBox.Name = "CardTypeBox";
            this.CardTypeBox.ReadOnly = true;
            this.CardTypeBox.Size = new System.Drawing.Size(160, 20);
            this.CardTypeBox.TabIndex = 23;
            // 
            // CardSetBox
            // 
            this.CardSetBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardSetBox.Location = new System.Drawing.Point(410, 180);
            this.CardSetBox.Name = "CardSetBox";
            this.CardSetBox.ReadOnly = true;
            this.CardSetBox.Size = new System.Drawing.Size(160, 20);
            this.CardSetBox.TabIndex = 24;
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Location = new System.Drawing.Point(375, 105);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CardNameLabel.TabIndex = 26;
            this.CardNameLabel.Text = "Name";
            // 
            // CardCostLabel
            // 
            this.CardCostLabel.AutoSize = true;
            this.CardCostLabel.Location = new System.Drawing.Point(375, 130);
            this.CardCostLabel.Name = "CardCostLabel";
            this.CardCostLabel.Size = new System.Drawing.Size(28, 13);
            this.CardCostLabel.TabIndex = 27;
            this.CardCostLabel.Text = "Cost";
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Location = new System.Drawing.Point(375, 156);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.CardTypeLabel.TabIndex = 28;
            this.CardTypeLabel.Text = "Type";
            // 
            // CardSetLabel
            // 
            this.CardSetLabel.AutoSize = true;
            this.CardSetLabel.Location = new System.Drawing.Point(375, 183);
            this.CardSetLabel.Name = "CardSetLabel";
            this.CardSetLabel.Size = new System.Drawing.Size(23, 13);
            this.CardSetLabel.TabIndex = 29;
            this.CardSetLabel.Text = "Set";
            // 
            // CardDescriptionLabel
            // 
            this.CardDescriptionLabel.AutoSize = true;
            this.CardDescriptionLabel.Location = new System.Drawing.Point(345, 210);
            this.CardDescriptionLabel.Name = "CardDescriptionLabel";
            this.CardDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.CardDescriptionLabel.TabIndex = 30;
            this.CardDescriptionLabel.Text = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllCardsToolStripMenuItem,
            this.addPromoCardsToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Settings";
            // 
            // viewAllCardsToolStripMenuItem
            // 
            this.viewAllCardsToolStripMenuItem.Name = "viewAllCardsToolStripMenuItem";
            this.viewAllCardsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewAllCardsToolStripMenuItem.Text = "View All Cards";
            this.viewAllCardsToolStripMenuItem.Click += new System.EventHandler(this.viewAllCardsToolStripMenuItem_Click);
            // 
            // addPromoCardsToolStripMenuItem
            // 
            this.addPromoCardsToolStripMenuItem.Name = "addPromoCardsToolStripMenuItem";
            this.addPromoCardsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addPromoCardsToolStripMenuItem.Text = "Add Promo Cards";
            this.addPromoCardsToolStripMenuItem.Click += new System.EventHandler(this.addPromoCardsToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AlchemyCheck
            // 
            this.AlchemyCheck.AutoSize = true;
            this.AlchemyCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AlchemyCheck.Checked = true;
            this.AlchemyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlchemyCheck.Location = new System.Drawing.Point(140, 270);
            this.AlchemyCheck.Name = "AlchemyCheck";
            this.AlchemyCheck.Size = new System.Drawing.Size(66, 17);
            this.AlchemyCheck.TabIndex = 32;
            this.AlchemyCheck.Text = "Alchemy";
            this.AlchemyCheck.UseVisualStyleBackColor = false;
            // 
            // CornucopiaCheck
            // 
            this.CornucopiaCheck.AutoSize = true;
            this.CornucopiaCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CornucopiaCheck.Checked = true;
            this.CornucopiaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CornucopiaCheck.Location = new System.Drawing.Point(140, 295);
            this.CornucopiaCheck.Name = "CornucopiaCheck";
            this.CornucopiaCheck.Size = new System.Drawing.Size(80, 17);
            this.CornucopiaCheck.TabIndex = 33;
            this.CornucopiaCheck.Text = "Cornucopia";
            this.CornucopiaCheck.UseVisualStyleBackColor = false;
            // 
            // GuildsCheck
            // 
            this.GuildsCheck.AutoSize = true;
            this.GuildsCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GuildsCheck.Checked = true;
            this.GuildsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GuildsCheck.Location = new System.Drawing.Point(140, 320);
            this.GuildsCheck.Name = "GuildsCheck";
            this.GuildsCheck.Size = new System.Drawing.Size(55, 17);
            this.GuildsCheck.TabIndex = 34;
            this.GuildsCheck.Text = "Guilds";
            this.GuildsCheck.UseVisualStyleBackColor = false;
            // 
            // PromoCheck
            // 
            this.PromoCheck.AutoSize = true;
            this.PromoCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PromoCheck.Location = new System.Drawing.Point(140, 345);
            this.PromoCheck.Name = "PromoCheck";
            this.PromoCheck.Size = new System.Drawing.Size(86, 17);
            this.PromoCheck.TabIndex = 35;
            this.PromoCheck.Text = "Promo Cards";
            this.PromoCheck.UseVisualStyleBackColor = false;
            this.PromoCheck.CheckedChanged += new System.EventHandler(this.PromoCheck_CheckedChanged);
            // 
            // additionalCards
            // 
            this.additionalCards.FormattingEnabled = true;
            this.additionalCards.Location = new System.Drawing.Point(620, 50);
            this.additionalCards.Name = "additionalCards";
            this.additionalCards.Size = new System.Drawing.Size(120, 316);
            this.additionalCards.TabIndex = 36;
            this.additionalCards.SelectedIndexChanged += new System.EventHandler(this.additionalCards_SelectedIndexChanged);
            // 
            // additionalCardsLabel
            // 
            this.additionalCardsLabel.AutoSize = true;
            this.additionalCardsLabel.Location = new System.Drawing.Point(620, 30);
            this.additionalCardsLabel.Name = "additionalCardsLabel";
            this.additionalCardsLabel.Size = new System.Drawing.Size(83, 13);
            this.additionalCardsLabel.TabIndex = 37;
            this.additionalCardsLabel.Text = "Additional Cards";
            // 
            // AddPromoCardButton
            // 
            this.AddPromoCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPromoCardButton.Location = new System.Drawing.Point(245, 342);
            this.AddPromoCardButton.Name = "AddPromoCardButton";
            this.AddPromoCardButton.Size = new System.Drawing.Size(20, 20);
            this.AddPromoCardButton.TabIndex = 38;
            this.AddPromoCardButton.Text = "...";
            this.AddPromoCardButton.UseVisualStyleBackColor = true;
            this.AddPromoCardButton.Click += new System.EventHandler(this.AddPromoCardButton_Click);
            // 
            // CheckChange
            // 
            this.CheckChange.AutoSize = true;
            this.CheckChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckChange.Location = new System.Drawing.Point(180, 370);
            this.CheckChange.Name = "CheckChange";
            this.CheckChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckChange.Size = new System.Drawing.Size(85, 17);
            this.CheckChange.TabIndex = 39;
            this.CheckChange.Text = "UnCheck All";
            this.CheckChange.UseVisualStyleBackColor = false;
            this.CheckChange.CheckedChanged += new System.EventHandler(this.CheckChange_CheckedChanged);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(10, 369);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(120, 25);
            this.Replace.TabIndex = 40;
            this.Replace.Text = "Remove and Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // AddCardButton
            // 
            this.AddCardButton.Location = new System.Drawing.Point(262, 25);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(25, 23);
            this.AddCardButton.TabIndex = 41;
            this.AddCardButton.Text = "+";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // DominionGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 397);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.CheckChange);
            this.Controls.Add(this.AddPromoCardButton);
            this.Controls.Add(this.additionalCardsLabel);
            this.Controls.Add(this.additionalCards);
            this.Controls.Add(this.PromoCheck);
            this.Controls.Add(this.GuildsCheck);
            this.Controls.Add(this.CornucopiaCheck);
            this.Controls.Add(this.AlchemyCheck);
            this.Controls.Add(this.CardDescriptionLabel);
            this.Controls.Add(this.CardSetLabel);
            this.Controls.Add(this.CardTypeLabel);
            this.Controls.Add(this.CardCostLabel);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.CardSetBox);
            this.Controls.Add(this.CardTypeBox);
            this.Controls.Add(this.CardCostBox);
            this.Controls.Add(this.CardNameBox);
            this.Controls.Add(this.CardDescriptionBox);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.ProsperityCheck);
            this.Controls.Add(this.DarkAgesCheck);
            this.Controls.Add(this.HinterlandsCheck);
            this.Controls.Add(this.SeasideCheck);
            this.Controls.Add(this.IntrigueCheck);
            this.Controls.Add(this.BaseCheck);
            this.Controls.Add(this.FilterOutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfCardsInc);
            this.Controls.Add(this.AddListings);
            this.Controls.Add(this.cardsOnField);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(765, 435);
            this.Name = "DominionGenerator";
            this.Text = "Dominion Card Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfCardsInc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cardsOnField;
        private System.Windows.Forms.Button AddListings;
        private System.Windows.Forms.NumericUpDown numOfCardsInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FilterOutLabel;
        private System.Windows.Forms.CheckBox BaseCheck;
        private System.Windows.Forms.CheckBox IntrigueCheck;
        private System.Windows.Forms.CheckBox SeasideCheck;
        private System.Windows.Forms.CheckBox HinterlandsCheck;
        private System.Windows.Forms.CheckBox DarkAgesCheck;
        private System.Windows.Forms.CheckBox ProsperityCheck;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button RemoveItem;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape FilterOutShape;
        private System.Windows.Forms.RichTextBox CardDescriptionBox;
        private System.Windows.Forms.TextBox CardNameBox;
        private System.Windows.Forms.TextBox CardCostBox;
        private System.Windows.Forms.TextBox CardTypeBox;
        private System.Windows.Forms.TextBox CardSetBox;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.Label CardCostLabel;
        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.Label CardSetLabel;
        private System.Windows.Forms.Label CardDescriptionLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPromoCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox AlchemyCheck;
        private System.Windows.Forms.CheckBox CornucopiaCheck;
        private System.Windows.Forms.CheckBox GuildsCheck;
        private System.Windows.Forms.CheckBox PromoCheck;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ListBox additionalCards;
        private System.Windows.Forms.Label additionalCardsLabel;
        private System.Windows.Forms.Button AddPromoCardButton;
        private System.Windows.Forms.CheckBox CheckChange;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

