namespace Design_Patterns.SOLID_Principles.Single_Responsibility_Principle;

public class Persistence
{
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
        {
            File.WriteAllText(filename,journal.ToString());
        }
    }
}