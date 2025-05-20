namespace GradeChecker;

public class Subject
{
    public string code { get; private set; }
    public string name { get; private set; } 
    public int grade { get; private set; }

    public Subject(string code, string name) 
    {
        this.code = code;
        this.name = name;
        this.grade = -1;
    }
    
    public Subject(string code, string name, int grade) 
    {
        this.code = code;
        this.name = name;
        this.grade = grade;
    }

    public void UpdateGrade(int grade)
    {
        this.grade = grade;
    }
}
