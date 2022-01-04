namespace QR_code_generator_for_PDF
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Go = new System.Windows.Forms.Button();
            this.pattern = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.choose_pdf_button = new System.Windows.Forms.Button();
            this.chosen_pdf = new System.Windows.Forms.Label();
            this.chosen_pdf_holder = new System.Windows.Forms.Label();
            this.new_pattern_button = new System.Windows.Forms.Button();
            this.pattern_details_box = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.taisho_page = new System.Windows.Forms.ComboBox();
            this.New_Pattern = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pattern_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Y_p = new System.Windows.Forms.TextBox();
            this.QR_w = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QR_h = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.completed_message = new System.Windows.Forms.Label();
            this.completed_message2 = new System.Windows.Forms.Label();
            this.continue_button = new System.Windows.Forms.Button();
            this.delete_pattern = new System.Windows.Forms.Button();
            this.pasting_progress = new System.Windows.Forms.ProgressBar();
            this.progress_message = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.X_p_for_calculation = new System.Windows.Forms.Label();
            this.Y_p_for_calculation = new System.Windows.Forms.Label();
            this.QR_w_for_calculation = new System.Windows.Forms.Label();
            this.QR_h_for_calculation = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radio_box = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.EditPattern = new System.Windows.Forms.Button();
            this.EditingHolder = new System.Windows.Forms.Label();
            this.clearSelection = new System.Windows.Forms.Button();
            this.shiboru_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.shiboru_box = new System.Windows.Forms.GroupBox();
            this.ChoosePatternFile = new System.Windows.Forms.Button();
            this.ChoosePathsTxt = new System.Windows.Forms.OpenFileDialog();
            this.Pattern_path_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PatternFileLabel = new System.Windows.Forms.Label();
            this.pattern_details_box.SuspendLayout();
            this.radio_box.SuspendLayout();
            this.shiboru_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 19);
            this.linkLabel1.TabIndex = 22;
            // 
            // Go
            // 
            this.Go.Enabled = false;
            this.Go.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Go.Location = new System.Drawing.Point(477, 617);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(275, 31);
            this.Go.TabIndex = 8;
            this.Go.Text = "QRをPDFに追加";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pattern
            // 
            this.pattern.Enabled = false;
            this.pattern.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pattern.FormattingEnabled = true;
            this.pattern.ItemHeight = 24;
            this.pattern.Location = new System.Drawing.Point(10, 241);
            this.pattern.Margin = new System.Windows.Forms.Padding(4);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(490, 220);
            this.pattern.TabIndex = 5;
            this.pattern.SelectedIndexChanged += new System.EventHandler(this.Pattern_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // choose_pdf_button
            // 
            this.choose_pdf_button.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choose_pdf_button.Location = new System.Drawing.Point(10, 9);
            this.choose_pdf_button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_pdf_button.Name = "choose_pdf_button";
            this.choose_pdf_button.Size = new System.Drawing.Size(130, 38);
            this.choose_pdf_button.TabIndex = 6;
            this.choose_pdf_button.Text = "PDF選択";
            this.choose_pdf_button.UseVisualStyleBackColor = true;
            this.choose_pdf_button.Click += new System.EventHandler(this.Choose_pdf_button_Click);
            // 
            // chosen_pdf
            // 
            this.chosen_pdf.AutoEllipsis = true;
            this.chosen_pdf.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chosen_pdf.Location = new System.Drawing.Point(212, 8);
            this.chosen_pdf.Name = "chosen_pdf";
            this.chosen_pdf.Size = new System.Drawing.Size(632, 39);
            this.chosen_pdf.TabIndex = 8;
            this.chosen_pdf.Text = "--";
            // 
            // chosen_pdf_holder
            // 
            this.chosen_pdf_holder.AutoSize = true;
            this.chosen_pdf_holder.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chosen_pdf_holder.Location = new System.Drawing.Point(51, 15);
            this.chosen_pdf_holder.Name = "chosen_pdf_holder";
            this.chosen_pdf_holder.Size = new System.Drawing.Size(38, 24);
            this.chosen_pdf_holder.TabIndex = 9;
            this.chosen_pdf_holder.Text = "--";
            this.chosen_pdf_holder.Visible = false;
            // 
            // new_pattern_button
            // 
            this.new_pattern_button.BackColor = System.Drawing.SystemColors.Control;
            this.new_pattern_button.Enabled = false;
            this.new_pattern_button.Location = new System.Drawing.Point(505, 202);
            this.new_pattern_button.Name = "new_pattern_button";
            this.new_pattern_button.Size = new System.Drawing.Size(166, 35);
            this.new_pattern_button.TabIndex = 0;
            this.new_pattern_button.Text = "新規パターン作成";
            this.new_pattern_button.UseVisualStyleBackColor = false;
            this.new_pattern_button.Click += new System.EventHandler(this.New_pattern_button_Click_1);
            // 
            // pattern_details_box
            // 
            this.pattern_details_box.Controls.Add(this.label12);
            this.pattern_details_box.Controls.Add(this.label11);
            this.pattern_details_box.Controls.Add(this.label10);
            this.pattern_details_box.Controls.Add(this.label9);
            this.pattern_details_box.Controls.Add(this.taisho_page);
            this.pattern_details_box.Controls.Add(this.New_Pattern);
            this.pattern_details_box.Controls.Add(this.label7);
            this.pattern_details_box.Controls.Add(this.pattern_name);
            this.pattern_details_box.Controls.Add(this.label8);
            this.pattern_details_box.Controls.Add(this.Y_p);
            this.pattern_details_box.Controls.Add(this.QR_w);
            this.pattern_details_box.Controls.Add(this.label3);
            this.pattern_details_box.Controls.Add(this.X_p);
            this.pattern_details_box.Controls.Add(this.label6);
            this.pattern_details_box.Controls.Add(this.label4);
            this.pattern_details_box.Controls.Add(this.QR_h);
            this.pattern_details_box.Controls.Add(this.label5);
            this.pattern_details_box.Location = new System.Drawing.Point(505, 236);
            this.pattern_details_box.Name = "pattern_details_box";
            this.pattern_details_box.Size = new System.Drawing.Size(339, 233);
            this.pattern_details_box.TabIndex = 21;
            this.pattern_details_box.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(304, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(304, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(304, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(304, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "mm";
            // 
            // taisho_page
            // 
            this.taisho_page.Enabled = false;
            this.taisho_page.FormattingEnabled = true;
            this.taisho_page.Items.AddRange(new object[] {
            "最終ページ",
            "先頭ページ"});
            this.taisho_page.Location = new System.Drawing.Point(6, 205);
            this.taisho_page.Name = "taisho_page";
            this.taisho_page.Size = new System.Drawing.Size(123, 32);
            this.taisho_page.TabIndex = 6;
            // 
            // New_Pattern
            // 
            this.New_Pattern.BackColor = System.Drawing.Color.Gainsboro;
            this.New_Pattern.Enabled = false;
            this.New_Pattern.Font = new System.Drawing.Font("HGSGothicM", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.New_Pattern.Location = new System.Drawing.Point(138, 184);
            this.New_Pattern.Name = "New_Pattern";
            this.New_Pattern.Size = new System.Drawing.Size(192, 43);
            this.New_Pattern.TabIndex = 7;
            this.New_Pattern.UseVisualStyleBackColor = false;
            this.New_Pattern.Click += new System.EventHandler(this.New_pattern_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(7, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "対象ページ";
            // 
            // pattern_name
            // 
            this.pattern_name.Enabled = false;
            this.pattern_name.Location = new System.Drawing.Point(12, 49);
            this.pattern_name.Name = "pattern_name";
            this.pattern_name.Size = new System.Drawing.Size(318, 31);
            this.pattern_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(7, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "パターン名";
            // 
            // Y_p
            // 
            this.Y_p.Enabled = false;
            this.Y_p.Location = new System.Drawing.Point(138, 158);
            this.Y_p.Name = "Y_p";
            this.Y_p.Size = new System.Drawing.Size(164, 31);
            this.Y_p.TabIndex = 5;
            // 
            // QR_w
            // 
            this.QR_w.Enabled = false;
            this.QR_w.Location = new System.Drawing.Point(138, 78);
            this.QR_w.Name = "QR_w";
            this.QR_w.Size = new System.Drawing.Size(164, 31);
            this.QR_w.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "QRコードの幅";
            // 
            // X_p
            // 
            this.X_p.Enabled = false;
            this.X_p.Location = new System.Drawing.Point(138, 133);
            this.X_p.Name = "X_p";
            this.X_p.Size = new System.Drawing.Size(164, 31);
            this.X_p.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(7, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "下から";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "QRコードの高さ";
            // 
            // QR_h
            // 
            this.QR_h.Enabled = false;
            this.QR_h.Location = new System.Drawing.Point(138, 104);
            this.QR_h.Name = "QR_h";
            this.QR_h.Size = new System.Drawing.Size(164, 31);
            this.QR_h.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "左から";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(147, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "対象PDF";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(758, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // completed_message
            // 
            this.completed_message.AutoSize = true;
            this.completed_message.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completed_message.Location = new System.Drawing.Point(12, 437);
            this.completed_message.Name = "completed_message";
            this.completed_message.Size = new System.Drawing.Size(0, 24);
            this.completed_message.TabIndex = 14;
            // 
            // completed_message2
            // 
            this.completed_message2.AutoSize = true;
            this.completed_message2.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.completed_message2.Location = new System.Drawing.Point(12, 453);
            this.completed_message2.Name = "completed_message2";
            this.completed_message2.Size = new System.Drawing.Size(0, 24);
            this.completed_message2.TabIndex = 15;
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(500, 513);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(344, 31);
            this.continue_button.TabIndex = 10;
            this.continue_button.Text = "続けて貼ります";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Visible = false;
            this.continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // delete_pattern
            // 
            this.delete_pattern.BackColor = System.Drawing.Color.OrangeRed;
            this.delete_pattern.Enabled = false;
            this.delete_pattern.Font = new System.Drawing.Font("HGSGothicM", 8F);
            this.delete_pattern.Location = new System.Drawing.Point(10, 476);
            this.delete_pattern.Name = "delete_pattern";
            this.delete_pattern.Size = new System.Drawing.Size(45, 19);
            this.delete_pattern.TabIndex = 18;
            this.delete_pattern.Text = "削除";
            this.delete_pattern.UseVisualStyleBackColor = false;
            this.delete_pattern.Click += new System.EventHandler(this.Delete_pattern_Click);
            // 
            // pasting_progress
            // 
            this.pasting_progress.Location = new System.Drawing.Point(8, 550);
            this.pasting_progress.Name = "pasting_progress";
            this.pasting_progress.RightToLeftLayout = true;
            this.pasting_progress.Size = new System.Drawing.Size(836, 14);
            this.pasting_progress.TabIndex = 23;
            this.pasting_progress.Visible = false;
            // 
            // progress_message
            // 
            this.progress_message.AutoSize = true;
            this.progress_message.Font = new System.Drawing.Font("HGSGothicM", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.progress_message.Location = new System.Drawing.Point(6, 536);
            this.progress_message.Name = "progress_message";
            this.progress_message.Size = new System.Drawing.Size(26, 16);
            this.progress_message.TabIndex = 28;
            this.progress_message.Text = "--";
            this.progress_message.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("HGSGothicM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(12, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(427, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "QRコードを挿入するPDFを選択してください。";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(9, 624);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(485, 18);
            this.label16.TabIndex = 34;
            this.label16.Text = "Copyright © 2019 HOTARU PRINTING CO., LTD. All rights reserved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGSGothicM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "表紙と本文や多言語などファイルが分かれている場合は、全てのファイルを選択してください。";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("HGSGothicM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(12, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(859, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "※複数選択した際は、「CV_」と付けられているファイル名のPDFにQRコードが貼付されます。";
            // 
            // X_p_for_calculation
            // 
            this.X_p_for_calculation.AutoSize = true;
            this.X_p_for_calculation.Location = new System.Drawing.Point(620, 20);
            this.X_p_for_calculation.Name = "X_p_for_calculation";
            this.X_p_for_calculation.Size = new System.Drawing.Size(38, 24);
            this.X_p_for_calculation.TabIndex = 37;
            this.X_p_for_calculation.Text = "--";
            this.X_p_for_calculation.Visible = false;
            // 
            // Y_p_for_calculation
            // 
            this.Y_p_for_calculation.AutoSize = true;
            this.Y_p_for_calculation.Location = new System.Drawing.Point(620, 20);
            this.Y_p_for_calculation.Name = "Y_p_for_calculation";
            this.Y_p_for_calculation.Size = new System.Drawing.Size(38, 24);
            this.Y_p_for_calculation.TabIndex = 38;
            this.Y_p_for_calculation.Text = "--";
            this.Y_p_for_calculation.Visible = false;
            // 
            // QR_w_for_calculation
            // 
            this.QR_w_for_calculation.AutoSize = true;
            this.QR_w_for_calculation.Location = new System.Drawing.Point(620, 15);
            this.QR_w_for_calculation.Name = "QR_w_for_calculation";
            this.QR_w_for_calculation.Size = new System.Drawing.Size(38, 24);
            this.QR_w_for_calculation.TabIndex = 35;
            this.QR_w_for_calculation.Text = "--";
            this.QR_w_for_calculation.Visible = false;
            // 
            // QR_h_for_calculation
            // 
            this.QR_h_for_calculation.AutoSize = true;
            this.QR_h_for_calculation.Location = new System.Drawing.Point(620, 15);
            this.QR_h_for_calculation.Name = "QR_h_for_calculation";
            this.QR_h_for_calculation.Size = new System.Drawing.Size(38, 24);
            this.QR_h_for_calculation.TabIndex = 36;
            this.QR_h_for_calculation.Text = "--";
            this.QR_h_for_calculation.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("HGSGothicM", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(9, 605);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label17.Size = new System.Drawing.Size(488, 26);
            this.label17.TabIndex = 41;
            this.label17.Text = "※QRコードは(株)デンソーウェーブの登録商標です。";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("HGSGothicM", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 21);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "QRをPDFに追加";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("HGSGothicM", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(126, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(229, 21);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.Text = "QR *.jpeg ファイルを作成";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radio_box
            // 
            this.radio_box.Controls.Add(this.radioButton2);
            this.radio_box.Controls.Add(this.radioButton1);
            this.radio_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio_box.Location = new System.Drawing.Point(477, 577);
            this.radio_box.Margin = new System.Windows.Forms.Padding(0);
            this.radio_box.Name = "radio_box";
            this.radio_box.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radio_box.Size = new System.Drawing.Size(275, 37);
            this.radio_box.TabIndex = 44;
            this.radio_box.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("HGSGothicM", 8F);
            this.label18.Location = new System.Drawing.Point(56, 480);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "選択したパターンを削除";
            // 
            // EditPattern
            // 
            this.EditPattern.BackColor = System.Drawing.SystemColors.Control;
            this.EditPattern.Enabled = false;
            this.EditPattern.Font = new System.Drawing.Font("HGSGothicM", 12F);
            this.EditPattern.Location = new System.Drawing.Point(678, 202);
            this.EditPattern.Name = "EditPattern";
            this.EditPattern.Size = new System.Drawing.Size(166, 35);
            this.EditPattern.TabIndex = 46;
            this.EditPattern.Text = "既存パターン編集";
            this.EditPattern.UseVisualStyleBackColor = false;
            this.EditPattern.Click += new System.EventHandler(this.EditPattern_Click);
            // 
            // EditingHolder
            // 
            this.EditingHolder.AutoSize = true;
            this.EditingHolder.Location = new System.Drawing.Point(333, 8);
            this.EditingHolder.Name = "EditingHolder";
            this.EditingHolder.Size = new System.Drawing.Size(0, 24);
            this.EditingHolder.TabIndex = 47;
            this.EditingHolder.Visible = false;
            // 
            // clearSelection
            // 
            this.clearSelection.Font = new System.Drawing.Font("HGSGothicM", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearSelection.Location = new System.Drawing.Point(150, 26);
            this.clearSelection.Name = "clearSelection";
            this.clearSelection.Size = new System.Drawing.Size(56, 21);
            this.clearSelection.TabIndex = 48;
            this.clearSelection.Text = "クリア";
            this.clearSelection.UseVisualStyleBackColor = true;
            this.clearSelection.Click += new System.EventHandler(this.ClearSelection_Click);
            // 
            // shiboru_button
            // 
            this.shiboru_button.Location = new System.Drawing.Point(422, 39);
            this.shiboru_button.Name = "shiboru_button";
            this.shiboru_button.Size = new System.Drawing.Size(57, 26);
            this.shiboru_button.TabIndex = 10;
            this.shiboru_button.Text = "検索";
            this.shiboru_button.UseVisualStyleBackColor = true;
            this.shiboru_button.Click += new System.EventHandler(this.Shiboru_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 28);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "国内";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 28);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "海外";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(127, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 28);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "取";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(127, 44);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 28);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "据";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(241, 21);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(66, 28);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "A1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(241, 44);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 28);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "A2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(294, 21);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 28);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "A3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(294, 44);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(66, 28);
            this.checkBox8.TabIndex = 18;
            this.checkBox8.Text = "A4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(347, 21);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(66, 28);
            this.checkBox9.TabIndex = 19;
            this.checkBox9.Text = "A5";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(347, 44);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(100, 28);
            this.checkBox10.TabIndex = 20;
            this.checkBox10.Text = "Letter";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // shiboru_box
            // 
            this.shiboru_box.Controls.Add(this.checkBox10);
            this.shiboru_box.Controls.Add(this.checkBox9);
            this.shiboru_box.Controls.Add(this.checkBox8);
            this.shiboru_box.Controls.Add(this.checkBox7);
            this.shiboru_box.Controls.Add(this.checkBox6);
            this.shiboru_box.Controls.Add(this.checkBox5);
            this.shiboru_box.Controls.Add(this.checkBox4);
            this.shiboru_box.Controls.Add(this.checkBox3);
            this.shiboru_box.Controls.Add(this.checkBox2);
            this.shiboru_box.Controls.Add(this.checkBox1);
            this.shiboru_box.Controls.Add(this.shiboru_button);
            this.shiboru_box.Location = new System.Drawing.Point(12, 166);
            this.shiboru_box.Name = "shiboru_box";
            this.shiboru_box.Size = new System.Drawing.Size(485, 71);
            this.shiboru_box.TabIndex = 33;
            this.shiboru_box.TabStop = false;
            this.shiboru_box.Text = "パターン選択";
            // 
            // ChoosePatternFile
            // 
            this.ChoosePatternFile.Font = new System.Drawing.Font("HGSGothicM", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChoosePatternFile.Location = new System.Drawing.Point(759, 51);
            this.ChoosePatternFile.Margin = new System.Windows.Forms.Padding(4);
            this.ChoosePatternFile.Name = "ChoosePatternFile";
            this.ChoosePatternFile.Size = new System.Drawing.Size(77, 21);
            this.ChoosePatternFile.TabIndex = 49;
            this.ChoosePatternFile.Text = "変更";
            this.ChoosePatternFile.UseVisualStyleBackColor = true;
            this.ChoosePatternFile.Click += new System.EventHandler(this.ChoosePatternFile_Click);
            // 
            // ChoosePathsTxt
            // 
            this.ChoosePathsTxt.FileName = "none";
            // 
            // Pattern_path_label
            // 
            this.Pattern_path_label.AutoEllipsis = true;
            this.Pattern_path_label.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pattern_path_label.Location = new System.Drawing.Point(150, 51);
            this.Pattern_path_label.Name = "Pattern_path_label";
            this.Pattern_path_label.Size = new System.Drawing.Size(602, 21);
            this.Pattern_path_label.TabIndex = 50;
            this.Pattern_path_label.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HGSGothicM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(150, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(729, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "作業後、選択したパターンファイルは上書きされ、同じところに保存されます。";
            // 
            // PatternFileLabel
            // 
            this.PatternFileLabel.AutoSize = true;
            this.PatternFileLabel.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PatternFileLabel.Location = new System.Drawing.Point(12, 51);
            this.PatternFileLabel.Name = "PatternFileLabel";
            this.PatternFileLabel.Size = new System.Drawing.Size(202, 24);
            this.PatternFileLabel.TabIndex = 52;
            this.PatternFileLabel.Text = "パターンファイル";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 655);
            this.Controls.Add(this.PatternFileLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Pattern_path_label);
            this.Controls.Add(this.ChoosePatternFile);
            this.Controls.Add(this.clearSelection);
            this.Controls.Add(this.EditingHolder);
            this.Controls.Add(this.EditPattern);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.radio_box);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_p_for_calculation);
            this.Controls.Add(this.X_p_for_calculation);
            this.Controls.Add(this.QR_h_for_calculation);
            this.Controls.Add(this.QR_w_for_calculation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.shiboru_box);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.progress_message);
            this.Controls.Add(this.pasting_progress);
            this.Controls.Add(this.delete_pattern);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.completed_message2);
            this.Controls.Add(this.completed_message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pattern_details_box);
            this.Controls.Add(this.new_pattern_button);
            this.Controls.Add(this.chosen_pdf);
            this.Controls.Add(this.choose_pdf_button);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chosen_pdf_holder);
            this.Font = new System.Drawing.Font("HGSGothicM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QR-code generator for PDF v1.9.3";
            this.pattern_details_box.ResumeLayout(false);
            this.pattern_details_box.PerformLayout();
            this.radio_box.ResumeLayout(false);
            this.radio_box.PerformLayout();
            this.shiboru_box.ResumeLayout(false);
            this.shiboru_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.ListBox pattern;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button choose_pdf_button;
        private System.Windows.Forms.Label chosen_pdf;
        private System.Windows.Forms.Label chosen_pdf_holder;
        private System.Windows.Forms.Button new_pattern_button;
        private System.Windows.Forms.GroupBox pattern_details_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Y_p;
        private System.Windows.Forms.TextBox X_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox taisho_page;
        private System.Windows.Forms.Button New_Pattern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pattern_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label completed_message;
        private System.Windows.Forms.Label completed_message2;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.Button delete_pattern;
        private System.Windows.Forms.ProgressBar pasting_progress;
        private System.Windows.Forms.Label progress_message;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label X_p_for_calculation;
        private System.Windows.Forms.Label Y_p_for_calculation;
        private System.Windows.Forms.Label QR_w_for_calculation;
        private System.Windows.Forms.Label QR_h_for_calculation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox QR_w;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QR_h;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox radio_box;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button EditPattern;
        private System.Windows.Forms.Label EditingHolder;
        private System.Windows.Forms.Button clearSelection;
        private System.Windows.Forms.Button shiboru_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.GroupBox shiboru_box;
        private System.Windows.Forms.Button ChoosePatternFile;
        private System.Windows.Forms.OpenFileDialog ChoosePathsTxt;
        private System.Windows.Forms.Label Pattern_path_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PatternFileLabel;
    }
}

