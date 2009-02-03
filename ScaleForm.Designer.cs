namespace GroupScaler
{
    partial class ScaleForm
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
            this.scaleButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.scaleFactorLabel = new System.Windows.Forms.Label();
            this.scaleFactorTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // scaleButton
            // 
            this.scaleButton.Location = new System.Drawing.Point(123, 58);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(75, 23);
            this.scaleButton.TabIndex = 0;
            this.scaleButton.Text = "Scale";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(205, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // scaleFactorLabel
            // 
            this.scaleFactorLabel.AutoSize = true;
            this.scaleFactorLabel.Location = new System.Drawing.Point(22, 21);
            this.scaleFactorLabel.Name = "scaleFactorLabel";
            this.scaleFactorLabel.Size = new System.Drawing.Size(64, 13);
            this.scaleFactorLabel.TabIndex = 2;
            this.scaleFactorLabel.Text = "Scale factor";
            // 
            // scaleFactorTextBox
            // 
            this.scaleFactorTextBox.Location = new System.Drawing.Point(123, 18);
            this.scaleFactorTextBox.Name = "scaleFactorTextBox";
            this.scaleFactorTextBox.Size = new System.Drawing.Size(132, 20);
            this.scaleFactorTextBox.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ScaleForm
            // 
            this.AcceptButton = this.scaleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(292, 95);
            this.Controls.Add(this.scaleFactorTextBox);
            this.Controls.Add(this.scaleFactorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.scaleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScaleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Scale selected objects";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label scaleFactorLabel;
        private System.Windows.Forms.TextBox scaleFactorTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}