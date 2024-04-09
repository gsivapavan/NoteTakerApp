namespace NoteTakerApp
{
    partial class NoteTaker
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
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PreviousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            NewNoteButton = new Button();
            SaveButton = new Button();
            NoteTakerAppLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(461, 51);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(327, 27);
            TitleBox.TabIndex = 0;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(461, 109);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(327, 344);
            NoteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(457, 24);
            label1.Name = "label1";
            label1.Size = new Size(327, 21);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(461, 81);
            label2.Name = "label2";
            label2.Size = new Size(327, 25);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PreviousNotes
            // 
            PreviousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNotes.BackgroundColor = Color.White;
            PreviousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNotes.Location = new Point(2, 33);
            PreviousNotes.Name = "PreviousNotes";
            PreviousNotes.RowHeadersWidth = 51;
            PreviousNotes.Size = new Size(453, 298);
            PreviousNotes.TabIndex = 4;
            PreviousNotes.CellDoubleClick += PreviousNotes_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.White;
            LoadButton.Location = new Point(12, 346);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(201, 29);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.Location = new Point(234, 346);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(201, 29);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NewNoteButton
            // 
            NewNoteButton.BackColor = Color.White;
            NewNoteButton.Location = new Point(12, 394);
            NewNoteButton.Name = "NewNoteButton";
            NewNoteButton.Size = new Size(201, 29);
            NewNoteButton.TabIndex = 7;
            NewNoteButton.Text = "New Note";
            NewNoteButton.UseVisualStyleBackColor = false;
            NewNoteButton.Click += NewNoteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.White;
            SaveButton.Location = new Point(234, 394);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(201, 29);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // NoteTakerAppLabel
            // 
            NoteTakerAppLabel.BackColor = Color.LimeGreen;
            NoteTakerAppLabel.Location = new Point(192, 2);
            NoteTakerAppLabel.Name = "NoteTakerAppLabel";
            NoteTakerAppLabel.Size = new Size(259, 25);
            NoteTakerAppLabel.TabIndex = 9;
            NoteTakerAppLabel.Text = "NoteTakerApp";
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(NoteTakerAppLabel);
            Controls.Add(SaveButton);
            Controls.Add(NewNoteButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(PreviousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            Name = "NoteTaker";
            Text = "NoteTaker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private Label label1;
        private Label label2;
        private DataGridView PreviousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button NewNoteButton;
        private Button SaveButton;
        private Label NoteTakerAppLabel;
    }
}
