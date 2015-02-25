using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using Apocalypsey_s_Blog.Models;

namespace Apocalypsey_s_Blog.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/

        public ActionResult Index()
        {
            UserInfoEntity user = new UserInfoEntity();
            string username = Request.Form["username"];
            string pwd = Request.Form["pwd"];
            user.UserName = username;
            user.Pwd = pwd;
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("selsct * from xx where username = @name and pwd = @pwd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //添加数据  第一个是属性名
                SqlParameter UserName = cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30);
                UserName.Value = username;
                SqlParameter UserPwd = cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 20);
                UserPwd.Value = pwd;
                con.Open();
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        Session["userName"] = username;
                        Session["passWord"] = pwd;
                    }
                    else
                    {
                        Session["userName"] = "";

                    }
                    dr.Close();
                }
                catch (Exception err)
                { 
                    
                }
                //关闭连接
                con.Close();
            }
            return View();
        }

    }
}
