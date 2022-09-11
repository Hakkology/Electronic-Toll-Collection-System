namespace Hakan.HGS.FormsApp
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
            this.Cars = new System.Windows.Forms.Button();
            this.Minibuses = new System.Windows.Forms.Button();
            this.Buses = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Cars
            // 
            this.Cars.Location = new System.Drawing.Point(12, 12);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(75, 23);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = true;
            // 
            // Minibuses
            // 
            this.Minibuses.Location = new System.Drawing.Point(93, 12);
            this.Minibuses.Name = "Minibuses";
            this.Minibuses.Size = new System.Drawing.Size(75, 23);
            this.Minibuses.TabIndex = 1;
            this.Minibuses.Text = "Minibuses";
            this.Minibuses.UseVisualStyleBackColor = true;
            // 
            // Buses
            // 
            this.Buses.Location = new System.Drawing.Point(174, 12);
            this.Buses.Name = "Buses";
            this.Buses.Size = new System.Drawing.Size(75, 23);
            this.Buses.TabIndex = 2;
            this.Buses.Text = "Buses";
            this.Buses.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 42);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(443, 43);
            this.Result.TabIndex = 3;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(13, 92);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(442, 40);
            this.Note.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 298);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Buses);
            this.Controls.Add(this.Minibuses);
            this.Controls.Add(this.Cars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Minibuses;
        private System.Windows.Forms.Button Buses;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

