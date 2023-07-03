namespace Phone_Book
{
    public static class Program
    {

        public static String name = "";
        public static String number = "";
        public static string names_path = @"C:\Temp\names.txt";
        public static string numbers_path = @"C:\Temp\numbers.txt";
        public static StreamReader reader = null;
        public static StreamReader reader2 = null;
        public static StreamWriter writer = null;
        public static List<string> names = new List<string>();
        public static List<string> numbers = new List<string>();
        public static string data1 = ""; //For accesing data
        public static string data2 = ""; //For accessing data
        public static void CreateFiles() //to Create text file if not available
        {
            if (!File.Exists(names_path))
            {
                writer = File.CreateText(names_path);
                writer.Close();
            }

            if (!File.Exists(numbers_path))
            {
                writer = File.CreateText(numbers_path);
                writer.Close();
            }

        }

        public static void ReadFiles() //TO Read Files from Text File
        {
            try
            {
                reader = new StreamReader(names_path);
                data1 = reader.ReadLine();
                while (data1 != null)
                {
                    names.Add(data1);
                    data1 = reader.ReadLine();
                }

                reader.Close();

                reader = new StreamReader(numbers_path);
                data2 = reader.ReadLine();
                while (data2 != null)
                {
                    numbers.Add(data2);
                    data2 = reader.ReadLine();
                }
                reader.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Sort(List<string> name, List<string> number) // Uses Selection Sort
        {
            try
            {
                int j, smallest;
                string temp = "";
                string t = "";

                for (int i = 0; i < name.Count - 1; i++)
                {
                    smallest = i;

                    for (j = i + 1; j < name.Count; j++)
                    {

                        if (name[j].CompareTo(name[smallest]) < 0)
                        {
                            smallest = j;
                        }

                    }
                    temp = name[smallest];
                    t = number[smallest];
                    name[smallest] = name[i];
                    number[smallest] = number[i];
                    name[i] = temp;
                    number[i] = t;
                }
            }

            catch (Exception e) { MessageBox.Show(e.Message); }

            
        }
        /// <summary>
        ///  The main entry p`
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new First_Page());
        }
    }
}