using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using RapidInterface;

namespace GsmStat
{
    #region AZSPARAMS
    /// <summary>
    /// Таблица "АЗС".
    /// </summary>
    [DBAttribute(Caption = "АЗС", IconFile = "AZSPARAMS.png")]
    public class AZSPARAMS : XPLiteObject
    {
        int fKM_ID;
        [Key]
        public int KM_ID
        {
            get { return fKM_ID; }
            set { SetPropertyValue<int>("KM_ID", ref fKM_ID, value); }
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

        DateTime fAP_KMLASTRECTIME;
        public DateTime AP_KMLASTRECTIME
        {
            get { return fAP_KMLASTRECTIME; }
            set { SetPropertyValue<DateTime>("AP_KMLASTRECTIME", ref fAP_KMLASTRECTIME, value); }
        }

        public AZSPARAMS(Session session) : base(session) { }
        public AZSPARAMS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    #endregion

    #region KMAZS
    /// <summary>
    /// Таблица "КМАЗС".
    /// </summary>
    [DBAttribute(Caption = "КМАЗС", IconFile = "KMAZS.png")]
    public class KMAZS : XPLiteObject
    {
        public KMAZS() : base(Session.DefaultSession) { }

        public KMAZS(Session session) : base(session) { }

        int _KM_ID;
        /// <summary>
        /// KM_ID.
        /// </summary>
        [DisplayName("KM_ID")]
        [Key]
        public int KM_ID
        {
            get { return _KM_ID; }
            set { SetPropertyValue("KM_ID", ref _KM_ID, value); }
        }

        string _KM_NAME;
        /// <summary>
        /// Имя КМАЗС.
        /// </summary>
        [DisplayName("Имя КМАЗС")]
        [Size(50)]
        [DBAttribute(DisplayMember = true)]
        public string KM_NAME
        {
            get { return _KM_NAME; }
            set { SetPropertyValue("KM_NAME", ref _KM_NAME, value); }
        }

        string _KM_ADDRESS;
        /// <summary>
        /// Адрес.
        /// </summary>
        [DisplayName("Адрес")]
        [Size(100)]
        public string KM_ADDRESS
        {
            get { return _KM_ADDRESS; }
            set { SetPropertyValue("KM_ADDRESS", ref _KM_ADDRESS, value); }
        }

        string _KM_PHONE;
        /// <summary>
        /// Телефон.
        /// </summary>
        [DisplayName("Телефон")]
        [Size(20)]
        public string KM_PHONE
        {
            get { return _KM_PHONE; }
            set { SetPropertyValue("KM_PHONE", ref _KM_PHONE, value); }
        }

        string _KM_EMAIL;
        /// <summary>
        /// E-mail сотрудника.
        /// </summary>
        [DisplayName("E-mail сотрудника")]
        [Size(30)]
        public string KM_EMAIL
        {
            get { return _KM_EMAIL; }
            set { SetPropertyValue("KM_EMAIL", ref _KM_EMAIL, value); }
        }
        


        string _KM_BOSS;
        /// <summary>
        /// ФИО.
        /// </summary>
        [DisplayName("ФИО")]
        [Size(50)]
        public string KM_BOSS
        {
            get { return _KM_BOSS; }
            set { SetPropertyValue("KM_BOSS", ref _KM_BOSS, value); }
        }

        bool _KM_ISDELETE;
        /// <summary>
        /// Удален.
        /// </summary>
        [DisplayName("Удален")]
        public bool KM_ISDELETE
        {
            get { return _KM_ISDELETE; }
            set { SetPropertyValue("OP_ISDELETE", ref _KM_ISDELETE, value); }
        }
    }
    #endregion

    #region OPERATORS
    /// <summary>
    /// Таблица "Оператор".
    /// </summary>
    [DBAttribute(Caption = "Оператор", IconFile = "OPERATORS.png")]
    public class OPERATORS : XPLiteObject
    {
        public OPERATORS() : base(Session.DefaultSession) { }

        public OPERATORS(Session session) : base(session) { }

        int _OP_ID;
        /// <summary>
        /// OP_ID.
        /// </summary>
        [DisplayName("OP_ID")]
        [Key]
        public int OP_ID
        {
            get { return _OP_ID; }
            set { SetPropertyValue("OP_ID", ref _OP_ID, value); }
        }

        string _OP_KEY;
        /// <summary>
        /// Ключ.
        /// </summary>
        [DisplayName("Ключ")]
        [Size(16)]
        public string OP_KEY
        {
            get { return _OP_KEY; }
            set { SetPropertyValue("OP_KEY", ref _OP_KEY, value); }
        }

        bool _OP_CANLOGIN;
        /// <summary>
        /// Может авторизаваться.
        /// </summary>
        [DisplayName("Может авторизаваться")]
        public bool OP_CANLOGIN
        {
            get { return _OP_CANLOGIN; }
            set { SetPropertyValue("OP_CANLOGIN", ref _OP_CANLOGIN, value); }
        }

        bool _OP_REQCARKEY;
        /// <summary>
        /// Требовать ключ авто.
        /// </summary>
        [DisplayName("Требовать ключ авто")]
        public bool OP_REQCARKEY
        {
            get { return _OP_REQCARKEY; }
            set { SetPropertyValue("OP_REQCARKEY", ref _OP_REQCARKEY, value); }
        }

        string _OP_FULLNAME;
        /// <summary>
        /// ФИО.
        /// </summary>
        [DisplayName("ФИО")]
        [Size(50)]
        [DBAttribute(DisplayMember = true)]
        public string OP_FULLNAME
        {
            get { return _OP_FULLNAME; }
            set { SetPropertyValue("OP_FULLNAME", ref _OP_FULLNAME, value); }
        }

        int _OP_DAYLIMIT;
        /// <summary>
        /// Суточный лимит.
        /// </summary>
        [DisplayName("Суточный лимит")]
        public int OP_DAYLIMIT
        {
            get { return _OP_DAYLIMIT; }
            set { SetPropertyValue("OP_DAYLIMIT", ref _OP_DAYLIMIT, value); }
        }

        int _OP_ALLLIMIT;
        /// <summary>
        /// Общий лимит.
        /// </summary>
        [DisplayName("Общий лимит")]
        public int OP_ALLLIMIT
        {
            get { return _OP_ALLLIMIT; }
            set { SetPropertyValue("OP_ALLLIMIT", ref _OP_ALLLIMIT, value); }
        }

        DateTime _OP_TIMELIMIT;
        /// <summary>
        /// Прекратить обслуживание.
        /// </summary>
        [DisplayName("Прекратить обслуживание")]
        public DateTime OP_TIMELIMIT
        {
            get { return _OP_TIMELIMIT; }
            set { SetPropertyValue("OP_TIMELIMIT", ref _OP_TIMELIMIT, value); }
        }

        bool _OP_ENABLED;
        /// <summary>
        /// Доступен.
        /// </summary>
        [DisplayName("Доступен")]
        public bool OP_ENABLED
        {
            get { return _OP_ENABLED; }
            set { SetPropertyValue("OP_ENABLED", ref _OP_ENABLED, value); }
        }

        bool _OP_ISDELETE;
        /// <summary>
        /// Удален.
        /// </summary>
        [DisplayName("Удален")]
        public bool OP_ISDELETE
        {
            get { return _OP_ISDELETE; }
            set { SetPropertyValue("OP_ISDELETE", ref _OP_ISDELETE, value); }
        }
    }
    #endregion

    #region CARS
    /// <summary>
    /// Таблица "Машина".
    /// </summary>
    [DBAttribute(Caption = "Машина", IconFile = "CARS.png")]
    public class CARS : XPLiteObject
    {
        public CARS() : base(Session.DefaultSession) { }

        public CARS(Session session) : base(session) { }

        int _CAR_ID;
        /// <summary>
        /// CAR_ID.
        /// </summary>
        [DisplayName("CAR_ID")]
        [Key]
        public int CAR_ID
        {
            get { return _CAR_ID; }
            set { SetPropertyValue("CAR_ID", ref _CAR_ID, value); }
        }

        string _CAR_KEY;
        /// <summary>
        /// Ключ.
        /// </summary>
        [DisplayName("Ключ")]
        [Size(16)]
        public string CAR_KEY
        {
            get { return _CAR_KEY; }
            set { SetPropertyValue("CAR_KEY", ref _CAR_KEY, value); }
        }

        bool _CAR_REQOPERKEY;
        /// <summary>
        /// Требовать ключ оператора.
        /// </summary>
        [DisplayName("Требовать ключ оператора")]
        public bool CAR_REQOPERKEY
        {
            get { return _CAR_REQOPERKEY; }
            set { SetPropertyValue("CAR_REQOPERKEY", ref _CAR_REQOPERKEY, value); }
        }

        string _CAR_NUMBER;
        /// <summary>
        /// Номер авто.
        /// </summary>
        [DisplayName("Номер авто")]
        [Size(16)]
        [DBAttribute(DisplayMember = true)]
        public string CAR_NUMBER
        {
            get { return _CAR_NUMBER; }
            set { SetPropertyValue("CAR_NUMBER", ref _CAR_NUMBER, value); }
        }

        string _CAR_MARKA;
        /// <summary>
        /// Модель авто.
        /// </summary>
        [DisplayName("Модель авто")]
        [Size(50)]
        public string CAR_MARKA
        {
            get { return _CAR_MARKA; }
            set { SetPropertyValue("CAR_MARKA", ref _CAR_MARKA, value); }
        }

        int _CAR_DAYLIMIT;
        /// <summary>
        /// Суточный лимит.
        /// </summary>
        [DisplayName("Суточный лимит")]
        public int CAR_DAYLIMIT
        {
            get { return _CAR_DAYLIMIT; }
            set { SetPropertyValue("CAR_DAYLIMIT", ref _CAR_DAYLIMIT, value); }
        }

        int _CAR_ALLLIMIT;
        /// <summary>
        /// Общий лимит.
        /// </summary>
        [DisplayName("Общий лимит")]
        public int CAR_ALLLIMIT
        {
            get { return _CAR_ALLLIMIT; }
            set { SetPropertyValue("CAR_ALLLIMIT", ref _CAR_ALLLIMIT, value); }
        }

        DateTime _CAR_TIMELIMIT;
        /// <summary>
        /// Прекратить обслуживание.
        /// </summary>
        [DisplayName("Прекратить обслуживание")]
        public DateTime CAR_TIMELIMIT
        {
            get { return _CAR_TIMELIMIT; }
            set { SetPropertyValue("CAR_TIMELIMIT", ref _CAR_TIMELIMIT, value); }
        }

        bool _CAR_ENABLED;
        /// <summary>
        /// Доступен.
        /// </summary>
        [DisplayName("Доступен")]
        public bool CAR_ENABLED
        {
            get { return _CAR_ENABLED; }
            set { SetPropertyValue("CAR_ENABLED", ref _CAR_ENABLED, value); }
        }

        bool _CAR_ISDELETE;
        /// <summary>
        /// Удален.
        /// </summary>
        [DisplayName("Удален")]
        public bool CAR_ISDELETE
        {
            get { return _CAR_ISDELETE; }
            set { SetPropertyValue("CAR_ISDELETE", ref _CAR_ISDELETE, value); }
        }
    }
    #endregion 

    #region TIDELOG
    /// <summary>
    /// Таблица "Отгрузка".
    /// </summary>
    [DBAttribute(Caption = "Отгрузка", IconFile = "TIDELOG.png")]
    public class TIDELOG : XPLiteObject
    {
        public TIDELOG(Session session) : base(session) { }
        public TIDELOG() : base(Session.DefaultSession) { }

        KMAZS _KM_ID;
        /// <summary>
        /// КМАЗС.
        /// </summary>
        [DisplayName("КМАЗС")]
        public KMAZS KM_ID
        {
            get { return _KM_ID; }
            set { SetPropertyValue("KM_ID", ref _KM_ID, value); }
        }

        int _TD_KMRECID;
        /// <summary>
        /// Запись.
        /// </Запись>
        [DisplayName("Запись")]
        [Key]
        public int TD_KMRECID
        {
            get { return _TD_KMRECID; }
            set { SetPropertyValue("TD_KMRECID", ref _TD_KMRECID, value); }
        }

        OPERATORS _OP_ID;
        /// <summary>
        /// Оператор.
        /// </summary>
        [DisplayName("Оператор")]
        public OPERATORS OP_ID
        {
            get { return _OP_ID; }
            set { SetPropertyValue("OP_ID", ref _OP_ID, value); }
        }

        CARS _CAR_ID;
        /// <summary>
        /// Машина.
        /// </summary>
        [DisplayName("Машина")]
        public CARS CAR_ID
        {
            get { return _CAR_ID; }
            set { SetPropertyValue("CAR_ID", ref _CAR_ID, value); }
        }

        DateTime _TD_TIME;
        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public DateTime TD_TIME
        {
            get { return _TD_TIME; }
            set { SetPropertyValue("TD_TIME", ref _TD_TIME, value); }
        }

        float _TD_LITERS;
        /// <summary>
        /// Литры.
        /// </summary>
        [DisplayName("Литры")]
        public float TD_LITERS
        {
            get { return _TD_LITERS; }
            set { SetPropertyValue("TD_LITERS", ref _TD_LITERS, value); }
        }

        /// <summary>
        /// Ближайнее время резервуара.
        /// </summary>
        [DisplayName("Ближайнее время резервуара")]
        [NonPersistent]
        public DateTime TankTime { get; set; }

        /// <summary>
        /// Уровень резервуара.
        /// </summary>
        [DisplayName("Уровень резервуара")]
        [NonPersistent]
        public double TankLevel { get; set; }

        /// <summary>
        /// Температура резервуара.
        /// </summary>
        [DisplayName("Температура резервуара")]
        [NonPersistent]
        public double TankTemperature { get; set; }

        /// <summary>
        /// Плотность резервуара.
        /// </summary>
        [DisplayName("Плотность резервуара")]
        [NonPersistent]
        public double TankDensity { get; set; }
    }
    #endregion

    #region TANKCONFIG
    /// <summary>
    /// Таблица "Резервуар".
    /// </summary>
    [DBAttribute(Caption = "Резервуар", IconFile = "TANKCONFIG.png")]
    public class TANKCONFIG : XPLiteObject
    {
        public TANKCONFIG() : base(Session.DefaultSession) { }

        public TANKCONFIG(Session session) : base(session) { }

        int _TC_NUM;
        /// <summary>
        /// Резервуар.
        /// </summary>
        [DisplayName("Резервуар")]
        public int TC_NUM
        {
            get { return _TC_NUM; }
            set { SetPropertyValue("TC_NUM", ref _TC_NUM, value); }
        }

        KMAZS _KM_ID;
        /// <summary>
        /// КМАЗС.
        /// </summary>
        [DisplayName("КМАЗС")]
        [Key]
        public KMAZS KM_ID
        {
            get { return _KM_ID; }
            set { SetPropertyValue("KM_ID", ref _KM_ID, value); }
        }

        string _TC_COMMENT;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(100)]
        public string TC_COMMENT
        {
            get { return _TC_COMMENT; }
            set { SetPropertyValue("TC_COMMENT", ref _TC_COMMENT, value); }
        }

        int _TC_VOLUME;
        /// <summary>
        /// Полный объем.
        /// </summary>
        [DisplayName("Полный объем")]
        public int TC_VOLUME
        {
            get { return _TC_VOLUME; }
            set { SetPropertyValue("TC_VOLUME", ref _TC_VOLUME, value); }
        }

        int _TC_HEIGHT;
        /// <summary>
        /// Высота.
        /// </summary>
        [DisplayName("Высота")]
        public int TC_HEIGHT
        {
            get { return _TC_HEIGHT; }
            set { SetPropertyValue("TC_HEIGHT", ref _TC_HEIGHT, value); }
        }


        int _TC_MAXLITERS;
        /// <summary>
        /// Макс. объем.
        /// </summary>
        [DisplayName("Макс. объем")]
        public int TC_MAXLITERS
        {
            get { return _TC_MAXLITERS; }
            set { SetPropertyValue("TC_MAXLITERS", ref _TC_MAXLITERS, value); }
        }

        int _TC_SIGNALLITERS;
        /// <summary>
        /// Сигнальный порог.
        /// </summary>
        [DisplayName("Сигнальный порог")]
        public int TC_SIGNALLITERS
        {
            get { return _TC_SIGNALLITERS; }
            set { SetPropertyValue("TC_SIGNALLITERS", ref _TC_SIGNALLITERS, value); }
        }
        
        GSMTYPE _GSM_ID;
        /// <summary>
        /// ГСМ.
        /// </summary>
        [DisplayName("ГСМ")]        
        public GSMTYPE GSM_ID
        {
            get { return _GSM_ID; }
            set { SetPropertyValue("GSM_ID", ref _GSM_ID, value); }
        }

        DateTime _TC_ST_TIME;
        /// <summary>
        /// Время опроса.
        /// </summary>
        [DisplayName("Время опроса")]
        public DateTime TC_ST_TIME
        {
            get { return _TC_ST_TIME; }
            set { SetPropertyValue("TC_ST_TIME", ref _TC_ST_TIME, value); }
        }

        int _TC_ST_LEVEL;
        /// <summary>
        /// Уровень топлива.
        /// </summary>
        [DisplayName("Уровень топлива")]
        public int TC_ST_LEVEL
        {
            get { return _TC_ST_LEVEL; }
            set { SetPropertyValue("TC_ST_LEVEL", ref _TC_ST_LEVEL, value); }
        }

        int _TC_ST_VOLUME;
        /// <summary>
        /// Объем топлива.
        /// </summary>
        [DisplayName("Объем топлива")]
        public int TC_ST_VOLUME
        {
            get { return _TC_ST_VOLUME; }
            set { SetPropertyValue("TC_ST_VOLUME", ref _TC_ST_VOLUME, value); }
        }

        int _TC_ST_WATERLEVEL;
        /// <summary>
        /// Уровень воды.
        /// </summary>
        [DisplayName("Уровень воды")]
        public int TC_ST_WATERLEVEL
        {
            get { return _TC_ST_WATERLEVEL; }
            set { SetPropertyValue("TC_ST_WATERLEVEL", ref _TC_ST_WATERLEVEL, value); }
        }

        short _TC_ST_PLOTN;
        /// <summary>
        /// Плотность.
        /// </summary>
        [DisplayName("Плотность")]
        public short TC_ST_PLOTN
        {
            get { return _TC_ST_PLOTN; }
            set { SetPropertyValue("TC_ST_PLOTN", ref _TC_ST_PLOTN, value); }
        }

        short _TC_ST_TEMPER;
        /// <summary>
        /// Температура.
        /// </summary>
        [DisplayName("Температура")]
        public short TC_ST_TEMPER
        {
            get { return _TC_ST_TEMPER; }
            set { SetPropertyValue("TC_ST_TEMPER", ref _TC_ST_TEMPER, value); }
        }
    }
    #endregion

