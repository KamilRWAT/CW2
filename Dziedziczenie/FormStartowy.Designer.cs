
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
            cbZwierzeta = new ComboBox();
            txtWiadomosc = new TextBox();
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
            // cbZwierzeta
            // 
            cbZwierzeta.FormattingEnabled = true;
            cbZwierzeta.Location = new Point(213, 129);
            cbZwierzeta.Name = "cbZwierzeta";
            cbZwierzeta.Size = new Size(121, 23);
            cbZwierzeta.TabIndex = 1;
            // 
            // txtWiadomosc
            // 
            txtWiadomosc.Location = new Point(340, 129);
            txtWiadomosc.Name = "txtWiadomosc";
            txtWiadomosc.Size = new Size(354, 23);
            txtWiadomosc.TabIndex = 2;
            // 
            // FormStartowy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWiadomosc);
            Controls.Add(cbZwierzeta);
            Controls.Add(btnWyswietl);
            Name = "FormStartowy";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWyswietl;
        private ComboBox cbZwierzeta;
        private TextBox txtWiadomosc;
    }
}
