using System;

class Program {
    static void Main() {
        foreach (Environment.SpecialFolder folder in Enum.GetValues(typeof(Environment.SpecialFolder))) {
            try {
                int value = (int)folder;
                string path = Environment.GetFolderPath(folder);
                
                string enumName = $"Environment.SpecialFolder.{folder}";
                string enumNum = $"({value})";

                Console.WriteLine($"{enumNum, 6} {enumName, -60} {path}");
            } catch (Exception) { }
        }
    }
}