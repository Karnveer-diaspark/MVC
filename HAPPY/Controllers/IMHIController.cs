using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HAPPY.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

namespace HAPPY.Controllers
{
    public class IMHIController : ApiController
    {
        //For new use Register
        [Route("Api/IMHI/UpdateCustomer")]
        [HttpPost]
        public object UpdateCustomer(CustomerDetail objCustomerDetail)
        {
            try
            {
                string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                SqlConnection con = new SqlConnection(strcon);
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

        //For new user  Enquiry 
        [Route("Api/IMHI/InsertEnquiry")]
        [HttpPost]
        public object InsertEnquiry(newEnquiry objEnquiry)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

                 //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                 //SqlConnection con = new SqlConnection(strcon);


                SqlCommand cmd = new SqlCommand("MasterInsertUpdateDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Firstname", objEnquiry.Firstname);
                cmd.Parameters.AddWithValue("@Middlename", objEnquiry.MiddleName);
                cmd.Parameters.AddWithValue("@Lastname", objEnquiry.Lastname);
                cmd.Parameters.AddWithValue("@Email", objEnquiry.Email);
                cmd.Parameters.AddWithValue("@ContactNo", objEnquiry.ContactNo);
                cmd.Parameters.AddWithValue("@PolicyMasterID", objEnquiry.PolicyMasterID);



                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "sucess";
                }
                else
                { return "Fail"; }

              
            }
            catch (Exception ex)
            {
                return new Response
                {
                    Status = "Fail",
                    Message = "Invalid Data"

                };
            }
        }

