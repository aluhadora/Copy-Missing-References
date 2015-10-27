namespace Copy_Missing_References
{
  partial class CopyForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.missingFileTextBox = new System.Windows.Forms.TextBox();
      this.errorTextBox = new System.Windows.Forms.TextBox();
      this.copyFileTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.rerunButton = new System.Windows.Forms.Button();
      this.copyButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 167);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Missing file:";
      // 
      // missingFileTextBox
      // 
      this.missingFileTextBox.Location = new System.Drawing.Point(79, 164);
      this.missingFileTextBox.Name = "missingFileTextBox";
      this.missingFileTextBox.ReadOnly = true;
      this.missingFileTextBox.Size = new System.Drawing.Size(543, 20);
      this.missingFileTextBox.TabIndex = 2;
      // 
      // errorTextBox
      // 
      this.errorTextBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.errorTextBox.Location = new System.Drawing.Point(0, 0);
      this.errorTextBox.Multiline = true;
      this.errorTextBox.Name = "errorTextBox";
      this.errorTextBox.ReadOnly = true;
      this.errorTextBox.Size = new System.Drawing.Size(653, 158);
      this.errorTextBox.TabIndex = 0;
      // 
      // copyFileTextBox
      // 
      this.copyFileTextBox.Location = new System.Drawing.Point(79, 190);
      this.copyFileTextBox.Name = "copyFileTextBox";
      this.copyFileTextBox.ReadOnly = true;
      this.copyFileTextBox.Size = new System.Drawing.Size(543, 20);
      this.copyFileTextBox.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 193);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Copy file:";
      // 
      // rerunButton
      // 
      this.rerunButton.Location = new System.Drawing.Point(241, 247);
      this.rerunButton.Name = "rerunButton";
      this.rerunButton.Size = new System.Drawing.Size(75, 23);
      this.rerunButton.TabIndex = 5;
      this.rerunButton.Text = "Re-run";
      this.rerunButton.UseVisualStyleBackColor = true;
      this.rerunButton.Click += new System.EventHandler(this.rerunButton_Click);
      // 
      // copyButton
      // 
      this.copyButton.Location = new System.Drawing.Point(322, 247);
      this.copyButton.Name = "copyButton";
      this.copyButton.Size = new System.Drawing.Size(75, 23);
      this.copyButton.TabIndex = 6;
      this.copyButton.Text = "Copy";
      this.copyButton.UseVisualStyleBackColor = true;
      this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(653, 282);
      this.Controls.Add(this.copyButton);
      this.Controls.Add(this.rerunButton);
      this.Controls.Add(this.copyFileTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.errorTextBox);
      this.Controls.Add(this.missingFileTextBox);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox missingFileTextBox;
    private System.Windows.Forms.TextBox errorTextBox;
    private System.Windows.Forms.TextBox copyFileTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button rerunButton;
    private System.Windows.Forms.Button copyButton;
  }
}

