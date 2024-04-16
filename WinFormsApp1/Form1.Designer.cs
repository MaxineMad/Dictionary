namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            search = new Button();
            tb = new TextBox();
            searchstick = new ComboBox();
            tb1 = new TextBox();
            tb2 = new TextBox();
            close = new Button();
            SuspendLayout();
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(594, 24);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 0;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // tb
            // 
            tb.Location = new Point(12, 76);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.ScrollBars = ScrollBars.Vertical;
            tb.Size = new Size(380, 362);
            tb.TabIndex = 1;
            // 
            // searchstick
            // 
            searchstick.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchstick.AutoCompleteSource = AutoCompleteSource.ListItems;
            searchstick.FormattingEnabled = true;
            searchstick.Location = new Point(195, 25);
            searchstick.MaxDropDownItems = 5;
            searchstick.Name = "searchstick";
            searchstick.Size = new Size(393, 28);
            searchstick.TabIndex = 2;
            searchstick.SelectedValueChanged += searchstick_SelectedValueChanged;
            // 
            // tb1
            // 
            tb1.Location = new Point(398, 310);
            tb1.Multiline = true;
            tb1.Name = "tb1";
            tb1.Size = new Size(390, 128);
            tb1.TabIndex = 3;
            // 
            // tb2
            // 
            tb2.Location = new Point(398, 76);
            tb2.Multiline = true;
            tb2.Name = "tb2";
            tb2.ScrollBars = ScrollBars.Vertical;
            tb2.Size = new Size(390, 228);
            tb2.TabIndex = 4;
            // 
            // close
            // 
            close.Location = new Point(95, 24);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 5;
            close.Text = "QUIT";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Form1
            // 
            AcceptButton = search;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(searchstick);
            Controls.Add(tb);
            Controls.Add(search);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search;
        private TextBox tb;
        private ComboBox searchstick;
        private TextBox tb1;
        private TextBox tb2;
        private Button close;
    }
}
