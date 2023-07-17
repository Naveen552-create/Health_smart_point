using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data;
using System.Configuration;
using System.Web.Services;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        string constring = @"Data Source=LAPTOP-B3UIQKN2;Initial Catalog=Svec;User Id=sa;Password=1234";

        [HttpGet]
        public ViewResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from Studentregister where Username='" + obj.Username + "' and Password='" + obj.Password + "'";
            SqlCommand Cmd = new SqlCommand(query, con);
            SqlDataReader dr = Cmd.ExecuteReader();
            if (dr.Read())
            {
                return RedirectToAction("adminpage");
            }
            else
            {
                ViewBag.msg = "Login failed";
            }

            return View();
        }

        [HttpGet]
        public ViewResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Modelclass obj)
        {

            string Username = obj.Username;
            string Password = obj.Password;
            
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Studentregister(Username,Password) values('" + obj.Username + "','" + obj.Password + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {
                ViewBag.msg = "Registration Successfully";
            }
            else
            {
                ViewBag.msg = "Registration failed";
            }

            return View();
        }

        [HttpGet]
        public ViewResult Home()
        {
           
           
            return View();
        }


        [HttpGet]
        public ViewResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from UserRegister where Username='" + obj.Username + "' and Password='" + obj.Password + "'";
            SqlCommand Cmd = new SqlCommand(query, con);
            SqlDataReader dr = Cmd.ExecuteReader();
            if (dr.Read())
            {
                
                return RedirectToAction("first");
            }
            else
            {
                ViewBag.msg = "Login failed";
            }

            return View();

        }
        [HttpGet]
        public ViewResult adminpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult UserSignup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserSignup(Modelclass obj)
        {
            string Name = obj.Name;
            string Email = obj.Email;
            string Phone = obj.Phone;
            string Username = obj.Username;
            string Password = obj.Password;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into UserRegister(Name,Email,Phone,Username,Password) values('" + obj.Name + "','" + obj.Email + "','" + obj.Phone + "','" + obj.Username + "','" + obj.Password + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {
              
                ViewBag.msg = "Registration Successfull";
            }
            else
            {
                ViewBag.msg = "Registration failed";
            }
            ModelState.Clear();
            return RedirectToAction("UserLogin");
        }

        [HttpGet]
        public ViewResult first()
        {
            return View();
        }

         [HttpGet]
        public ViewResult Forgotpassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forgotpassword(string Email, string Password)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            string querystring = "UPDATE UserRegister SET Password='" + Password + "' where Email = '" + Email + "'";
            SqlCommand cmdText = new SqlCommand(querystring, conn);
            int row = cmdText.ExecuteNonQuery();
            if (row > 0)
            {
                ViewBag.message = "Updated Successfully";
            }
            else
            {
                ViewBag.message = "Invalid Email";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Admincard()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statelocation()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statelocation1()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statelocation2()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statelocation3()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statelocation4()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Andhrapradesh()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Andhrapradesh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Andhrapradesh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Arunachalpradesh()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Arunachalpradesh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Arunachalpradesh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Assam()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Assam(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Assam(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Bihar()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Bihar(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Bihar(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Chhattisgarh()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Chhattisgarh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Chhattisgarh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Goa()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Goa(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Goa(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Gujarat()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Gujarat(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Gujarat(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Haryana()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Haryana(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Haryana(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Himachalpradesh()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Himachalpradesh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Himachalpradesh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jammu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jammu(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jammu(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jharkhand()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jharkhand(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jharkhand(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Karnataka()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Karnataka(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Karnataka(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Kerala()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kerala(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Kerala(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Madhyapradesh()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Madhyapradesh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Madhyapradesh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Manipur()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Manipur(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Manipur(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Meghalaya()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Meghalaya(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Meghalaya(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Maharashtra()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Maharashtra(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Maharashtra(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Mizoram()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mizoram(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Mizoram(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Nagaland()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Nagaland(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Nagaland(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Odsiha()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Odsiha(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Odsiha(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Punjab()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Punjab(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Punjab(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Rajasthan()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Rajasthan(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Rajasthan(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Sikkim()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Sikkim(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Sikkim(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tamilnadu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tamilnadu(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tamilnadu(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Telangana()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Telangana(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Telangana(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tripua()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tripua(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tripua(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarpradesh()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarpradesh(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarpradesh(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarakhand()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarakhand(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarakhand(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult  Westbengal()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Westbengal(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Westbengal(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }


        [HttpGet]
        public ViewResult Andhrapradesh1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Andhrapradesh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Andhrapradesh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Arunachalpradesh1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Arunachalpradesh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Arunachalpradesh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Assam1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Assam1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Assam1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Bihar1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Bihar1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Bihar1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Chhattisgarh1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Chhattisgarh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Chhattisgarh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Goa1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Goa1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Goa1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Gujarat1()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Gujarat1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Gujarat1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Haryana1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Haryana1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Haryana1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Himachalpradesh1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Himachalpradesh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Himachalpradesh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jammu1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jammu1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jammu1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jharkhand1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jharkhand1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jharkhand1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Karnataka1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Karnataka1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Karnataka1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Kerala1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kerala1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Kerala1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Madhyapradesh1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Madhyapradesh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Madhyapradesh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Manipur1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Manipur1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Manipur1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Maharashtra1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Maharashtra1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Maharashtra1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Meghalaya1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Meghalaya1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Meghalaya1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Mizoram1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mizoram1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Mizoram1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Nagaland1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Nagaland1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Nagaland1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Odsiha1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Odsiha1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Odsiha1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Punjab1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Punjab1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Punjab1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Rajasthan1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Rajasthan1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Rajasthan1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Sikkim1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Sikkim1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Sikkim1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tamilnadu1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tamilnadu1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tamilnadu1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Telangana1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Telangana1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Telangana1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tripua1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tripua1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tripua1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarpradesh1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarpradesh1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarpradesh1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarakhand1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarakhand1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarakhand1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Westbengal1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Westbengal1(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Westbengal1(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }



        [HttpGet]
        public ViewResult Andhrapradesh2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Andhrapradesh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Andhrapradesh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Arunachalpradesh2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Arunachalpradesh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Arunachalpradesh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Assam2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Assam2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Assam2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Bihar2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Bihar2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Bihar2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Chhattisgarh2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Chhattisgarh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Chhattisgarh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Goa2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Goa2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Goa2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Gujarat2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Gujarat2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Gujarat2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Haryana2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Haryana2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Haryana2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Himachalpradesh2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Himachalpradesh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Himachalpradesh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jammu2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jammu2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jammu2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jharkhand2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jharkhand2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jharkhand2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Karnataka2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Karnataka2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Karnataka2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Kerala2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kerala2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Kerala2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Maharashtra2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Maharashtra2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Maharashtra2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Madhyapradesh2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Madhyapradesh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Madhyapradesh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Manipur2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Manipur2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Manipur2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Meghalaya2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Meghalaya2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Meghalaya2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Mizoram2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mizoram2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Mizoram2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Nagaland2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Nagaland2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Nagaland2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Odsiha2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Odsiha2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Odsiha2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Punjab2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Punjab2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Punjab2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Rajasthan2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Rajasthan2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Rajasthan2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Sikkim2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Sikkim2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Sikkim2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tamilnadu2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tamilnadu2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tamilnadu2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Telangana2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Telangana2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Telangana2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tripua2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tripua2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tripua2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarpradesh2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarpradesh2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarpradesh2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarakhand2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarakhand2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarakhand2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Westbengal2()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Westbengal2(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Westbengal2(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }



        [HttpGet]
        public ViewResult Andhrapradesh3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Andhrapradesh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Andhrapradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Arunachalpradesh3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Arunachalpradesh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Arunachalpradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Assam3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Assam3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Assam3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Bihar3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Bihar3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Bihar3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Chhattisgarh3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Chhattisgarh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Chhattisgarh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Goa3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Goa3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Goa3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Gujarat3()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Gujarat3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Gujarat3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Haryana3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Haryana3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Haryana3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Himachalpradesh3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Himachalpradesh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Himachalpradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jammu3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jammu3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jammu3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jharkhand3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jharkhand3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jharkhand3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Karnataka3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Karnataka3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Karnataka3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Kerala3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kerala3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Kerala3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Madhyapradesh3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Madhyapradesh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Madhyapradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Maharashtra3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Maharashtra3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Maharashtra3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Manipur3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Manipur3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Manipur3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Meghalaya3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Meghalaya3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Meghalaya3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Mizoram3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mizoram3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Mizoram3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Nagaland3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Nagaland3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Nagaland3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Odsiha3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Odsiha3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Odsiha3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Punjab3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Punjab3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Punjab3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Rajasthan3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Rajasthan3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Rajasthan3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Sikkim3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Sikkim3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Sikkim3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tamilnadu3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tamilnadu3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tamilnadu3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Telangana3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Telangana3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Telangana3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tripua3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tripua3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tripua3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarpradesh3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarpradesh3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarpradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarakhand3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarakhand3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarakhand3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Westbengal3()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Westbengal3(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Westbengal3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }



        [HttpGet]
        public ViewResult Andhrapradesh4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Andhrapradesh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Andhrapradesh4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Arunachalpradesh4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Arunachalpradesh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Arunachalpradesh4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Assam4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Assam4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Assam4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Bihar4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Bihar4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Bihar4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Chhattisgarh4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Chhattisgarh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Chhattisgarh4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Goa4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Goa4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Goa4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Gujarat4()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Gujarat4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Gujarat4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Haryana4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Haryana4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Haryana4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Himachalpradesh4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Himachalpradesh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Himachalpradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jammu4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jammu4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jammu4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Jharkhand4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Jharkhand4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Jharkhand4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Karnataka4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Karnataka4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Karnataka4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Kerala4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kerala4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Kerala4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Maharashtra4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Maharashtra4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Maharashtra4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Madhyapradesh4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Madhyapradesh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Madhyapradesh4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult Manipur4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Manipur4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Manipur4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Meghalaya4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Meghalaya4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Meghalaya4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Mizoram4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mizoram4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Mizoram4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Nagaland4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Nagaland4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Nagaland4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Odsiha4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Odsiha4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Odsiha4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Punjab4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Punjab4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Punjab4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Rajasthan4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Rajasthan4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Rajasthan4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Sikkim4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Sikkim4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Sikkim4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tamilnadu4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tamilnadu4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tamilnadu4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Telangana4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Telangana4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Telangana3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Tripua4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Tripua4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Tripua4(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarpradesh4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarpradesh4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarpradesh3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Uttarakhand4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Uttarakhand4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Uttarakhand3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ViewResult Westbengal4()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Westbengal4(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Westbengal3(Hospitalname,Type,Ambulance,Beds,Oxygen,PhoneNumber,Hospitaladdress) values('" + obj.Hospitalname + "','" + obj.Type + "','" + obj.Ambulance + "','" + obj.Beds + "','" + obj.Oxygen + "','" + obj.PhoneNumber + "','" + obj.Hospitaladdress + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Saved Successfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
        }


        [HttpGet]
        public ViewResult Statepage()
        {
            return View();
        }

        private List<Modelclass> Andhrapradesh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Andhrapradesh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userandhrapradesh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userandhrapradesh.Add(obj);
            }
            return Userandhrapradesh;
        }
        [HttpGet]
        public ViewResult Userandhrapradesh()
        {
            List<Modelclass> Userandhrapradesh = Andhrapradesh5();
            Userandhrapradesh = Andhrapradesh5();
            return View(Userandhrapradesh);
            
        }

        private List<Modelclass> Andhrapradesh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Andhrapradesh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userandhrapradesh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userandhrapradesh1.Add(obj);
            }
            return Userandhrapradesh1;
        }
        [HttpGet]
        public ViewResult Userandhrapradesh1()
        {
            List<Modelclass> Userandhrapradesh1 = Andhrapradesh6();
            Userandhrapradesh1 = Andhrapradesh6();
            return View(Userandhrapradesh1);

        }

        private List<Modelclass> Andhrapradesh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Andhrapradesh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userandhrapradesh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userandhrapradesh2.Add(obj);
            }
            return Userandhrapradesh2;
        }
        [HttpGet]
        public ViewResult Userandhrapradesh2()
        {
            List<Modelclass> Userandhrapradesh2 = Andhrapradesh7();
            Userandhrapradesh2 = Andhrapradesh7();
            return View(Userandhrapradesh2);

        }

        private List<Modelclass> Andhrapradesh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Andhrapradesh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userandhrapradesh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userandhrapradesh3.Add(obj);
            }
            return Userandhrapradesh3;
        }
        [HttpGet]
        public ViewResult Userandhrapradesh3()
        {
            List<Modelclass> Userandhrapradesh3 = Andhrapradesh8();
            Userandhrapradesh3 = Andhrapradesh8();
            return View(Userandhrapradesh3);

        }

        private List<Modelclass> Andhrapradesh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Andhrapradesh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userandhrapradesh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userandhrapradesh4.Add(obj);
            }
            return Userandhrapradesh4;
        }
        [HttpGet]
        public ViewResult Userandhrapradesh4()
        {
            List<Modelclass> Userandhrapradesh4 = Andhrapradesh9();
            Userandhrapradesh4 = Andhrapradesh9();
            return View(Userandhrapradesh4);

        }

        private List<Modelclass> Arunachalpradesh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Arunachalpradesh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userarunachalpradesh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userarunachalpradesh.Add(obj);
            }
            return Userarunachalpradesh;
        }
        [HttpGet]
        public ViewResult Userarunachalpradesh()
        {
            List<Modelclass> Userarunachalpradesh = Arunachalpradesh5();
            Userarunachalpradesh = Arunachalpradesh5();
            return View(Userarunachalpradesh);

        }

        private List<Modelclass> Arunachalpradesh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Arunachalpradesh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userarunachalpradesh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userarunachalpradesh1.Add(obj);
            }
            return Userarunachalpradesh1;
        }
        [HttpGet]
        public ViewResult Userarunachalpradesh1()
        {
            List<Modelclass> Userarunachalpradesh1 = Arunachalpradesh6();
            Userarunachalpradesh1 = Arunachalpradesh6();
            return View(Userarunachalpradesh1);

        }

        private List<Modelclass> Arunachalpradesh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Arunachalpradesh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userarunachalpradesh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userarunachalpradesh2.Add(obj);
            }
            return Userarunachalpradesh2;
        }
        [HttpGet]
        public ViewResult Userarunachalpradesh2()
        {
            List<Modelclass> Userarunachalpradesh2 = Arunachalpradesh7();
            Userarunachalpradesh2 = Arunachalpradesh7();
            return View(Userarunachalpradesh2);

        }

        private List<Modelclass> Arunachalpradesh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Arunachalpradesh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userarunachalpradesh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userarunachalpradesh3.Add(obj);
            }
            return Userarunachalpradesh3;
        }
        [HttpGet]
        public ViewResult Userarunachalpradesh3()
        {
            List<Modelclass> Userarunachalpradesh3 = Arunachalpradesh8();
            Userarunachalpradesh3 = Arunachalpradesh8();
            return View(Userarunachalpradesh3);

        }

        private List<Modelclass> Arunachalpradesh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Arunachalpradesh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Userarunachalpradesh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                Userarunachalpradesh4.Add(obj);
            }
            return Userarunachalpradesh4;
        }
        [HttpGet]
        public ViewResult Userarunachalpradesh4()
        {
            List<Modelclass> Userarunachalpradesh4 = Arunachalpradesh9();
            Userarunachalpradesh4 = Arunachalpradesh9();
            return View(Userarunachalpradesh4);

        }

        private List<Modelclass> Assam5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Assam";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserAssam = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserAssam.Add(obj);
            }
            return UserAssam;
        }
        [HttpGet]
        public ViewResult UserAssam()
        {
            List<Modelclass> UserAssam = Assam5();
            UserAssam = Assam5();
            return View(UserAssam);

        }

        private List<Modelclass> Assam6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Assam1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserAssam1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserAssam1.Add(obj);
            }
            return UserAssam1;
        }
        [HttpGet]
        public ViewResult UserAssam1()
        {
            List<Modelclass> UserAssam1 = Assam6();
            UserAssam1 = Assam6();
            return View(UserAssam1);

        }

        private List<Modelclass> Assam7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Assam2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserAssam2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserAssam2.Add(obj);
            }
            return UserAssam2;
        }
        [HttpGet]
        public ViewResult UserAssam2()
        {
            List<Modelclass> UserAssam2 = Assam7();
            UserAssam2 = Assam7();
            return View(UserAssam2);

        }

        private List<Modelclass> Assam8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Assam3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserAssam3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserAssam3.Add(obj);
            }
            return UserAssam3;
        }
        [HttpGet]
        public ViewResult UserAssam3()
        {
            List<Modelclass> UserAssam3 = Assam8();
            UserAssam3 = Assam8();
            return View(UserAssam3);

        }

        private List<Modelclass> Assam9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Assam4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserAssam4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserAssam4.Add(obj);
            }
            return UserAssam4;
        }
        [HttpGet]
        public ViewResult UserAssam4()
        {
            List<Modelclass> UserAssam4 = Assam9();
            UserAssam4 = Assam9();
            return View(UserAssam4);

        }

        private List<Modelclass> Bihar5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Bihar";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserBihar = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserBihar.Add(obj);
            }
            return UserBihar;
        }
        [HttpGet]
        public ViewResult UserBihar()
        {
            List<Modelclass> UserBihar = Bihar5();
            UserBihar = Bihar5();
            return View(UserBihar);

        }

        private List<Modelclass> Bihar6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Bihar1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserBihar1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserBihar1.Add(obj);
            }
            return UserBihar1;
        }
        [HttpGet]
        public ViewResult UserBihar1()
        {
            List<Modelclass> UserBihar1 = Bihar6();
            UserBihar1 = Bihar6();
            return View(UserBihar1);

        }

        private List<Modelclass> Bihar7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Bihar2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserBihar2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserBihar2.Add(obj);
            }
            return UserBihar2;
        }
        [HttpGet]
        public ViewResult UserBihar2()
        {
            List<Modelclass> UserBihar2 = Bihar7();
            UserBihar2 = Bihar7();
            return View(UserBihar2);

        }

        private List<Modelclass> Bihar8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Bihar3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserBihar3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserBihar3.Add(obj);
            }
            return UserBihar3;
        }
        [HttpGet]
        public ViewResult UserBihar3()
        {
            List<Modelclass> UserBihar3 = Bihar8();
            UserBihar3 = Bihar8();
            return View(UserBihar3);

        }

        private List<Modelclass> Bihar9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Bihar4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserBihar4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserBihar4.Add(obj);
            }
            return UserBihar4;
        }
        [HttpGet]
        public ViewResult UserBihar4()
        {
            List<Modelclass> UserBihar4 = Bihar9();
            UserBihar4 = Bihar9();
            return View(UserBihar4);

        }


        private List<Modelclass> Chhattisgarh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Chhattisgarh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserChhattisgarh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserChhattisgarh.Add(obj);
            }
            return UserChhattisgarh;
        }
        [HttpGet]
        public ViewResult UserChhattisgarh()
        {
            List<Modelclass> UserChhattisgarh = Chhattisgarh5();
            UserChhattisgarh = Chhattisgarh5();
            return View(UserChhattisgarh);

        }

        private List<Modelclass> Chhattisgarh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Chhattisgarh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserChhattisgarh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserChhattisgarh1.Add(obj);
            }
            return UserChhattisgarh1;
        }
        [HttpGet]
        public ViewResult UserChhattisgarh1()
        {
            List<Modelclass> UserChhattisgarh1 = Chhattisgarh6();
            UserChhattisgarh1 = Chhattisgarh6();
            return View(UserChhattisgarh1);

        }

        private List<Modelclass> Chhattisgarh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Chhattisgarh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserChhattisgarh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserChhattisgarh2.Add(obj);
            }
            return UserChhattisgarh2;
        }
        [HttpGet]
        public ViewResult UserChhattisgarh2()
        {
            List<Modelclass> UserChhattisgarh2 = Chhattisgarh7();
            UserChhattisgarh2 = Chhattisgarh7();
            return View(UserChhattisgarh2);

        }

        private List<Modelclass> Chhattisgarh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Chhattisgarh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserChhattisgarh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserChhattisgarh3.Add(obj);
            }
            return UserChhattisgarh3;
        }
        [HttpGet]
        public ViewResult UserChhattisgarh3()
        {
            List<Modelclass> UserChhattisgarh3 = Chhattisgarh8();
            UserChhattisgarh3 = Chhattisgarh8();
            return View(UserChhattisgarh3);

        }

        private List<Modelclass> Chhattisgarh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Chhattisgarh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserChhattisgarh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserChhattisgarh4.Add(obj);
            }
            return UserChhattisgarh4;
        }
        [HttpGet]
        public ViewResult UserChhattisgarh4()
        {
            List<Modelclass> UserChhattisgarh4 = Chhattisgarh9();
            UserChhattisgarh4 = Chhattisgarh9();
            return View(UserChhattisgarh4);

        }


        private List<Modelclass> Goa5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Goa";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGoa = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGoa.Add(obj);
            }
            return UserGoa;
        }
        [HttpGet]
        public ViewResult UserGoa()
        {
            List<Modelclass> UserGoa = Goa5();
            UserGoa = Goa5();
            return View(UserGoa);

        }

        private List<Modelclass> Goa6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Goa1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGoa1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGoa1.Add(obj);
            }
            return UserGoa1;
        }
        [HttpGet]
        public ViewResult UserGoa1()
        {
            List<Modelclass> UserGoa1 = Goa6();
            UserGoa1 = Goa6();
            return View(UserGoa1);

        }

        private List<Modelclass> Goa7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Goa2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGoa2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGoa2.Add(obj);
            }
            return UserGoa2;
        }
        [HttpGet]
        public ViewResult UserGoa2()
        {
            List<Modelclass> UserGoa2 = Goa7();
            UserGoa2 = Goa7();
            return View(UserGoa2);

        }

        private List<Modelclass> Goa8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Goa3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGoa3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGoa3.Add(obj);
            }
            return UserGoa3;
        }
        [HttpGet]
        public ViewResult UserGoa3()
        {
            List<Modelclass> UserGoa3 = Goa8();
            UserGoa3 = Goa8();
            return View(UserGoa3);

        }

        private List<Modelclass> Goa9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Goa4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGoa4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGoa4.Add(obj);
            }
            return UserGoa4;
        }
        [HttpGet]
        public ViewResult UserGoa4()
        {
            List<Modelclass> UserGoa4 = Goa9();
            UserGoa4 = Goa9();
            return View(UserGoa4);

        }


        private List<Modelclass> Gujarat5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Gujarat";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGujarat = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGujarat.Add(obj);
            }
            return UserGujarat;
        }
        [HttpGet]
        public ViewResult UserGujarat()
        {
            List<Modelclass> UserGujarat = Gujarat5();
            UserGujarat = Gujarat5();
            return View(UserGujarat);

        }


        private List<Modelclass> Gujarat6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Gujarat1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGujarat1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGujarat1.Add(obj);
            }
            return UserGujarat1;
        }
        [HttpGet]
        public ViewResult UserGujarat1()
        {
            List<Modelclass> UserGujarat1 = Gujarat6();
            UserGujarat1 = Gujarat6();
            return View(UserGujarat1);

        }

        private List<Modelclass> Gujarat7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Gujarat2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGujarat2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGujarat2.Add(obj);
            }
            return UserGujarat2;
        }
        [HttpGet]
        public ViewResult UserGujarat2()
        {
            List<Modelclass> UserGujarat2 = Gujarat7();
            UserGujarat2 = Gujarat7();
            return View(UserGujarat2);

        }

        private List<Modelclass> Gujarat8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Gujarat3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGujarat3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGujarat3.Add(obj);
            }
            return UserGujarat3;
        }
        [HttpGet]
        public ViewResult UserGujarat3()
        {
            List<Modelclass> UserGujarat3 = Gujarat8();
            UserGujarat3 = Gujarat8();
            return View(UserGujarat3);

        }

        private List<Modelclass> Gujarat9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Gujarat4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserGujarat4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserGujarat4.Add(obj);
            }
            return UserGujarat4;
        }
        [HttpGet]
        public ViewResult UserGujarat4()
        {
            List<Modelclass> UserGujarat4 = Gujarat9();
            UserGujarat4 = Gujarat9();
            return View(UserGujarat4);

        }

        private List<Modelclass> Haryana5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Haryana";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHaryana = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHaryana.Add(obj);
            }
            return UserHaryana;
        }
        [HttpGet]
        public ViewResult UserHaryana()
        {
            List<Modelclass> UserHaryana = Haryana5();
            UserHaryana = Haryana5();
            return View(UserHaryana);

        }

        private List<Modelclass> Haryana6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Haryana1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHaryana1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHaryana1.Add(obj);
            }
            return UserHaryana1;
        }
        [HttpGet]
        public ViewResult UserHaryana1()
        {
            List<Modelclass> UserHaryana1 = Haryana6();
            UserHaryana1 = Haryana6();
            return View(UserHaryana1);

        }

        private List<Modelclass> Haryana7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Haryana2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHaryana2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHaryana2.Add(obj);
            }
            return UserHaryana2;
        }
        [HttpGet]
        public ViewResult UserHaryana2()
        {
            List<Modelclass> UserHaryana2 = Haryana7();
            UserHaryana2 = Haryana7();
            return View(UserHaryana2);

        }

        private List<Modelclass> Haryana8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Haryana3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHaryana3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHaryana3.Add(obj);
            }
            return UserHaryana3;
        }
        [HttpGet]
        public ViewResult UserHaryana3()
        {
            List<Modelclass> UserHaryana3 = Haryana8();
            UserHaryana3 = Haryana8();
            return View(UserHaryana3);

        }

        private List<Modelclass> Haryana9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Haryana4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHaryana4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHaryana4.Add(obj);
            }
            return UserHaryana4;
        }
        [HttpGet]
        public ViewResult UserHaryana4()
        {
            List<Modelclass> UserHaryana4 = Haryana9();
            UserHaryana4 = Haryana9();
            return View(UserHaryana4);

        }

        private List<Modelclass> Himachalpradesh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Himachalpradesh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHimachalpradesh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHimachalpradesh.Add(obj);
            }
            return UserHimachalpradesh;
        }
        [HttpGet]
        public ViewResult UserHimachalpradesh()
        {
            List<Modelclass> UserHimachalpradesh = Himachalpradesh5();
            UserHimachalpradesh = Himachalpradesh5();
            return View(UserHimachalpradesh);

        }

        private List<Modelclass> Himachalpradesh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Himachalpradesh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHimachalpradesh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHimachalpradesh1.Add(obj);
            }
            return UserHimachalpradesh1;
        }
        [HttpGet]
        public ViewResult UserHimachalpradesh1()
        {
            List<Modelclass> UserHimachalpradesh1 = Himachalpradesh6();
            UserHimachalpradesh1 = Himachalpradesh6();
            return View(UserHimachalpradesh1);

        }

        private List<Modelclass> Himachalpradesh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Himachalpradesh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHimachalpradesh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHimachalpradesh2.Add(obj);
            }
            return UserHimachalpradesh2;
        }
        [HttpGet]
        public ViewResult UserHimachalpradesh2()
        {
            List<Modelclass> UserHimachalpradesh2 = Himachalpradesh7();
            UserHimachalpradesh2 = Himachalpradesh7();
            return View(UserHimachalpradesh2);

        }

        private List<Modelclass> Himachalpradesh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Himachalpradesh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHimachalpradesh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHimachalpradesh3.Add(obj);
            }
            return UserHimachalpradesh3;
        }
        [HttpGet]
        public ViewResult UserHimachalpradesh3()
        {
            List<Modelclass> UserHimachalpradesh3 = Himachalpradesh8();
            UserHimachalpradesh3 = Himachalpradesh8();
            return View(UserHimachalpradesh3);

        }

        private List<Modelclass> Himachalpradesh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Himachalpradesh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserHimachalpradesh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserHimachalpradesh4.Add(obj);
            }
            return UserHimachalpradesh4;
        }
        [HttpGet]
        public ViewResult UserHimachalpradesh4()
        {
            List<Modelclass> UserHimachalpradesh4 = Himachalpradesh9();
            UserHimachalpradesh4 = Himachalpradesh9();
            return View(UserHimachalpradesh4);

        }

        private List<Modelclass> Jammu5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jammu";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJammu = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJammu.Add(obj);
            }
            return UserJammu;
        }
        [HttpGet]
        public ViewResult UserJammu()
        {
            List<Modelclass> UserJammu = Jammu5();
            UserJammu = Jammu5();
            return View(UserJammu);

        }

        private List<Modelclass> Jammu6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jammu1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJammu1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJammu1.Add(obj);
            }
            return UserJammu1;
        }
        [HttpGet]
        public ViewResult UserJammu1()
        {
            List<Modelclass> UserJammu1 = Jammu6();
            UserJammu1 = Jammu6();
            return View(UserJammu1);

        }

        private List<Modelclass> Jammu7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jammu2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJammu2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJammu2.Add(obj);
            }
            return UserJammu2;
        }
        [HttpGet]
        public ViewResult UserJammu2()
        {
            List<Modelclass> UserJammu2 = Jammu7();
            UserJammu2 = Jammu7();
            return View(UserJammu2);

        }

        private List<Modelclass> Jammu8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jammu3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJammu3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJammu3.Add(obj);
            }
            return UserJammu3;
        }
        [HttpGet]
        public ViewResult UserJammu3()
        {
            List<Modelclass> UserJammu3 = Jammu8();
            UserJammu3 = Jammu8();
            return View(UserJammu3);

        }


        private List<Modelclass> Jammu9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jammu4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJammu4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJammu4.Add(obj);
            }
            return UserJammu4;
        }
        [HttpGet]
        public ViewResult UserJammu4()
        {
            List<Modelclass> UserJammu4 = Jammu9();
            UserJammu4 = Jammu9();
            return View(UserJammu4);

        }

        private List<Modelclass> Jharkhand5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jharkhand";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJharkhand = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJharkhand.Add(obj);
            }
            return UserJharkhand;
        }
        [HttpGet]
        public ViewResult UserJharkhand()
        {
            List<Modelclass> UserJharkhand = Jharkhand5();
            UserJharkhand = Jharkhand5();
            return View(UserJharkhand);

        }

        private List<Modelclass> Jharkhand6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jharkhand1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJharkhand1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJharkhand1.Add(obj);
            }
            return UserJharkhand1;
        }
        [HttpGet]
        public ViewResult UserJharkhand1()
        {
            List<Modelclass> UserJharkhand1 = Jharkhand6();
            UserJharkhand1 = Jharkhand6();
            return View(UserJharkhand1);

        }

        private List<Modelclass> Jharkhand7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jharkhand2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJharkhand2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJharkhand2.Add(obj);
            }
            return UserJharkhand2;
        }
        [HttpGet]
        public ViewResult UserJharkhand2()
        {
            List<Modelclass> UserJharkhand2 = Jharkhand7();
            UserJharkhand2 = Jharkhand7();
            return View(UserJharkhand2);

        }

        private List<Modelclass> Jharkhand8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jharkhand3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJharkhand3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJharkhand3.Add(obj);
            }
            return UserJharkhand3;
        }
        [HttpGet]
        public ViewResult UserJharkhand3()
        {
            List<Modelclass> UserJharkhand3 = Jharkhand8();
            UserJharkhand3 = Jharkhand8();
            return View(UserJharkhand3);

        }

        private List<Modelclass> Jharkhand9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Jharkhand4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserJharkhand4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserJharkhand4.Add(obj);
            }
            return UserJharkhand4;
        }
        [HttpGet]
        public ViewResult UserJharkhand4()
        {
            List<Modelclass> UserJharkhand4 = Jharkhand9();
            UserJharkhand4 = Jharkhand9();
            return View(UserJharkhand4);

        }

        private List<Modelclass> Karnataka5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Karnataka";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKarnataka = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKarnataka.Add(obj);
            }
            return UserKarnataka;
        }
        [HttpGet]
        public ViewResult UserKarnataka()
        {
            List<Modelclass> UserKarnataka = Karnataka5();
            UserKarnataka = Karnataka5();
            return View(UserKarnataka);

        }


        private List<Modelclass> Karnataka6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Karnataka1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKarnataka1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKarnataka1.Add(obj);
            }
            return UserKarnataka1;
        }
        [HttpGet]
        public ViewResult UserKarnataka1()
        {
            List<Modelclass> UserKarnataka1 = Karnataka6();
            UserKarnataka1 = Karnataka6();
            return View(UserKarnataka1);

        }

        private List<Modelclass> Karnataka7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Karnataka2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKarnataka2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKarnataka2.Add(obj);
            }
            return UserKarnataka2;
        }
        [HttpGet]
        public ViewResult UserKarnataka2()
        {
            List<Modelclass> UserKarnataka2 = Karnataka7();
            UserKarnataka2 = Karnataka7();
            return View(UserKarnataka2);

        }

        private List<Modelclass> Karnataka8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Karnataka3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKarnataka3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKarnataka3.Add(obj);
            }
            return UserKarnataka3;
        }
        [HttpGet]
        public ViewResult UserKarnataka3()
        {
            List<Modelclass> UserKarnataka3 = Karnataka8();
            UserKarnataka3 = Karnataka8();
            return View(UserKarnataka3);

        }

        private List<Modelclass> Karnataka9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Karnataka4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKarnataka4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKarnataka4.Add(obj);
            }
            return UserKarnataka4;
        }
        [HttpGet]
        public ViewResult UserKarnataka4()
        {
            List<Modelclass> UserKarnataka4 = Karnataka9();
            UserKarnataka4 = Karnataka9();
            return View(UserKarnataka4);

        }

        private List<Modelclass> Kerala5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Kerala";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKerala = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKerala.Add(obj);
            }
            return UserKerala;
        }
        [HttpGet]
        public ViewResult UserKerala()
        {
            List<Modelclass> UserKerala = Kerala5();
            UserKerala = Kerala5();
            return View(UserKerala);

        }

        private List<Modelclass> Kerala6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Kerala1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKerala1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKerala1.Add(obj);
            }
            return UserKerala1;
        }
        [HttpGet]
        public ViewResult UserKerala1()
        {
            List<Modelclass> UserKerala1 = Kerala6();
            UserKerala1 = Kerala6();
            return View(UserKerala1);

        }

        private List<Modelclass> Kerala7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Kerala2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKerala2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKerala2.Add(obj);
            }
            return UserKerala2;
        }
        [HttpGet]
        public ViewResult UserKerala2()
        {
            List<Modelclass> UserKerala2 = Kerala7();
            UserKerala2 = Kerala7();
            return View(UserKerala2);

        }

        private List<Modelclass> Kerala8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Kerala3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKerala3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKerala3.Add(obj);
            }
            return UserKerala3;
        }
        [HttpGet]
        public ViewResult UserKerala3()
        {
            List<Modelclass> UserKerala3 = Kerala8();
            UserKerala3 = Kerala8();
            return View(UserKerala3);

        }

        private List<Modelclass> Kerala9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Kerala4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserKerala4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserKerala4.Add(obj);
            }
            return UserKerala4;
        }
        [HttpGet]
        public ViewResult UserKerala4()
        {
            List<Modelclass> UserKerala4 = Kerala9();
            UserKerala4 = Kerala9();
            return View(UserKerala4);

        }

        private List<Modelclass> Maharashtra5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Maharashtra";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMaharashtra = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMaharashtra.Add(obj);
            }
            return UserMaharashtra;
        }
        [HttpGet]
        public ViewResult UserMaharashtra()
        {
            List<Modelclass> UserMaharashtra = Maharashtra5();
            UserMaharashtra = Maharashtra5();
            return View(UserMaharashtra);

        }


        private List<Modelclass> Maharashtra6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Maharashtra1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMaharashtra1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMaharashtra1.Add(obj);
            }
            return UserMaharashtra1;
        }
        [HttpGet]
        public ViewResult UserMaharashtra1()
        {
            List<Modelclass> UserMaharashtra1 = Maharashtra6();
            UserMaharashtra1 = Maharashtra6();
            return View(UserMaharashtra1);

        }

        private List<Modelclass> Maharashtra7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Maharashtra2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMaharashtra2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMaharashtra2.Add(obj);
            }
            return UserMaharashtra2;
        }
        [HttpGet]
        public ViewResult UserMaharashtra2()
        {
            List<Modelclass> UserMaharashtra2 = Maharashtra7();
            UserMaharashtra2 = Maharashtra7();
            return View(UserMaharashtra2);

        }

        private List<Modelclass> Maharashtra8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Maharashtra3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMaharashtra3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMaharashtra3.Add(obj);
            }
            return UserMaharashtra3;
        }
        [HttpGet]
        public ViewResult UserMaharashtra3()
        {
            List<Modelclass> UserMaharashtra3 = Maharashtra8();
            UserMaharashtra3 = Maharashtra8();
            return View(UserMaharashtra3);

        }

        private List<Modelclass> Maharashtra9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Maharashtra4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMaharashtra4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMaharashtra4.Add(obj);
            }
            return UserMaharashtra4;
        }
        [HttpGet]
        public ViewResult UserMaharashtra4()
        {
            List<Modelclass> UserMaharashtra4 = Maharashtra9();
            UserMaharashtra4 = Maharashtra9();
            return View(UserMaharashtra4);

        }

        private List<Modelclass> Madhyapradesh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Madhyapradesh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMadhyapradesh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMadhyapradesh.Add(obj);
            }
            return UserMadhyapradesh;
        }
        [HttpGet]
        public ViewResult UserMadhyapradesh()
        {
            List<Modelclass> UserMadhyapradesh = Madhyapradesh5();
            UserMadhyapradesh = Madhyapradesh5();
            return View(UserMadhyapradesh);

        }

        private List<Modelclass> Madhyapradesh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Madhyapradesh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMadhyapradesh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMadhyapradesh1.Add(obj);
            }
            return UserMadhyapradesh1;
        }
        [HttpGet]
        public ViewResult UserMadhyapradesh1()
        {
            List<Modelclass> UserMadhyapradesh1 = Madhyapradesh6();
            UserMadhyapradesh1 = Madhyapradesh6();
            return View(UserMadhyapradesh1);

        }

        private List<Modelclass> Madhyapradesh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Madhyapradesh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMadhyapradesh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMadhyapradesh2.Add(obj);
            }
            return UserMadhyapradesh2;
        }
        [HttpGet]
        public ViewResult UserMadhyapradesh2()
        {
            List<Modelclass> UserMadhyapradesh2 = Madhyapradesh7();
            UserMadhyapradesh2 = Madhyapradesh7();
            return View(UserMadhyapradesh2);

        }

        private List<Modelclass> Madhyapradesh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Madhyapradesh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMadhyapradesh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMadhyapradesh3.Add(obj);
            }
            return UserMadhyapradesh3;
        }
        [HttpGet]
        public ViewResult UserMadhyapradesh3()
        {
            List<Modelclass> UserMadhyapradesh3 = Madhyapradesh8();
            UserMadhyapradesh3 = Madhyapradesh8();
            return View(UserMadhyapradesh3);

        }

        private List<Modelclass> Madhyapradesh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Madhyapradesh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMadhyapradesh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMadhyapradesh4.Add(obj);
            }
            return UserMadhyapradesh4;
        }
        [HttpGet]
        public ViewResult UserMadhyapradesh4()
        {
            List<Modelclass> UserMadhyapradesh4 = Madhyapradesh9();
            UserMadhyapradesh4 = Madhyapradesh9();
            return View(UserMadhyapradesh4);

        }

        private List<Modelclass> Manipur5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Manipur";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserManipur = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserManipur.Add(obj);
            }
            return UserManipur;
        }
        [HttpGet]
        public ViewResult UserManipur()
        {
            List<Modelclass> UserManipur = Manipur5();
            UserManipur = Manipur5();
            return View(UserManipur);

        }

        private List<Modelclass> Manipur6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Manipur1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserManipur1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserManipur1.Add(obj);
            }
            return UserManipur1;
        }
        [HttpGet]
        public ViewResult UserManipur1()
        {
            List<Modelclass> UserManipur1 = Manipur6();
            UserManipur1 = Manipur6();
            return View(UserManipur1);

        }

        private List<Modelclass> Manipur7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Manipur2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserManipur2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserManipur2.Add(obj);
            }
            return UserManipur2;
        }
        [HttpGet]
        public ViewResult UserManipur2()
        {
            List<Modelclass> UserManipur2 = Manipur7();
            UserManipur2 = Manipur7();
            return View(UserManipur2);

        }

        private List<Modelclass> Manipur8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Manipur3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserManipur3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserManipur3.Add(obj);
            }
            return UserManipur3;
        }
        [HttpGet]
        public ViewResult UserManipur3()
        {
            List<Modelclass> UserManipur3 = Manipur8();
            UserManipur3 = Manipur8();
            return View(UserManipur3);

        }

        private List<Modelclass> Manipur9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Manipur4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserManipur4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserManipur4.Add(obj);
            }
            return UserManipur4;
        }
        [HttpGet]
        public ViewResult UserManipur4()
        {
            List<Modelclass> UserManipur4 = Manipur9();
            UserManipur4 = Manipur9();
            return View(UserManipur4);

        }


        private List<Modelclass> Meghalaya5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Meghalaya";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMeghalaya = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMeghalaya.Add(obj);
            }
            return UserMeghalaya;
        }
        [HttpGet]
        public ViewResult UserMeghalaya()
        {
            List<Modelclass> UserMeghalaya = Meghalaya5();
            UserMeghalaya = Meghalaya5();
            return View(UserMeghalaya);

        }

        private List<Modelclass> Meghalaya6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Meghalaya1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMeghalaya1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMeghalaya1.Add(obj);
            }
            return UserMeghalaya1;
        }
        [HttpGet]
        public ViewResult UserMeghalaya1()
        {
            List<Modelclass> UserMeghalaya1 = Meghalaya6();
            UserMeghalaya1 = Meghalaya6();
            return View(UserMeghalaya1);

        }

        private List<Modelclass> Meghalaya7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Meghalaya2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMeghalaya2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMeghalaya2.Add(obj);
            }
            return UserMeghalaya2;
        }
        [HttpGet]
        public ViewResult UserMeghalaya2()
        {
            List<Modelclass> UserMeghalaya2 = Meghalaya7();
            UserMeghalaya2 = Meghalaya7();
            return View(UserMeghalaya2);

        }

        private List<Modelclass> Meghalaya8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Meghalaya3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMeghalaya3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMeghalaya3.Add(obj);
            }
            return UserMeghalaya3;
        }
        [HttpGet]
        public ViewResult UserMeghalaya3()
        {
            List<Modelclass> UserMeghalaya3 = Meghalaya8();
            UserMeghalaya3 = Meghalaya8();
            return View(UserMeghalaya3);

        }

        private List<Modelclass> Meghalaya9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Meghalaya4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMeghalaya4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMeghalaya4.Add(obj);
            }
            return UserMeghalaya4;
        }
        [HttpGet]
        public ViewResult UserMeghalaya4()
        {
            List<Modelclass> UserMeghalaya4 = Meghalaya9();
            UserMeghalaya4 = Meghalaya9();
            return View(UserMeghalaya4);

        }

        private List<Modelclass> Mizoram5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Mizoram";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMizoram = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMizoram.Add(obj);
            }
            return UserMizoram;
        }
        [HttpGet]
        public ViewResult UserMizoram()
        {
            List<Modelclass> UserMizoram = Mizoram5();
            UserMizoram = Mizoram5();
            return View(UserMizoram);

        }


        private List<Modelclass> Mizoram6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Mizoram1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMizoram1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMizoram1.Add(obj);
            }
            return UserMizoram1;
        }
        [HttpGet]
        public ViewResult UserMizoram1()
        {
            List<Modelclass> UserMizoram1 = Mizoram6();
            UserMizoram1 = Mizoram6();
            return View(UserMizoram1);

        }

        private List<Modelclass> Mizoram7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Mizoram2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMizoram2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMizoram2.Add(obj);
            }
            return UserMizoram2;
        }
        [HttpGet]
        public ViewResult UserMizoram2()
        {
            List<Modelclass> UserMizoram2 = Mizoram7();
            UserMizoram2 = Mizoram7();
            return View(UserMizoram2);

        }

        private List<Modelclass> Mizoram8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Mizoram3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMizoram3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMizoram3.Add(obj);
            }
            return UserMizoram3;
        }
        [HttpGet]
        public ViewResult UserMizoram3()
        {
            List<Modelclass> UserMizoram3 = Mizoram8();
            UserMizoram3 = Mizoram8();
            return View(UserMizoram3);

        }

        private List<Modelclass> Mizoram9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Mizoram4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserMizoram4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserMizoram4.Add(obj);
            }
            return UserMizoram4;
        }
        [HttpGet]
        public ViewResult UserMizoram4()
        {
            List<Modelclass> UserMizoram4 = Mizoram9();
            UserMizoram4 = Mizoram9();
            return View(UserMizoram4);

        }

        private List<Modelclass> Nagaland5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Nagaland";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserNagaland = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserNagaland.Add(obj);
            }
            return UserNagaland;
        }
        [HttpGet]
        public ViewResult UserNagaland()
        {
            List<Modelclass> UserNagaland = Nagaland5();
            UserNagaland = Nagaland5();
            return View(UserNagaland);

        }

        private List<Modelclass> Nagaland6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Nagaland1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserNagaland1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserNagaland1.Add(obj);
            }
            return UserNagaland1;
        }
        [HttpGet]
        public ViewResult UserNagaland1()
        {
            List<Modelclass> UserNagaland1 = Nagaland6();
            UserNagaland1 = Nagaland6();
            return View(UserNagaland1);

        }

        private List<Modelclass> Nagaland7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Nagaland2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserNagaland2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserNagaland2.Add(obj);
            }
            return UserNagaland2;
        }
        [HttpGet]
        public ViewResult UserNagaland2()
        {
            List<Modelclass> UserNagaland2 = Nagaland7();
            UserNagaland2 = Nagaland7();
            return View(UserNagaland2);

        }

        private List<Modelclass> Nagaland8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Nagaland3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserNagaland3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserNagaland3.Add(obj);
            }
            return UserNagaland3;
        }
        [HttpGet]
        public ViewResult UserNagaland3()
        {
            List<Modelclass> UserNagaland3 = Nagaland8();
            UserNagaland3 = Nagaland8();
            return View(UserNagaland3);

        }

        private List<Modelclass> Nagaland9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Nagaland4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserNagaland4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserNagaland4.Add(obj);
            }
            return UserNagaland4;
        }
        [HttpGet]
        public ViewResult UserNagaland4()
        {
            List<Modelclass> UserNagaland4 = Nagaland9();
            UserNagaland4 = Nagaland9();
            return View(UserNagaland4);

        }

        private List<Modelclass> Odsiha5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Odsiha";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserOdsiha = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserOdsiha.Add(obj);
            }
            return UserOdsiha;
        }
        [HttpGet]
        public ViewResult UserOdsiha()
        {
            List<Modelclass> UserOdsiha = Odsiha5();
            UserOdsiha = Odsiha5();
            return View(UserOdsiha);

        }

        private List<Modelclass> Odsiha6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Odsiha1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserOdsiha1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserOdsiha1.Add(obj);
            }
            return UserOdsiha1;
        }
        [HttpGet]
        public ViewResult UserOdsiha1()
        {
            List<Modelclass> UserOdsiha1 = Odsiha6();
            UserOdsiha1 = Odsiha6();
            return View(UserOdsiha1);

        }

        private List<Modelclass> Odsiha7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Odsiha2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserOdsiha2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserOdsiha2.Add(obj);
            }
            return UserOdsiha2;
        }
        [HttpGet]
        public ViewResult UserOdsiha2()
        {
            List<Modelclass> UserOdsiha2 = Odsiha7();
            UserOdsiha2 = Odsiha7();
            return View(UserOdsiha2);

        }

        private List<Modelclass> Odsiha8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Odsiha3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserOdsiha3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserOdsiha3.Add(obj);
            }
            return UserOdsiha3;
        }
        [HttpGet]
        public ViewResult UserOdsiha3()
        {
            List<Modelclass> UserOdsiha3 = Odsiha8();
            UserOdsiha3 = Odsiha8();
            return View(UserOdsiha3);

        }

        private List<Modelclass> Odsiha9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Odsiha4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserOdsiha4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserOdsiha4.Add(obj);
            }
            return UserOdsiha4;
        }
        [HttpGet]
        public ViewResult UserOdsiha4()
        {
            List<Modelclass> UserOdsiha4 = Odsiha9();
            UserOdsiha4 = Odsiha9();
            return View(UserOdsiha4);

        }

        private List<Modelclass> Punjab5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Punjab";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserPunjab = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserPunjab.Add(obj);
            }
            return UserPunjab;
        }
        [HttpGet]
        public ViewResult UserPunjab()
        {
            List<Modelclass> UserPunjab = Punjab5();
            UserPunjab = Punjab5();
            return View(UserPunjab);

        }

        private List<Modelclass> Punjab6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Punjab1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserPunjab1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserPunjab1.Add(obj);
            }
            return UserPunjab1;
        }
        [HttpGet]
        public ViewResult UserPunjab1()
        {
            List<Modelclass> UserPunjab1 = Punjab6();
            UserPunjab1 = Punjab6();
            return View(UserPunjab1);

        }

        private List<Modelclass> Punjab7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Punjab2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserPunjab2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserPunjab2.Add(obj);
            }
            return UserPunjab2;
        }
        [HttpGet]
        public ViewResult UserPunjab2()
        {
            List<Modelclass> UserPunjab2 = Punjab7();
            UserPunjab2 = Punjab7();
            return View(UserPunjab2);

        }

        private List<Modelclass> Punjab8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Punjab3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserPunjab3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserPunjab3.Add(obj);
            }
            return UserPunjab3;
        }
        [HttpGet]
        public ViewResult UserPunjab3()
        {
            List<Modelclass> UserPunjab3 = Punjab8();
            UserPunjab3 = Punjab8();
            return View(UserPunjab3);

        }

        private List<Modelclass> Punjab9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Punjab4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserPunjab4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserPunjab4.Add(obj);
            }
            return UserPunjab4;
        }
        [HttpGet]
        public ViewResult UserPunjab4()
        {
            List<Modelclass> UserPunjab4 = Punjab9();
            UserPunjab4 = Punjab9();
            return View(UserPunjab4);

        }

        private List<Modelclass> Rajasthan5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Rajasthan";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserRajasthan = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserRajasthan.Add(obj);
            }
            return UserRajasthan;
        }
        [HttpGet]
        public ViewResult UserRajasthan()
        {
            List<Modelclass> UserRajasthan = Rajasthan5();
            UserRajasthan = Rajasthan5();
            return View(UserRajasthan);

        }

        private List<Modelclass> Rajasthan6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Rajasthan1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserRajasthan1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserRajasthan1.Add(obj);
            }
            return UserRajasthan1;
        }
        [HttpGet]
        public ViewResult UserRajasthan1()
        {
            List<Modelclass> UserRajasthan1 = Rajasthan6();
            UserRajasthan1 = Rajasthan6();
            return View(UserRajasthan1);

        }

        private List<Modelclass> Rajasthan7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Rajasthan2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserRajasthan2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserRajasthan2.Add(obj);
            }
            return UserRajasthan2;
        }
        [HttpGet]
        public ViewResult UserRajasthan2()
        {
            List<Modelclass> UserRajasthan2 = Rajasthan7();
            UserRajasthan2 = Rajasthan7();
            return View(UserRajasthan2);

        }

        private List<Modelclass> Rajasthan8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Rajasthan3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserRajasthan3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserRajasthan3.Add(obj);
            }
            return UserRajasthan3;
        }
        [HttpGet]
        public ViewResult UserRajasthan3()
        {
            List<Modelclass> UserRajasthan3 = Rajasthan8();
            UserRajasthan3 = Rajasthan8();
            return View(UserRajasthan3);

        }

        private List<Modelclass> Rajasthan9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Rajasthan4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserRajasthan4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserRajasthan4.Add(obj);
            }
            return UserRajasthan4;
        }
        [HttpGet]
        public ViewResult UserRajasthan4()
        {
            List<Modelclass> UserRajasthan4 = Rajasthan9();
            UserRajasthan4 = Rajasthan9();
            return View(UserRajasthan4);

        }

        private List<Modelclass> Sikkim5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Sikkim";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserSikkim = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserSikkim.Add(obj);
            }
            return UserSikkim;
        }
        [HttpGet]
        public ViewResult UserSikkim()
        {
            List<Modelclass> UserSikkim = Sikkim5();
            UserSikkim = Sikkim5();
            return View(UserSikkim);

        }

        private List<Modelclass> Sikkim6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Sikkim1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserSikkim1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserSikkim1.Add(obj);
            }
            return UserSikkim1;
        }
        [HttpGet]
        public ViewResult UserSikkim1()
        {
            List<Modelclass> UserSikkim1 = Sikkim6();
            UserSikkim1 = Sikkim6();
            return View(UserSikkim1);

        }

        private List<Modelclass> Sikkim7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Sikkim2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserSikkim2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserSikkim2.Add(obj);
            }
            return UserSikkim2;
        }
        [HttpGet]
        public ViewResult UserSikkim2()
        {
            List<Modelclass> UserSikkim2 = Sikkim7();
            UserSikkim2 = Sikkim7();
            return View(UserSikkim2);

        }

        private List<Modelclass> Sikkim8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Sikkim3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserSikkim3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserSikkim3.Add(obj);
            }
            return UserSikkim3;
        }
        [HttpGet]
        public ViewResult UserSikkim3()
        {
            List<Modelclass> UserSikkim3 = Sikkim8();
            UserSikkim3 = Sikkim8();
            return View(UserSikkim3);

        }

        private List<Modelclass> Sikkim9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Sikkim4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserSikkim4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserSikkim4.Add(obj);
            }
            return UserSikkim4;
        }
        [HttpGet]
        public ViewResult UserSikkim4()
        {
            List<Modelclass> UserSikkim4 = Sikkim9();
            UserSikkim4 = Sikkim9();
            return View(UserSikkim4);

        }

        private List<Modelclass> Tamilnadu5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tamilnadu";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTamilnadu = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTamilnadu.Add(obj);
            }
            return UserTamilnadu;
        }
        [HttpGet]
        public ViewResult UserTamilnadu()
        {
            List<Modelclass> UserTamilnadu = Tamilnadu5();
            UserTamilnadu = Tamilnadu5();
            return View(UserTamilnadu);

        }

        private List<Modelclass> Tamilnadu6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tamilnadu1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTamilnadu1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTamilnadu1.Add(obj);
            }
            return UserTamilnadu1;
        }
        [HttpGet]
        public ViewResult UserTamilnadu1()
        {
            List<Modelclass> UserTamilnadu1 = Tamilnadu6();
            UserTamilnadu1 = Tamilnadu6();
            return View(UserTamilnadu1);

        }

        private List<Modelclass> Tamilnadu7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tamilnadu2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTamilnadu2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTamilnadu2.Add(obj);
            }
            return UserTamilnadu2;
        }
        [HttpGet]
        public ViewResult UserTamilnadu2()
        {
            List<Modelclass> UserTamilnadu2 = Tamilnadu7();
            UserTamilnadu2 = Tamilnadu7();
            return View(UserTamilnadu2);

        }

        private List<Modelclass> Tamilnadu8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tamilnadu3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTamilnadu3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTamilnadu3.Add(obj);
            }
            return UserTamilnadu3;
        }
        [HttpGet]
        public ViewResult UserTamilnadu3()
        {
            List<Modelclass> UserTamilnadu3 = Tamilnadu8();
            UserTamilnadu3 = Tamilnadu8();
            return View(UserTamilnadu3);

        }

        private List<Modelclass> Tamilnadu9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tamilnadu4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTamilnadu4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTamilnadu4.Add(obj);
            }
            return UserTamilnadu4;
        }
        [HttpGet]
        public ViewResult UserTamilnadu4()
        {
            List<Modelclass> UserTamilnadu4 = Tamilnadu9();
            UserTamilnadu4 = Tamilnadu9();
            return View(UserTamilnadu4);

        }

        private List<Modelclass> Telangana5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Telangana";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTelangana = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTelangana.Add(obj);
            }
            return UserTelangana;
        }
        [HttpGet]
        public ViewResult UserTelangana()
        {
            List<Modelclass> UserTelangana = Telangana5();
            UserTelangana = Telangana5();
            return View(UserTelangana);

        }

        private List<Modelclass> Telangana6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Telangana1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTelangana1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTelangana1.Add(obj);
            }
            return UserTelangana1;
        }
        [HttpGet]
        public ViewResult UserTelangana1()
        {
            List<Modelclass> UserTelangana1 = Telangana6();
            UserTelangana1 = Telangana6();
            return View(UserTelangana1);

        }

        private List<Modelclass> Telangana7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Telangana2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTelangana2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTelangana2.Add(obj);
            }
            return UserTelangana2;
        }
        [HttpGet]
        public ViewResult UserTelangana2()
        {
            List<Modelclass> UserTelangana2 = Telangana7();
            UserTelangana2 = Telangana7();
            return View(UserTelangana2);

        }

        private List<Modelclass> Telangana8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Telangana3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTelangana3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTelangana3.Add(obj);
            }
            return UserTelangana3;
        }
        [HttpGet]
        public ViewResult UserTelangana3()
        {
            List<Modelclass> UserTelangana3 = Telangana8();
            UserTelangana3 = Telangana8();
            return View(UserTelangana3);

        }

        private List<Modelclass> Telangana9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Telangana4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTelangana4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTelangana4.Add(obj);
            }
            return UserTelangana4;
        }
        [HttpGet]
        public ViewResult UserTelangana4()
        {
            List<Modelclass> UserTelangana4 = Telangana9();
            UserTelangana4 = Telangana9();
            return View(UserTelangana4);

        }

        private List<Modelclass> Tripua5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tripua";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTripua = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTripua.Add(obj);
            }
            return UserTripua;
        }
        [HttpGet]
        public ViewResult UserTripua()
        {
            List<Modelclass> UserTripua = Tripua5();
            UserTripua = Tripua5();
            return View(UserTripua);

        }


        private List<Modelclass> Tripua6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tripua1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTripua1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTripua1.Add(obj);
            }
            return UserTripua1;
        }
        [HttpGet]
        public ViewResult UserTripua1()
        {
            List<Modelclass> UserTripua1 = Tripua6();
            UserTripua1 = Tripua6();
            return View(UserTripua1);

        }

        private List<Modelclass> Tripua7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tripua2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTripua2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTripua2.Add(obj);
            }
            return UserTripua2;
        }
        [HttpGet]
        public ViewResult UserTripua2()
        {
            List<Modelclass> UserTripua2 = Tripua6();
            UserTripua2 = Tripua6();
            return View(UserTripua2);

        }

        private List<Modelclass> Tripua8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tripua3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTripua3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTripua3.Add(obj);
            }
            return UserTripua3;
        }
        [HttpGet]
        public ViewResult UserTripua3()
        {
            List<Modelclass> UserTripua3 = Tripua8();
            UserTripua3 = Tripua8();
            return View(UserTripua3);

        }

        private List<Modelclass> Tripua9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Tripua4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserTripua4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserTripua4.Add(obj);
            }
            return UserTripua4;
        }
        [HttpGet]
        public ViewResult UserTripua4()
        {
            List<Modelclass> UserTripua4 = Tripua9();
            UserTripua4 = Tripua9();
            return View(UserTripua4);

        }

        private List<Modelclass> Uttarpradesh5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarpradesh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarpradesh = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarpradesh.Add(obj);
            }
            return UserUttarpradesh;
        }
        [HttpGet]
        public ViewResult UserUttarpradesh()
        {
            List<Modelclass> UserUttarpradesh = Uttarpradesh5();
            UserUttarpradesh = Uttarpradesh5();
            return View(UserUttarpradesh);

        }

        private List<Modelclass> Uttarpradesh6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarpradesh1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarpradesh1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarpradesh1.Add(obj);
            }
            return UserUttarpradesh1;
        }
        [HttpGet]
        public ViewResult UserUttarpradesh1()
        {
            List<Modelclass> UserUttarpradesh1 = Uttarpradesh6();
            UserUttarpradesh1 = Uttarpradesh6();
            return View(UserUttarpradesh1);

        }

        private List<Modelclass> Uttarpradesh7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarpradesh2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarpradesh2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarpradesh2.Add(obj);
            }
            return UserUttarpradesh2;
        }
        [HttpGet]
        public ViewResult UserUttarpradesh2()
        {
            List<Modelclass> UserUttarpradesh2 = Uttarpradesh7();
            UserUttarpradesh2 = Uttarpradesh7();
            return View(UserUttarpradesh2);

        }

        private List<Modelclass> Uttarpradesh8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarpradesh3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarpradesh3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarpradesh3.Add(obj);
            }
            return UserUttarpradesh3;
        }
        [HttpGet]
        public ViewResult UserUttarpradesh3()
        {
            List<Modelclass> UserUttarpradesh3 = Uttarpradesh8();
            UserUttarpradesh3 = Uttarpradesh8();
            return View(UserUttarpradesh3);

        }

        private List<Modelclass> Uttarpradesh9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarpradesh4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarpradesh4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarpradesh4.Add(obj);
            }
            return UserUttarpradesh4;
        }
        [HttpGet]
        public ViewResult UserUttarpradesh4()
        {
            List<Modelclass> UserUttarpradesh4 = Uttarpradesh9();
            UserUttarpradesh4 = Uttarpradesh9();
            return View(UserUttarpradesh4);

        }

        private List<Modelclass> Uttarakhand5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarakhand";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarakhand = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarakhand.Add(obj);
            }
            return UserUttarakhand;
        }
        [HttpGet]
        public ViewResult UserUttarakhand()
        {
            List<Modelclass> UserUttarakhand = Uttarakhand5();
            UserUttarakhand = Uttarakhand5();
            return View(UserUttarakhand);

        }

        private List<Modelclass> Uttarakhand6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarakhand1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarakhand1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarakhand1.Add(obj);
            }
            return UserUttarakhand1;
        }
        [HttpGet]
        public ViewResult UserUttarakhand1()
        {
            List<Modelclass> UserUttarakhand1 = Uttarakhand6();
            UserUttarakhand1 = Uttarakhand6();
            return View(UserUttarakhand1);

        }

        private List<Modelclass> Uttarakhand7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarakhand2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarakhand2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarakhand2.Add(obj);
            }
            return UserUttarakhand2;
        }
        [HttpGet]
        public ViewResult UserUttarakhand2()
        {
            List<Modelclass> UserUttarakhand2 = Uttarakhand7();
            UserUttarakhand2 = Uttarakhand7();
            return View(UserUttarakhand2);

        }

        private List<Modelclass> Uttarakhand8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarakhand3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarakhand3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarakhand3.Add(obj);
            }
            return UserUttarakhand3;
        }
        [HttpGet]
        public ViewResult UserUttarakhand3()
        {
            List<Modelclass> UserUttarakhand3 = Uttarakhand8();
            UserUttarakhand3 = Uttarakhand8();
            return View(UserUttarakhand3);

        }

        private List<Modelclass> Uttarakhand9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Uttarakhand4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserUttarakhand4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserUttarakhand4.Add(obj);
            }
            return UserUttarakhand4;
        }
        [HttpGet]
        public ViewResult UserUttarakhand4()
        {
            List<Modelclass> UserUttarakhand4 = Uttarakhand9();
            UserUttarakhand4 = Uttarakhand9();
            return View(UserUttarakhand4);

        }

        private List<Modelclass> Westbengal5()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Westbengal";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserWestbengal = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserWestbengal.Add(obj);
            }
            return UserWestbengal;
        }
        [HttpGet]
        public ViewResult UserWestbengal()
        {
            List<Modelclass> UserWestbengal = Westbengal5();
            UserWestbengal = Westbengal5();
            return View(UserWestbengal);

        }

        private List<Modelclass> Westbengal6()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Westbengal1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserWestbengal1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserWestbengal1.Add(obj);
            }
            return UserWestbengal1;
        }
        [HttpGet]
        public ViewResult UserWestbengal1()
        {
            List<Modelclass> UserWestbengal1 = Westbengal6();
            UserWestbengal1 = Westbengal6();
            return View(UserWestbengal1);

        }

        private List<Modelclass> Westbengal7()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Westbengal2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserWestbengal2 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserWestbengal2.Add(obj);
            }
            return UserWestbengal2;
        }
        [HttpGet]
        public ViewResult UserWestbengal2()
        {
            List<Modelclass> UserWestbengal2 = Westbengal7();
            UserWestbengal2 = Westbengal7();
            return View(UserWestbengal2);

        }

        private List<Modelclass> Westbengal8()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Westbengal3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserWestbengal3 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserWestbengal3.Add(obj);
            }
            return UserWestbengal3;
        }
        [HttpGet]
        public ViewResult UserWestbengal3()
        {
            List<Modelclass> UserWestbengal3 = Westbengal8();
            UserWestbengal3 = Westbengal8();
            return View(UserWestbengal3);

        }

        private List<Modelclass> Westbengal9()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Westbengal4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> UserWestbengal4 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Hospitalname = Convert.ToString(dr["Hospitalname"]);
                obj.Type = Convert.ToString(dr["Type"]);
                obj.Ambulance = Convert.ToString(dr["Ambulance"]);
                obj.Beds = Convert.ToString(dr["Beds"]);
                obj.Oxygen = Convert.ToString(dr["Oxygen"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Hospitaladdress = Convert.ToString(dr["Hospitaladdress"]);
                UserWestbengal4.Add(obj);
            }
            return UserWestbengal4;
        }
        [HttpGet]
        public ViewResult UserWestbengal4()
        {
            List<Modelclass> UserWestbengal4 = Westbengal9();
            UserWestbengal4 = Westbengal9();
            return View(UserWestbengal4);

        }

        [HttpGet]
        public ViewResult Guidelines()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Guidelines(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Guidelines2(Name,Disease,Location,PhoneNumber,Email,Address) values('" + obj.Name + "','" + obj.Disease + "','" + obj.Location + "','" + obj.PhoneNumber + "','" + obj.Email + "','" + obj.Address + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Succesfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
           
        }




        [HttpGet]
        public ViewResult Heartfirstpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Heartexercise()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Heartdeath()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Brainfirstpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Braingame()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Braindeath()
        {
            return View();
        }

        [HttpGet]
        public ViewResult kidneyfirstpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult kidneygame()
        {
            return View();
        }

        [HttpGet]
        public ViewResult KidneyDiseases()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Liverfirstpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Liverfunction()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Liverdiseases()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Lungfirstpage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Lungfuncion()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Lungdiseases()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Generaldiesases()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Donorpage()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Statepage1()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statepage2()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statepage3()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Statepage4()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Donorfrom()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Donorfrom(Modelclass obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string cmdText = "Insert into Donorfrom5(Name,Bloodgrouptype,Location,PhoneNumber,Email,Address) values('" + obj.Name + "','" + obj.Bloodgrouptype + "','" + obj.Location + "','" + obj.PhoneNumber + "','" + obj.Email + "','" + obj.Address + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int roweffected = cmd.ExecuteNonQuery();
            if (roweffected > 0)
            {

                ViewBag.msg = "Data Succesfully";
            }
            else
            {
                ViewBag.msg = "Data failed";
            }
            ModelState.Clear();
            return View();
            
        }


        private List<Modelclass> Admindonor()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Donorfrom5";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Admindonor1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Name = Convert.ToString(dr["Name"]);
                obj.Bloodgrouptype = Convert.ToString(dr["Bloodgrouptype"]);
                obj.Location = Convert.ToString(dr["Location"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Email = Convert.ToString(dr["Email"]);
                obj.Address = Convert.ToString(dr["Address"]);
                
                Admindonor1.Add(obj);
            }
            return Admindonor1;
        }
        [HttpGet]
        public ViewResult Admindonor1()
        {
            List<Modelclass> Admindonor1 = Admindonor();
            Admindonor1 = Admindonor();
            return View(Admindonor1);

        }

        private List<Modelclass> Adminguidelines()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string query = "select * from Guidelines2";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelclass> Adminguidelines1 = new List<Modelclass>();
            while (dr.Read())
            {
                Modelclass obj = new Modelclass();
                obj.Name = Convert.ToString(dr["Name"]);
                obj.Disease = Convert.ToString(dr["Disease"]);
                obj.Location = Convert.ToString(dr["Location"]);
                obj.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                obj.Email = Convert.ToString(dr["Email"]);
                obj.Address = Convert.ToString(dr["Address"]);

                Adminguidelines1.Add(obj);
            }
            return Adminguidelines1;
        }
        [HttpGet]
        public ViewResult Adminguidelines1()
        {
            List<Modelclass> Adminguidelines1 = Adminguidelines();
            Adminguidelines1 = Adminguidelines();
            return View(Adminguidelines1);

        }

        [HttpGet]
        public ViewResult Aboutus()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contanctus()
        {
            return View();
        }
        [WebMethod]
        public static List<String>GetState(String Statedetails)
        {
            List<String> state = new List<String>();
            String mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn= new SqlConnection(mainconn);
            string sqlquerry = string.Format("select Hospitalname from Andhrapradesh where Hospitalname LIKE '%{0}%'", Statedetails);
            sqlconn.Open();
            SqlCommand Sqlconn= new SqlCommand(sqlquerry, sqlconn); 
            SqlDataReader dr= Sqlconn.ExecuteReader();
            while(dr.Read())
            {
                state.Add(dr.GetString(0));
            }
            sqlconn.Close(); 
            return state;
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Home");
        }









    }
}