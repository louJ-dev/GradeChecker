using System.Text.Json;

namespace GradeChecker;

public static class SaveManager
{
    public static void SaveAsJson(string fileName, Subject[] subjects)
    {
        using(Stream sw = File.Create(fileName)) 
        {
            Utf8JsonWriter writer = new Utf8JsonWriter(sw, new JsonWriterOptions() {
                    Indented = true
                });

            writer.WriteStartObject();
            writer.WriteStartArray("subjects");

            for(int i = 0; i < subjects.Length; i++)
            {
                writer.WriteStartObject();
                writer.WriteString("name", subjects[i].name);
                writer.WriteString("code", subjects[i].code);
                writer.WriteNumber("grade", subjects[i].grade);
                writer.WriteEndObject();
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Flush();
        }
    }
    
    public static void Save(string fileName, string[] data)
    {
        using(StreamWriter sw = File.CreateText(fileName))
        { 
            for(int i = 0; i < data.Length; i++)
            {
                sw.WriteLine(data[i]);
            }

            sw.Flush();
            sw.Close();
        }
    }
}
