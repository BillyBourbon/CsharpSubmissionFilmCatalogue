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
            ((System.ComponentModel.ISupportInitialize)dgvFilmsView).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmsView
            // 
            dgvFilmsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmsView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvFilmsView.Location = new Point(59, 12);
            dgvFilmsView.Name = "dgvFilmsView";
            dgvFilmsView.RowHeadersWidth = 51;
            dgvFilmsView.Size = new Size(678, 437);
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
            btnPageLeftViewFilms.Location = new Point(3, 12);
            btnPageLeftViewFilms.Name = "btnPageLeftViewFilms";
            btnPageLeftViewFilms.Size = new Size(57, 437);
            btnPageLeftViewFilms.TabIndex = 1;
            btnPageLeftViewFilms.Text = "<";
            btnPageLeftViewFilms.UseVisualStyleBackColor = true;
            btnPageLeftViewFilms.Click += btnPageLeftViewFilms_Click;
            // 
            // btnPageRightViewFilms
            // 
            btnPageRightViewFilms.Location = new Point(733, 12);
            btnPageRightViewFilms.Name = "btnPageRightViewFilms";
            btnPageRightViewFilms.Size = new Size(67, 437);
            btnPageRightViewFilms.TabIndex = 2;
            btnPageRightViewFilms.Text = ">";
            btnPageRightViewFilms.UseVisualStyleBackColor = true;
            btnPageRightViewFilms.Click += btnPageRightViewFilms_Click;
            // 
            // ViewFilms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPageRightViewFilms);
            Controls.Add(btnPageLeftViewFilms);
            Controls.Add(dgvFilmsView);
            Name = "ViewFilms";
            Text = "ViewFilms";
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
    }
}