using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HAPPY.Models;
using System.Data;
 using System.Data.SqlClient;



namespace HAPPY.Controllers
{
    public class CustomerDetailController : ApiController
    {
        //For new use Register
        [Route("Api/Customer/UpdateCustomer")]
        [HttpPost]
        public object UpdateCustomer(CustomerDetail objCustomerDetail)
        {
            try
            {             

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", objCustomerDetail.CustomerID);
                cmd.Parameters.AddWithValue("@Name", objCustomerDetail.Name);
                cmd.Parameters.AddWithValue("@Email", objCustomerDetail.Email);
                 cmd.Parameters.AddWithValue("@Address", objCustomerDetail.Address);
                cmd.Parameters.AddWithValue("@ContactNo", objCustomerDetail.ContactNo);
                cmd.Parameters.AddWithValue("@city", objCustomerDetail.city);

                //cmd.Parameters.AddWithValue("@Enabled", objCustomerDetail.Enabled);
                cmd.Parameters.AddWithValue("@DOB", objCustomerDetail.DOB);
                cmd.Parameters.AddWithValue("@Street", objCustomerDetail.Street);

                cmd.Parameters.AddWithValue("@State", objCustomerDetail.State);
                cmd.Parameters.AddWithValue("@PIN", objCustomerDetail.PIN);
                cmd.Parameters.AddWithValue("@ParentID", objCustomerDetail.ParentID);

                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "sucess";
                }
                else
                { return "Fail"; }

                return new Response
                {
                    Status = "Success",
                    Message = "SuccessFully Saved."
                };

            }
            catch (Exception Ex)
            {
                return new Response
                {
                    Status = "Error",
                    Message = "Invalid Data."
                };
            }          

        }
    }

}



