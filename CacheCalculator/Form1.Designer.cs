namespace CacheCalculator
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
            this.textBox_memoryCapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_numBlocks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_blockSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_addressToCalc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_addrTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_addrLine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_addrOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_offsetSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_lineSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_tagSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_eet_inCacheInstructionExecutionTime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_eet_subsequentBurstTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_eet_initialBurstTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_eet_resultNanoseconds = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_eet_hitRatioPercentage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_eet_refillLine = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_eet_busWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_eet_clockMhz = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_eet_resultCycles = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_hitratio = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_hittime = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_misstime = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_clockfreq = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_resultClockCycles = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_eeteasy_resultNanoseconds = new System.Windows.Forms.TextBox();
            this.textBox_setAssociativity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_cacheSize = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_resultCacheCapacity = new System.Windows.Forms.TextBox();
            this.textBox_resultNumBlocks = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_resultBlockSize = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_sizeInBytes = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_sizeInBits = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_memoryCapacity
            // 
            this.textBox_memoryCapacity.Location = new System.Drawing.Point(21, 83);
            this.textBox_memoryCapacity.Name = "textBox_memoryCapacity";
            this.textBox_memoryCapacity.Size = new System.Drawing.Size(190, 20);
            this.textBox_memoryCapacity.TabIndex = 0;
            this.textBox_memoryCapacity.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Virtual Memory Capacity (in bytes na/k/m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of blocks";
            // 
            // textBox_numBlocks
            // 
            this.textBox_numBlocks.Location = new System.Drawing.Point(20, 122);
            this.textBox_numBlocks.Name = "textBox_numBlocks";
            this.textBox_numBlocks.Size = new System.Drawing.Size(190, 20);
            this.textBox_numBlocks.TabIndex = 2;
            this.textBox_numBlocks.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Block Size";
            // 
            // textBox_blockSize
            // 
            this.textBox_blockSize.Location = new System.Drawing.Point(20, 161);
            this.textBox_blockSize.Name = "textBox_blockSize";
            this.textBox_blockSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_blockSize.TabIndex = 4;
            this.textBox_blockSize.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Associativity (0 = fully)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address to calculate   (ABC123)";
            // 
            // textBox_addressToCalc
            // 
            this.textBox_addressToCalc.Location = new System.Drawing.Point(9, 44);
            this.textBox_addressToCalc.Name = "textBox_addressToCalc";
            this.textBox_addressToCalc.Size = new System.Drawing.Size(190, 20);
            this.textBox_addressToCalc.TabIndex = 8;
            this.textBox_addressToCalc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tag";
            // 
            // textBox_addrTag
            // 
            this.textBox_addrTag.Location = new System.Drawing.Point(9, 96);
            this.textBox_addrTag.Name = "textBox_addrTag";
            this.textBox_addrTag.Size = new System.Drawing.Size(190, 20);
            this.textBox_addrTag.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Line";
            // 
            // textBox_addrLine
            // 
            this.textBox_addrLine.Location = new System.Drawing.Point(9, 140);
            this.textBox_addrLine.Name = "textBox_addrLine";
            this.textBox_addrLine.Size = new System.Drawing.Size(190, 20);
            this.textBox_addrLine.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Offset";
            // 
            // textBox_addrOffset
            // 
            this.textBox_addrOffset.Location = new System.Drawing.Point(9, 188);
            this.textBox_addrOffset.Name = "textBox_addrOffset";
            this.textBox_addrOffset.Size = new System.Drawing.Size(190, 20);
            this.textBox_addrOffset.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Offset size (block offset size)";
            // 
            // textBox_offsetSize
            // 
            this.textBox_offsetSize.Location = new System.Drawing.Point(21, 408);
            this.textBox_offsetSize.Name = "textBox_offsetSize";
            this.textBox_offsetSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_offsetSize.TabIndex = 20;
            this.textBox_offsetSize.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Line size (set index size)";
            // 
            // textBox_lineSize
            // 
            this.textBox_lineSize.Location = new System.Drawing.Point(21, 360);
            this.textBox_lineSize.Name = "textBox_lineSize";
            this.textBox_lineSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_lineSize.TabIndex = 18;
            this.textBox_lineSize.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tag size";
            // 
            // textBox_tagSize
            // 
            this.textBox_tagSize.Location = new System.Drawing.Point(21, 316);
            this.textBox_tagSize.Name = "textBox_tagSize";
            this.textBox_tagSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_tagSize.TabIndex = 16;
            this.textBox_tagSize.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.textBox_resultCacheCapacity);
            this.groupBox1.Controls.Add(this.textBox_resultNumBlocks);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.textBox_resultBlockSize);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_cacheSize);
            this.groupBox1.Controls.Add(this.textBox_setAssociativity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_memoryCapacity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_numBlocks);
            this.groupBox1.Controls.Add(this.textBox_offsetSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_blockSize);
            this.groupBox1.Controls.Add(this.textBox_lineSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_tagSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 624);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cache Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_addressToCalc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_addrTag);
            this.groupBox2.Controls.Add(this.textBox_addrOffset);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_addrLine);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 240);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Calculator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textBox_eet_resultCycles);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox_eet_inCacheInstructionExecutionTime);
            this.groupBox3.Controls.Add(this.textBox_eet_clockMhz);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBox_eet_subsequentBurstTime);
            this.groupBox3.Controls.Add(this.textBox_eet_hitRatioPercentage);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox_eet_resultNanoseconds);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox_eet_initialBurstTime);
            this.groupBox3.Controls.Add(this.textBox_eet_refillLine);
            this.groupBox3.Controls.Add(this.textBox_eet_busWidth);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(604, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 451);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Effective Execution Time";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(197, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "#clock cycles a hit (in-cache-instr) takes";
            // 
            // textBox_eet_inCacheInstructionExecutionTime
            // 
            this.textBox_eet_inCacheInstructionExecutionTime.Location = new System.Drawing.Point(9, 212);
            this.textBox_eet_inCacheInstructionExecutionTime.Name = "textBox_eet_inCacheInstructionExecutionTime";
            this.textBox_eet_inCacheInstructionExecutionTime.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_inCacheInstructionExecutionTime.TabIndex = 86;
            this.textBox_eet_inCacheInstructionExecutionTime.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(189, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "subsequent burst time (in clock cycles)";
            // 
            // textBox_eet_subsequentBurstTime
            // 
            this.textBox_eet_subsequentBurstTime.Location = new System.Drawing.Point(9, 292);
            this.textBox_eet_subsequentBurstTime.Name = "textBox_eet_subsequentBurstTime";
            this.textBox_eet_subsequentBurstTime.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_subsequentBurstTime.TabIndex = 88;
            this.textBox_eet_subsequentBurstTime.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Initial burst setup time (clock cycles)";
            // 
            // textBox_eet_initialBurstTime
            // 
            this.textBox_eet_initialBurstTime.Location = new System.Drawing.Point(9, 254);
            this.textBox_eet_initialBurstTime.Name = "textBox_eet_initialBurstTime";
            this.textBox_eet_initialBurstTime.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_initialBurstTime.TabIndex = 87;
            this.textBox_eet_initialBurstTime.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 405);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Effective Execution Time";
            // 
            // textBox_eet_resultNanoseconds
            // 
            this.textBox_eet_resultNanoseconds.Location = new System.Drawing.Point(15, 421);
            this.textBox_eet_resultNanoseconds.Name = "textBox_eet_resultNanoseconds";
            this.textBox_eet_resultNanoseconds.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_resultNanoseconds.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "average hit rate (specify in decimal format)";
            // 
            // textBox_eet_hitRatioPercentage
            // 
            this.textBox_eet_hitRatioPercentage.Location = new System.Drawing.Point(9, 168);
            this.textBox_eet_hitRatioPercentage.Name = "textBox_eet_hitRatioPercentage";
            this.textBox_eet_hitRatioPercentage.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_hitRatioPercentage.TabIndex = 85;
            this.textBox_eet_hitRatioPercentage.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "refill line size in bytes";
            // 
            // textBox_eet_refillLine
            // 
            this.textBox_eet_refillLine.Location = new System.Drawing.Point(9, 80);
            this.textBox_eet_refillLine.Name = "textBox_eet_refillLine";
            this.textBox_eet_refillLine.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_refillLine.TabIndex = 83;
            this.textBox_eet_refillLine.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Bus size/width in bits";
            // 
            // textBox_eet_busWidth
            // 
            this.textBox_eet_busWidth.Location = new System.Drawing.Point(9, 32);
            this.textBox_eet_busWidth.Name = "textBox_eet_busWidth";
            this.textBox_eet_busWidth.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_busWidth.TabIndex = 80;
            this.textBox_eet_busWidth.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "clock frequency in Mhz";
            // 
            // textBox_eet_clockMhz
            // 
            this.textBox_eet_clockMhz.Location = new System.Drawing.Point(9, 119);
            this.textBox_eet_clockMhz.Name = "textBox_eet_clockMhz";
            this.textBox_eet_clockMhz.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_clockMhz.TabIndex = 84;
            this.textBox_eet_clockMhz.TextChanged += new System.EventHandler(this.textBox_eet_clockMhz_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 366);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(193, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Effective Execution Time (clock cycles)";
            // 
            // textBox_eet_resultCycles
            // 
            this.textBox_eet_resultCycles.Location = new System.Drawing.Point(15, 382);
            this.textBox_eet_resultCycles.Name = "textBox_eet_resultCycles";
            this.textBox_eet_resultCycles.Size = new System.Drawing.Size(190, 20);
            this.textBox_eet_resultCycles.TabIndex = 44;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_resultClockCycles);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_clockfreq);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_resultNanoseconds);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_misstime);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_hittime);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBox_eeteasy_hitratio);
            this.groupBox4.Location = new System.Drawing.Point(865, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 338);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EET easy mode";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 89;
            this.label21.Text = "hit ratio";
            // 
            // textBox_eeteasy_hitratio
            // 
            this.textBox_eeteasy_hitratio.Location = new System.Drawing.Point(6, 45);
            this.textBox_eeteasy_hitratio.Name = "textBox_eeteasy_hitratio";
            this.textBox_eeteasy_hitratio.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_hitratio.TabIndex = 100;
            this.textBox_eeteasy_hitratio.TextChanged += new System.EventHandler(this.textBox_eeteasy_hitratio_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 13);
            this.label22.TabIndex = 91;
            this.label22.Text = "hit time (clock cycles)";
            // 
            // textBox_eeteasy_hittime
            // 
            this.textBox_eeteasy_hittime.Location = new System.Drawing.Point(6, 91);
            this.textBox_eeteasy_hittime.Name = "textBox_eeteasy_hittime";
            this.textBox_eeteasy_hittime.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_hittime.TabIndex = 101;
            this.textBox_eeteasy_hittime.TextChanged += new System.EventHandler(this.textBox_eeteasy_hitratio_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 13);
            this.label24.TabIndex = 93;
            this.label24.Text = "miss time (clock cycles)";
            // 
            // textBox_eeteasy_misstime
            // 
            this.textBox_eeteasy_misstime.Location = new System.Drawing.Point(6, 141);
            this.textBox_eeteasy_misstime.Name = "textBox_eeteasy_misstime";
            this.textBox_eeteasy_misstime.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_misstime.TabIndex = 102;
            this.textBox_eeteasy_misstime.TextChanged += new System.EventHandler(this.textBox_eeteasy_hitratio_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 176);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 95;
            this.label25.Text = "clock freq (mhz)";
            // 
            // textBox_eeteasy_clockfreq
            // 
            this.textBox_eeteasy_clockfreq.Location = new System.Drawing.Point(6, 193);
            this.textBox_eeteasy_clockfreq.Name = "textBox_eeteasy_clockfreq";
            this.textBox_eeteasy_clockfreq.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_clockfreq.TabIndex = 103;
            this.textBox_eeteasy_clockfreq.TextChanged += new System.EventHandler(this.textBox_eeteasy_hitratio_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 246);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(193, 13);
            this.label26.TabIndex = 92;
            this.label26.Text = "Effective Execution Time (clock cycles)";
            // 
            // textBox_eeteasy_resultClockCycles
            // 
            this.textBox_eeteasy_resultClockCycles.Location = new System.Drawing.Point(9, 262);
            this.textBox_eeteasy_resultClockCycles.Name = "textBox_eeteasy_resultClockCycles";
            this.textBox_eeteasy_resultClockCycles.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_resultClockCycles.TabIndex = 91;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 285);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 13);
            this.label27.TabIndex = 90;
            this.label27.Text = "Effective Execution Time";
            // 
            // textBox_eeteasy_resultNanoseconds
            // 
            this.textBox_eeteasy_resultNanoseconds.Location = new System.Drawing.Point(9, 301);
            this.textBox_eeteasy_resultNanoseconds.Name = "textBox_eeteasy_resultNanoseconds";
            this.textBox_eeteasy_resultNanoseconds.Size = new System.Drawing.Size(190, 20);
            this.textBox_eeteasy_resultNanoseconds.TabIndex = 89;
            // 
            // textBox_setAssociativity
            // 
            this.textBox_setAssociativity.Location = new System.Drawing.Point(20, 41);
            this.textBox_setAssociativity.Name = "textBox_setAssociativity";
            this.textBox_setAssociativity.Size = new System.Drawing.Size(190, 20);
            this.textBox_setAssociativity.TabIndex = 0;
            this.textBox_setAssociativity.TextChanged += new System.EventHandler(this.comboBox_associativity_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cache Capacity (in bytes)";
            // 
            // textBox_cacheSize
            // 
            this.textBox_cacheSize.Location = new System.Drawing.Point(21, 204);
            this.textBox_cacheSize.Name = "textBox_cacheSize";
            this.textBox_cacheSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_cacheSize.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 227);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(214, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Note* cache capacity = #blocks * blocksize";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 240);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(169, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "only 2 out of 3 boxes must be filled";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 570);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(127, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Cache Capacity (in bytes)";
            // 
            // textBox_resultCacheCapacity
            // 
            this.textBox_resultCacheCapacity.Location = new System.Drawing.Point(22, 586);
            this.textBox_resultCacheCapacity.Name = "textBox_resultCacheCapacity";
            this.textBox_resultCacheCapacity.Size = new System.Drawing.Size(190, 20);
            this.textBox_resultCacheCapacity.TabIndex = 31;
            // 
            // textBox_resultNumBlocks
            // 
            this.textBox_resultNumBlocks.Location = new System.Drawing.Point(21, 504);
            this.textBox_resultNumBlocks.Name = "textBox_resultNumBlocks";
            this.textBox_resultNumBlocks.Size = new System.Drawing.Size(190, 20);
            this.textBox_resultNumBlocks.TabIndex = 28;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 488);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 13);
            this.label31.TabIndex = 29;
            this.label31.Text = "# of blocks";
            // 
            // textBox_resultBlockSize
            // 
            this.textBox_resultBlockSize.Location = new System.Drawing.Point(21, 543);
            this.textBox_resultBlockSize.Name = "textBox_resultBlockSize";
            this.textBox_resultBlockSize.Size = new System.Drawing.Size(190, 20);
            this.textBox_resultBlockSize.TabIndex = 30;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(18, 527);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 13);
            this.label32.TabIndex = 32;
            this.label32.Text = "Block Size";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 475);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 34;
            this.label33.Text = "Computed sizes:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.textBox_sizeInBits);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.textBox_sizeInBytes);
            this.groupBox5.Location = new System.Drawing.Point(279, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 168);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Basic stuff (fill either textbox)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(121, 13);
            this.label34.TabIndex = 36;
            this.label34.Text = "size in bytes (na / k / m)";
            // 
            // textBox_sizeInBytes
            // 
            this.textBox_sizeInBytes.Location = new System.Drawing.Point(8, 35);
            this.textBox_sizeInBytes.Name = "textBox_sizeInBytes";
            this.textBox_sizeInBytes.Size = new System.Drawing.Size(190, 20);
            this.textBox_sizeInBytes.TabIndex = 35;
            this.textBox_sizeInBytes.TextChanged += new System.EventHandler(this.textBox_sizeInBytes_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 58);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 13);
            this.label35.TabIndex = 38;
            this.label35.Text = "size in bits";
            // 
            // textBox_sizeInBits
            // 
            this.textBox_sizeInBits.Location = new System.Drawing.Point(8, 74);
            this.textBox_sizeInBits.Name = "textBox_sizeInBits";
            this.textBox_sizeInBits.Size = new System.Drawing.Size(190, 20);
            this.textBox_sizeInBits.TabIndex = 37;
            this.textBox_sizeInBits.TextChanged += new System.EventHandler(this.textBox_sizeInBits_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(765, 516);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 313);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "log2(size of a page or a pageframe) = page offset in bits\n\n\npage number bits = to" +
    "tal_bits - page_offset_bits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 841);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_memoryCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numBlocks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_blockSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_addressToCalc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_addrTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_addrLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_addrOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_offsetSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_lineSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_tagSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_eet_resultNanoseconds;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_eet_hitRatioPercentage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_eet_refillLine;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_eet_busWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_eet_clockMhz;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_eet_inCacheInstructionExecutionTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_eet_subsequentBurstTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_eet_initialBurstTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_eet_resultCycles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_eeteasy_resultClockCycles;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_eeteasy_clockfreq;
        private System.Windows.Forms.TextBox textBox_eeteasy_resultNanoseconds;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_eeteasy_misstime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_eeteasy_hittime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_eeteasy_hitratio;
        private System.Windows.Forms.TextBox textBox_setAssociativity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_cacheSize;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_resultCacheCapacity;
        private System.Windows.Forms.TextBox textBox_resultNumBlocks;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_resultBlockSize;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox_sizeInBits;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_sizeInBytes;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

