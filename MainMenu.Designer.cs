namespace CsharpSubmissionFilmCatalogue
{
    partial class MainMenu
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
            gbNav = new GroupBox();
            btnViewFilmDB = new Button();
            btnFindFilm = new Button();
            gbNav.SuspendLayout();
            SuspendLayout();
            // 
            // gbNav
            // 
            gbNav.Controls.Add(btnViewFilmDB);
            gbNav.Controls.Add(btnFindFilm);
            gbNav.Location = new Point(12, 12);
            gbNav.Name = "gbNav";
            gbNav.Size = new Size(776, 87);
            gbNav.TabIndex = 0;
            gbNav.TabStop = false;
            gbNav.Text = "NavGroup";
            // 
            // btnViewFilmDB
            // 
            btnViewFilmDB.Location = new Point(192, 26);
            btnViewFilmDB.Name = "btnViewFilmDB";
            btnViewFilmDB.Size = new Size(121, 49);
            btnViewFilmDB.TabIndex = 1;
            btnViewFilmDB.Text = "View Stored Films";
            btnViewFilmDB.UseVisualStyleBackColor = true;
            btnViewFilmDB.Click += btnViewFilmDB_Click;
            // 
            // btnFindFilm
            // 
            btnFindFilm.Location = new Point(474, 26);
            btnFindFilm.Name = "btnFindFilm";
            btnFindFilm.Size = new Size(121, 49);
            btnFindFilm.TabIndex = 0;
            btnFindFilm.Text = "Find A Film";
            btnFindFilm.UseVisualStyleBackColor = true;
            btnFindFilm.Click += btnFindFilm_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbNav);
            Name = "MainMenu";
            Text = "Form1";
            gbNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbNav;
        private Button btnFindFilm;
        private Button btnFindFilmByActor;
        private Button btnViewFilmDB;
    }
}
