using MeanLibs.Models;

namespace MeanLibs.Models
{
  public class QuotesVariable
  {
    private string _adjective;
    private string _dayOfTheWeek;
    private string _color;
    private string _profession;
    private string _slang;
    private string _verb;

    public string Adjective { get => _adjective ; set => _adjective = value;  }

    public string DayOfTheWeek { get => _dayOfTheWeek; set => _dayOfTheWeek = value; }

    public string Color { get => _color; set => _color = value; }

    public string Profession { get => _profession; set => _profession = value; }

    public string Slang { get => _slang; set => _slang = value; }

    public string Verb { get => _verb; set => _verb = value; }

  }
}