    #region GSMTYPE
    /// <summary>
    /// Таблица "ГСМ".
    /// </summary>
    [DBAttribute(Caption = "ГСМ", IconFile = "GSMTYPE.png")]
    public class GSMTYPE : XPLiteObject
    {
        public GSMTYPE() : base(Session.DefaultSession) { }

        public GSMTYPE(Session session) : base(session) { }

        int _GSM_ID;
        /// <summary>
        /// GSM_ID.
        /// </summary>
        [DisplayName("GSM_ID")]
        [Key]
        [NullValue(0)]
        public int GSM_ID
        {
            get { return _GSM_ID; }
            set { SetPropertyValue("GSM_ID", ref _GSM_ID, value); }
        }

        string _GSM_NAME;
        /// <summary>
        /// Имя.
        /// </summary>
        [DisplayName("Имя")]
        [Size(50)]
        public string GSM_NAME
        {
            get { return _GSM_NAME; }
            set { SetPropertyValue("GSM_NAME", ref _GSM_NAME, value); }
        }

        string _GSM_SHORTNAME;
        /// <summary>
        /// Короткое имя.
        /// </summary>
        [DisplayName("Короткое имя")]
        [Size(4)]
        [DBAttribute(DisplayMember = true)]
        public string GSM_SHORTNAME
        {
            get { return _GSM_SHORTNAME; }
            set { SetPropertyValue("GSM_SHORTNAME", ref _GSM_SHORTNAME, value); }
        }

