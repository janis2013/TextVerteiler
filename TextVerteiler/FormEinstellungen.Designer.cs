namespace TextVerteiler
{
    partial class FormEinstellungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxByZeitspanne = new System.Windows.Forms.CheckBox();
            this.checkBoxByLostFocus = new System.Windows.Forms.CheckBox();
            this.checkBoxByClicked = new System.Windows.Forms.CheckBox();
            this.groupBoxZeitspanne = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numZeitspanne = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numOpcaity = new System.Windows.Forms.NumericUpDown();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.numAutomatischVerstecken = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numHistoryStack = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBoxZeitspanne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZeitspanne)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpcaity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutomatischVerstecken)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryStack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inhalt synchronisieren wenn ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxByZeitspanne);
            this.groupBox1.Controls.Add(this.checkBoxByLostFocus);
            this.groupBox1.Controls.Add(this.checkBoxByClicked);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synchronosieren";
            // 
            // checkBoxByZeitspanne
            // 
            this.checkBoxByZeitspanne.AutoSize = true;
            this.checkBoxByZeitspanne.Location = new System.Drawing.Point(57, 101);
            this.checkBoxByZeitspanne.Name = "checkBoxByZeitspanne";
            this.checkBoxByZeitspanne.Size = new System.Drawing.Size(147, 17);
            this.checkBoxByZeitspanne.TabIndex = 7;
            this.checkBoxByZeitspanne.Text = "... Zeitspanne abgelaufen";
            this.checkBoxByZeitspanne.UseVisualStyleBackColor = true;
            this.checkBoxByZeitspanne.CheckedChanged += new System.EventHandler(this.checkBoxByZeitspanne_CheckedChanged);
            // 
            // checkBoxByLostFocus
            // 
            this.checkBoxByLostFocus.AutoSize = true;
            this.checkBoxByLostFocus.Location = new System.Drawing.Point(57, 78);
            this.checkBoxByLostFocus.Name = "checkBoxByLostFocus";
            this.checkBoxByLostFocus.Size = new System.Drawing.Size(142, 17);
            this.checkBoxByLostFocus.TabIndex = 7;
            this.checkBoxByLostFocus.Text = "... Textfeld Focus verliert";
            this.checkBoxByLostFocus.UseVisualStyleBackColor = true;
            this.checkBoxByLostFocus.CheckedChanged += new System.EventHandler(this.checkBoxByLostFocus_CheckedChanged);
            // 
            // checkBoxByClicked
            // 
            this.checkBoxByClicked.AutoSize = true;
            this.checkBoxByClicked.Location = new System.Drawing.Point(57, 56);
            this.checkBoxByClicked.Name = "checkBoxByClicked";
            this.checkBoxByClicked.Size = new System.Drawing.Size(131, 17);
            this.checkBoxByClicked.TabIndex = 7;
            this.checkBoxByClicked.Text = "... Button geklickt wird";
            this.checkBoxByClicked.UseVisualStyleBackColor = true;
            this.checkBoxByClicked.CheckedChanged += new System.EventHandler(this.checkBoxByClicked_CheckedChanged);
            // 
            // groupBoxZeitspanne
            // 
            this.groupBoxZeitspanne.Controls.Add(this.label2);
            this.groupBoxZeitspanne.Controls.Add(this.numZeitspanne);
            this.groupBoxZeitspanne.Location = new System.Drawing.Point(249, 12);
            this.groupBoxZeitspanne.Name = "groupBoxZeitspanne";
            this.groupBoxZeitspanne.Size = new System.Drawing.Size(124, 50);
            this.groupBoxZeitspanne.TabIndex = 4;
            this.groupBoxZeitspanne.TabStop = false;
            this.groupBoxZeitspanne.Text = "Zeitspanne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ms";
            // 
            // numZeitspanne
            // 
            this.numZeitspanne.Location = new System.Drawing.Point(28, 19);
            this.numZeitspanne.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numZeitspanne.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numZeitspanne.Name = "numZeitspanne";
            this.numZeitspanne.Size = new System.Drawing.Size(62, 20);
            this.numZeitspanne.TabIndex = 5;
            this.numZeitspanne.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numZeitspanne.ValueChanged += new System.EventHandler(this.numZeitspanne_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numOpcaity);
            this.groupBox2.Location = new System.Drawing.Point(256, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durchsichtigkeit";
            // 
            // numOpcaity
            // 
            this.numOpcaity.DecimalPlaces = 2;
            this.numOpcaity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpcaity.Location = new System.Drawing.Point(21, 19);
            this.numOpcaity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpcaity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpcaity.Name = "numOpcaity";
            this.numOpcaity.Size = new System.Drawing.Size(62, 20);
            this.numOpcaity.TabIndex = 0;
            this.numOpcaity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpcaity.ValueChanged += new System.EventHandler(this.numOpcaity_ValueChanged);
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.Location = new System.Drawing.Point(256, 180);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(117, 30);
            this.btnResetPosition.TabIndex = 6;
            this.btnResetPosition.Text = "Reset Position";
            this.btnResetPosition.UseVisualStyleBackColor = true;
            this.btnResetPosition.Click += new System.EventHandler(this.btnResetPosition_Click);
            // 
            // numAutomatischVerstecken
            // 
            this.numAutomatischVerstecken.Location = new System.Drawing.Point(15, 27);
            this.numAutomatischVerstecken.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAutomatischVerstecken.Name = "numAutomatischVerstecken";
            this.numAutomatischVerstecken.Size = new System.Drawing.Size(67, 20);
            this.numAutomatischVerstecken.TabIndex = 7;
            this.numAutomatischVerstecken.ValueChanged += new System.EventHandler(this.numAutomatischVerstecken_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numAutomatischVerstecken);
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 61);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "automatisch Verstecken nach ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sekunden (0 = nie, mit \r\nEnter bestätigen)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numHistoryStack);
            this.groupBox4.Location = new System.Drawing.Point(256, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 50);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "History Stack";
            // 
            // numHistoryStack
            // 
            this.numHistoryStack.Location = new System.Drawing.Point(21, 19);
            this.numHistoryStack.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numHistoryStack.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHistoryStack.Name = "numHistoryStack";
            this.numHistoryStack.Size = new System.Drawing.Size(62, 20);
            this.numHistoryStack.TabIndex = 0;
            this.numHistoryStack.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHistoryStack.ValueChanged += new System.EventHandler(this.numHistoryStack_ValueChanged);
            // 
            // FormEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 217);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnResetPosition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxZeitspanne);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEinstellungen";
            this.ShowInTaskbar = false;
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEinstellungen_FormClosing);
            this.Load += new System.EventHandler(this.FormEinstellungen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxZeitspanne.ResumeLayout(false);
            this.groupBoxZeitspanne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZeitspanne)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOpcaity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutomatischVerstecken)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryStack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxZeitspanne;
        private System.Windows.Forms.NumericUpDown numZeitspanne;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.CheckBox checkBoxByClicked;
        internal System.Windows.Forms.CheckBox checkBoxByLostFocus;
        internal System.Windows.Forms.CheckBox checkBoxByZeitspanne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numOpcaity;
        private System.Windows.Forms.Button btnResetPosition;
        private System.Windows.Forms.NumericUpDown numAutomatischVerstecken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numHistoryStack;
    }
}