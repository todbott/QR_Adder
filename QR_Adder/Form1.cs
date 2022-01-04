using System;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using iTextSharp.text;
using System.Collections.Generic;
using ImageMagick;
using MessagingToolkit.QRCode.Codec;

namespace QR_code_generator_for_PDF
{

    public partial class Form1 : Form
    {

        public string client_name = "general";

        public string text_file_location = "";
        public string path_file_location = AppDomain.CurrentDomain.BaseDirectory + "patterns_path.txt";
        public string QR_holding_location_png = AppDomain.CurrentDomain.BaseDirectory + "qr.png"; // our basic image file
        public string QR_holding_location_tiff = AppDomain.CurrentDomain.BaseDirectory + "qr.tiff"; // used when pasting into a PDF, as it can be made transparent
        public string QR_holding_location_jpg = AppDomain.CurrentDomain.BaseDirectory + "qr.jpeg";  // used when making a standalone image file, as it can be made CMYK and pastable into a PDF

        public string files_string;
        public string paths_string;

        public bool pattern_being_added = false;
        public bool pattern_being_edited = false;
     

        public Form1()
        {
            InitializeComponent();

            if (client_name == "DFS")
            {
                this.Text = this.Text + "f";
            }

            StartupPatterns();
        }




        public void StartupPatterns()
        {
            //if path information exists in the "patterns_path.txt" file, read it and load the patterns
            //if no path information exists (which means that the program has never been run before), ask the user to choose a path and file

            string[] pattern_path = System.IO.File.ReadAllLines(path_file_location);

            if (pattern_path[0] == "")
            {
                ChoosePathsTxt.Filter = "Txt (*.txt)|*.txt";
                ChoosePathsTxt.ShowDialog();

                if (ChoosePathsTxt.FileName != "none")
                {
                    text_file_location = ChoosePathsTxt.FileName;
                    Pattern_path_label.Text = text_file_location;
                    pattern.Enabled = true;
                    delete_pattern.Enabled = true;

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(path_file_location, false))
                    {
                        file.WriteLine(ChoosePathsTxt.FileName);
                    }
                }
            }
            else
            {
                text_file_location = pattern_path[0];
                Pattern_path_label.Text = text_file_location;
                pattern.Enabled = true;
                delete_pattern.Enabled = true;
            }

            string[] lines = System.IO.File.ReadAllLines(text_file_location);
            foreach (string line in lines)
            {
                pattern.Items.Add(line.Split(',')[0]);
            }
        }





        // gets the pdf text using PDFBOX, which is able to get the TOMBO-GAI text that iTextSharp can't get
        public static String PDFText(String PDFFilePath)
        {
            PDDocument doc = PDDocument.load(PDFFilePath);

            PDFTextStripper stripper = new PDFTextStripper();
            return stripper.getText(doc);
        }



        // converts points-to-mm and mm-to-points
        public static string Convert(string type, string value)
        {
            if (type == "to point")
            {
                value = (Math.Round(float.Parse(value)) / 0.352778).ToString();
            }
            if (type == "to mm")
            {
                value = (Math.Round(float.Parse(value)) * 0.352778).ToString();
            }
            return value;
        }


        public static int GetScale(string width)
        {
            List<int> cutoffs = new List<int>{9, 17, 26, 35, 42, 52, 61, 70, 78, 87, 96, 105, 114, 122};
            List<int> scales = new List<int>();
            for (int s = 1; s < 15; s++)
            {
                scales.Add(s);
            }
            float w = float.Parse(width);
            for (int t = 0; t < 15; t++)
            {
                if (w <= cutoffs[t])
                {
                    return scales[t];
                }
            }
            return 15;
        }




