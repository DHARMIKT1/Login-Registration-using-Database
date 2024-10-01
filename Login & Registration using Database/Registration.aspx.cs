using System;
using System.Data.SqlClient;
using System.Data;

namespace Login___Registration_using_Database
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO reg (userName,name,email,phoneNumber,password) VALUES (@uname,@nm,@email,@phoneNo,@pass)";

            try
            {
                using (con)
                {
                    con.Open();
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.Add("@uname", SqlDbType.NVarChar).Value = txtUserName.Text.Trim();
                            cmd.Parameters.Add("@nm", SqlDbType.NVarChar).Value = txtName.Text.Trim();
                            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text.Trim();
                            cmd.Parameters.Add("@phoneNo", SqlDbType.NVarChar).Value = txtPhoneNumber.Text.Trim();
                            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtPassword.Text.Trim();

                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                lblMessage.ForeColor = System.Drawing.Color.Green;
                                lblMessage.Text = "Registration successful!";
                            }
                            else
                            {
                                lblMessage.Text = "Registration failed. Please try again.";
                            }
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Passwords do not match!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}