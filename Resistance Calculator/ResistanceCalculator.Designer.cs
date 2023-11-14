namespace Resistance_Calculator
{
  partial class ResistanceCalculator
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
      this.label2 = new System.Windows.Forms.Label();
      this.voltageInput = new System.Windows.Forms.TextBox();
      this.amperageInput = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.resistanceInput = new System.Windows.Forms.TextBox();
      this.bandOne = new System.Windows.Forms.Label();
      this.bandTwo = new System.Windows.Forms.Label();
      this.bandMultiplier = new System.Windows.Forms.Label();
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(56, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Voltage";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Amperage";
      // 
      // voltageInput
      // 
      this.voltageInput.Location = new System.Drawing.Point(131, 24);
      this.voltageInput.Name = "voltageInput";
      this.voltageInput.Size = new System.Drawing.Size(51, 20);
      this.voltageInput.TabIndex = 2;
      // 
      // amperageInput
      // 
      this.amperageInput.Location = new System.Drawing.Point(131, 51);
      this.amperageInput.Name = "amperageInput";
      this.amperageInput.Size = new System.Drawing.Size(51, 20);
      this.amperageInput.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(236, 27);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Resistance";
      // 
      // resistanceInput
      // 
      this.resistanceInput.Location = new System.Drawing.Point(311, 24);
      this.resistanceInput.Name = "resistanceInput";
      this.resistanceInput.Size = new System.Drawing.Size(56, 20);
      this.resistanceInput.TabIndex = 5;
      // 
      // bandOne
      // 
      this.bandOne.AutoSize = true;
      this.bandOne.Location = new System.Drawing.Point(75, 135);
      this.bandOne.Name = "bandOne";
      this.bandOne.Size = new System.Drawing.Size(0, 13);
      this.bandOne.TabIndex = 6;
      this.bandOne.Click += new System.EventHandler(this.bandOne_Click);
      // 
      // bandTwo
      // 
      this.bandTwo.AutoSize = true;
      this.bandTwo.Location = new System.Drawing.Point(163, 135);
      this.bandTwo.Name = "bandTwo";
      this.bandTwo.Size = new System.Drawing.Size(0, 13);
      this.bandTwo.TabIndex = 7;
      // 
      // bandMultiplier
      // 
      this.bandMultiplier.AutoSize = true;
      this.bandMultiplier.Location = new System.Drawing.Point(314, 135);
      this.bandMultiplier.Name = "bandMultiplier";
      this.bandMultiplier.Size = new System.Drawing.Size(0, 13);
      this.bandMultiplier.TabIndex = 9;
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Location = new System.Drawing.Point(239, 52);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(128, 23);
      this.buttonCalculate.TabIndex = 11;
      this.buttonCalculate.Text = "Calculate";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(165, 100);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(125, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Band Colour Scheme";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(314, 122);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "Multiplier";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(163, 122);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(56, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Band Two";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(75, 122);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(55, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Band One";
      // 
      // ResistanceCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 164);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonCalculate);
      this.Controls.Add(this.bandMultiplier);
      this.Controls.Add(this.bandTwo);
      this.Controls.Add(this.bandOne);
      this.Controls.Add(this.resistanceInput);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.amperageInput);
      this.Controls.Add(this.voltageInput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "ResistanceCalculator";
      this.Text = "Resistance Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox voltageInput;
    private System.Windows.Forms.TextBox amperageInput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox resistanceInput;
    private System.Windows.Forms.Label bandOne;
    private System.Windows.Forms.Label bandTwo;
    private System.Windows.Forms.Label bandMultiplier;
    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

