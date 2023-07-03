using System.ComponentModel;


namespace Phone_Book
{
    public partial class First_Page : Form
    {
        public static String PhoneBook = "{0, -55} {1, -25}";
        public static ListBox listbox;

        public static void PrintList()
        {
           
            listbox.Items.Clear();

            listbox.Items.Add(String.Format(PhoneBook, "Name", "Contact No."));
            listbox.Items.Add(String.Format(PhoneBook, " ", " "));

           
            
            Program.Sort(Program.names, Program.numbers);
            for (int i = 0; i < Program.names.Count; i++)
            {
                Program.name = Program.names[i];
                Program.number = Program.numbers[i];


                listbox.Items.Add(String.Format(PhoneBook, Program.name, Program.number));
            }
        }



        public First_Page()
        {
            InitializeComponent();
        }

        private void phone_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void First_Page_Load(object sender, EventArgs e)
        {

            listbox = phone_list;
            phone_list.Items.Add(String.Format(PhoneBook, "Name", "Contact No."));
            phone_list.Items.Add(String.Format(PhoneBook, " ", " "));
            Program.CreateFiles();
            Program.ReadFiles();
            Program.Sort(Program.names, Program.numbers);
            for (int i = 0; i < Program.names.Count; i++)
            {
                Program.name = Program.names[i];
                Program.number = Program.numbers[i];


                phone_list.Items.Add(String.Format(PhoneBook, Program.name, Program.number));
            }
        }
        //Following Code made by accident:
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void add_btn_Click(object sender, EventArgs e)
        {

            options_cmbo.Focus();
        }   
        private void phone_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        /////////////////////////////////////////////////////