        bool _GSM_ISDELETE;
        /// <summary>
        /// Удален.
        /// </summary>
        [DisplayName("Удален")]
        public bool GSM_ISDELETE
        {
            get { return _GSM_ISDELETE; }
            set { SetPropertyValue("GSM_ISDELETE", ref _GSM_ISDELETE, value); }
        }

    }
    #endregion

    #region TANKHISTORY
    /// <summary>
    /// Таблица "Опрос резервуаров".
    /// </summary>
    [DBAttribute(Caption = "Опрос резервуаров", IconFile = "TANKHISTORY.png")]
    public class TANKHISTORY : XPLiteObject
    {
        public TANKHISTORY() : base(Session.DefaultSession) { }

        public TANKHISTORY(Session session) : base(session) { }

        KMAZS _KM_ID;
        /// <summary>
        /// КМАЗС.
        /// </summary>
        [DisplayName("КМАЗС")]
        public KMAZS KM_ID
        {
            get { return _KM_ID; }
            set { SetPropertyValue("KM_ID", ref _KM_ID, value); }
        }

        int _TC_NUM;
        /// <summary>
        /// Резервуар.
        /// </summary>
        [DisplayName("Резервуар")]
        public int TC_NUM
        {
            get { return _TC_NUM; }
            set { SetPropertyValue("TC_NUM", ref _TC_NUM, value); }
        }

