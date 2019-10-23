using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HAPPY.Models;


using System.Configuration;
using System.Net.Mail;


namespace HAPPY.Controllers
{
    public class NewRegisterController : ApiController
    {
        [Route("Api/IMHI/NewRegister")]
        [HttpPost]
        public object RegisterCustomer(RegisterCustomer objRegisterCustomer00)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

               // string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spRegisterCustomer00", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", objRegisterCustomer00.CustomerID);
                cmd.Parameters.AddWithValue("@FirstName", objRegisterCustomer00.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", objRegisterCustomer00.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", objRegisterCustomer00.LastName);
                cmd.Parameters.AddWithValue("@Email", objRegisterCustomer00.Email);
                cmd.Parameters.AddWithValue("@Address", objRegisterCustomer00.Address);

                cmd.Parameters.AddWithValue("@ContactNo", objRegisterCustomer00.ContactNo);
                cmd.Parameters.AddWithValue("@city", objRegisterCustomer00.city);
                cmd.Parameters.AddWithValue("@State", objRegisterCustomer00.State);
                cmd.Parameters.AddWithValue("@PIN", objRegisterCustomer00.PIN);
                cmd.Parameters.AddWithValue("@Street", objRegisterCustomer00.Street);
                cmd.Parameters.AddWithValue("@DOB", objRegisterCustomer00.DOB);
                cmd.Parameters.AddWithValue("@PolicyMasterID", objRegisterCustomer00.PolicyMasterID);
                cmd.Parameters.AddWithValue("@SumAssured", objRegisterCustomer00.SumAssured);
                cmd.Parameters.AddWithValue("@PolicyDetailID", objRegisterCustomer00.PolicyDetailID);
                cmd.Parameters.AddWithValue("@BankName", objRegisterCustomer00.BankName);
                cmd.Parameters.AddWithValue("@ChequeNumber", objRegisterCustomer00.ChequeNumber);
                cmd.Parameters.AddWithValue("@AadharNo", objRegisterCustomer00.AadharNo);
                cmd.Parameters.AddWithValue("@EnquiryID", objRegisterCustomer00.EnquiryID);
                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "Data Successfully Saved.";
                }
                else
                { return "Some error occurred."; }
                /*
                return new Response
                {
                    Status = "Success",
                    Message = "SuccessFully Saved."
                };*/

            }
            catch (Exception Ex)
            {
                //return "Invalid Data. " + Ex.Message;
                return "Invalid Data, Please try again.";
                /*
                return new Response
                {
                    Status = "Error",
                    Message = "Invalid Data. "+Ex.Message
                };*/
            }

        }



        [Route("Api/IMHI/Newenquerylist")]
        [HttpGet]
        public object Newenquerylist(Newenquerylist objCustomerDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("Newenquerylist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                { return "Fail"; }

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



    