        //For show CustomerList
        [Route("Api/IMHI/GetEnquiryCustomerList")]
        [HttpGet]
        public object GetEnquiryCustomerList(CustomerDetail objCustomerDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
               //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spGetEnquiryCustomerList", con);
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



        //For new user Payment
        [Route("Api/IMHI/Payment")]
        [HttpPost]
        public object Payment(PolicyTransaction objCustomerPayment)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
                //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@TransactionID", objCustomerPayment.TransactionID);
                cmd.Parameters.AddWithValue("@BankName", objCustomerPayment.BankName);
                cmd.Parameters.AddWithValue("@ChequeNumber", objCustomerPayment.ChequeNumber);
                cmd.Parameters.AddWithValue("@PolicyDetailID", objCustomerPayment.PolicyDetailID);
                cmd.Parameters.AddWithValue("@DateTimeStamp", objCustomerPayment.DateTimeStamp);

                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "sucess";
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


        //For PolicyDetail
        [Route("Api/IMHI/PolicyDetail")]
        [HttpPost]
        public object PolicyDetail(CustomerPolicyDetail objPolicyDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spCustomerPolicyDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PolicyMasterID", objPolicyDetail.PolicyMasterID);
                cmd.Parameters.AddWithValue("@SumAssured", objPolicyDetail.SumAssured);
                cmd.Parameters.AddWithValue("@StartDate", objPolicyDetail.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", objPolicyDetail.EndDate);
                cmd.Parameters.AddWithValue("@CustomerID", 0);

                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "sucess";
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



        //For show CustomerList
        [Route("Api/IMHI/GetEnquiry")]
        [HttpGet]
        public object GetEnquiry(CustomerDetail objCustomerDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
               //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spGetEnquiry", con);
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



        //For show CustomerList
        [Route("Api/IMHI/GetEnquiryList")]
        [HttpGet]
        public object GetEnquiryList(CustomerDetail objCustomerDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

                //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spGetEnquiryList", con);
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



        //For show CustomerIDList
        [Route("Api/IMHI/GetCustomerIDList")]
        [HttpGet]
        public object GetCustomerIDList(CustomerDetail objCustomerDetail)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

                //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SelectCustomerIDList", con);
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


        //For Admin
        [Route("Api/IMHI/GETAdmin")]
        [HttpPost]
        public object GetAdmin(Admin ObjCustomer )
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
               

                //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("spGETadmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = ObjCustomer.CustomerID;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
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


        //For ContactUs
        [Route("Api/IMHI/ContactUs")]
        [HttpPost]
        public object contactus(contactus objContactUs)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

                //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spcontact", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FullName", objContactUs.FullName);
                cmd.Parameters.AddWithValue("@Email", objContactUs.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", objContactUs.PhoneNumber);
                cmd.Parameters.AddWithValue("@Message", objContactUs.Message);
                //cmd.Parameters.AddWithValue("@ContactusID", objContactUs.ContactusID);
                con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    return "sucess";
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



        // New API approved

        [Route("Api/IMHI/PolicyApproval")]
        [HttpPost]
        public object PolicyApproval(Approved objapproved)
        {
            try
            {
                string strNewPassword = GeneratePassword().ToString();

                SqlDataAdapter DA = new SqlDataAdapter();
                DataTable DT = new DataTable();
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("sp_approved", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", objapproved.CustomerID);
                cmd.Parameters.AddWithValue("@PolicyDetailID", objapproved.PolicyDetailID);
                cmd.Parameters.AddWithValue("@Status", objapproved.Status);
                //cmd.Parameters.AddWithValue("@RejectionReason", objapproved.RejectionReason);
                cmd.Parameters.AddWithValue("@Password", strNewPassword);


                con.Open();
                //int k = cmd.ExecuteNonQuery();

                DA = new SqlDataAdapter(cmd);

                DA.Fill(DT);
                if (DT != null && DT.Rows.Count > 0)

                {
                    string email = DT.Rows[0]["Email"].ToString();

                    if (objapproved.Status == "Approved")
                    {
                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("ayushimalviya1997@gmail.com", "@ayushI25"),
                            EnableSsl = true
                        };
                        client.Send("ayushimalviya1997@gmail.com", email, "Policy Approved ", "Your Policy is Approved.Please login in portal and check further detail with below password .Your Random password is:" + strNewPassword);
                    } 
                    else
                    {
                        var client = new SmtpClient("smtp.gmail.com",587)
                        {
                            Credentials = new NetworkCredential("ayushimalviya1997@gmail.com", "@ayushI25"),
                            EnableSsl = true
                        };
                        client.Send("ayushimalviya1997@gmail.com", email, "Policy Disaproved", "Your claim is DisApproved by company admin .");

                    }

                    return "sucess";
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

        public string GeneratePassword()
        {
            string PasswordLength = "8";
            string NewPassword = "";

            string allowedChars = "";
            allowedChars = "1,2,3,4,5,6,7,8,9,0";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";


            char[] sep = {
            ','
        };
            string[] arr = allowedChars.Split(sep);


            string IDString = "";
            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                IDString += temp;
                NewPassword = IDString;

            }
            return NewPassword;

        }
        //For GETcontactus
        [Route("Api/IMHI/GETcontactus")]
        [HttpGet]
        public object Getcontactus(contactus objcontactus)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spGETcontactus", con);
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

        //For GetUserLoginStatus
        [Route("Api/IMHI/GetUserLoginStatus")]
        [HttpPost]
        public object GetUserLoginStatus(UserLoginStatus objUserLoginStatus)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");

               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("spCheckLoginStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmailId", objUserLoginStatus.UserId);
                cmd.Parameters.AddWithValue("@Password", objUserLoginStatus.Password);

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


        //For Agent
        [Route("Api/IMHI/GETEnquiryAgent")]
        [HttpPost]
        public object GetEnquiryAgent(newEnquiry Obj)
        {
            try
            {

                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS8I9A6;Initial Catalog=happy;Integrated Security=True");
                

               //string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                //SqlConnection con = new SqlConnection(strcon);
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetEnquiryAgent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EnquiryID", SqlDbType.Int);
                cmd.Parameters["@EnquiryID"].Value = Obj.EnquiryID;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

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



    