        DateTime _TH_ST_TIME;
        /// <summary>
        /// Время опроса.
        /// </summary>
        [DisplayName("Время опроса")]
        public DateTime TH_ST_TIME
        {
            get { return _TH_ST_TIME; }
            set { SetPropertyValue("TH_ST_TIME", ref _TH_ST_TIME, value); }
        }

        int _TH_ST_LEVEL;
        /// <summary>
        /// Уровень.
        /// </summary>
        [DisplayName("Уровень")]
        public int TH_ST_LEVEL
        {
            get { return _TH_ST_LEVEL; }
            set { SetPropertyValue("TH_ST_LEVEL", ref _TH_ST_LEVEL, value); }
        }

        int _TH_ST_VOLUME;
        /// <summary>
        /// Объем.
        /// </summary>
        [DisplayName("Объем")]
        public int TH_ST_VOLUME
        {
            get { return _TH_ST_VOLUME; }
            set { SetPropertyValue("TH_ST_VOLUME", ref _TH_ST_VOLUME, value); }
        }

        int _TH_ST_WATERLEVEL;
        /// <summary>
        /// Уровень воды.
        /// </summary>
        [DisplayName("Уровень воды")]
        public int TH_ST_WATERLEVEL
        {
            get { return _TH_ST_WATERLEVEL; }
            set { SetPropertyValue("TH_ST_WATERLEVEL", ref _TH_ST_WATERLEVEL, value); }
        }

