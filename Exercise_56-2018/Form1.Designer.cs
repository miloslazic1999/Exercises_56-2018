namespace Exercise_56_2018
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
            this.listBoxExerciseResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxExerciseResults
            // 
            this.listBoxExerciseResults.FormattingEnabled = true;
            this.listBoxExerciseResults.ItemHeight = 15;
            this.listBoxExerciseResults.Location = new System.Drawing.Point(12, 27);
            this.listBoxExerciseResults.Name = "listBoxExerciseResults";
            this.listBoxExerciseResults.Size = new System.Drawing.Size(207, 214);
            this.listBoxExerciseResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxExerciseResults);
            this.Name = "Form1";
            this.Text = "Exercise results";
            this.Load += new System.EventHandler(this.Ucitaj);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResults;
        private System.Windows.Forms.Label label1;
    }
}

