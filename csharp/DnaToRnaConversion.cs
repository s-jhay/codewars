namespace Converter {
  public class Converter
  {
    public string dnaToRna(string dna)
    {
        dna.ToUpper();
        return dna.Replace('T', 'U');
    }
  }
}