        short _TH_ST_PLOTN;
        /// <summary>
        /// Плотность.
        /// </summary>
        [DisplayName("Плотность")]
        public short TH_ST_PLOTN
        {
            get { return _TH_ST_PLOTN; }
            set { SetPropertyValue("TH_ST_PLOTN", ref _TH_ST_PLOTN, value); }
        }

        short _TH_ST_TEMPER;
        /// <summary>
        /// Температура.
        /// </summary>
        [DisplayName("Температура")]
        public short TH_ST_TEMPER
        {
            get { return _TH_ST_TEMPER; }
            set { SetPropertyValue("TH_ST_TEMPER", ref _TH_ST_TEMPER, value); }
        }
        /*
        GSMTYPE _GSM_ID;
        /// <summary>
        /// ГСМ.
        /// </summary>
        [DisplayName("ГСМ")]
        [NullValue(0)]
        public GSMTYPE GSM_ID
        {
            get { return _GSM_ID; }
            set { SetPropertyValue("GSM_ID", ref _GSM_ID, value); }
        }
         */

        int _TH_ORDERNUM;
        /// <summary>
        /// Порядковый №.
        /// </summary>
        [DisplayName("Порядковый №")]
        [Key]
        public int TH_ORDERNUM
        {
            get { return _TH_ORDERNUM; }
            set { SetPropertyValue("TH_ORDERNUM", ref _TH_ORDERNUM, value); }
        }

        int _TH_ISTIDE;
        /// <summary>
        /// Caption.
        /// </summary>
        [DisplayName("Caption")]
        public int TH_ISTIDE
        {
            get { return _TH_ISTIDE; }
            set { SetPropertyValue("TH_ISTIDE", ref _TH_ISTIDE, value); }
        }

        DateTime _TH_ADDTIME;
        /// <summary>
        /// Время добавления.
        /// </summary>
        [DisplayName("Время добавления")]
        public DateTime TH_ADDTIME
        {
            get { return _TH_ADDTIME; }
            set { SetPropertyValue("TH_ADDTIME", ref _TH_ADDTIME, value); }
        }
    }
    #endregion
}
