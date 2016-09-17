﻿/*
 *  Copyright © 2010-2016 Thomas R. Lawrence
 * 
 *  GNU General Public License
 * 
 *  This file is part of PhotoMunger
 * 
 *  PhotoMunger is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program. If not, see <http://www.gnu.org/licenses/>.
 * 
*/
namespace AdaptiveImageSizeReducer
{
    partial class GlobalOptionsDialog
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBrightAdjust = new System.Windows.Forms.CheckBox();
            this.globalOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxAutoCrop = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxShrinkFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoCropLeftMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAutoCropTopMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAutoCropRightMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAutoCropBottomMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMinClusterFrac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxWhiteCorrection = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxShrink = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonRotation0 = new System.Windows.Forms.RadioButton();
            this.radioButtonRotation90 = new System.Windows.Forms.RadioButton();
            this.radioButtonRotation180 = new System.Windows.Forms.RadioButton();
            this.radioButtonRotation270 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAutoCropMinMedianBrightness = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxJpegQuality = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxOneBit = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButtonOneBitChannelAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOneBitChannelR = new System.Windows.Forms.RadioButton();
            this.radioButtonOneBitChannelG = new System.Windows.Forms.RadioButton();
            this.radioButtonOneBitChannelB = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxOneBitThreshhold = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButtonOneBitOutputBmp = new System.Windows.Forms.RadioButton();
            this.radioButtonOneBitOutputPng = new System.Windows.Forms.RadioButton();
            this.checkBoxOneBitScaleUp = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBoxStaticSaturation = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxStaticSaturationWhiteThreshhold = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxStaticSaturationBlackThreshhold = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxStaticSaturateExponent = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBoxAutoNormalizeGeometry = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxNormalizeGeometryAspectWidth = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxNormalizeGeometryAspectHeight = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBoxNormalizeGeometryPreviewResizeMethod = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBoxNormalizeGeometryFinalResizeMethod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxUnbias = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUnbiasMaxDegree = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUnbiasMaxChiSq = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.radioButtonJpegEncoderGDI = new System.Windows.Forms.RadioButton();
            this.radioButtonJpegEncoderWPF = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalOptionsBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.checkBoxBrightAdjust, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoCrop, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxShrink, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxJpegQuality, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxOneBit, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxStaticSaturation, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel9, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoNormalizeGeometry, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel10, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel11, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUnbias, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel12, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBoxBrightAdjust
            // 
            this.checkBoxBrightAdjust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxBrightAdjust.AutoSize = true;
            this.checkBoxBrightAdjust.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "BrightAdjust", true));
            this.checkBoxBrightAdjust.Location = new System.Drawing.Point(171, 173);
            this.checkBoxBrightAdjust.Name = "checkBoxBrightAdjust";
            this.checkBoxBrightAdjust.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBrightAdjust.TabIndex = 7;
            this.checkBoxBrightAdjust.UseVisualStyleBackColor = true;
            // 
            // globalOptionsBindingSource
            // 
            this.globalOptionsBindingSource.DataSource = typeof(AdaptiveImageSizeReducer.GlobalOptions);
            // 
            // checkBoxAutoCrop
            // 
            this.checkBoxAutoCrop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAutoCrop.AutoSize = true;
            this.checkBoxAutoCrop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "AutoCrop", true));
            this.checkBoxAutoCrop.Location = new System.Drawing.Point(171, 93);
            this.checkBoxAutoCrop.Name = "checkBoxAutoCrop";
            this.checkBoxAutoCrop.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoCrop.TabIndex = 2;
            this.checkBoxAutoCrop.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.21191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.57619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.2119F));
            this.tableLayoutPanel2.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Location = new System.Drawing.Point(166, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(405, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label19);
            this.flowLayoutPanel7.Controls.Add(this.textBoxShrinkFactor);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(208, 30);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(86, 20);
            this.flowLayoutPanel7.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Factor:";
            // 
            // textBoxShrinkFactor
            // 
            this.textBoxShrinkFactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "ShrinkFactor", true));
            this.textBoxShrinkFactor.Location = new System.Drawing.Point(46, 0);
            this.textBoxShrinkFactor.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxShrinkFactor.Name = "textBoxShrinkFactor";
            this.textBoxShrinkFactor.Size = new System.Drawing.Size(40, 20);
            this.textBoxShrinkFactor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autocrop:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAutoCropLeftMax);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAutoCropTopMax);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAutoCropRightMax);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAutoCropBottomMax);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 90);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 20);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LeftMax:";
            // 
            // textBoxAutoCropLeftMax
            // 
            this.textBoxAutoCropLeftMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAutoCropLeftMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoCropLeftMax", true));
            this.textBoxAutoCropLeftMax.Location = new System.Drawing.Point(51, 0);
            this.textBoxAutoCropLeftMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAutoCropLeftMax.Name = "textBoxAutoCropLeftMax";
            this.textBoxAutoCropLeftMax.Size = new System.Drawing.Size(40, 20);
            this.textBoxAutoCropLeftMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TopMax:";
            // 
            // textBoxAutoCropTopMax
            // 
            this.textBoxAutoCropTopMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAutoCropTopMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoCropTopMax", true));
            this.textBoxAutoCropTopMax.Location = new System.Drawing.Point(143, 0);
            this.textBoxAutoCropTopMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAutoCropTopMax.Name = "textBoxAutoCropTopMax";
            this.textBoxAutoCropTopMax.Size = new System.Drawing.Size(40, 20);
            this.textBoxAutoCropTopMax.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RightMax:";
            // 
            // textBoxAutoCropRightMax
            // 
            this.textBoxAutoCropRightMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAutoCropRightMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoCropRightMax", true));
            this.textBoxAutoCropRightMax.Location = new System.Drawing.Point(241, 0);
            this.textBoxAutoCropRightMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAutoCropRightMax.Name = "textBoxAutoCropRightMax";
            this.textBoxAutoCropRightMax.Size = new System.Drawing.Size(40, 20);
            this.textBoxAutoCropRightMax.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BottomMax:";
            // 
            // textBoxAutoCropBottomMax
            // 
            this.textBoxAutoCropBottomMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAutoCropBottomMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoCropBottomMax", true));
            this.textBoxAutoCropBottomMax.Location = new System.Drawing.Point(347, 0);
            this.textBoxAutoCropBottomMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAutoCropBottomMax.Name = "textBoxAutoCropBottomMax";
            this.textBoxAutoCropBottomMax.Size = new System.Drawing.Size(40, 20);
            this.textBoxAutoCropBottomMax.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bulk Rotation:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Adjust Brightness:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.textBoxMinClusterFrac);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxWhiteCorrection);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(208, 170);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(289, 20);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Minimum Cluster Fraction:";
            // 
            // textBoxMinClusterFrac
            // 
            this.textBoxMinClusterFrac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "BrightAdjustMinClusterFrac", true));
            this.textBoxMinClusterFrac.Location = new System.Drawing.Point(133, 0);
            this.textBoxMinClusterFrac.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMinClusterFrac.Name = "textBoxMinClusterFrac";
            this.textBoxMinClusterFrac.Size = new System.Drawing.Size(40, 20);
            this.textBoxMinClusterFrac.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "White Correction:";
            // 
            // checkBoxWhiteCorrection
            // 
            this.checkBoxWhiteCorrection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxWhiteCorrection.AutoSize = true;
            this.checkBoxWhiteCorrection.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "BrightAdjustWhiteCorrect", true));
            this.checkBoxWhiteCorrection.Location = new System.Drawing.Point(271, 3);
            this.checkBoxWhiteCorrection.Name = "checkBoxWhiteCorrection";
            this.checkBoxWhiteCorrection.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWhiteCorrection.TabIndex = 16;
            this.checkBoxWhiteCorrection.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Shrink:";
            // 
            // checkBoxShrink
            // 
            this.checkBoxShrink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxShrink.AutoSize = true;
            this.checkBoxShrink.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "Shrink", true));
            this.checkBoxShrink.Location = new System.Drawing.Point(171, 33);
            this.checkBoxShrink.Name = "checkBoxShrink";
            this.checkBoxShrink.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShrink.TabIndex = 12;
            this.checkBoxShrink.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonRotation0);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonRotation90);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonRotation180);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonRotation270);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(168, 151);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(198, 17);
            this.flowLayoutPanel4.TabIndex = 10;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // radioButtonRotation0
            // 
            this.radioButtonRotation0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonRotation0.AutoSize = true;
            this.radioButtonRotation0.Location = new System.Drawing.Point(3, 0);
            this.radioButtonRotation0.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonRotation0.Name = "radioButtonRotation0";
            this.radioButtonRotation0.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRotation0.TabIndex = 0;
            this.radioButtonRotation0.TabStop = true;
            this.radioButtonRotation0.Text = "None";
            this.radioButtonRotation0.UseVisualStyleBackColor = true;
            this.radioButtonRotation0.CheckedChanged += new System.EventHandler(this.radioButtonRotation0_CheckedChanged);
            // 
            // radioButtonRotation90
            // 
            this.radioButtonRotation90.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonRotation90.AutoSize = true;
            this.radioButtonRotation90.Location = new System.Drawing.Point(60, 0);
            this.radioButtonRotation90.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonRotation90.Name = "radioButtonRotation90";
            this.radioButtonRotation90.Size = new System.Drawing.Size(37, 17);
            this.radioButtonRotation90.TabIndex = 1;
            this.radioButtonRotation90.TabStop = true;
            this.radioButtonRotation90.Text = "90";
            this.radioButtonRotation90.UseVisualStyleBackColor = true;
            this.radioButtonRotation90.CheckedChanged += new System.EventHandler(this.radioButtonRotation90_CheckedChanged);
            // 
            // radioButtonRotation180
            // 
            this.radioButtonRotation180.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonRotation180.AutoSize = true;
            this.radioButtonRotation180.Location = new System.Drawing.Point(103, 0);
            this.radioButtonRotation180.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonRotation180.Name = "radioButtonRotation180";
            this.radioButtonRotation180.Size = new System.Drawing.Size(43, 17);
            this.radioButtonRotation180.TabIndex = 2;
            this.radioButtonRotation180.TabStop = true;
            this.radioButtonRotation180.Text = "180";
            this.radioButtonRotation180.UseVisualStyleBackColor = true;
            this.radioButtonRotation180.CheckedChanged += new System.EventHandler(this.radioButtonRotation180_CheckedChanged);
            // 
            // radioButtonRotation270
            // 
            this.radioButtonRotation270.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonRotation270.AutoSize = true;
            this.radioButtonRotation270.Location = new System.Drawing.Point(152, 0);
            this.radioButtonRotation270.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonRotation270.Name = "radioButtonRotation270";
            this.radioButtonRotation270.Size = new System.Drawing.Size(43, 17);
            this.radioButtonRotation270.TabIndex = 3;
            this.radioButtonRotation270.TabStop = true;
            this.radioButtonRotation270.Text = "270";
            this.radioButtonRotation270.UseVisualStyleBackColor = true;
            this.radioButtonRotation270.CheckedChanged += new System.EventHandler(this.radioButtonRotation270_CheckedChanged);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.textBoxAutoCropMinMedianBrightness);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(208, 110);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(163, 20);
            this.flowLayoutPanel5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Min Median Brightness:";
            // 
            // textBoxAutoCropMinMedianBrightness
            // 
            this.textBoxAutoCropMinMedianBrightness.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoCropMinMedianBrightness", true));
            this.textBoxAutoCropMinMedianBrightness.Location = new System.Drawing.Point(123, 0);
            this.textBoxAutoCropMinMedianBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAutoCropMinMedianBrightness.Name = "textBoxAutoCropMinMedianBrightness";
            this.textBoxAutoCropMinMedianBrightness.Size = new System.Drawing.Size(40, 20);
            this.textBoxAutoCropMinMedianBrightness.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Jpeg Quality:";
            // 
            // textBoxJpegQuality
            // 
            this.textBoxJpegQuality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxJpegQuality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "JpegQuality", true));
            this.textBoxJpegQuality.Location = new System.Drawing.Point(168, 10);
            this.textBoxJpegQuality.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxJpegQuality.Name = "textBoxJpegQuality";
            this.textBoxJpegQuality.Size = new System.Drawing.Size(40, 20);
            this.textBoxJpegQuality.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Monochrome Bitmap Output:";
            // 
            // checkBoxOneBit
            // 
            this.checkBoxOneBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxOneBit.AutoSize = true;
            this.checkBoxOneBit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "OneBit", true));
            this.checkBoxOneBit.Location = new System.Drawing.Point(171, 213);
            this.checkBoxOneBit.Name = "checkBoxOneBit";
            this.checkBoxOneBit.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOneBit.TabIndex = 17;
            this.checkBoxOneBit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label17);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonOneBitChannelAll);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonOneBitChannelR);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonOneBitChannelG);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonOneBitChannelB);
            this.flowLayoutPanel6.Controls.Add(this.label18);
            this.flowLayoutPanel6.Controls.Add(this.textBoxOneBitThreshhold);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(208, 210);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(343, 20);
            this.flowLayoutPanel6.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Key Channel:";
            // 
            // radioButtonOneBitChannelAll
            // 
            this.radioButtonOneBitChannelAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitChannelAll.AutoSize = true;
            this.radioButtonOneBitChannelAll.Location = new System.Drawing.Point(79, 1);
            this.radioButtonOneBitChannelAll.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonOneBitChannelAll.Name = "radioButtonOneBitChannelAll";
            this.radioButtonOneBitChannelAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonOneBitChannelAll.TabIndex = 7;
            this.radioButtonOneBitChannelAll.TabStop = true;
            this.radioButtonOneBitChannelAll.Text = "All";
            this.radioButtonOneBitChannelAll.UseVisualStyleBackColor = true;
            this.radioButtonOneBitChannelAll.CheckedChanged += new System.EventHandler(this.radioButtonOneBitChannelAll_CheckedChanged);
            // 
            // radioButtonOneBitChannelR
            // 
            this.radioButtonOneBitChannelR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitChannelR.AutoSize = true;
            this.radioButtonOneBitChannelR.Location = new System.Drawing.Point(121, 1);
            this.radioButtonOneBitChannelR.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonOneBitChannelR.Name = "radioButtonOneBitChannelR";
            this.radioButtonOneBitChannelR.Size = new System.Drawing.Size(33, 17);
            this.radioButtonOneBitChannelR.TabIndex = 6;
            this.radioButtonOneBitChannelR.TabStop = true;
            this.radioButtonOneBitChannelR.Text = "R";
            this.radioButtonOneBitChannelR.UseVisualStyleBackColor = true;
            this.radioButtonOneBitChannelR.CheckedChanged += new System.EventHandler(this.radioButtonOneBitChannelR_CheckedChanged);
            // 
            // radioButtonOneBitChannelG
            // 
            this.radioButtonOneBitChannelG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitChannelG.AutoSize = true;
            this.radioButtonOneBitChannelG.Location = new System.Drawing.Point(160, 1);
            this.radioButtonOneBitChannelG.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonOneBitChannelG.Name = "radioButtonOneBitChannelG";
            this.radioButtonOneBitChannelG.Size = new System.Drawing.Size(33, 17);
            this.radioButtonOneBitChannelG.TabIndex = 5;
            this.radioButtonOneBitChannelG.TabStop = true;
            this.radioButtonOneBitChannelG.Text = "G";
            this.radioButtonOneBitChannelG.UseVisualStyleBackColor = true;
            this.radioButtonOneBitChannelG.CheckedChanged += new System.EventHandler(this.radioButtonOneBitChannelG_CheckedChanged);
            // 
            // radioButtonOneBitChannelB
            // 
            this.radioButtonOneBitChannelB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitChannelB.AutoSize = true;
            this.radioButtonOneBitChannelB.Location = new System.Drawing.Point(199, 1);
            this.radioButtonOneBitChannelB.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonOneBitChannelB.Name = "radioButtonOneBitChannelB";
            this.radioButtonOneBitChannelB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonOneBitChannelB.TabIndex = 4;
            this.radioButtonOneBitChannelB.TabStop = true;
            this.radioButtonOneBitChannelB.Text = "B";
            this.radioButtonOneBitChannelB.UseVisualStyleBackColor = true;
            this.radioButtonOneBitChannelB.CheckedChanged += new System.EventHandler(this.radioButtonOneBitChannelB_CheckedChanged);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Threshhold:";
            // 
            // textBoxOneBitThreshhold
            // 
            this.textBoxOneBitThreshhold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOneBitThreshhold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "OneBitThreshhold", true));
            this.textBoxOneBitThreshhold.Location = new System.Drawing.Point(303, 0);
            this.textBoxOneBitThreshhold.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxOneBitThreshhold.Name = "textBoxOneBitThreshhold";
            this.textBoxOneBitThreshhold.Size = new System.Drawing.Size(40, 20);
            this.textBoxOneBitThreshhold.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.label20);
            this.flowLayoutPanel8.Controls.Add(this.radioButtonOneBitOutputBmp);
            this.flowLayoutPanel8.Controls.Add(this.radioButtonOneBitOutputPng);
            this.flowLayoutPanel8.Controls.Add(this.checkBoxOneBitScaleUp);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(208, 230);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(345, 20);
            this.flowLayoutPanel8.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Output Format:";
            // 
            // radioButtonOneBitOutputBmp
            // 
            this.radioButtonOneBitOutputBmp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitOutputBmp.AutoSize = true;
            this.radioButtonOneBitOutputBmp.Location = new System.Drawing.Point(86, 3);
            this.radioButtonOneBitOutputBmp.Name = "radioButtonOneBitOutputBmp";
            this.radioButtonOneBitOutputBmp.Size = new System.Drawing.Size(46, 17);
            this.radioButtonOneBitOutputBmp.TabIndex = 1;
            this.radioButtonOneBitOutputBmp.TabStop = true;
            this.radioButtonOneBitOutputBmp.Text = "Bmp";
            this.radioButtonOneBitOutputBmp.UseVisualStyleBackColor = true;
            this.radioButtonOneBitOutputBmp.CheckedChanged += new System.EventHandler(this.radioButtonOneBitOutputBmp_CheckedChanged);
            // 
            // radioButtonOneBitOutputPng
            // 
            this.radioButtonOneBitOutputPng.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonOneBitOutputPng.AutoSize = true;
            this.radioButtonOneBitOutputPng.Location = new System.Drawing.Point(138, 3);
            this.radioButtonOneBitOutputPng.Name = "radioButtonOneBitOutputPng";
            this.radioButtonOneBitOutputPng.Size = new System.Drawing.Size(44, 17);
            this.radioButtonOneBitOutputPng.TabIndex = 2;
            this.radioButtonOneBitOutputPng.TabStop = true;
            this.radioButtonOneBitOutputPng.Text = "Png";
            this.radioButtonOneBitOutputPng.UseVisualStyleBackColor = true;
            this.radioButtonOneBitOutputPng.CheckedChanged += new System.EventHandler(this.radioButtonOneBitOutputPng_CheckedChanged);
            // 
            // checkBoxOneBitScaleUp
            // 
            this.checkBoxOneBitScaleUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxOneBitScaleUp.AutoSize = true;
            this.checkBoxOneBitScaleUp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "OneBitScaleUp", true));
            this.checkBoxOneBitScaleUp.Location = new System.Drawing.Point(188, 3);
            this.checkBoxOneBitScaleUp.Name = "checkBoxOneBitScaleUp";
            this.checkBoxOneBitScaleUp.Size = new System.Drawing.Size(154, 17);
            this.checkBoxOneBitScaleUp.TabIndex = 3;
            this.checkBoxOneBitScaleUp.Text = "Scale 2x Before Quantizing";
            this.checkBoxOneBitScaleUp.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Static Saturation:";
            // 
            // checkBoxStaticSaturation
            // 
            this.checkBoxStaticSaturation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxStaticSaturation.AutoSize = true;
            this.checkBoxStaticSaturation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "StaticSaturate", true));
            this.checkBoxStaticSaturation.Location = new System.Drawing.Point(171, 193);
            this.checkBoxStaticSaturation.Name = "checkBoxStaticSaturation";
            this.checkBoxStaticSaturation.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStaticSaturation.TabIndex = 17;
            this.checkBoxStaticSaturation.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.label22);
            this.flowLayoutPanel9.Controls.Add(this.textBoxStaticSaturationWhiteThreshhold);
            this.flowLayoutPanel9.Controls.Add(this.label23);
            this.flowLayoutPanel9.Controls.Add(this.textBoxStaticSaturationBlackThreshhold);
            this.flowLayoutPanel9.Controls.Add(this.label24);
            this.flowLayoutPanel9.Controls.Add(this.textBoxStaticSaturateExponent);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(208, 190);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(380, 20);
            this.flowLayoutPanel9.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "White Threshhold:";
            // 
            // textBoxStaticSaturationWhiteThreshhold
            // 
            this.textBoxStaticSaturationWhiteThreshhold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "StaticSaturateWhiteThreshhold", true));
            this.textBoxStaticSaturationWhiteThreshhold.Location = new System.Drawing.Point(100, 0);
            this.textBoxStaticSaturationWhiteThreshhold.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStaticSaturationWhiteThreshhold.Name = "textBoxStaticSaturationWhiteThreshhold";
            this.textBoxStaticSaturationWhiteThreshhold.Size = new System.Drawing.Size(40, 20);
            this.textBoxStaticSaturationWhiteThreshhold.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(143, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Black Threshhold:";
            // 
            // textBoxStaticSaturationBlackThreshhold
            // 
            this.textBoxStaticSaturationBlackThreshhold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "StaticSaturateBlackThreshhold", true));
            this.textBoxStaticSaturationBlackThreshhold.Location = new System.Drawing.Point(239, 0);
            this.textBoxStaticSaturationBlackThreshhold.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStaticSaturationBlackThreshhold.Name = "textBoxStaticSaturationBlackThreshhold";
            this.textBoxStaticSaturationBlackThreshhold.Size = new System.Drawing.Size(40, 20);
            this.textBoxStaticSaturationBlackThreshhold.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(282, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Exponent:";
            // 
            // textBoxStaticSaturateExponent
            // 
            this.textBoxStaticSaturateExponent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "StaticSaturateExponent", true));
            this.textBoxStaticSaturateExponent.Location = new System.Drawing.Point(340, 0);
            this.textBoxStaticSaturateExponent.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStaticSaturateExponent.Name = "textBoxStaticSaturateExponent";
            this.textBoxStaticSaturateExponent.Size = new System.Drawing.Size(40, 20);
            this.textBoxStaticSaturateExponent.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(142, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Auto-normalize Geometry:";
            // 
            // checkBoxAutoNormalizeGeometry
            // 
            this.checkBoxAutoNormalizeGeometry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAutoNormalizeGeometry.AutoSize = true;
            this.checkBoxAutoNormalizeGeometry.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.globalOptionsBindingSource, "EnableAutoNormalizeGeometry", true));
            this.checkBoxAutoNormalizeGeometry.Location = new System.Drawing.Point(171, 53);
            this.checkBoxAutoNormalizeGeometry.Name = "checkBoxAutoNormalizeGeometry";
            this.checkBoxAutoNormalizeGeometry.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoNormalizeGeometry.TabIndex = 2;
            this.checkBoxAutoNormalizeGeometry.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.Controls.Add(this.label29);
            this.flowLayoutPanel10.Controls.Add(this.label26);
            this.flowLayoutPanel10.Controls.Add(this.textBoxNormalizeGeometryAspectWidth);
            this.flowLayoutPanel10.Controls.Add(this.label27);
            this.flowLayoutPanel10.Controls.Add(this.textBoxNormalizeGeometryAspectHeight);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(208, 50);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(269, 20);
            this.flowLayoutPanel10.TabIndex = 3;
            this.flowLayoutPanel10.WrapContents = false;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 3);
            this.label29.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Force Aspect Ratio:";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(107, 3);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Width:";
            // 
            // textBoxNormalizeGeometryAspectWidth
            // 
            this.textBoxNormalizeGeometryAspectWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNormalizeGeometryAspectWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoNormalizeGeometryAspectWidthAsString", true));
            this.textBoxNormalizeGeometryAspectWidth.Location = new System.Drawing.Point(145, 0);
            this.textBoxNormalizeGeometryAspectWidth.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNormalizeGeometryAspectWidth.Name = "textBoxNormalizeGeometryAspectWidth";
            this.textBoxNormalizeGeometryAspectWidth.Size = new System.Drawing.Size(40, 20);
            this.textBoxNormalizeGeometryAspectWidth.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(188, 3);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Height:";
            // 
            // textBoxNormalizeGeometryAspectHeight
            // 
            this.textBoxNormalizeGeometryAspectHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNormalizeGeometryAspectHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "AutoNormalizeGeometryAspectHeightAsString", true));
            this.textBoxNormalizeGeometryAspectHeight.Location = new System.Drawing.Point(229, 0);
            this.textBoxNormalizeGeometryAspectHeight.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNormalizeGeometryAspectHeight.Name = "textBoxNormalizeGeometryAspectHeight";
            this.textBoxNormalizeGeometryAspectHeight.Size = new System.Drawing.Size(40, 20);
            this.textBoxNormalizeGeometryAspectHeight.TabIndex = 7;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.Controls.Add(this.label28);
            this.flowLayoutPanel11.Controls.Add(this.label30);
            this.flowLayoutPanel11.Controls.Add(this.comboBoxNormalizeGeometryPreviewResizeMethod);
            this.flowLayoutPanel11.Controls.Add(this.label31);
            this.flowLayoutPanel11.Controls.Add(this.comboBoxNormalizeGeometryFinalResizeMethod);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(208, 70);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(330, 20);
            this.flowLayoutPanel11.TabIndex = 3;
            this.flowLayoutPanel11.WrapContents = false;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 4);
            this.label28.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Resize Method:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(87, 4);
            this.label30.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Preview:";
            // 
            // comboBoxNormalizeGeometryPreviewResizeMethod
            // 
            this.comboBoxNormalizeGeometryPreviewResizeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNormalizeGeometryPreviewResizeMethod.DropDownWidth = 120;
            this.comboBoxNormalizeGeometryPreviewResizeMethod.FormattingEnabled = true;
            this.comboBoxNormalizeGeometryPreviewResizeMethod.Items.AddRange(new object[] {
            "Bicubic",
            "Bilinear",
            "Nearest Neighbor"});
            this.comboBoxNormalizeGeometryPreviewResizeMethod.Location = new System.Drawing.Point(135, 0);
            this.comboBoxNormalizeGeometryPreviewResizeMethod.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxNormalizeGeometryPreviewResizeMethod.Name = "comboBoxNormalizeGeometryPreviewResizeMethod";
            this.comboBoxNormalizeGeometryPreviewResizeMethod.Size = new System.Drawing.Size(80, 21);
            this.comboBoxNormalizeGeometryPreviewResizeMethod.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(218, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 5;
            this.label31.Text = "Final:";
            // 
            // comboBoxNormalizeGeometryFinalResizeMethod
            // 
            this.comboBoxNormalizeGeometryFinalResizeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNormalizeGeometryFinalResizeMethod.DropDownWidth = 120;
            this.comboBoxNormalizeGeometryFinalResizeMethod.FormattingEnabled = true;
            this.comboBoxNormalizeGeometryFinalResizeMethod.Items.AddRange(new object[] {
            "Bicubic",
            "Bilinear",
            "Nearest Neighbor"});
            this.comboBoxNormalizeGeometryFinalResizeMethod.Location = new System.Drawing.Point(250, 0);
            this.comboBoxNormalizeGeometryFinalResizeMethod.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxNormalizeGeometryFinalResizeMethod.Name = "comboBoxNormalizeGeometryFinalResizeMethod";
            this.comboBoxNormalizeGeometryFinalResizeMethod.Size = new System.Drawing.Size(80, 21);
            this.comboBoxNormalizeGeometryFinalResizeMethod.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Polynomial Unbias:";
            // 
            // checkBoxUnbias
            // 
            this.checkBoxUnbias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUnbias.AutoSize = true;
            this.checkBoxUnbias.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.globalOptionsBindingSource, "Unbias", true));
            this.checkBoxUnbias.Location = new System.Drawing.Point(171, 133);
            this.checkBoxUnbias.Name = "checkBoxUnbias";
            this.checkBoxUnbias.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUnbias.TabIndex = 0;
            this.checkBoxUnbias.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label14);
            this.flowLayoutPanel3.Controls.Add(this.textBoxUnbiasMaxDegree);
            this.flowLayoutPanel3.Controls.Add(this.label15);
            this.flowLayoutPanel3.Controls.Add(this.textBoxUnbiasMaxChiSq);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(208, 130);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(241, 20);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Max Degree:";
            // 
            // textBoxUnbiasMaxDegree
            // 
            this.textBoxUnbiasMaxDegree.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "UnbiasMaxDegree", true));
            this.textBoxUnbiasMaxDegree.Location = new System.Drawing.Point(74, 0);
            this.textBoxUnbiasMaxDegree.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUnbiasMaxDegree.Name = "textBoxUnbiasMaxDegree";
            this.textBoxUnbiasMaxDegree.Size = new System.Drawing.Size(40, 20);
            this.textBoxUnbiasMaxDegree.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(117, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Max ChiSq:";
            // 
            // textBoxUnbiasMaxChiSq
            // 
            this.textBoxUnbiasMaxChiSq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalOptionsBindingSource, "UnbiasMaxChisq", true));
            this.textBoxUnbiasMaxChiSq.Location = new System.Drawing.Point(181, 0);
            this.textBoxUnbiasMaxChiSq.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUnbiasMaxChiSq.Name = "textBoxUnbiasMaxChiSq";
            this.textBoxUnbiasMaxChiSq.Size = new System.Drawing.Size(60, 20);
            this.textBoxUnbiasMaxChiSq.TabIndex = 16;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.Controls.Add(this.label33);
            this.flowLayoutPanel12.Controls.Add(this.radioButtonJpegEncoderGDI);
            this.flowLayoutPanel12.Controls.Add(this.radioButtonJpegEncoderWPF);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(208, 11);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(303, 17);
            this.flowLayoutPanel12.TabIndex = 10;
            this.flowLayoutPanel12.WrapContents = false;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 2);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 13);
            this.label33.TabIndex = 13;
            this.label33.Text = "Encoder:";
            // 
            // radioButtonJpegEncoderGDI
            // 
            this.radioButtonJpegEncoderGDI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonJpegEncoderGDI.AutoSize = true;
            this.radioButtonJpegEncoderGDI.Location = new System.Drawing.Point(59, 0);
            this.radioButtonJpegEncoderGDI.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonJpegEncoderGDI.Name = "radioButtonJpegEncoderGDI";
            this.radioButtonJpegEncoderGDI.Size = new System.Drawing.Size(50, 17);
            this.radioButtonJpegEncoderGDI.TabIndex = 0;
            this.radioButtonJpegEncoderGDI.TabStop = true;
            this.radioButtonJpegEncoderGDI.Text = "GDI+";
            this.radioButtonJpegEncoderGDI.UseVisualStyleBackColor = true;
            this.radioButtonJpegEncoderGDI.CheckedChanged += new System.EventHandler(this.radioButtonJpegEncoderGDI_CheckedChanged);
            // 
            // radioButtonJpegEncoderWPF
            // 
            this.radioButtonJpegEncoderWPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonJpegEncoderWPF.AutoSize = true;
            this.radioButtonJpegEncoderWPF.Location = new System.Drawing.Point(115, 0);
            this.radioButtonJpegEncoderWPF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioButtonJpegEncoderWPF.Name = "radioButtonJpegEncoderWPF";
            this.radioButtonJpegEncoderWPF.Size = new System.Drawing.Size(185, 17);
            this.radioButtonJpegEncoderWPF.TabIndex = 1;
            this.radioButtonJpegEncoderWPF.TabStop = true;
            this.radioButtonJpegEncoderWPF.Text = "WPF (better for high-color images)";
            this.radioButtonJpegEncoderWPF.UseVisualStyleBackColor = true;
            this.radioButtonJpegEncoderWPF.CheckedChanged += new System.EventHandler(this.radioButtonJpegEncoderWPF_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(598, 33);
            this.pictureBox.Name = "pictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox, 11);
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(658, 13);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Version";
            // 
            // GlobalOptionsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(703, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalOptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Options";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalOptionsBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAutoCrop;
        private System.Windows.Forms.BindingSource globalOptionsBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoCropLeftMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAutoCropTopMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAutoCropRightMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAutoCropBottomMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxBrightAdjust;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMinClusterFrac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxWhiteCorrection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxUnbias;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUnbiasMaxDegree;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUnbiasMaxChiSq;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonRotation0;
        private System.Windows.Forms.RadioButton radioButtonRotation90;
        private System.Windows.Forms.RadioButton radioButtonRotation180;
        private System.Windows.Forms.RadioButton radioButtonRotation270;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxShrink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAutoCropMinMedianBrightness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxJpegQuality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxOneBit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxOneBitThreshhold;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxShrinkFactor;
        private System.Windows.Forms.RadioButton radioButtonOneBitChannelAll;
        private System.Windows.Forms.RadioButton radioButtonOneBitChannelR;
        private System.Windows.Forms.RadioButton radioButtonOneBitChannelG;
        private System.Windows.Forms.RadioButton radioButtonOneBitChannelB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButtonOneBitOutputBmp;
        private System.Windows.Forms.RadioButton radioButtonOneBitOutputPng;
        private System.Windows.Forms.CheckBox checkBoxOneBitScaleUp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBoxStaticSaturation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxStaticSaturationWhiteThreshhold;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxStaticSaturationBlackThreshhold;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxStaticSaturateExponent;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBoxAutoNormalizeGeometry;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxNormalizeGeometryAspectWidth;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxNormalizeGeometryAspectHeight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBoxNormalizeGeometryPreviewResizeMethod;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBoxNormalizeGeometryFinalResizeMethod;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton radioButtonJpegEncoderGDI;
        private System.Windows.Forms.RadioButton radioButtonJpegEncoderWPF;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelVersion;
    }
}