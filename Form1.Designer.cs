namespace AstronomicalProcessing
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
            components = new System.ComponentModel.Container();
            listBoxNeutrinos = new ListBox();
            txtBoxNeut = new TextBox();
            btnBubbleSort = new Button();
            btnBinarySearch = new Button();
            lblListBox = new Label();
            lblTextBox = new Label();
            btnEdit = new Button();
            btnMid = new Button();
            btnMode = new Button();
            btnAverge = new Button();
            btnRange = new Button();
            btnSeqSearch = new Button();
            txtBoxCalc = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // listBoxNeutrinos
            // 
            listBoxNeutrinos.FormattingEnabled = true;
            listBoxNeutrinos.ItemHeight = 20;
            listBoxNeutrinos.Location = new Point(12, 32);
            listBoxNeutrinos.Name = "listBoxNeutrinos";
            listBoxNeutrinos.Size = new Size(160, 484);
            listBoxNeutrinos.TabIndex = 0;
            listBoxNeutrinos.SelectedIndexChanged += listBoxNeutrinos_SelectedIndexChanged;
            // 
            // txtBoxNeut
            // 
            txtBoxNeut.Location = new Point(201, 79);
            txtBoxNeut.Name = "txtBoxNeut";
            txtBoxNeut.Size = new Size(142, 27);
            txtBoxNeut.TabIndex = 1;
            toolTip1.SetToolTip(txtBoxNeut, "Text box for functionality");
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(201, 112);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(94, 29);
            btnBubbleSort.TabIndex = 4;
            btnBubbleSort.Text = "Sort";
            toolTip1.SetToolTip(btnBubbleSort, "Button to sort the list using bubble sort algorithm");
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(201, 147);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(94, 29);
            btnBinarySearch.TabIndex = 5;
            btnBinarySearch.Text = "Search";
            toolTip1.SetToolTip(btnBinarySearch, "Button to search the list using binary search algorithm");
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Location = new Point(12, 9);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(73, 20);
            lblListBox.TabIndex = 6;
            lblListBox.Text = "Neutrinos";
            // 
            // lblTextBox
            // 
            lblTextBox.AutoSize = true;
            lblTextBox.Location = new Point(201, 56);
            lblTextBox.Name = "lblTextBox";
            lblTextBox.Size = new Size(114, 20);
            lblTextBox.TabIndex = 7;
            lblTextBox.Text = "Neutrinos Per/H";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(201, 182);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            toolTip1.SetToolTip(btnEdit, "Button to edit a selected value");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnMid
            // 
            btnMid.Location = new Point(201, 427);
            btnMid.Name = "btnMid";
            btnMid.Size = new Size(94, 29);
            btnMid.TabIndex = 9;
            btnMid.Text = "Middle";
            toolTip1.SetToolTip(btnMid, "Button that retrieves the middle value");
            btnMid.UseVisualStyleBackColor = true;
            btnMid.Click += btnMid_Click;
            // 
            // btnMode
            // 
            btnMode.Location = new Point(201, 392);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(94, 29);
            btnMode.TabIndex = 10;
            btnMode.Text = "Mode";
            toolTip1.SetToolTip(btnMode, "Button that calculates the mode");
            btnMode.UseVisualStyleBackColor = true;
            btnMode.Click += btnMode_Click;
            // 
            // btnAverge
            // 
            btnAverge.Location = new Point(201, 287);
            btnAverge.Name = "btnAverge";
            btnAverge.Size = new Size(94, 29);
            btnAverge.TabIndex = 11;
            btnAverge.Text = "Average";
            toolTip1.SetToolTip(btnAverge, "Button that calculates the average of neutrinos");
            btnAverge.UseVisualStyleBackColor = true;
            btnAverge.Click += btnAverge_Click;
            // 
            // btnRange
            // 
            btnRange.Location = new Point(201, 322);
            btnRange.Name = "btnRange";
            btnRange.Size = new Size(94, 29);
            btnRange.TabIndex = 12;
            btnRange.Text = "Range";
            toolTip1.SetToolTip(btnRange, "Button that calculates the range of neutrinos");
            btnRange.UseVisualStyleBackColor = true;
            btnRange.Click += btnRange_Click;
            // 
            // btnSeqSearch
            // 
            btnSeqSearch.Location = new Point(201, 357);
            btnSeqSearch.Name = "btnSeqSearch";
            btnSeqSearch.Size = new Size(94, 29);
            btnSeqSearch.TabIndex = 13;
            btnSeqSearch.Text = "Search";
            toolTip1.SetToolTip(btnSeqSearch, "Button that sequentially searches the list ");
            btnSeqSearch.UseVisualStyleBackColor = true;
            btnSeqSearch.Click += btnSeqSearch_Click;
            // 
            // txtBoxCalc
            // 
            txtBoxCalc.Location = new Point(201, 254);
            txtBoxCalc.Name = "txtBoxCalc";
            txtBoxCalc.Size = new Size(125, 27);
            txtBoxCalc.TabIndex = 14;
            toolTip1.SetToolTip(txtBoxCalc, "Text box for calculations");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 231);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 15;
            label1.Text = "Calculations";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 528);
            Controls.Add(label1);
            Controls.Add(txtBoxCalc);
            Controls.Add(btnSeqSearch);
            Controls.Add(btnRange);
            Controls.Add(btnAverge);
            Controls.Add(btnMode);
            Controls.Add(btnMid);
            Controls.Add(btnEdit);
            Controls.Add(lblTextBox);
            Controls.Add(lblListBox);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnBubbleSort);
            Controls.Add(txtBoxNeut);
            Controls.Add(listBoxNeutrinos);
            Name = "Form1";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxNeutrinos;
        private TextBox txtBoxNeut;
        private Button btnBubbleSort;
        private Button btnBinarySearch;
        private Label lblListBox;
        private Label lblTextBox;
        private Button btnEdit;
        private Button btnMid;
        private Button btnMode;
        private Button btnAverge;
        private Button btnRange;
        private Button btnSeqSearch;
        private TextBox txtBoxCalc;
        private Label label1;
        private ToolTip toolTip1;
    }
}