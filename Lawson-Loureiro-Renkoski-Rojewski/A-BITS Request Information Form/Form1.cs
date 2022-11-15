using System.Data.OleDb;
using System.Windows.Forms;


namespace A_BITS_Request_Information_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Initiate SQL Connection variables
            String abitsDatabaseString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\ABITS.accdb";
            OleDbConnection abitsConnection;
            OleDbCommand abitsCommand;

            //abitsDatabaseString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\jacob\\source\\repos\\sappytree229\\SystemsAnalysisAndDesign\\Lawson-Loureiro-Renkoski-Rojewski\\A-BITS Request Information Form\\ABITS.accdb";


            /*
             * So there is an issue regarding the directory for the database being hardcoded, it won't run from other people's machines that way.
             * I have managed to get a relative path working (check line 17 Data Source), but it is relative to where Visual Studio is running the app from...
             * which by default is the Debug folder at "\..\A-BITS Request Information Form\bin\Debug\net6.0-windows\ABITS.accdb"
             * So I have had to copy the database file to that folder. I do not know how to alter the relative path to be different than where Visual Studio is running the app.
             * -Jacob
             */


            // WORK IN PROGRESS!!!! abitsInsertCommandString = "Insert into PROSPECTIVE_MEMBER_INFO (fName) values (" + FirstNameBox.Text + ")";

            //Initiate SQL Connection
            abitsConnection = new OleDbConnection(abitsDatabaseString);
            abitsConnection.Open();

            //Create and run SQL command to insert values to database
            abitsCommand = new OleDbCommand();
            abitsCommand.Connection = abitsConnection;
            abitsCommand.CommandText = "Insert into PROSPECTIVE_MEMBER_INFO (fName, lName, email)" + " values ('" + FirstNameBox.Text + "', '" + LastNameBox.Text + "','" + EmailBox.Text + "');";
            abitsCommand.ExecuteNonQuery();


            //check success of database entry
            //This is a little jank, and I can't get a try/catch exception handler to work correctly, so right now if a duplicate is attempted, it crashes.
            //my intention was to display what the reader pulls from the newly inserted column value as verification, but I haven't been able to make that happen. It just checks if anything exists and then says success presently...
            OleDbCommand readingCommand = new OleDbCommand(
                "SELECT fName FROM PROSPECTIVE_MEMBER_INFO;");
            readingCommand.Connection = abitsConnection;
            OleDbDataReader reader = readingCommand.ExecuteReader();
            
            if (reader.HasRows)
            {
                    MessageBox.Show("Successfully added member.");
            }
            

            //Close SQL Connection
            abitsConnection.Close();

            //Prospective Member variables
            string prospectiveMemberFirstNameString;
            string prospectiveMemberLastNameString;
            string prospectiveMemberEmailString;
            Boolean willProspectiveMemberSponsorAbitsBoolean = false;

            //Change Sponsor boolean from false to true
            if (willProspectiveMemberSponsorAbitsBoolean = SponsorBox.Checked)
            {
                willProspectiveMemberSponsorAbitsBoolean = true;
            }

            //Store User input in Prospective Member Variables
            prospectiveMemberFirstNameString = FirstNameBox.Text;
            prospectiveMemberLastNameString  = LastNameBox.Text;
            prospectiveMemberEmailString     = EmailBox.Text;
           

            //Send email with information to user

            //Close database connections

            //TestCode
            Console.WriteLine(prospectiveMemberFirstNameString);

            this.Close();
            
        }
    }
}