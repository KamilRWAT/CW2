
namespace Dziedziczenie
{
    partial class FormStartowy
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
            btnWyswietl = new Button();
            SuspendLayout();
            // 
            // btnWyswietl
            // 
            btnWyswietl.Location = new Point(316, 307);
            btnWyswietl.Name = "btnWyswietl";
            btnWyswietl.Size = new Size(75, 23);
            btnWyswietl.TabIndex = 0;
            btnWyswietl.Text = "Wyswietl";
            btnWyswietl.UseVisualStyleBackColor = true;
            btnWyswietl.Click += btnWyswietl_Click;
            // 
            // FormStartowy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWyswietl);
            Name = "FormStartowy";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWyswietl;
    }
}
