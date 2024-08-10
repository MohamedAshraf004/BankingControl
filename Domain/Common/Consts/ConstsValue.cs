namespace Domain.Common.Consts;

public class ConstsValue
{
    public const string IBAN_REGEX = @"^([A-Z]{2}[ '+'\\\\'+'-]?[0-9]{2})(?=(?:[ '+'\\\\'+'-]?[A-Z0-9]){9,30}\$)((?:[ '+'\\\\'+'-]?[A-Z0-9]{3,5}){2,7})([ '+'\\\\'+'-]?[A-Z0-9]{1,3})?\$";
    public const string Mobile_REGEX = @"^[+]{1}(?:[0-9\\-\\(\\)\\/" +
                          "\\.]\\s?){6,15}[0-9]{1}$";
    public const string DigitsOnly_REGEX = @"^\d+$";
}
