namespace CsharpSubmissionFilmCatalogue
{
    partial class ViewFilms
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
            dgvFilmsView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnPageLeftViewFilms = new Button();
            btnPageRightViewFilms = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFilmsView).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmsView
            // 
            dgvFilmsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmsView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvFilmsView.Location = new Point(56, 61);
            dgvFilmsView.Name = "dgvFilmsView";
            dgvFilmsView.RowHeadersWidth = 51;
            dgvFilmsView.Size = new Size(678, 388);
            dgvFilmsView.TabIndex = 0;
            dgvFilmsView.CellContentClick += dgvFilmsView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Title";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Year Released";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Genre";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Director";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Media Type";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btnPageLeftViewFilms
            // 
            btnPageLeftViewFilms.Location = new Point(3, 61);
            btnPageLeftViewFilms.Name = "btnPageLeftViewFilms";
            btnPageLeftViewFilms.Size = new Size(57, 388);
            btnPageLeftViewFilms.TabIndex = 1;
            btnPageLeftViewFilms.Text = "<";
            btnPageLeftViewFilms.UseVisualStyleBackColor = true;
            btnPageLeftViewFilms.Click += btnPageLeftViewFilms_Click;
            // 
            // btnPageRightViewFilms
            // 
            btnPageRightViewFilms.Location = new Point(733, 61);
            btnPageRightViewFilms.Name = "btnPageRightViewFilms";
            btnPageRightViewFilms.Size = new Size(67, 388);
            btnPageRightViewFilms.TabIndex = 2;
            btnPageRightViewFilms.Text = ">";
            btnPageRightViewFilms.UseVisualStyleBackColor = true;
            btnPageRightViewFilms.Click += btnPageRightViewFilms_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(774, 49);
            label1.TabIndex = 3;
            label1.Text = "Double click a row to view the detailed infomation for a film\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewFilms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnPageRightViewFilms);
            Controls.Add(btnPageLeftViewFilms);
            Controls.Add(dgvFilmsView);
            Name = "ViewFilms";
            Text = "View Stored Films";
            ((System.ComponentModel.ISupportInitialize)dgvFilmsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFilmsView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnPageLeftViewFilms;
        private Button btnPageRightViewFilms;
        private Label label1;
    }
}