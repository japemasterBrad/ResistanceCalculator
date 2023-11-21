using System;
using System.Windows.Forms;

namespace Resistance_Calculator
{
  public partial class ResistanceCalculator : Form
  {
    public ResistanceCalculator()
    {
      InitializeComponent();
    }

    public void CalculateResistance()
    {
      try
      {
        _voltageInput = Convert.ToDecimal(voltageInput.Text);
        _amperageInput = Convert.ToDecimal(amperageInput.Text);
        _resistance = Convert.ToDecimal(Math.Ceiling(_voltageInput / _amperageInput));
        resistanceInput.Text = Convert.ToString(_resistance);

        ResistanceBandCalculator bandCalculator = new ResistanceBandCalculator(_resistance);
        Resistor resistor = bandCalculator.GetCompletedResistor();
        _resistor = resistor;
      }
      catch (FormatException formatException)
      {
        Console.WriteLine($"SYSTEM EXCEPTION: {formatException.Message}");
        Console.WriteLine("What you entered probably contained a letter or something, take another look.");
      }
    }

    public void PushValues()
    {
      bandOne.Text = _resistor.BandOne;
      bandTwo.Text = _resistor.BandTwo;
      bandMultiplier.Text = _resistor.BandMultiply;
    }

    #region Private Members

    private decimal _voltageInput;
    private decimal _amperageInput;
    private decimal _resistance;
    private Resistor _resistor = new Resistor();

    #endregion

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
      CalculateResistance();
      PushValues();
    }

    private void bandOne_Click(object sender, EventArgs e)
    {

    }
  }
}
