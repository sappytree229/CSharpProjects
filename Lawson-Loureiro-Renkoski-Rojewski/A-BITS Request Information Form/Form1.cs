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
            String abitsDatabaseString = "";
            String abitsInsertCommandString = "";
            OleDbConnection abitsConnection;
            OleDbCommand abitsCommand;

            abitsDatabaseString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\sappy\\source\\repos\\sappytree229\\SystemsAnalysisAndDesign\\Lawson-Loureiro-Renkoski-Rojewski\\A-BITS Request Information Form\\ABITS.accdb\"";

            // WORK IN PROGRESS!!!! abitsInsertCommandString = "Insert into PROSPECTIVE_MEMBER_INFO (fName) values (" + FirstNameBox.Text + ")";
            
            //Initiate SQL Connection
            abitsConnection = new OleDbConnection(abitsDatabaseString);
            abitsConnection.Open();

            abitsCommand = new OleDbCommand(abitsInsertCommandString);

            //Prospective Member variables
            string  prospectiveMemberFirstNameString = "";
            string  prospectiveMemberLastNameString  = "";
            string  prospectiveMemberEmailString     = "";
            Boolean willProspectiveMemberSponsorAbitsBoolean = false;

            //Store User input in Prospective Member Variables
            prospectiveMemberFirstNameString = FirstNameBox.Text;
            prospectiveMemberLastNameString  = LastNameBox.Text;
            prospectiveMemberEmailString     = EmailBox.Text;

            //Change Sponsor boolean from false to true
            if (willProspectiveMemberSponsorAbitsBoolean = SponsorBox.Checked)
            {
                willProspectiveMemberSponsorAbitsBoolean = true;
            }


            //Insert user information to database using SQL command and user input variables

            //Send email with information to user

            //Close database connections

            //TestCode
            Console.WriteLine(prospectiveMemberFirstNameString);

            this.Close();
        }
    }
}