        // QR Code Generator part ---------------------------------------------------------
        public static Bitmap Make_QR_Code(string width, List<string> zubans, List<string> timestamps, string QR_holding_location_png, string QR_holding_location_tiff, string QR_holding_location_jpg, bool includes_CV, string pn)
        {
            QRCodeEncoder qce = new QRCodeEncoder
            {
                CharacterSet = "UTF-8",
                QRCodeBackgroundColor = System.Drawing.Color.White,
                QRCodeForegroundColor = System.Drawing.Color.Black,

                QRCodeScale = GetScale(width)
            };

            if (!includes_CV)
            {
                qce.QRCodeVersion = 4;
            }


            string all_timestamps_and_zubans = "";

            for (int tz = 0; tz < zubans.Count; tz++)
            {
                all_timestamps_and_zubans = zubans[tz] + "\n" + timestamps[tz] + "\n" + all_timestamps_and_zubans;
            }

            var result = new Bitmap(qce.Encode(all_timestamps_and_zubans));
            return result;
           
        }




        public static float GetAppropriateDPI(Bitmap map, string user_input_mm_dim)
        {
            // --------------------------------------- mess with the resolution until the image is close to the desired mm dimensions ----------------------------------------
            float answer;
            float dpi = map.VerticalResolution;
            float rw = map.Width;
            // -- based on the current DPI, what will the width in MM be, once it is pasted on a PDF? (this is what "answer" is)
            answer = rw / dpi / .0393701F;

            // -- if the current DPI will make the image BIGGER than the desired width in mm, we loop through and 
            // gradually increase the DPI, until the image becomes the target dimensions
            if (answer > float.Parse(user_input_mm_dim))
            {
                do
                {
                    dpi += .001F;
                    answer = rw / dpi / .0393701F;

                }
                while (answer > float.Parse(user_input_mm_dim));
            }
            else
            // -- if the current DPI will make the image SMALLER than the desired width in mm, we loop through and 
            // gradually decrease the DPI, until the image becomes the target dimensions
            {
                do
                {
                    dpi -= .001F;
                    answer = rw / dpi / .0393701F;

                }
                while (answer < float.Parse(user_input_mm_dim));
            }
            return dpi;
            // --------------------------------------- -------------------------------------------------------------------------- ----------------------------------------
        }




        public static bool Check_for_CV(string[] pdfs)
        {
            bool found_a_CV = false;
            foreach (string pdf in pdfs)
            {
                if (pdf.Split('\\')[pdf.Split('\\').Length - 1].IndexOf("CV") > -1)
                {
                    found_a_CV = true;
                }
            }
            return found_a_CV;
        }







        public static String[] PutCVLast(string[] pdfs)
        {
            var ordered_pdfs = new System.Collections.Generic.List<string>();

            foreach (string pdf in pdfs)
            {
                if (pdf.Split('\\')[pdf.Split('\\').Length - 1].IndexOf("CV") > -1)
                {
                    ordered_pdfs.Insert(0, pdf);
                }
                else
                {
                    ordered_pdfs.Insert(0, pdf);
                }
                    
            }
            string[] op = ordered_pdfs.ToArray();
            return op;
        }







        protected virtual bool IsFileLocked(string file)
        {
            FileStream str = null;

            try
            {
                str = new FileStream(file, FileMode.Open);
            }
            catch (IOException)
            {
                MessageBox.Show(string.Format("{0}は使用中ですので、閉じてからもう一回起動してください。", file.Split('\\')[file.Split('\\').Length - 1]));
                return true;
            }
            finally
            {
                if (str != null)
                    str.Close();
            }
            return false;
        }






        public static Match Try_a_match(string pdf_text, Regex pattern)
        {
            Match m = null;
            string[] characters = pdf_text.Split();
            foreach (string c in characters)
            {
                m = pattern.Match(c);
                if (m.Length > 0)
                {
                    break;
                }
            }
            return m;
        }

        


