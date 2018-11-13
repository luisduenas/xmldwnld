using OfficeOpenXml;
using OfficeOpenXml.Style;
using SplashSample;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        //Admin
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
        private void createExcel()
        {

            try
            {
                MessageBox.Show("Primero seleccione la carpeta donde se encuentran los XML a importar!");
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        Properties.Settings.Default["xmlFilesPath"] = fbd.SelectedPath;
                        Properties.Settings.Default.Save(); // Saves settings in application configuration file
                    }
                    else
                    {
                        throw new Exception("No se selecciono ninguna carpeta, intente de nuevo para poder continuar.");
                    }
                }
                MessageBox.Show("Seleccione la carpeta donde se guardara el Excel generado.(Opcional)");
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        Properties.Settings.Default["xlsExportPath"] = fbd.SelectedPath;
                        Properties.Settings.Default.Save(); // Saves settings in application configuration file
                    }
                    else
                    {
                        MessageBox.Show($"No se selecciono ninguna carpeta, se guardara en la carpeta anterior({Properties.Settings.Default["xlsExportPath"]})");
                    }
                }

                //check if theres any file to read
                string[] files = Directory.GetFiles(Properties.Settings.Default["xmlFilesPath"].ToString(), "*.xml");
                if (files.Length == 0)
                {
                    throw new Exception("No se encontraron archivos para importar");
                }

                XmlSerializer serializer;
                serializer = new XmlSerializer(typeof(Comprobante));

                StringReader rdr;
                int registro = 1;
                Comprobante response;
                ExcelPackage ExcelPkg = new ExcelPackage();
                ExcelWorksheet wsSheet = ExcelPkg.Workbook.Worksheets.Add("Libro1");


                Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#B7DEE8");

                wsSheet.Cells[registro, 1].Value = "Version";
                wsSheet.Cells[registro, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 1].Style.Fill.BackgroundColor.SetColor(colFromHex);


                wsSheet.Cells[registro, 2].Value = "Tipo";
                wsSheet.Cells[registro, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 2].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 3].Value = "Fecha Emision";
                wsSheet.Cells[registro, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 3].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 4].Value = "Fecha Timbrado";
                wsSheet.Cells[registro, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 4].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 5].Value = "Folio";
                wsSheet.Cells[registro, 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 5].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 6].Value = "UUID";
                wsSheet.Cells[registro, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 6].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 7].Value = "RFC Emisor";
                wsSheet.Cells[registro, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 7].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 8].Value = "Nombre Emisor";
                wsSheet.Cells[registro, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 8].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 9].Value = "LugarDeExpedicion";
                wsSheet.Cells[registro, 9].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 9].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 10].Value = "RFC Receptor";
                wsSheet.Cells[registro, 10].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 10].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 11].Value = "Nombre Receptor";
                wsSheet.Cells[registro, 11].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 11].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 12].Value = "Subtotal";
                wsSheet.Cells[registro, 12].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 12].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 13].Value = "Total IEPS";
                wsSheet.Cells[registro, 13].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 13].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 14].Value = "IVA 16%";
                wsSheet.Cells[registro, 14].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 14].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 15].Value = "Total";
                wsSheet.Cells[registro, 15].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 15].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 16].Value = "Total traslados";
                wsSheet.Cells[registro, 16].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 16].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 17].Value = "Moneda";
                wsSheet.Cells[registro, 17].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 17].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 18].Value = "Forma De Pago";
                wsSheet.Cells[registro, 18].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 18].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 19].Value = "Metodo de Pago";
                wsSheet.Cells[registro, 19].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 19].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 20].Value = "Condicion de Pago";
                wsSheet.Cells[registro, 20].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 20].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 21].Value = "Conceptos";
                wsSheet.Cells[registro, 21].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 21].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 22].Value = "Combustible";
                wsSheet.Cells[registro, 22].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 22].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 23].Value = "IEPS 3%";
                wsSheet.Cells[registro, 23].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 23].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 24].Value = "IEPS 6%";
                wsSheet.Cells[registro, 24].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 24].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 25].Value = "IEPS 7%";
                wsSheet.Cells[registro, 25].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 25].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 26].Value = "IEPS 8%";
                wsSheet.Cells[registro, 26].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 26].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 27].Value = "IEPS 9%";
                wsSheet.Cells[registro, 27].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 27].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 28].Value = "IEPS 26.5%";
                wsSheet.Cells[registro, 28].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 28].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 29].Value = "IEPS 30%";
                wsSheet.Cells[registro, 29].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 29].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 30].Value = "IEPS 53%";
                wsSheet.Cells[registro, 30].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 30].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 31].Value = "IEPS 160%";
                wsSheet.Cells[registro, 31].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 31].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 32].Value = "Direccion Emisor";
                wsSheet.Cells[registro, 32].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 32].Style.Fill.BackgroundColor.SetColor(colFromHex);

                wsSheet.Cells[registro, 33].Value = "Localidad Emisor";
                wsSheet.Cells[registro, 33].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wsSheet.Cells[registro, 33].Style.Fill.BackgroundColor.SetColor(colFromHex);



                //Console.WriteLine("Iniciando migracion a excel...");
                pbDownload.Minimum = 0;
                pbDownload.Maximum = files.Length;
                pbDownload.Visible = true;


                foreach (string file in files)
                {
                    registro++;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        string contents = File.ReadAllText(file);
                        rdr = new StringReader(contents);
                        response = (Comprobante)serializer.Deserialize(rdr);

                    }
                    catch (Exception ex)
                    {
                        Console.ReadKey();
                        return;
                    }
                    wsSheet.Cells[registro, 1].Value = response.Version;
                    wsSheet.Cells[registro, 2].Value = response.TipoDeComprobante;
                    wsSheet.Cells[registro, 3].Value = response.Fecha.ToShortDateString();
                    //wsSheet.Cells[registro, 4].Value = response.Complemento != null ? response.Complemento.TimbreFiscalDigital.FechaTimbrado.ToShortDateString() : "";
                    wsSheet.Cells[registro, 5].Value = response.Folio;
                    wsSheet.Cells[registro, 6].Value = response.CfdiRelacionados?.CfdiRelacionado[0].UUID;
                    wsSheet.Cells[registro, 7].Value = response.Emisor.Rfc;
                    wsSheet.Cells[registro, 8].Value = response.Emisor.Nombre;
                    wsSheet.Cells[registro, 9].Value = response.LugarExpedicion;
                    wsSheet.Cells[registro, 10].Value = response.Receptor.Rfc;
                    wsSheet.Cells[registro, 11].Value = response.Receptor.Nombre;
                    wsSheet.Cells[registro, 12].Value = response.SubTotal;
                    //wsSheet.Cells[registro, 13].Value = "Total IEPS";
                    //wsSheet.Cells[registro, 14].Value = "IVA 16%";
                    //wsSheet.Cells[registro, 15].Value = "Total";
                    //wsSheet.Cells[registro, 16].Value = "Total traslados";
                    wsSheet.Cells[registro, 16].Value = response.Conceptos[0];
                    //wsSheet.Cells[registro, 17].Value = "Moneda";
                    //wsSheet.Cells[registro, 18].Value = "Forma De Pago";
                    //wsSheet.Cells[registro, 19].Value = "Metodo de Pago";
                    //wsSheet.Cells[registro, 20].Value = "Condicion de Pago";
                    //wsSheet.Cells[registro, 21].Value = "Conceptos";
                    //wsSheet.Cells[registro, 22].Value = "Combustible";
                    //wsSheet.Cells[registro, 23].Value = "IEPS 3%";
                    //wsSheet.Cells[registro, 24].Value = "IEPS 6%";
                    //wsSheet.Cells[registro, 25].Value = "IEPS 7%";
                    //wsSheet.Cells[registro, 26].Value = "IEPS 8%";
                    //wsSheet.Cells[registro, 27].Value = "IEPS 9%";
                    //wsSheet.Cells[registro, 28].Value = "IEPS 26.5%";
                    //wsSheet.Cells[registro, 29].Value = "IEPS 30%";
                    //wsSheet.Cells[registro, 30].Value = "IEPS 53%";
                    //wsSheet.Cells[registro, 31].Value = "IEPS 160%";
                    //wsSheet.Cells[registro, 32].Value = "Direccion Emisor";
                    //wsSheet.Cells[registro, 33].Value = "Localidad Emisor";
                    pbDownload.Value += 1;

                }
                wsSheet.Protection.IsProtected = false;
                wsSheet.Protection.AllowSelectLockedCells = false;
                ExcelPkg.SaveAs(new FileInfo($@"{Properties.Settings.Default["xlsExportPath"].ToString()}\Facturas-{DateTime.Now.ToShortDateString()}.xlsx"));
                MessageBox.Show("Importación finalizada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pbDownload.Visible = false;
            }
        }
        //Events
        private void xmldwnld_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lblTitle.Text = $"brainstorm";
            lblVersion.Text = $"v{version.Major}.{version.Minor}.{version.Build}";
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnExportaExcel_Click(object sender, EventArgs e)
        {
            createExcel();
        }
        //Main
        [STAThread]
        static void Main()
        {
            SplashFadeAppContext splashContext = new SplashFadeAppContext(new xmldwnld(), new Splash());

            splashContext.DoFadeOpen = false;
            splashContext.DoFadeClose = false;
            splashContext.SecondsSplashShown = 3;

            Application.Run(splashContext);
        }
    }
}
