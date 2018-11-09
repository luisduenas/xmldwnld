using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace xmldwnld
{
    public partial class xmldwnld : Form
    {
        HtmlElementCollection links;
        HtmlElementCollection folios;
        HtmlDocument document;
        WebBrowser webbrowser;
        Dictionary<string, string> urls;
        Regex regexURL = new Regex("RecuperaCfdi[^']+");
        Regex regexFolio = new Regex("(?:value=)\"([^ \"\r\n]*)\"");
        WebClient client = new WebClient();
        public xmldwnld()
        {
            InitializeComponent();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webbrowser = (WebBrowser)sender;
        }

        private void btnDescargaXML_Click(object sender, EventArgs e)
        {
            validaDescarga();
        }

        private void btnIrSat_Click(object sender, EventArgs e)
        {
            webbrowser.Url = new Uri("https://portalcfdi.facturaelectronica.sat.gob.mx");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default["downloadPath"] = fbd.SelectedPath;
                    Properties.Settings.Default.Save(); // Saves settings in application configuration file
                }
            }
        }

        private bool obtenerFoliosYLinks()
        {
            bool result = false;
            try
            {
                urls = new Dictionary<string, string>();
                document = webbrowser.Document;
                links = document.GetElementsByTagName("span");
                folios = document.GetElementsByTagName("input");
                links = links.GetElementsByName("BtnDescarga");
                folios = folios.GetElementsByName("ListaFolios");
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }
        private void validaDescarga()
        {
            try
            {
                if (webbrowser.Url.ToString().StartsWith("https://portalcfdi.facturaelectronica.sat.gob.mx"))
                {
                    if (obtenerFoliosYLinks())
                    {
                        realizaDescarga();
                    }
                }
                else
                {
                    MessageBox.Show("Primero filtre los folios a descargar");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void realizaDescarga()
        {
            try
            {
                for (int i = 0; i < links.Count; i++)
                {
                    Match o = regexURL.Match(links[i].OuterHtml);
                    if (o.Success)
                    {
                        Match f = regexFolio.Match(folios[i].OuterHtml);
                        if (f.Success)
                        {
                            urls.Add(f.Groups[1].Value, $"https://portalcfdi.facturaelectronica.sat.gob.mx/{o.Value}");
                        }
                    }
                }
                if (urls.Count == 0)
                {
                    MessageBox.Show("No hay ningun XML por descargar...");
                }
                else if (MessageBox.Show($"Quieres descargar {urls.Count} XML's ?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pbDownload.Minimum = 0;
                    pbDownload.Maximum = folios.Count;
                    pbDownload.Visible = true;
                    var cookies = FullWebBrowserCookie.GetCookieInternal(webbrowser.Url, false);
                    WebClient wc = new WebClient();
                    wc.Headers.Add("Cookie: " + cookies);
                    wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    foreach (var file in urls)
                    {
                        wc.DownloadFile(file.Value, $@"{Properties.Settings.Default["downloadPath"]}\{file.Key}.xml");
                        pbDownload.Value += 1;
                    }
                    pbDownload.Visible = false;
                    MessageBox.Show($"Descarga finalizada!, se descargaron {urls.Count} archivos en {Properties.Settings.Default["downloadPath"]} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la descarga");
            }
        }

        private void xmldwnld_Load(object sender, EventArgs e)
        {
            //var version = System.Windows.Forms.Application.ProductVersion;
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"brainstorm - xmldwnld V{version.Major}.{version.Minor}.{version.Build}";
            //    this.Text = $"brainstorm - xmldwnld V{version}";
        }
    }
}