        private void add_contact_btn_Click(object sender, EventArgs e) //Adds new Contact
        {
            string num = no_txtbx.Text;
            string name = name_txtbx.Text;
            int correct = 0;
            int mark = 0;
            try
            {
                if (options_cmbo.SelectedIndex.ToString() == null)
                {
                    MessageBox.Show("Please Fill All boxes", "Error", MessageBoxButtons.OK);
                }
                else if (options_cmbo.SelectedItem.ToString() == "Cell")
                {
                    no_txtbx.Text = "03";          
                    if (num[4] != '-')
                    {
                        MessageBox.Show("Please Enter number in following format: 03xx-xxxxxxx", "Error", MessageBoxButtons.OK);
                    }                    
                    else if (num.Length != 12)
                    {
                        MessageBox.Show("Please enter correct number:", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i] != '0' && num[i] != '1' && num[i] != '2' && num[i] != '3' && num[i] != '4' && num[i] != '5'
                                && num[i] != '6' && num[i] != '7' && num[i] != '8' && num[i] != '9' && num[i] != '-')
                            {
                                break;
                            }
                            else
                            {
                                correct++;

                            }
                        }
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i]=='-')
                            {
                                mark++;
                            }
                        }
                            if (mark != 1)
                            {
                                MessageBox.Show("Please Enter number in following format: 03xx-xxxxxxx", "Error", MessageBoxButtons.OK);

                            }
                            else if (correct == 12)
                            {

                                Program.names.Add(name);
                                Program.numbers.Add(num);
                                Program.Sort(Program.names, Program.numbers);
                                Program.writer = File.AppendText(Program.names_path);
                                Program.writer.WriteLine(name);
                                Program.writer.Close();
                                Program.writer = File.AppendText(Program.numbers_path);
                                Program.writer.WriteLine(Program.number);
                                Program.writer.Close();
                                PrintList();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter number in following format: 03xx-xxxxxxx", "Error", MessageBoxButtons.OK);
                            }
                    }
                }

                else if (options_cmbo.SelectedItem.ToString() == "Landline")
                {
                    no_txtbx.Text = "021-";
                    if (num[3] != '-')
                    {
                        MessageBox.Show("Please Enter number in following format: 021-xxxxxxxx", "Error", MessageBoxButtons.OK);
                    }
                    else if (num.Length != 12)
                    {
                        MessageBox.Show("Please enter correct number:", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i] != '0' && num[i] != '1' && num[i] != '2' && num[i] != '3' && num[i] != '4' && num[i] != '5' && num[i] != '6'
                                && num[i] != '7' && num[i] != '8' && num[i] != '9' && num[i] != '-')
                            {

                                break;
                            }
                            else
                            {
                                correct++;
                            }
                        }
                    }
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i] == '-')
                        {
                            mark++;
                        }
                       
                    }
                    if (mark != 1)
                    {

                        MessageBox.Show("Please Enter number in following format: 03xx-xxxxxxx", "Error", MessageBoxButtons.OK);
                    }
                    else if (correct == 12)
                    {
                        Program.names.Add(name);
                        Program.numbers.Add(num);
                        Program.Sort(Program.names, Program.numbers);
                        Program.writer = File.AppendText(Program.names_path);
                        Program.writer.WriteLine(Program.name);
                        Program.writer.Close();
                        Program.writer = File.AppendText(Program.numbers_path);
                        Program.writer.WriteLine(Program.number);
                        Program.writer.Close();
                        PrintList();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter number in following format: 021-xxxxxxxx", "Error", MessageBoxButtons.OK);
                    }
                    }
                }
            
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please Fill All boxes", "Error", MessageBoxButtons.OK);

            }
            no_txtbx.Clear();
            name_txtbx.Clear();

        }
        private void button1_Click(object sender, EventArgs e) // CLear choices
        {
            options_cmbo.Text = String.Empty;
            name_txtbx.Clear();
            no_txtbx.Clear();
        }
        private void SearchBox_KeyDown(object sender, KeyEventArgs e) // Uses Binary search name or number
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string contact = SearchBox.Text;
                    if (SearchBox.Text.Length == 0)
                    {
                        MessageBox.Show("Enter a number or name plz", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        listbox.Items.Clear();
                        listbox.Items.Add(String.Format(PhoneBook, "Name", "Contact No."));
                    }
                    Program.Sort(Program.names, Program.numbers);

                    int f = 0;
                    int l = Program.names.Count - 1;
                    int mid = (f + l) / 2;

                    if (contact[0] == '0')
                    {
                        while (f <= l)
                        {
                            if (contact.Equals(Program.numbers[mid]))
                            {
                                
                                listbox.Items.Add(String.Format(PhoneBook, Program.names[mid], Program.numbers[mid]));


                                break;
                            }
                            else if (contact.CompareTo(Program.numbers[mid]) < 0)
                            {
                                l = mid - 1;
                            }
                            else
                            {

                                f = mid + 1;
                            }
                            mid = (f + l) / 2;
                            if (f > l)
                            {
                                MessageBox.Show("Contact Not Found", "Error", MessageBoxButtons.OK);
                            }
                        }

                    }
                    else
                    {

                        while (f <= l)
                        {
                            if (contact.Equals(Program.names[mid]))
                            {
                                string d = mid.ToString();
                                int m = int.Parse(d) + 1;

                                listbox.Items.Add(String.Format(PhoneBook, Program.names[mid], Program.numbers[mid]));

                                break;
                            }
                            else if (contact.CompareTo(Program.names[mid]) < 0)
                            {
                                l = mid - 1;
                            }
                            else
                            {

                                f = mid + 1;
                            }
                            mid = (f + l) / 2;
                            if (f > l)
                            {
                                MessageBox.Show("Contact Not Found", "Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                catch (Exception p) {  }
            }          
           
        }
        private void DIsplay_Click(object sender, EventArgs e) // Displays all the contacts
        {
            PrintList();
        }
        private void button1_Click_1(object sender, EventArgs e) // Deletes the Selected Contact
        {
            int index = phone_list.SelectedIndex - 2;
            Program.names.RemoveAt(index);
            Program.numbers.RemoveAt(index);
            Program.writer = new StreamWriter(Program.names_path);
            for (int i = 0; i < Program.names.Count; i++)
            {
                Program.writer.WriteLine(Program.names[i]);
            }
            Program.writer.Close();
            Program.writer = new StreamWriter(Program.numbers_path);

            for (int i = 0; i < Program.numbers.Count; i++)
            {
                Program.writer.WriteLine(Program.numbers[i]);
            }
            Program.writer.Close();
            Program.Sort(Program.names, Program.numbers);
            PrintList();
        }
    }
}
