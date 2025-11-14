namespace EgzaminINF042025Czerwiec2Grupa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.title1 = new System.Windows.Forms.Label();
            this.keyValue = new System.Windows.Forms.TextBox();
            this.title2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title1.Location = new System.Drawing.Point(13, 13);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(221, 25);
            this.title1.TabIndex = 0;
            this.title1.Text = "Podaj wartość klucza:";
            // 
            // keyValue
            // 
            this.keyValue.Location = new System.Drawing.Point(18, 41);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(100, 20);
            this.keyValue.TabIndex = 1;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title2.Location = new System.Drawing.Point(13, 83);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(359, 25);
            this.title2.TabIndex = 2;
            this.title2.Text = "Podaj wiadomość do zaszyfrowania:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(18, 112);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(354, 20);
            this.input.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(18, 139);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(354, 33);
            this.btn.TabIndex = 4;
            this.btn.Text = "szyfruj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.keyValue);
            this.Controls.Add(this.title1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.TextBox keyValue;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btn;
    }
}

