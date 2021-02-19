using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserFunctions
{
    public partial class Form1 : Form
    {
        WebBrowser webTab = null;
        History history = null;
        WriteHTML writeHTML = null;
        
        public Form1()
        {
            InitializeComponent();
            history = new History();
            writeHTML = new WriteHTML();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textURL.Focus();
            webBrowser.Navigate(System.AppContext.BaseDirectory + "Links.html");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }
        private string normURL(string text)
        {
            text.Trim();
            //^(https)?(http)?(://)?\w{3}?\.?\w+\.?\w{3,5}.*$
            Regex completeURL = new Regex("^(https)?(http)?(://)?\\w{3}?\\.?\\w+\\.?\\w{3,5}.*$");
            if (!completeURL.IsMatch(text))
            {
                return $"https://{text}";
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                Regex isSearch = new Regex("^¿?([\\wáéíóú]+\\s?)+\\??$");
                if (isSearch.IsMatch(textURL.Text))
                {
                    web.Navigate($"http://www.google.com/search?q={textURL.Text.Trim()}");
                    textURL.Text = $"http://www.google.com/search?q={textURL.Text.Trim()}";
                    web.DocumentCompleted += WebBrowser_DocumentCompleted;
                }
                else
                {
                    textURL.Text = normURL(textURL.Text);
                    web.Navigate(textURL.Text);
                }
            }
            history.AddUrl(textURL.Text);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com/");
            webTab.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void textURL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    Regex isSearch = new Regex("^¿?([\\wáéíóú]+\\s?)+\\??$");
                    if (isSearch.IsMatch(textURL.Text))
                    {
                        textURL.Text = $" http://www.google.com/search?q={textURL.Text}";
                        web.Navigate(textURL.Text);
                    }
                    else
                    {
                        textURL.Text = normURL(textURL.Text);
                        web.Navigate(textURL.Text);
                    }
                    history.AddUrl(textURL.Text);
                }
            }
        }
    }
}