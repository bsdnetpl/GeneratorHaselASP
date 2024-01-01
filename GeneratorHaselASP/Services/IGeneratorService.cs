namespace GeneratorHaselASP.Services
{
    public interface IGeneratorService
    {
        string GeneratePassword(int LongPassword, bool specialsPlChars);
    }
}