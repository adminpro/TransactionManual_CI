using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BindingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelRequestInfo labelRequestInfo = new LabelRequestInfo();
            BindingContext bindContext=new BindingContext();
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length == 0)
            {
                SendKeys.Send("{HOME}");
            }
        }

        private void btnRichTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbHtml.Rtf = @"{\rtf1\ansi This is in \b bold\b0.}";
        }

        //MarkupConverter markupConverter = new MarkupConverter();

        //private string ConvertRtfToHtml(string rtfText)
        //{
        //    var thread = new Thread(ConvertRtfInSTAThread);
        //    var threadData = new ConvertRtfThreadData { RtfText = rtfText };
        //    thread.SetApartmentState(ApartmentState.STA);
        //    thread.Start(threadData);
        //    thread.Join();
        //    return threadData.HtmlText;
        //}

        //private void ConvertRtfInSTAThread(object rtf)
        //{
        //    var threadData = rtf as ConvertRtfThreadData;
        //    threadData.HtmlText = markupConverter.ConvertRtfToHtml(threadData.RtfText);
        //}
        //private class ConvertRtfThreadData
        //{
        //    public string RtfText { get; set; }
        //    public string HtmlText { get; set; }
        //}
    }
    
}
