namespace Theme34Lesson6
{
    partial class FormAdEditStudent
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            numericUpDownФпу = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownФпу).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(14, 14);
            textBoxFirstName.Margin = new Padding(5, 5, 5, 5);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(358, 33);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(14, 67);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(358, 33);
            textBoxLastName.TabIndex = 1;
            // 
            // numericUpDownФпу
            // 
            numericUpDownФпу.Location = new Point(14, 120);
            numericUpDownФпу.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownФпу.Name = "numericUpDownФпу";
            numericUpDownФпу.Size = new Size(358, 33);
            numericUpDownФпу.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(14, 177);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(129, 45);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(255, 177);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(117, 45);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAdEditStudent
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 234);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownФпу);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormAdEditStudent";
            Text = "FormAdEditStudent";
            ((System.ComponentModel.ISupportInitialize)numericUpDownФпу).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxFirstName;
        public TextBox textBoxLastName;
        public NumericUpDown numericUpDownФпу;
        private Button buttonSave;
        private Button buttonCancel;
    }
}