using System;
using System.Collections.Generic;
using RapidInterface;
//using Domino;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraEditors;
using System.Configuration;

namespace GsmStat
{
    [DBAttribute(Caption = "Lotus", IconFile = "Lotus.png")]
    public partial class LotusView : DBViewBase
    {
        public LotusView()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitFormEx));
                SplashScreenManager.Default.SetWaitFormDescription("Происходит формирование отчета с SQL-сервера.");

                GSMReportx report = new GSMReportx();

                string password = txtPassword.Text;
                string server = txtServer.Text;
                string database = txtDatabase.Text;
                string sendTo = txtSendTo.Text;
                string copyTo = txtCopyTo.Text;
                string subject = txtSubject.Text;
                string dir = txtDir.Text;

                report.BeginDate.Value = deBeginDate.EditValue;
                report.EndDate.Value = deEndDate.EditValue;
                report.ExportOptions.Xls.ShowGridLines = true;
                report.RequestParameters = false;

                DateTime endDate = (DateTime)report.EndDate.Value;
                string fileName = string.Format("Отчет ГСМ ({0:0000}.{1:00}.{2:00}).xls", endDate.Year, endDate.Month, endDate.Day);
                string filePath = dir + fileName;
                report.ExportToXls(filePath);

                SplashScreenManager.Default.SetWaitFormDescription("Происходит отправка отчета по Lotus Notes.");

                //Thread.Sleep(5000);
                NotesSession _notesSession = new NotesSession();
                _notesSession.Initialize(password);
                NotesDatabase _notesDataBase = _notesSession.GetDatabase(server, database, false);

                if (!_notesDataBase.IsOpen)
                    _notesDataBase.Open();

                NotesDocument _notesDocument = _notesDataBase.CreateDocument();
                _notesDocument.ReplaceItemValue("SendTo", sendTo);
                _notesDocument.ReplaceItemValue("CopyTo", copyTo);
                _notesDocument.ReplaceItemValue("Subject", subject);

                NotesRichTextItem _richTextItem = _notesDocument.CreateRichTextItem("Body");

                //_richTextItem.AppendText("Отчет ГСМ\r\n");

                _richTextItem.EmbedObject(EMBED_TYPE.EMBED_ATTACHMENT, "", filePath);

                _notesDocument.Send(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ex.Source);
            }

            SplashScreenManager.CloseForm();
            */
        }

        private void LotusView_Load(object sender, EventArgs e)
        {
            deEndDate.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            deBeginDate.EditValue = (DateTime)deEndDate.EditValue - new TimeSpan(1, 0, 0, 0);
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.LotusPassword = txtPassword.Text;
                Properties.Settings.Default.LotusServer = txtServer.Text;
                Properties.Settings.Default.LotusDatabase = txtDatabase.Text;
                Properties.Settings.Default.LotusSendTo = txtSendTo.Text;
                Properties.Settings.Default.LotusCopyTo = txtCopyTo.Text;
                Properties.Settings.Default.LotusSubject = txtSubject.Text;
                Properties.Settings.Default.LotusDir =  txtDir.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void LotusView_FormUpdate(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = Properties.Settings.Default.LotusPassword;
                txtServer.Text = Properties.Settings.Default.LotusServer;
                txtDatabase.Text = Properties.Settings.Default.LotusDatabase;
                txtSendTo.Text = Properties.Settings.Default.LotusSendTo;
                txtCopyTo.Text = Properties.Settings.Default.LotusCopyTo;
                txtSubject.Text = Properties.Settings.Default.LotusSubject;
                txtDir.Text = Properties.Settings.Default.LotusDir;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}