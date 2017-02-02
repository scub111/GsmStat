using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace KMAZSBASE
{
    public static class ConnectionHelper
    {
        public const string ConnectionString = @"XpoProvider=Firebird;DataSource=172.31.106.147;User=SYSDBA;Password=masterkey;Database=C:\KMAZS\DataBase\KMAZSBASE.FDB;ServerType=0;Charset=NONE";
        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

    public class OFFICES : XPLiteObject
    {
        int fOFC_ID;
        [Key]
        public int OFC_ID
        {
            get { return fOFC_ID; }
            set { SetPropertyValue<int>("OFC_ID", ref fOFC_ID, value); }
        }
        char fOFC_TYPE;
        public char OFC_TYPE
        {
            get { return fOFC_TYPE; }
            set { SetPropertyValue<char>("OFC_TYPE", ref fOFC_TYPE, value); }
        }
        string fOFC_NAME;
        [Size(50)]
        public string OFC_NAME
        {
            get { return fOFC_NAME; }
            set { SetPropertyValue<string>("OFC_NAME", ref fOFC_NAME, value); }
        }
        string fOFC_ADDRESS;
        public string OFC_ADDRESS
        {
            get { return fOFC_ADDRESS; }
            set { SetPropertyValue<string>("OFC_ADDRESS", ref fOFC_ADDRESS, value); }
        }
        string fOFC_PHONE;
        [Size(20)]
        public string OFC_PHONE
        {
            get { return fOFC_PHONE; }
            set { SetPropertyValue<string>("OFC_PHONE", ref fOFC_PHONE, value); }
        }
        string fOFC_LINKPHONE;
        [Size(20)]
        public string OFC_LINKPHONE
        {
            get { return fOFC_LINKPHONE; }
            set { SetPropertyValue<string>("OFC_LINKPHONE", ref fOFC_LINKPHONE, value); }
        }
        string fOFC_ZIP;
        [Size(15)]
        public string OFC_ZIP
        {
            get { return fOFC_ZIP; }
            set { SetPropertyValue<string>("OFC_ZIP", ref fOFC_ZIP, value); }
        }
        string fOFC_EMAIL;
        [Size(30)]
        public string OFC_EMAIL
        {
            get { return fOFC_EMAIL; }
            set { SetPropertyValue<string>("OFC_EMAIL", ref fOFC_EMAIL, value); }
        }
        string fOFC_BOSS;
        [Size(50)]
        public string OFC_BOSS
        {
            get { return fOFC_BOSS; }
            set { SetPropertyValue<string>("OFC_BOSS", ref fOFC_BOSS, value); }
        }
        string fOFC_OTHER;
        [Size(SizeAttribute.Unlimited)]
        public string OFC_OTHER
        {
            get { return fOFC_OTHER; }
            set { SetPropertyValue<string>("OFC_OTHER", ref fOFC_OTHER, value); }
        }
        string fOFC_INN;
        [Size(20)]
        public string OFC_INN
        {
            get { return fOFC_INN; }
            set { SetPropertyValue<string>("OFC_INN", ref fOFC_INN, value); }
        }
        string fOFC_IP;
        [Size(12)]
        public string OFC_IP
        {
            get { return fOFC_IP; }
            set { SetPropertyValue<string>("OFC_IP", ref fOFC_IP, value); }
        }
        char fOFC_ISDELETE;
        public char OFC_ISDELETE
        {
            get { return fOFC_ISDELETE; }
            set { SetPropertyValue<char>("OFC_ISDELETE", ref fOFC_ISDELETE, value); }
        }
        [Association(@"KMAZS.OFC_ID_OFFICES")]
        public XPCollection<KMAZS> KMAZSs
        {
            get { return GetCollection<KMAZS>(@"KMAZSs"); }
        }
        public OFFICES(Session session) : base(session) { }
        public OFFICES() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class DEPARTMENTS : XPLiteObject
    {
        int fDEP_ID;
        [Key]
        public int DEP_ID
        {
            get { return fDEP_ID; }
            set { SetPropertyValue<int>("DEP_ID", ref fDEP_ID, value); }
        }
        string fDEP_NAME;
        [Size(50)]
        public string DEP_NAME
        {
            get { return fDEP_NAME; }
            set { SetPropertyValue<string>("DEP_NAME", ref fDEP_NAME, value); }
        }
        string fDEP_PHONE;
        [Size(20)]
        public string DEP_PHONE
        {
            get { return fDEP_PHONE; }
            set { SetPropertyValue<string>("DEP_PHONE", ref fDEP_PHONE, value); }
        }
        string fDEP_BOSS;
        [Size(50)]
        public string DEP_BOSS
        {
            get { return fDEP_BOSS; }
            set { SetPropertyValue<string>("DEP_BOSS", ref fDEP_BOSS, value); }
        }
        string fDEP_ADDRESS;
        public string DEP_ADDRESS
        {
            get { return fDEP_ADDRESS; }
            set { SetPropertyValue<string>("DEP_ADDRESS", ref fDEP_ADDRESS, value); }
        }
        string fDEP_EMAIL;
        [Size(30)]
        public string DEP_EMAIL
        {
            get { return fDEP_EMAIL; }
            set { SetPropertyValue<string>("DEP_EMAIL", ref fDEP_EMAIL, value); }
        }
        string fDEP_INN;
        [Size(20)]
        public string DEP_INN
        {
            get { return fDEP_INN; }
            set { SetPropertyValue<string>("DEP_INN", ref fDEP_INN, value); }
        }
        string fDEP_OTHER;
        [Size(SizeAttribute.Unlimited)]
        public string DEP_OTHER
        {
            get { return fDEP_OTHER; }
            set { SetPropertyValue<string>("DEP_OTHER", ref fDEP_OTHER, value); }
        }
        char fDEP_ISDELETE;
        public char DEP_ISDELETE
        {
            get { return fDEP_ISDELETE; }
            set { SetPropertyValue<char>("DEP_ISDELETE", ref fDEP_ISDELETE, value); }
        }
        public DEPARTMENTS(Session session) : base(session) { }
        public DEPARTMENTS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class KMAZS : XPLiteObject
    {
        int fKM_ID;
        [Key]
        public int KM_ID
        {
            get { return fKM_ID; }
            set { SetPropertyValue<int>("KM_ID", ref fKM_ID, value); }
        }
        OFFICES fOFC_ID;
        [Association(@"KMAZS.OFC_ID_OFFICES")]
        public OFFICES OFC_ID
        {
            get { return fOFC_ID; }
            set { SetPropertyValue<OFFICES>("OFC_ID", ref fOFC_ID, value); }
        }
        string fKM_NAME;
        [Size(50)]
        public string KM_NAME
        {
            get { return fKM_NAME; }
            set { SetPropertyValue<string>("KM_NAME", ref fKM_NAME, value); }
        }
        string fKM_ADDRESS;
        public string KM_ADDRESS
        {
            get { return fKM_ADDRESS; }
            set { SetPropertyValue<string>("KM_ADDRESS", ref fKM_ADDRESS, value); }
        }
        string fKM_PHONE;
        [Size(20)]
        public string KM_PHONE
        {
            get { return fKM_PHONE; }
            set { SetPropertyValue<string>("KM_PHONE", ref fKM_PHONE, value); }
        }
        string fKM_EMAIL;
        [Size(30)]
        public string KM_EMAIL
        {
            get { return fKM_EMAIL; }
            set { SetPropertyValue<string>("KM_EMAIL", ref fKM_EMAIL, value); }
        }
        string fKM_LINKPHONE;
        [Size(20)]
        public string KM_LINKPHONE
        {
            get { return fKM_LINKPHONE; }
            set { SetPropertyValue<string>("KM_LINKPHONE", ref fKM_LINKPHONE, value); }
        }
        string fKM_BOSS;
        [Size(50)]
        public string KM_BOSS
        {
            get { return fKM_BOSS; }
            set { SetPropertyValue<string>("KM_BOSS", ref fKM_BOSS, value); }
        }
        string fKM_IP;
        [Size(12)]
        public string KM_IP
        {
            get { return fKM_IP; }
            set { SetPropertyValue<string>("KM_IP", ref fKM_IP, value); }
        }
        string fKM_OTHER;
        [Size(SizeAttribute.Unlimited)]
        public string KM_OTHER
        {
            get { return fKM_OTHER; }
            set { SetPropertyValue<string>("KM_OTHER", ref fKM_OTHER, value); }
        }
        char fKM_ISDELETE;
        public char KM_ISDELETE
        {
            get { return fKM_ISDELETE; }
            set { SetPropertyValue<char>("KM_ISDELETE", ref fKM_ISDELETE, value); }
        }
        [Association(@"AZSPARAMS.KM_ID_KMAZS")]
        public XPCollection<AZSPARAMS> AZSPARAMSs
        {
            get { return GetCollection<AZSPARAMS>(@"AZSPARAMSs"); }
        }
        public KMAZS(Session session) : base(session) { }
        public KMAZS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class USERNUMBERS : XPLiteObject
    {
        int fUN_NUM;
        [Key]
        public int UN_NUM
        {
            get { return fUN_NUM; }
            set { SetPropertyValue<int>("UN_NUM", ref fUN_NUM, value); }
        }
        int fOFC_ID;
        public int OFC_ID
        {
            get { return fOFC_ID; }
            set { SetPropertyValue<int>("OFC_ID", ref fOFC_ID, value); }
        }
        int fUN_USERID;
        public int UN_USERID
        {
            get { return fUN_USERID; }
            set { SetPropertyValue<int>("UN_USERID", ref fUN_USERID, value); }
        }
        char fUN_USERTYPE;
        public char UN_USERTYPE
        {
            get { return fUN_USERTYPE; }
            set { SetPropertyValue<char>("UN_USERTYPE", ref fUN_USERTYPE, value); }
        }
        public USERNUMBERS(Session session) : base(session) { }
        public USERNUMBERS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class GSMTYPE : XPLiteObject
    {
        int fGSM_ID;
        [Key]
        public int GSM_ID
        {
            get { return fGSM_ID; }
            set { SetPropertyValue<int>("GSM_ID", ref fGSM_ID, value); }
        }
        string fGSM_NAME;
        [Size(10)]
        public string GSM_NAME
        {
            get { return fGSM_NAME; }
            set { SetPropertyValue<string>("GSM_NAME", ref fGSM_NAME, value); }
        }
        string fGSM_SHORTNAME;
        [Size(4)]
        public string GSM_SHORTNAME
        {
            get { return fGSM_SHORTNAME; }
            set { SetPropertyValue<string>("GSM_SHORTNAME", ref fGSM_SHORTNAME, value); }
        }
        char fGSM_ISDELETE;
        public char GSM_ISDELETE
        {
            get { return fGSM_ISDELETE; }
            set { SetPropertyValue<char>("GSM_ISDELETE", ref fGSM_ISDELETE, value); }
        }
        public GSMTYPE(Session session) : base(session) { }
        public GSMTYPE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class AZSPARAMS : XPLiteObject
    {
        KMAZS fKM_ID;
        [Key]
        [Association(@"AZSPARAMS.KM_ID_KMAZS")]
        public KMAZS KM_ID
        {
            get { return fKM_ID; }
            set { SetPropertyValue<KMAZS>("KM_ID", ref fKM_ID, value); }
        }
        short fAP_CALLPERIOD;
        public short AP_CALLPERIOD
        {
            get { return fAP_CALLPERIOD; }
            set { SetPropertyValue<short>("AP_CALLPERIOD", ref fAP_CALLPERIOD, value); }
        }
        short fAP_SLIVFIXPERIOD;
        public short AP_SLIVFIXPERIOD
        {
            get { return fAP_SLIVFIXPERIOD; }
            set { SetPropertyValue<short>("AP_SLIVFIXPERIOD", ref fAP_SLIVFIXPERIOD, value); }
        }
        short fAP_SLIVFIXLITER;
        public short AP_SLIVFIXLITER
        {
            get { return fAP_SLIVFIXLITER; }
            set { SetPropertyValue<short>("AP_SLIVFIXLITER", ref fAP_SLIVFIXLITER, value); }
        }
        int fAP_SENDOBJECTS;
        public int AP_SENDOBJECTS
        {
            get { return fAP_SENDOBJECTS; }
            set { SetPropertyValue<int>("AP_SENDOBJECTS", ref fAP_SENDOBJECTS, value); }
        }
        int fAP_GETOBJECTS;
        public int AP_GETOBJECTS
        {
            get { return fAP_GETOBJECTS; }
            set { SetPropertyValue<int>("AP_GETOBJECTS", ref fAP_GETOBJECTS, value); }
        }
        public AZSPARAMS(Session session) : base(session) { }
        public AZSPARAMS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
