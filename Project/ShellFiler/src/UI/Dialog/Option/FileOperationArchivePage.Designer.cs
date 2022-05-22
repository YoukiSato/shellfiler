﻿namespace ShellFiler.UI.Dialog.Option {
    partial class FileOperationArchivePage {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFix = new System.Windows.Forms.RadioButton();
            this.radioButtonPrev = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxLZipTime = new System.Windows.Forms.CheckBox();
            this.comboBoxLZipEnc = new System.Windows.Forms.ComboBox();
            this.comboBoxLZipAlg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarLZipLevel = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.trackBarL7zLevel = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxL7zTime = new System.Windows.Forms.CheckBox();
            this.trackBarLTgzLevel = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxLTgzTime = new System.Windows.Forms.CheckBox();
            this.trackBarLTBz2Level = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBoxLTbz2Time = new System.Windows.Forms.CheckBox();
            this.trackBarRZipLevel = new System.Windows.Forms.TrackBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBoxRZipTime = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBoxLTarTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLZipLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarL7zLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLTgzLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLTBz2Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRZipLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ファイル一覧の比較";
            // 
            // radioButtonFix
            // 
            this.radioButtonFix.AutoSize = true;
            this.radioButtonFix.Location = new System.Drawing.Point(5, 82);
            this.radioButtonFix.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonFix.Name = "radioButtonFix";
            this.radioButtonFix.Size = new System.Drawing.Size(177, 34);
            this.radioButtonFix.TabIndex = 2;
            this.radioButtonFix.TabStop = true;
            this.radioButtonFix.Text = "初期値を指定(&I)";
            this.radioButtonFix.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrev
            // 
            this.radioButtonPrev.AutoSize = true;
            this.radioButtonPrev.Location = new System.Drawing.Point(5, 44);
            this.radioButtonPrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonPrev.Name = "radioButtonPrev";
            this.radioButtonPrev.Size = new System.Drawing.Size(421, 34);
            this.radioButtonPrev.TabIndex = 1;
            this.radioButtonPrev.TabStop = true;
            this.radioButtonPrev.Text = "直前に指定された設定を初期値として使用(&R)";
            this.radioButtonPrev.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "圧縮方法(&M):";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(184, 122);
            this.comboBoxMethod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(286, 38);
            this.comboBoxMethod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "圧縮形式(&P):";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(642, 122);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(209, 38);
            this.comboBoxType.TabIndex = 6;
            // 
            // checkBoxLZipTime
            // 
            this.checkBoxLZipTime.AutoSize = true;
            this.checkBoxLZipTime.Location = new System.Drawing.Point(88, 222);
            this.checkBoxLZipTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxLZipTime.Name = "checkBoxLZipTime";
            this.checkBoxLZipTime.Size = new System.Drawing.Size(346, 34);
            this.checkBoxLZipTime.TabIndex = 9;
            this.checkBoxLZipTime.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxLZipTime.UseVisualStyleBackColor = true;
            // 
            // comboBoxLZipEnc
            // 
            this.comboBoxLZipEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLZipEnc.FormattingEnabled = true;
            this.comboBoxLZipEnc.Location = new System.Drawing.Point(215, 354);
            this.comboBoxLZipEnc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxLZipEnc.Name = "comboBoxLZipEnc";
            this.comboBoxLZipEnc.Size = new System.Drawing.Size(212, 38);
            this.comboBoxLZipEnc.TabIndex = 17;
            // 
            // comboBoxLZipAlg
            // 
            this.comboBoxLZipAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLZipAlg.FormattingEnabled = true;
            this.comboBoxLZipAlg.Location = new System.Drawing.Point(215, 261);
            this.comboBoxLZipAlg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxLZipAlg.Name = "comboBoxLZipAlg";
            this.comboBoxLZipAlg.Size = new System.Drawing.Size(212, 38);
            this.comboBoxLZipAlg.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "アルゴリズム:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "高圧縮";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "暗号化方式:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "高速";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "圧縮率:";
            // 
            // trackBarLZipLevel
            // 
            this.trackBarLZipLevel.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarLZipLevel.LargeChange = 2;
            this.trackBarLZipLevel.Location = new System.Drawing.Point(252, 308);
            this.trackBarLZipLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trackBarLZipLevel.Maximum = 9;
            this.trackBarLZipLevel.Name = "trackBarLZipLevel";
            this.trackBarLZipLevel.Size = new System.Drawing.Size(114, 80);
            this.trackBarLZipLevel.TabIndex = 14;
            this.trackBarLZipLevel.TickFrequency = 0;
            this.trackBarLZipLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "このコンピュータでZIP作成";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(490, 194);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(243, 30);
            this.label21.TabIndex = 25;
            this.label21.Text = "このコンピュータでtar.gz作成";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "このコンピュータでtar.bz2作成";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(490, 539);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(209, 30);
            this.label20.TabIndex = 42;
            this.label20.Text = "リモートサーバでZIP作成";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(46, 439);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(241, 30);
            this.label27.TabIndex = 18;
            this.label27.Text = "このコンピュータで7-Zip作成";
            // 
            // trackBarL7zLevel
            // 
            this.trackBarL7zLevel.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarL7zLevel.LargeChange = 2;
            this.trackBarL7zLevel.Location = new System.Drawing.Point(252, 495);
            this.trackBarL7zLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trackBarL7zLevel.Maximum = 9;
            this.trackBarL7zLevel.Name = "trackBarL7zLevel";
            this.trackBarL7zLevel.Size = new System.Drawing.Size(114, 80);
            this.trackBarL7zLevel.TabIndex = 23;
            this.trackBarL7zLevel.TickFrequency = 0;
            this.trackBarL7zLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 500);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "圧縮率:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 500);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 30);
            this.label14.TabIndex = 22;
            this.label14.Text = "高速";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 500);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 30);
            this.label15.TabIndex = 24;
            this.label15.Text = "高圧縮";
            // 
            // checkBoxL7zTime
            // 
            this.checkBoxL7zTime.AutoSize = true;
            this.checkBoxL7zTime.Location = new System.Drawing.Point(88, 467);
            this.checkBoxL7zTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxL7zTime.Name = "checkBoxL7zTime";
            this.checkBoxL7zTime.Size = new System.Drawing.Size(346, 34);
            this.checkBoxL7zTime.TabIndex = 20;
            this.checkBoxL7zTime.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxL7zTime.UseVisualStyleBackColor = true;
            // 
            // trackBarLTgzLevel
            // 
            this.trackBarLTgzLevel.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarLTgzLevel.LargeChange = 2;
            this.trackBarLTgzLevel.Location = new System.Drawing.Point(704, 250);
            this.trackBarLTgzLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trackBarLTgzLevel.Maximum = 9;
            this.trackBarLTgzLevel.Name = "trackBarLTgzLevel";
            this.trackBarLTgzLevel.Size = new System.Drawing.Size(114, 80);
            this.trackBarLTgzLevel.TabIndex = 30;
            this.trackBarLTgzLevel.TickFrequency = 0;
            this.trackBarLTgzLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(536, 256);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 30);
            this.label16.TabIndex = 28;
            this.label16.Text = "圧縮率:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(663, 256);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 30);
            this.label17.TabIndex = 29;
            this.label17.Text = "高速";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(810, 256);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 30);
            this.label18.TabIndex = 31;
            this.label18.Text = "高圧縮";
            // 
            // checkBoxLTgzTime
            // 
            this.checkBoxLTgzTime.AutoSize = true;
            this.checkBoxLTgzTime.Location = new System.Drawing.Point(539, 222);
            this.checkBoxLTgzTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxLTgzTime.Name = "checkBoxLTgzTime";
            this.checkBoxLTgzTime.Size = new System.Drawing.Size(346, 34);
            this.checkBoxLTgzTime.TabIndex = 27;
            this.checkBoxLTgzTime.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxLTgzTime.UseVisualStyleBackColor = true;
            // 
            // trackBarLTBz2Level
            // 
            this.trackBarLTBz2Level.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarLTBz2Level.LargeChange = 2;
            this.trackBarLTBz2Level.Location = new System.Drawing.Point(704, 374);
            this.trackBarLTBz2Level.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trackBarLTBz2Level.Maximum = 9;
            this.trackBarLTBz2Level.Name = "trackBarLTBz2Level";
            this.trackBarLTBz2Level.Size = new System.Drawing.Size(114, 80);
            this.trackBarLTBz2Level.TabIndex = 37;
            this.trackBarLTBz2Level.TickFrequency = 0;
            this.trackBarLTBz2Level.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(536, 380);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 30);
            this.label22.TabIndex = 35;
            this.label22.Text = "圧縮率:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(663, 380);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 30);
            this.label24.TabIndex = 36;
            this.label24.Text = "高速";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(810, 380);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 30);
            this.label25.TabIndex = 38;
            this.label25.Text = "高圧縮";
            // 
            // checkBoxLTbz2Time
            // 
            this.checkBoxLTbz2Time.AutoSize = true;
            this.checkBoxLTbz2Time.Location = new System.Drawing.Point(539, 346);
            this.checkBoxLTbz2Time.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxLTbz2Time.Name = "checkBoxLTbz2Time";
            this.checkBoxLTbz2Time.Size = new System.Drawing.Size(346, 34);
            this.checkBoxLTbz2Time.TabIndex = 34;
            this.checkBoxLTbz2Time.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxLTbz2Time.UseVisualStyleBackColor = true;
            // 
            // trackBarRZipLevel
            // 
            this.trackBarRZipLevel.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRZipLevel.LargeChange = 2;
            this.trackBarRZipLevel.Location = new System.Drawing.Point(704, 595);
            this.trackBarRZipLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trackBarRZipLevel.Maximum = 9;
            this.trackBarRZipLevel.Name = "trackBarRZipLevel";
            this.trackBarRZipLevel.Size = new System.Drawing.Size(114, 80);
            this.trackBarRZipLevel.TabIndex = 47;
            this.trackBarRZipLevel.TickFrequency = 0;
            this.trackBarRZipLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(536, 600);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 30);
            this.label26.TabIndex = 45;
            this.label26.Text = "圧縮率:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(663, 600);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 30);
            this.label28.TabIndex = 46;
            this.label28.Text = "高速";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(810, 600);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 30);
            this.label30.TabIndex = 48;
            this.label30.Text = "高圧縮";
            // 
            // checkBoxRZipTime
            // 
            this.checkBoxRZipTime.AutoSize = true;
            this.checkBoxRZipTime.Location = new System.Drawing.Point(539, 567);
            this.checkBoxRZipTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxRZipTime.Name = "checkBoxRZipTime";
            this.checkBoxRZipTime.Size = new System.Drawing.Size(346, 34);
            this.checkBoxRZipTime.TabIndex = 44;
            this.checkBoxRZipTime.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxRZipTime.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(490, 444);
            this.label31.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(218, 30);
            this.label31.TabIndex = 39;
            this.label31.Text = "このコンピュータでtar作成";
            // 
            // checkBoxLTarTime
            // 
            this.checkBoxLTarTime.AutoSize = true;
            this.checkBoxLTarTime.Location = new System.Drawing.Point(539, 472);
            this.checkBoxLTarTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxLTarTime.Name = "checkBoxLTarTime";
            this.checkBoxLTarTime.Size = new System.Drawing.Size(346, 34);
            this.checkBoxLTarTime.TabIndex = 41;
            this.checkBoxLTarTime.Text = "書庫の時刻を最新ファイルに合わせる";
            this.checkBoxLTarTime.UseVisualStyleBackColor = true;
            // 
            // FileOperationArchivePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.checkBoxLTarTime);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.checkBoxRZipTime);
            this.Controls.Add(this.checkBoxLTbz2Time);
            this.Controls.Add(this.checkBoxLTgzTime);
            this.Controls.Add(this.checkBoxL7zTime);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.checkBoxLZipTime);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.comboBoxLZipEnc);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxLZipAlg);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBarRZipLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarLTBz2Level);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarL7zLevel);
            this.Controls.Add(this.trackBarLZipLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFix);
            this.Controls.Add(this.radioButtonPrev);
            this.Controls.Add(this.trackBarLTgzLevel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FileOperationArchivePage";
            this.Size = new System.Drawing.Size(910, 648);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLZipLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarL7zLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLTgzLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLTBz2Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRZipLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonFix;
        private System.Windows.Forms.RadioButton radioButtonPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxLZipTime;
        private System.Windows.Forms.ComboBox comboBoxLZipEnc;
        private System.Windows.Forms.ComboBox comboBoxLZipAlg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarLZipLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TrackBar trackBarL7zLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxL7zTime;
        private System.Windows.Forms.TrackBar trackBarLTgzLevel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBoxLTgzTime;
        private System.Windows.Forms.TrackBar trackBarLTBz2Level;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBoxLTbz2Time;
        private System.Windows.Forms.TrackBar trackBarRZipLevel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBoxRZipTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox checkBoxLTarTime;


    }
}
