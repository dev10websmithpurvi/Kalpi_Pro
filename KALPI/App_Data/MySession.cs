using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ENT = WS.Framework.Entity;

/// <summary>
/// Summary description for MySession
/// </summary>
public class MySession
{
    // private constructor
    private MySession()
    {
        Username = null;
        PasswordChange = null;
        UserFullname = null;
        UserType = new WS.Framework.Common.Enumration.UserType();
        SearchParam = null;
        MessageResult = new FormResultEntity();
        //UserProfileAccessList = new List<WS.Entity.ProfileUserAccessLevel>();
        UserAccessLevelEntity = new UserAccessLevelEntity();
        UserProfile = new WS.Framework.Entity.UserProfile();
        ExportVendor = new GridView();
        ExportCollection = new GridView();
        ExportVoucher = new GridView();
    }

    // Gets the current session.
    public static MySession Current
    {
        get
        {
            MySession session =
              (MySession)HttpContext.Current.Session["__MySession__"];
            if (session == null)
            {
                session = new MySession();
                HttpContext.Current.Session["__MySession__"] = session;
            }
            return session;
        }
    }

    // **** add your session properties here, e.g like this:

    public string Username { get; set; }
    public string PasswordChange { get; set; }
    public FormResultEntity MessageResult { get; set; }
    public string UserFullname { get; set; }
    public WS.Framework.Common.Enumration.UserType UserType { get; set; }
    //public List<ENT.ProfileUserAccessLevel> UserProfileAccessList { get; set; }
    public UserAccessLevelEntity UserAccessLevelEntity { get; set; }

    public ENT.UserProfile UserProfile { get; set; }
    public GridView ExportVendor { get; set; }
    public GridView ExportCollection { get; set; }
    public GridView ExportVoucher { get; set; }
    public string SearchParam { get; set; }
}



