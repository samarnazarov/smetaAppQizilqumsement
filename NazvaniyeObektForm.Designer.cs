namespace SmetaApp
{
    partial class NazvaniyeObektForm
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
            this.cancelNazvaniyeStroyka_button = new System.Windows.Forms.Button();
            this.saveNazvanieStroyka_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelNazvaniyeStroyka_button
            // 
            this.cancelNazvaniyeStroyka_button.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelNazvaniyeStroyka_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelNazvaniyeStroyka_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelNazvaniyeStroyka_button.Image = global::SmetaApp.Properties.Resources.cancel21;
            this.cancelNazvaniyeStroyka_button.Location = new System.Drawing.Point(285, 86);
            this.cancelNazvaniyeStroyka_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancelNazvaniyeStroyka_button.Name = "cancelNazvaniyeStroyka_button";
            this.cancelNazvaniyeStroyka_button.Size = new System.Drawing.Size(131, 39);
            this.cancelNazvaniyeStroyka_button.TabIndex = 7;
            this.cancelNazvaniyeStroyka_button.Text = "  ОТМЕНА";
            this.cancelNazvaniyeStroyka_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelNazvaniyeStroyka_button.UseVisualStyleBackColor = false;
            // 
            // saveNazvanieStroyka_button
            // 
            this.saveNazvanieStroyka_button.BackColor = System.Drawing.Color.Gainsboro;
            this.saveNazvanieStroyka_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveNazvanieStroyka_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveNazvanieStroyka_button.Image = global::SmetaApp.Properties.Resources.ok22;
            this.saveNazvanieStroyka_button.Location = new System.Drawing.Point(84, 86);
            this.saveNazvanieStroyka_button.Margin = new System.Windows.Forms.Padding(4);
            this.saveNazvanieStroyka_button.Name = "saveNazvanieStroyka_button";
            this.saveNazvanieStroyka_button.Size = new System.Drawing.Size(131, 39);
            this.saveNazvanieStroyka_button.TabIndex = 6;
            this.saveNazvanieStroyka_button.Text = "  OK";
            this.saveNazvanieStroyka_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveNazvanieStroyka_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование объекта";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(14, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "НАПИШИТЕ НАЗВАНИЕ ОБЪЕКТА";
            // 
            // NazvaniyeObektForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 140);
            this.Controls.Add(this.cancelNazvaniyeStroyka_button);
            this.Controls.Add(this.saveNazvanieStroyka_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NazvaniyeObektForm";
            this.Text = "Объект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelNazvaniyeStroyka_button;
        private System.Windows.Forms.Button saveNazvanieStroyka_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}