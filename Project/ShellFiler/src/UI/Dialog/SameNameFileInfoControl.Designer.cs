﻿namespace ShellFiler.UI.Dialog {
    partial class SameNameFileInfoControl {
        /// <summary> 
        /// 必要なデザイナー変数です。
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SameNameFileInfoControl));
            this.labelDest = new System.Windows.Forms.Label();
            this.textBoxSrcPath = new System.Windows.Forms.TextBox();
            this.labelSrcSize = new System.Windows.Forms.Label();
            this.textBoxSrcSize = new System.Windows.Forms.TextBox();
            this.labelSrcTime = new System.Windows.Forms.Label();
            this.textBoxSrcTime = new System.Windows.Forms.TextBox();
            this.labelSrc = new System.Windows.Forms.Label();
            this.textBoxDestPath = new System.Windows.Forms.TextBox();
            this.labelDestSize = new System.Windows.Forms.Label();
            this.textBoxDestSize = new System.Windows.Forms.TextBox();
            this.labelDestTime = new System.Windows.Forms.Label();
            this.textBoxDestTime = new System.Windows.Forms.TextBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelSrcCompare = new System.Windows.Forms.Label();
            this.labelDestCompare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(9, 329);
            this.labelDest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(81, 30);
            this.labelDest.TabIndex = 1;
            this.labelDest.Text = "転送先:";
            // 
            // textBoxSrcPath
            // 
            this.textBoxSrcPath.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSrcPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSrcPath.Location = new System.Drawing.Point(94, 102);
            this.textBoxSrcPath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxSrcPath.Name = "textBoxSrcPath";
            this.textBoxSrcPath.ReadOnly = true;
            this.textBoxSrcPath.Size = new System.Drawing.Size(280, 28);
            this.textBoxSrcPath.TabIndex = 0;
            // 
            // labelSrcSize
            // 
            this.labelSrcSize.AutoSize = true;
            this.labelSrcSize.Location = new System.Drawing.Point(7, 128);
            this.labelSrcSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSrcSize.Name = "labelSrcSize";
            this.labelSrcSize.Size = new System.Drawing.Size(67, 30);
            this.labelSrcSize.TabIndex = 1;
            this.labelSrcSize.Text = "サイズ:";
            // 
            // textBoxSrcSize
            // 
            this.textBoxSrcSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSrcSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSrcSize.Location = new System.Drawing.Point(94, 128);
            this.textBoxSrcSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxSrcSize.Name = "textBoxSrcSize";
            this.textBoxSrcSize.ReadOnly = true;
            this.textBoxSrcSize.Size = new System.Drawing.Size(280, 28);
            this.textBoxSrcSize.TabIndex = 2;
            // 
            // labelSrcTime
            // 
            this.labelSrcTime.AutoSize = true;
            this.labelSrcTime.Location = new System.Drawing.Point(7, 154);
            this.labelSrcTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSrcTime.Name = "labelSrcTime";
            this.labelSrcTime.Size = new System.Drawing.Size(60, 30);
            this.labelSrcTime.TabIndex = 1;
            this.labelSrcTime.Text = "更新:";
            // 
            // textBoxSrcTime
            // 
            this.textBoxSrcTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSrcTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSrcTime.Location = new System.Drawing.Point(94, 154);
            this.textBoxSrcTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxSrcTime.Name = "textBoxSrcTime";
            this.textBoxSrcTime.ReadOnly = true;
            this.textBoxSrcTime.Size = new System.Drawing.Size(280, 28);
            this.textBoxSrcTime.TabIndex = 2;
            // 
            // labelSrc
            // 
            this.labelSrc.AutoSize = true;
            this.labelSrc.Location = new System.Drawing.Point(7, 102);
            this.labelSrc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSrc.Name = "labelSrc";
            this.labelSrc.Size = new System.Drawing.Size(81, 30);
            this.labelSrc.TabIndex = 1;
            this.labelSrc.Text = "転送元:";
            // 
            // textBoxDestPath
            // 
            this.textBoxDestPath.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDestPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDestPath.Location = new System.Drawing.Point(94, 329);
            this.textBoxDestPath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxDestPath.Name = "textBoxDestPath";
            this.textBoxDestPath.ReadOnly = true;
            this.textBoxDestPath.Size = new System.Drawing.Size(280, 28);
            this.textBoxDestPath.TabIndex = 0;
            // 
            // labelDestSize
            // 
            this.labelDestSize.AutoSize = true;
            this.labelDestSize.Location = new System.Drawing.Point(7, 355);
            this.labelDestSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDestSize.Name = "labelDestSize";
            this.labelDestSize.Size = new System.Drawing.Size(67, 30);
            this.labelDestSize.TabIndex = 1;
            this.labelDestSize.Text = "サイズ:";
            // 
            // textBoxDestSize
            // 
            this.textBoxDestSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDestSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDestSize.Location = new System.Drawing.Point(94, 355);
            this.textBoxDestSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxDestSize.Name = "textBoxDestSize";
            this.textBoxDestSize.ReadOnly = true;
            this.textBoxDestSize.Size = new System.Drawing.Size(280, 28);
            this.textBoxDestSize.TabIndex = 2;
            // 
            // labelDestTime
            // 
            this.labelDestTime.AutoSize = true;
            this.labelDestTime.Location = new System.Drawing.Point(7, 382);
            this.labelDestTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDestTime.Name = "labelDestTime";
            this.labelDestTime.Size = new System.Drawing.Size(60, 30);
            this.labelDestTime.TabIndex = 1;
            this.labelDestTime.Text = "更新:";
            // 
            // textBoxDestTime
            // 
            this.textBoxDestTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDestTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDestTime.Location = new System.Drawing.Point(94, 382);
            this.textBoxDestTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxDestTime.Name = "textBoxDestTime";
            this.textBoxDestTime.ReadOnly = true;
            this.textBoxDestTime.Size = new System.Drawing.Size(280, 28);
            this.textBoxDestTime.TabIndex = 2;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.InitialImage = null;
            this.pictureBoxArrow.Location = new System.Drawing.Point(150, 192);
            this.pictureBoxArrow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(84, 28);
            this.pictureBoxArrow.TabIndex = 3;
            this.pictureBoxArrow.TabStop = false;
            // 
            // labelSrcCompare
            // 
            this.labelSrcCompare.AutoSize = true;
            this.labelSrcCompare.Location = new System.Drawing.Point(201, 40);
            this.labelSrcCompare.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSrcCompare.Name = "labelSrcCompare";
            this.labelSrcCompare.Size = new System.Drawing.Size(0, 30);
            this.labelSrcCompare.TabIndex = 1;
            // 
            // labelDestCompare
            // 
            this.labelDestCompare.AutoSize = true;
            this.labelDestCompare.Location = new System.Drawing.Point(201, 275);
            this.labelDestCompare.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDestCompare.Name = "labelDestCompare";
            this.labelDestCompare.Size = new System.Drawing.Size(0, 30);
            this.labelDestCompare.TabIndex = 1;
            // 
            // SameNameFileInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.textBoxDestTime);
            this.Controls.Add(this.textBoxDestSize);
            this.Controls.Add(this.textBoxSrcTime);
            this.Controls.Add(this.labelDestTime);
            this.Controls.Add(this.textBoxSrcSize);
            this.Controls.Add(this.labelDestSize);
            this.Controls.Add(this.labelSrcTime);
            this.Controls.Add(this.labelSrcSize);
            this.Controls.Add(this.labelDestCompare);
            this.Controls.Add(this.labelSrcCompare);
            this.Controls.Add(this.labelSrc);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.textBoxDestPath);
            this.Controls.Add(this.textBoxSrcPath);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SameNameFileInfoControl";
            this.Size = new System.Drawing.Size(385, 427);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SameNameFileInfoControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSrc;
        private System.Windows.Forms.TextBox textBoxSrcPath;
        private System.Windows.Forms.Label labelSrcSize;
        private System.Windows.Forms.TextBox textBoxSrcSize;
        private System.Windows.Forms.Label labelSrcTime;
        private System.Windows.Forms.TextBox textBoxSrcTime;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.TextBox textBoxDestPath;
        private System.Windows.Forms.Label labelDestSize;
        private System.Windows.Forms.TextBox textBoxDestSize;
        private System.Windows.Forms.Label labelDestTime;
        private System.Windows.Forms.TextBox textBoxDestTime;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Label labelSrcCompare;
        private System.Windows.Forms.Label labelDestCompare;
    }
}
