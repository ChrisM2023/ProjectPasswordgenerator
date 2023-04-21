namespace ProjectPasswordgenerator.Models
{
    public class PasswordGeneratorViewModel
    {
        public int PasswordLength { get; set; }
        public string PasswordResult { get; set; }
        public bool Uppercase { get; set; }
        public bool Numbers { get; set; }
        public bool SpecialCharacters { get; set; }
    }
}