        public static string Month_to_number(string m)
        {
            int position = 0;

            var months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                position += 1;
                if (month == m)
                {
                    break;
                }
            }
            return position.ToString();
        }





        // HARU Button -- The button that starts the program ---------------------
        private void Button1_Click(object sender, EventArgs e)
        {

            bool includes_CV = false;

            var timestamps = new System.Collections.Generic.List<string>();

            string year = null;
            string month = null;
            string day = null;
            string hour = null;
            string minute = null;

            string message = "";
            string message2 = "";

            var zubans = new System.Collections.Generic.List<string>();

            progress_message.Visible = true;
            pasting_progress.Visible = true;

            string[] pdfs = chosen_pdf_holder.Text.Split(',');
            string[] ordered_PDFS = PutCVLast(pdfs);
            includes_CV = Check_for_CV(pdfs);

            pasting_progress.Maximum = ordered_PDFS.Length;

            for (int p = ordered_PDFS.Length-1; p >= 0; p--)
            {

                pasting_progress.Value = Math.Abs(p - ordered_PDFS.Length);
                string pdf = ordered_PDFS[p];

                if (pdf == "")
                    continue;

                using (var inputPdfStream = new FileStream(pdf, FileMode.Open))
                {
                        
                    PdfReader reader = new PdfReader(inputPdfStream);

                    int page = 0;
                    if (taisho_page.SelectedItem.ToString() == "最終ページ")
                    {
                        page = reader.NumberOfPages;
                    }
                    else
                    {
                        page = 1;
                    }

                    progress_message.Text = "図番・日付情報を取っています";
                    progress_message.Refresh();

                    // this chunk copies the page in question from the original PDF, then saves the file
                    // Then, it reads the file and gets the text out of it (which we use later to get the zuban and hizuke.
                    // Finally, it deletes the file
                    Document document = new Document();
                    string copied_file_path = pdf.Replace(".pdf", "_copied.pdf");
                    PdfCopy copy = new PdfCopy(document, new FileStream(copied_file_path, FileMode.Create));
                    document.Open();
                    copy.AddPage(copy.GetImportedPage(reader, page));
                    document.Close();
                    string pdf_text = PDFText(copied_file_path);
                    File.Delete(copied_file_path);


                    // TRY THE OLD STYLE February 25, 2019 style date pattern--------------------------
                    Match dmatch = null;
                    string word_two_four = "(January|February|March|April|May|June|July|August|September|October|November|December) [0-9]{1,2}, [0-9]{2,4}";
                    dmatch = Regex.Match(pdf_text, word_two_four);
                    if (dmatch.Length > 0)
                    {
                        year = dmatch.Value.Split(',')[1];
                        month = Month_to_number(dmatch.Value.Split(' ')[0]);
                        day = dmatch.Value.Split(' ')[1].Replace(",", ""); 
                    }
                    // ----------------- then try YYYY/MM/DD ------------------
                    if (dmatch.Length <= 0)
                    {
                        Regex four_two_two = new Regex(@"^[0-9]{4}/[0-9]{2}/[0-9]{2}");
                        dmatch = Try_a_match(pdf_text, four_two_two);
                        if (dmatch.Length > 0)
                        {
                            year = dmatch.Value.Split('/')[0];
                            month = dmatch.Value.Split('/')[1];
                            day = dmatch.Value.Split('/')[2];
                        }
                    }
                    // ---------------- then try DD/MM/YYYY and D/MM/YYYY ----------------------
                    if (dmatch.Length <= 0)
                    {
                        Regex two_two_four = new Regex(@"^[0-9]{1,2}/[0-9]{2}/[0-9]{4}");
                        dmatch = Try_a_match(pdf_text, two_two_four);
                        if (dmatch.Length > 0)
                        {
                            year = dmatch.Value.Split('/')[2];
                            month = dmatch.Value.Split('/')[0];
                            day = dmatch.Value.Split('/')[1];
                        }
                    }
                    if (dmatch.Length <= 0)
                    {
                        MessageBox.Show("この PDF の日付の情報が読み取れませんでした。");
                    }





                    Match tmatch = null;
                    Regex two_two_two = new Regex(@"[0-9]{1,2}:[0-9]{2}:[0-9]{2}");
                    tmatch = Try_a_match(pdf_text, two_two_two);
                    if (tmatch.Length > 0)
                    {
                        hour = tmatch.Value.Split(':')[0];
                        minute = tmatch.Value.Split(':')[1];
                    }
                    if (tmatch.Length <= 0)
                    {
                        Regex no_seconds = new Regex(@"[0-9]{1,2}:[0-9]{2}");
                        tmatch = Try_a_match(pdf_text, no_seconds);
                        if (tmatch.Length > 0)
                        {
                            hour = tmatch.Value.Split(':')[0];
                            minute = tmatch.Value.Split(':')[1];
                            //second = "";
                        }
                    }
                    if (tmatch.Length <= 0)
                    {
                        MessageBox.Show("この PDF の時間の情報が読み取れませんでした。");
                    }



                    if (pdf_text.Substring(tmatch.Index).IndexOf("PM") > -1)
                    {
                        hour = (int.Parse(hour) + 12).ToString();
                    }



                    timestamps.Add(year + "/" + month + "/" + day + " " + hour + ":" + minute);
                    zubans.Add(inputPdfStream.Name.Split('\\')[inputPdfStream.Name.Split('\\').Length - 1].Replace(".pdf", "").Replace(".fm", ""));

                    if ((pdf.Split('\\')[pdf.Split('\\').Length - 1].IndexOf("CV") > -1) || includes_CV == false)
                    {

                        progress_message.Text = "QRコードを作成しています";
                        progress_message.Refresh();


                        if (Go.Text == "QRをPDFに追加")
                        {

                            var QR_image = Make_QR_Code(QR_w.Text, zubans, timestamps, QR_holding_location_png, QR_holding_location_tiff, QR_holding_location_jpg, includes_CV, pattern_name.Text);
                            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(0, 0, QR_image.Width - 1, QR_image.Height - 1);
                            Bitmap QR_image_cropped = QR_image.Clone(rectangle, QR_image.PixelFormat);
                            QR_image_cropped.MakeTransparent(System.Drawing.Color.White);
                            QR_image_cropped.Save(QR_holding_location_png, System.Drawing.Imaging.ImageFormat.Png);
                            MagickReadSettings settings = new MagickReadSettings
                            {
                                ColorSpace = ColorSpace.CMYK,
                            };
                            
                            TiffWriteDefines defines = new TiffWriteDefines
                            {
                                Endian = ImageMagick.Endian.LSB // -- PUTS THE BYTE ORDER IN PC ORDER (REQUESTED IMPROVEMENT ON AUGUST 1st 2019)
                            };
                            using (MagickImage tiff_image = new MagickImage(QR_holding_location_png, settings))
                            {
                                tiff_image.Write(QR_holding_location_tiff, defines);
                            }

                            progress_message.Text = "PDFを保存しています";
                            progress_message.Refresh();

                            var inputImageStream = new FileStream(QR_holding_location_tiff, FileMode.Open);

                            var outputPdfStream = StreamName(pdf, client_name);
                            
                            PdfStamper stamper = new PdfStamper(reader, outputPdfStream);
                            PdfContentByte pdfContentByte = stamper.GetOverContent(page);
                            var image = iTextSharp.text.Image.GetInstance(inputImageStream);
                            image.ScaleAbsoluteWidth(float.Parse(QR_w_for_calculation.Text));
                            image.ScaleAbsoluteHeight(float.Parse(QR_h_for_calculation.Text));
                            image.SetAbsolutePosition(float.Parse(X_p_for_calculation.Text), float.Parse(Y_p_for_calculation.Text));
                            pdfContentByte.AddImage(image);
                            stamper.Close();
                            inputImageStream.Close();
                            reader.Close();

                            message = "対象PDFの上に、QRコードが貼られました。";

                            if (client_name == "DFS")
                            {
                                message2 = "元の名前 + '_forPrt.pdf' として、元のところに保存されました。";
                            }
                            else
                            {
                                message2 = "元の名前 + '_stamped.pdf' として、元のところに保存されました。";
                            }
                        }
                        else
                        {

                            var QR_image = Make_QR_Code(QR_w.Text, zubans, timestamps, QR_holding_location_png, QR_holding_location_tiff, QR_holding_location_jpg, includes_CV, pattern_name.Text);
                            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(0, 0, QR_image.Width - 1, QR_image.Height - 1);
                            Bitmap QR_image_cropped = QR_image.Clone(rectangle, QR_image.PixelFormat);

                            float dpi = GetAppropriateDPI(QR_image_cropped, QR_w.Text);
                            QR_image_cropped.SetResolution(dpi, dpi);

                            QR_image_cropped.Save(QR_holding_location_png, System.Drawing.Imaging.ImageFormat.Png);

                            MagickReadSettings image_settings = new MagickReadSettings
                            {
                                ColorSpace = ColorSpace.CMYK,
                            };
                            ImageMagick.Density density = new Density(System.Convert.ToDouble(dpi));
                            using (MagickImage QRimage = new MagickImage(QR_holding_location_png, image_settings))
                            {
                                QRimage.ColorSpace = ColorSpace.CMYK;
                                QRimage.Quality = 100;
                                QRimage.Format = MagickFormat.Jpeg;
                                QRimage.Density = density;
                                QRimage.Write(QR_holding_location_jpg);  
                            }


                            File.Copy(QR_holding_location_jpg, pdf.Replace(".pdf", "_QR_code.jpeg"), true);

                            progress_message.Text = "QRコードを *.jpeg として保存しています";
                            progress_message.Refresh();

                            message = "QRコードは JPEG ファイルとして下記のところに保存されました。";
                            message2 = "元の名前 + '_QR_code.jpeg' として、元のところに保存されました。";
                        }

                        timestamps.Clear();
                        zubans.Clear();
                    }
                }
            }
            progress_message.Visible = false;
            pasting_progress.Visible = false;

            completed_message.Text = message;
            completed_message2.Text = message2;

            pattern.Enabled = false;
            delete_pattern.Enabled = false;

            Go.Enabled = false;
            new_pattern_button.Enabled = false;
            EditPattern.Enabled = false;
            pattern_details_box.Enabled = false;
            chosen_pdf.Text = "--";
            files_string = "";
            chosen_pdf_holder.Text = "";
            paths_string = "";
            choose_pdf_button.Enabled = false;
            clearSelection.Enabled = false;
            continue_button.Visible = true;
        }


        public static FileStream StreamName(string pdf, string client_name)
        {
            if (client_name == "DFS")
            {
                var pdf_name = pdf.Split('\\')[pdf.Split('\\').Length - 1];
                pdf_name = pdf_name.Replace("-", "_");

                string[] pdf_parts = pdf.Split('\\');

                pdf = pdf_parts[0];

                for (var pp = 1; pp < pdf_parts.Length - 1; pp++)
                {
                    pdf = pdf + '\\' + pdf_parts[pp];
                }
                pdf = pdf + '\\' + pdf_name;

                return new FileStream(pdf.Replace(".pdf", "_forPrt.pdf"), FileMode.Create);
            }
            else
            {
                return new FileStream(pdf.Replace(".pdf", "_stamped.pdf"), FileMode.Create);
            }
        }



        private void Choose_pdf_button_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
            openFileDialog1.ShowDialog();

            foreach (String file in openFileDialog1.FileNames)
            {
                files_string = file.Split('\\')[file.Split('\\').Length - 1] + "," + files_string;
                paths_string = file + "," + paths_string;
                if (IsFileLocked(file))
                {
                    files_string = "";
                    paths_string = "";
                    break;
                }
            }

            chosen_pdf.Text = files_string;
            chosen_pdf_holder.Text = paths_string;

            ChoosePatternFile.Enabled = true;
        }





        // this is the button to ACTUALLY REGISTER the new pattern
        private void New_pattern_button_Click(object sender, EventArgs e)
        {

            // This simply writes a new pattern to the END of the patterns.txt text file----------------------------------
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(text_file_location, true))
            {
                if (pattern_being_added == true)
                {

                    // putting the pattern data into patterns.txt.  Format is as follows:

                    // Pattern name,  QRW(p), QRH(p), X(p), Y(p), Page, QRW(mm), QRH(mm), X(mm), Y(mm)
                    //                --- these are for program-        --- these are for display ----

                    string info = pattern_name.Text + "," + Convert("to point", QR_w.Text) + "," + Convert("to point", QR_h.Text) + "," + Convert("to point", X_p.Text) + "," + Convert("to point", Y_p.Text) + "," + taisho_page.SelectedItem.ToString() + "," + QR_w.Text + "," + QR_h.Text + "," + X_p.Text + "," + Y_p.Text;
                    file.WriteLine(info);
                }
            }
            // ------------------------------------------------------------------------------------------------------------

            if (pattern_being_edited == true)
            {
                string tempFile = System.IO.Path.GetTempFileName();

                using (var sr = new StreamReader(text_file_location))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Split(',')[0] != EditingHolder.Text)
                        {
                            sw.WriteLine(line);
                        }
                        else
                        {
                            string info = pattern_name.Text + "," + Convert("to point", QR_w.Text) + "," + Convert("to point", QR_h.Text) + "," + Convert("to point", X_p.Text) + "," + Convert("to point", Y_p.Text) + "," + taisho_page.SelectedItem.ToString() + "," + QR_w.Text + "," + QR_h.Text + "," + X_p.Text + "," + Y_p.Text;
                            sw.WriteLine(info);
                        }
                    }
                }
                File.Delete(text_file_location);
                File.Move(tempFile, text_file_location);

            }




            pattern.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(text_file_location);
            foreach (string line in lines)
            {
                pattern.Items.Add(line.Split(',')[0]);
            }

            if (pattern_being_added == true)
            {
                pattern.SetSelected(pattern.Items.Count - 1, true);
            }
                

            pattern_being_added = false;
            pattern_being_edited = false;

            new_pattern_button.Enabled = true;
            EditPattern.Enabled = true;

            pattern_details_box.Enabled = false;

            EditingHolder.Text = "";
            Go.Enabled = true;

            New_Pattern.Text = "";

        }






        private void Pattern_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((pattern_being_added == false) && (pattern_being_edited == false))
            {
                new_pattern_button.Enabled = true;
                delete_pattern.Enabled = true;
                EditPattern.Enabled = true;
            }

            string[] lines = System.IO.File.ReadAllLines(text_file_location);

            foreach (string line in lines)
            {
                if ((pattern.SelectedItems.Count > 0) && (pattern.SelectedItem.ToString() == line.Split(',')[0]))
                {
                    pattern_name.Text = line.Split(',')[0];

                    QR_w.Text = line.Split(',')[6];
                    QR_w_for_calculation.Text = line.Split(',')[1];

                    QR_h.Text = line.Split(',')[7];
                    QR_h_for_calculation.Text = line.Split(',')[2];


                    X_p.Text = line.Split(',')[8];
                    X_p_for_calculation.Text = line.Split(',')[3];

                    Y_p.Text = line.Split(',')[9];
                    Y_p_for_calculation.Text = line.Split(',')[4];

                    taisho_page.SelectedItem = line.Split(',')[5];
                }
            }
            if ((chosen_pdf.Text != "--") && (pattern_being_added == false && pattern_being_edited == false))
            {
                Go.Enabled = true;
            }
        }






        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        // code is all messed up, but this is the button to ACTIVATE the new pattern fields for editing
        private void New_pattern_button_Click_1(object sender, EventArgs e)
        {

            EditingHolder.Text = "--";
            EditPattern.Enabled = false;
            new_pattern_button.Enabled = false;

            pattern_details_box.Enabled = true;
            pattern_name.Enabled = true;
            pattern_name.Text = "新しい名前を入力してください";
            X_p.Enabled = true;
            Y_p.Enabled = true;
            QR_w.Enabled = true;
            QR_h.Enabled = true;
            taisho_page.Enabled = true;
            New_Pattern.Enabled = true;
            Go.Enabled = false;
            pattern_being_added = true;

            New_Pattern.Text = "パターンを追加します";
        }






        private void Continue_button_Click(object sender, EventArgs e)
        {
            choose_pdf_button.Enabled = true;
            clearSelection.Enabled = true;
            continue_button.Visible = false;
            completed_message.Text = "";
            completed_message2.Text = "";
        }






        private void Delete_pattern_Click(object sender, EventArgs e)
        {
            string tempFile = System.IO.Path.GetTempFileName();

            using (var sr = new StreamReader(text_file_location))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Split(',')[0] != pattern.SelectedItem.ToString())
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(text_file_location);
            File.Move(tempFile, text_file_location);

            pattern.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(text_file_location);
            foreach (string line in lines)
            {
                pattern.Items.Add(line.Split(',')[0]);
            }
        }







        private void Shiboru_button_Click(object sender, EventArgs e)
        {
            var keywords = new System.Collections.Generic.List<string>();
            bool include_this_line = true;

            Control.ControlCollection controls = shiboru_box.Controls;
            foreach (Control c in controls)
            {
                if (c is CheckBox checker && checker.Checked)
                {
                    keywords.Add(c.Text);
                }
            }

            pattern.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(text_file_location);
            foreach (string line in lines)
            {
                include_this_line = true;
                foreach (string k in keywords)
                {
                    if (line.IndexOf(k) < 0)
                    {
                        include_this_line = false;
                    }
                }
                if (include_this_line)
                {
                    pattern.Items.Add(line.Split(',')[0]);
                }

            }
        }





        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in radio_box.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        Go.Text = radio.Text;
                    }
                }
            }
        }






        private void EditPattern_Click(object sender, EventArgs e)
        {
            EditingHolder.Text = pattern.SelectedItem.ToString();
            new_pattern_button.Enabled = false;
            EditPattern.Enabled = false;

            pattern_details_box.Enabled = true;
            pattern_name.Enabled = true;
            X_p.Enabled = true;
            Y_p.Enabled = true;
            QR_w.Enabled = true;
            QR_h.Enabled = true;
            taisho_page.Enabled = true;
            New_Pattern.Enabled = true;
            Go.Enabled = false;
            pattern_being_edited = true;

            New_Pattern.Text = "パターンを上書きします";
        }




        
        private void ClearSelection_Click(object sender, EventArgs e)
        {
            chosen_pdf.Text = "--";
            chosen_pdf_holder.Text = "";
            files_string = "";
            paths_string = "";

            pattern.Enabled = false;
            delete_pattern.Enabled = false;
            ChoosePatternFile.Enabled = false;
        }




        private void ChoosePatternFile_Click(object sender, EventArgs e)
        {
            ChoosePathsTxt.Filter = "Txt (*.txt)|*.txt";
            ChoosePathsTxt.ShowDialog();

            if (ChoosePathsTxt.FileName != "none")
            {
                text_file_location = ChoosePathsTxt.FileName;
                Pattern_path_label.Text = text_file_location;
                pattern.Enabled = true;
                delete_pattern.Enabled = true;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path_file_location, false))
                {
                    file.WriteLine(ChoosePathsTxt.FileName);
                }
            }

            pattern.Items.Clear();

            string[] lines = System.IO.File.ReadAllLines(text_file_location);
            foreach (string line in lines)
            {
                pattern.Items.Add(line.Split(',')[0]);
            }
        }
    }
}

