using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Silmoon.Web.UI
{
    /// <summary>
    /// �������ǰ�˽ű���ʵ��һЩ����
    /// </summary>
    public class WebForms
    {
        /// <summary>
        /// ����һ����Ϣ��
        /// </summary>
        /// <param name="Message">Ҫ��ʾ����Ϣ</param>
        public static void MessageBox(string Message)
        {
            Message = Message.Replace("\r", "\\r");
            Message = Message.Replace("\n", "\\n");
            Message = Message.Replace("\"", "\"\"\"\"");
            HttpContext.Current.Response.Write("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + Message + "');</script>");
        }
        /// <summary>
        /// ʹ�ýű��ķ�ʽת����һ��URL
        /// </summary>
        /// <param name="URL">Ҫת���URL</param>
        public static void ScriptRedirect(string URL)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">location.href='" + URL + "';</script>"); ;
        }
        /// <summary>
        /// ʹ�ýű���һ���µ�IE����
        /// </summary>
        /// <param name="URL">Ҫ��IE���ڵ�URL</param>
        public static void OpenWindow(string URL)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">window.open('" + URL + "');</script>");
        }
        /// <summary>
        /// ˢ�µ�ǰ��ҳ��
        /// </summary>
        public static void RefreshPage()
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">location.reload(location.href);</script>"); ;
        }
        /// <summary>
        /// ʹ�ýű��رյ�ǰҳ�档
        /// </summary>
        public static void ClosePage()
        {
            HttpContext.Current.Response.Write("<script language=\"javascript\" type=\"text/javascript\">window.opener=null;window.open('','_self');window.close();</script>");
        }
    }
}