using GradeChecker;

public class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Enter number of Subjects: ");
        // int n = int.Parse(Console.ReadLine() ?? "0");

        Subject[] subjects = new Subject[]
        {
            new Subject("1", "App dev"), 
            new Subject("2", "CP 2"), 
            new Subject("3", "OOP"), 
        };
/*
        for(int i = 0; i < n; i++)
        {
            Console.Write("Subject Name: ");
            
            string name = string.Empty;
            while(name == "")
            {
                name = (Console.ReadLine() ?? " ").Trim();
            }

            Console.Write("Subject Code: ");

            string code = string.Empty;
            while(code == "")
            {
                code = (Console.ReadLine() ?? " ").Trim();
            }

            subjects[i] = new Subject(code, name);
        }
*/
        string[] data = new string[subjects.Length];

        for (int i = 0; i < subjects.Length; i++)
        {
            string info = subjects[i].code + " " + subjects[i].name;

            Console.WriteLine(info);
            data[i] = info;
        }

        SaveManager.SaveAsJson("save000", subjects);
    }
}
