namespace MyMediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoviePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Movies = new System.Windows.Forms.ListBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePlayer
            // 
            this.MoviePlayer.Enabled = true;
            this.MoviePlayer.Location = new System.Drawing.Point(323, 12);
            this.MoviePlayer.Name = "MoviePlayer";
            this.MoviePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MoviePlayer.OcxState")));
            this.MoviePlayer.Size = new System.Drawing.Size(994, 537);
            this.MoviePlayer.TabIndex = 0;
            // 
            // Movies
            // 
            this.Movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Movies.FormattingEnabled = true;
            this.Movies.ItemHeight = 25;
            this.Movies.Location = new System.Drawing.Point(12, 12);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(298, 529);
            this.Movies.Sorted = true;
            this.Movies.TabIndex = 1;
            this.Movies.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(77, 560);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(142, 58);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 680);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.MoviePlayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MoviePlayer;
        private System.Windows.Forms.ListBox Movies;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

