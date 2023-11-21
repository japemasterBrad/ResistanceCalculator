using System;

namespace Resistance_Calculator
{
  public class ResistanceBandCalculator
  {
    public ResistanceBandCalculator(decimal resistance)
    {
      _resistance = resistance;
      _resistanceRounded = Convert.ToString(Convert.ToInt32(Math.Ceiling(_resistance)));

      if (Convert.ToDecimal(_resistanceRounded) < 100)
        CycleNumericValues(_resistanceRounded, 1);
      else if (Convert.ToDecimal(_resistanceRounded) >= 100 && Convert.ToDecimal(_resistanceRounded) < 1000)
        CycleNumericValues(_resistanceRounded, 10);
      else if (Convert.ToDecimal(_resistanceRounded) >= 1000 && Convert.ToDecimal(_resistanceRounded) < 10000)
        CycleNumericValues(_resistanceRounded, 100);
      else if (Convert.ToDecimal(_resistanceRounded) >= 10000 && Convert.ToDecimal(_resistanceRounded) < 100000)
        CycleNumericValues(_resistanceRounded, 1000);
    }

    public void CycleNumericValues(string resistanceRounded, int multiplier)
    {
      string[] bandsArray = new string[4];
      decimal valueDividedByMultiplier = Math.Ceiling(Convert.ToDecimal(resistanceRounded) / multiplier) + 1;

      foreach (char value in Convert.ToString(valueDividedByMultiplier))
      {
        string convertCharToString = Convert.ToString(value);
        string bandCalculation = CalculateBand(convertCharToString);
        bandsArray[Convert.ToString(valueDividedByMultiplier).IndexOf(convertCharToString)] = bandCalculation;
      }
      bandsArray[3] = CalculateMultiplier(Convert.ToString(multiplier));

      _resistor.BandOne = bandsArray[0];
      _resistor.BandTwo = bandsArray[1];
      _resistor.BandMultiply = bandsArray[3];
      _resistor.MultiplyAmount = Convert.ToString(multiplier);
      _resistor.Resistance = resistanceRounded;
    }

    #region Band Calculation

    public string CalculateBand(string value)
    {
      string colour = string.Empty;

      switch (value)
      {
        case "0":
          colour = "black";
          break;
        case "1":
          colour = "brown";
          break;
        case "2":
          colour = "red";
          break;
        case "3":
          colour = "orange";
          break;
        case "4":
          colour = "yellow";
          break;
        case "5":
          colour = "green";
          break;
        case "6":
          colour = "blue";
          break;
        case "7":
          colour = "purple";
          break;
        case "8":
          colour = "grey";
          break;
        case "9":
          colour = "white";
          break;
          //default:
          //throw new Exception("SYSTEM ERROR: That number doesn't like up from 0-9");
      }

      return colour;
    }

    public string CalculateMultiplier(string multiplier)
    {
      string bandColour = string.Empty;

      switch (multiplier)
      {
        case "1":
          bandColour = "black";
          break;
        case "10":
          bandColour = "brown";
          break;
        case "100":
          bandColour = "red";
          break;
        case "1000":
          bandColour = "orange";
          break;
        case "10000":
          bandColour = "yellow";
          break;
        case "100000":
          bandColour = "green";
          break;
        case "1000000":
          bandColour = "blue";
          break;
        case "0.1":
          bandColour = "gold";
          break;
        case "0.01":
          bandColour = "grey";
          break;
      }

      return bandColour;
    }

    #endregion

    public Resistor GetCompletedResistor()
    {
      return _resistor;
    }

    #region Private Members 

    private Resistor _resistor = new Resistor();

    private decimal _resistance;
    private string _resistanceRounded;

    #endregion
  }
}
