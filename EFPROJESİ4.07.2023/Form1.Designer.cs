namespace EFPROJESİ4._07._2023
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
            txtYapilacakis = new TextBox();
            btnEkle = new Button();
            label1 = new Label();
            clbToDos = new CheckedListBox();
            BTNdELETE = new Button();
            SuspendLayout();
            // 
            // txtYapilacakis
            // 
            txtYapilacakis.Location = new Point(12, 80);
            txtYapilacakis.Name = "txtYapilacakis";
            txtYapilacakis.Size = new Size(325, 23);
            txtYapilacakis.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 109);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(325, 30);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "ADD";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "İş tanımı:";
            // 
            // clbToDos
            // 
            clbToDos.FormattingEnabled = true;
            clbToDos.Location = new Point(353, 12);
            clbToDos.Name = "clbToDos";
            clbToDos.Size = new Size(333, 310);
            clbToDos.TabIndex = 7;
            clbToDos.ItemCheck += clbToDos_ItemCheck;
            // 
            // BTNdELETE
            // 
            BTNdELETE.Location = new Point(611, 338);
            BTNdELETE.Name = "BTNdELETE";
            BTNdELETE.Size = new Size(75, 23);
            BTNdELETE.TabIndex = 8;
            BTNdELETE.Text = "DELETE";
            BTNdELETE.UseVisualStyleBackColor = true;
            BTNdELETE.Click += BTNdELETE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 373);
            Controls.Add(BTNdELETE);
            Controls.Add(clbToDos);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(txtYapilacakis);
            Name = "Form1";
            Text = "Yapılacak İşler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYapilacakis;
        private Button btnEkle;
        private Label label1;
        private CheckedListBox clbToDos;
        private Button BTNdELETE;
    }
}