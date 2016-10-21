using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : Page
{
    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Eoin\Documents\Visual Studio 2013\WebSites\WebSite2\App_Data\Database.mdf;Integrated Security=True");
    /*protected void Page_Load(object sender, EventArgs e)
    {
        
    }*/
    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        SqlCommand command = new SqlCommand();
        String query = "INSERT INTO member VALUES(@Name, @Email, @School)";
        
        int MemberId = 0;

        using (SqlCommand cmd = new SqlCommand("AddMember"))
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", MemberId);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@School", SchoolLbl.Text.Trim());
                cmd.Connection = connection;
                connection.Open();
                MemberId = MemberId ++;
                //cmd = new SqlCommand(query, connection);
                //cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        String messge = String.Empty;
        switch (MemberId)
        { 
            case 1:
                messge = "Name already exists.\nPlease try a different name.";
                break;
            case 2:
                messge = "Email address is already used.\nPlease try a different email address.";
                break;
            default:
                messge = "Registration complete.";
                break;
        }
        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + messge + "');", true);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        connection.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Eoin\Documents\Visual Studio 2013\WebSites\WebSite2\App_Data\Database.mdf;Integrated Security=True";

        using (SqlCommand cmd = new SqlCommand("Procedure2"))
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();
                String addstr = "SELECT Id, name, emailaddress, school FROM member";
                SqlCommand command = new SqlCommand(addstr, connection);
                DataTable table = new DataTable();
                command.CommandType = CommandType.Text;
                DropDownList1.DataSource = table;
                DropDownList1.DataTextField = "School";
                DropDownList1.DataValueField = "School";
                DropDownList1.DataBind();

                for (int i = 0; i < DropDownList1.Items.Count; i++)
                {
                    if (DropDownList1.Items[i].Selected == true)
                    {
                        String str = "INSERT INTO member VALUES(@School)";
                        command = new SqlCommand(str, connection);
                        command.ExecuteNonQuery();

                    }
                }
            }
        }
        connection.Close();
    }
}