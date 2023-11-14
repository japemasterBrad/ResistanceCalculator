using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        _resistanceInput = _voltageInput / _amperageInput;
        resistanceInput.Text = Convert.ToString(_resistanceInput);
        Console.WriteLine(_resistanceInput);
      }
      catch (FormatException formatException)
      {
        Console.WriteLine(formatException.Message);
        Console.WriteLine("That wasn't a number, and can't be calculated.");
      }
    }

    #region Private Members

    decimal _voltageInput;
    decimal _amperageInput;
    decimal _resistanceInput;

    #endregion

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
      CalculateResistance();
    }
  }
}
