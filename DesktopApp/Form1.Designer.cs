namespace DesktopApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeN = new System.Windows.Forms.RadioButton();
            this.latitudeS = new System.Windows.Forms.RadioButton();
            this.longitudeE = new System.Windows.Forms.RadioButton();
            this.longitudeW = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.latitudeGroup = new System.Windows.Forms.GroupBox();
            this.longitudeGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.latitudeGroup.SuspendLayout();
            this.longitudeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitClicked);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyText);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteText);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Go to Google Maps";
            this.toolStripButton1.Click += new System.EventHandler(this.goToGoogleMaps);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Refresh";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a Point of Interest";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(118, 104);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(329, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Address";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.addressChecked);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "GeoLocation";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Enabled = false;
            this.latitudeTextBox.Location = new System.Drawing.Point(6, 22);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(171, 20);
            this.latitudeTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Enabled = false;
            this.longitudeTextBox.Location = new System.Drawing.Point(6, 33);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(171, 20);
            this.longitudeTextBox.TabIndex = 12;
            // 
            // latitudeN
            // 
            this.latitudeN.AutoSize = true;
            this.latitudeN.Checked = true;
            this.latitudeN.Enabled = false;
            this.latitudeN.Location = new System.Drawing.Point(183, 23);
            this.latitudeN.Name = "latitudeN";
            this.latitudeN.Size = new System.Drawing.Size(51, 17);
            this.latitudeN.TabIndex = 13;
            this.latitudeN.TabStop = true;
            this.latitudeN.Text = "North";
            this.latitudeN.UseVisualStyleBackColor = true;
            // 
            // latitudeS
            // 
            this.latitudeS.AutoSize = true;
            this.latitudeS.Enabled = false;
            this.latitudeS.Location = new System.Drawing.Point(240, 23);
            this.latitudeS.Name = "latitudeS";
            this.latitudeS.Size = new System.Drawing.Size(53, 17);
            this.latitudeS.TabIndex = 14;
            this.latitudeS.Text = "South";
            this.latitudeS.UseVisualStyleBackColor = true;
            // 
            // longitudeE
            // 
            this.longitudeE.AutoSize = true;
            this.longitudeE.Enabled = false;
            this.longitudeE.Location = new System.Drawing.Point(183, 36);
            this.longitudeE.Name = "longitudeE";
            this.longitudeE.Size = new System.Drawing.Size(46, 17);
            this.longitudeE.TabIndex = 15;
            this.longitudeE.Text = "East";
            this.longitudeE.UseVisualStyleBackColor = true;
            // 
            // longitudeW
            // 
            this.longitudeW.AutoSize = true;
            this.longitudeW.Checked = true;
            this.longitudeW.Enabled = false;
            this.longitudeW.Location = new System.Drawing.Point(240, 36);
            this.longitudeW.Name = "longitudeW";
            this.longitudeW.Size = new System.Drawing.Size(50, 17);
            this.longitudeW.TabIndex = 16;
            this.longitudeW.TabStop = true;
            this.longitudeW.Text = "West";
            this.longitudeW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(9, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Type";
            // 
            // latitudeGroup
            // 
            this.latitudeGroup.Controls.Add(this.latitudeTextBox);
            this.latitudeGroup.Controls.Add(this.latitudeN);
            this.latitudeGroup.Controls.Add(this.latitudeS);
            this.latitudeGroup.Location = new System.Drawing.Point(118, 133);
            this.latitudeGroup.Name = "latitudeGroup";
            this.latitudeGroup.Size = new System.Drawing.Size(362, 54);
            this.latitudeGroup.TabIndex = 18;
            this.latitudeGroup.TabStop = false;
            this.latitudeGroup.Text = "Latitude";
            // 
            // longitudeGroup
            // 
            this.longitudeGroup.Controls.Add(this.longitudeTextBox);
            this.longitudeGroup.Controls.Add(this.longitudeE);
            this.longitudeGroup.Controls.Add(this.longitudeW);
            this.longitudeGroup.Location = new System.Drawing.Point(118, 203);
            this.longitudeGroup.Name = "longitudeGroup";
            this.longitudeGroup.Size = new System.Drawing.Size(362, 62);
            this.longitudeGroup.TabIndex = 19;
            this.longitudeGroup.TabStop = false;
            this.longitudeGroup.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please enter latitude and longtitude in the decimal form";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showToolbarToolStripMenuItem
            // 
            this.showToolbarToolStripMenuItem.Checked = true;
            this.showToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
            this.showToolbarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolbarToolStripMenuItem.Text = "Hide Toolbar";
            this.showToolbarToolStripMenuItem.Click += new System.EventHandler(this.showToolbarToolStripMenuItem_Click);
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.importFromFileToolStripMenuItem.Text = "Import From file";
            this.importFromFileToolStripMenuItem.Click += new System.EventHandler(this.importFromFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.longitudeGroup);
            this.Controls.Add(this.latitudeGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Map Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.latitudeGroup.ResumeLayout(false);
            this.latitudeGroup.PerformLayout();
            this.longitudeGroup.ResumeLayout(false);
            this.longitudeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.RadioButton latitudeN;
        private System.Windows.Forms.RadioButton latitudeS;
        private System.Windows.Forms.RadioButton longitudeE;
        private System.Windows.Forms.RadioButton longitudeW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox latitudeGroup;
        private System.Windows.Forms.GroupBox longitudeGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
    }
}

