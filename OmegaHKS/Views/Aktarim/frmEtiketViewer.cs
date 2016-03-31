using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Neodynamic.SDK.Printing;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmEtiketViewer : BaseForm
    {
        private double _dpi = 96;
        //private double _solBosluk = 0;
        //private double _ustBosluk = 0;
        private ThermalLabel _currentThermalLabel = null;
        private int _currentEtiketIndex = -1;
        private ImageSettings _imgSettings = new ImageSettings();
        private IList<Models.EtiketEkranListe> etkList = new List<Models.EtiketEkranListe>();

        public frmEtiketViewer(List<Models.EtiketEkranListe> model)
        {
            InitializeComponent();
            this.etkList = model;
            beCozunurluk.EditValue = "Ekran";
            DisplayThermalLabel();
        }

        private void DisplayThermalLabel()
        {
            var copies = 1;
            try
            {
                _currentThermalLabel = GenerateThermalLabelDataBinding();
                if (_currentThermalLabel != null)
                {
                    using (var pj = new PrintJob())
                    {
                        pj.ThermalLabel = _currentThermalLabel;
                        pj.Copies = copies;
                        var ms = new System.IO.MemoryStream();
                        pj.ExportToImage(ms, new ImageSettings(ImageFormat.Tiff), _dpi);

                        uscImageViewer1.LoadImage(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} // {1}", ex.ToString(), ex.Source.ToString()));
            }
        }

        private ThermalLabel GenerateThermalLabelDataBinding()
        {
            ThermalLabel tLabel = new ThermalLabel(UnitType.Cm, 8, 3);
            tLabel.GapLength = 0.2;
            var satir = 0.1d;

            /// Künye No
            TextItem txtKunyeNoLbl = new TextItem(0.1, satir, 1.19, 0.25, "Künye No:");
            txtKunyeNoLbl.Font.Name = "Arial Narrow";
            txtKunyeNoLbl.Font.Unit = FontUnit.Point;
            txtKunyeNoLbl.Font.Size = 6;
            txtKunyeNoLbl.TextAlignment = TextAlignment.Left;
            txtKunyeNoLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtKunyeNoData = new TextItem(1.2, satir, 6, 0.25, "");
            txtKunyeNoData.DataField = "KUNYENO";
            txtKunyeNoData.Font.Name = "Arial Narrow";
            txtKunyeNoData.Font.Unit = FontUnit.Point;
            txtKunyeNoData.Font.Size = 6;
            txtKunyeNoData.TextAlignment = TextAlignment.Left;
            txtKunyeNoData.TextPadding = new FrameThickness(0, 0, 0, 0);
            
            /// Üretim Tarihi
            satir += 0.26;
            TextItem txtUretimTarihLbl = new TextItem(0.1, satir, 1.19, 0.25, "Üretim Tarihi:");
            txtUretimTarihLbl.Font.Name = "Arial Narrow";
            txtUretimTarihLbl.Font.Unit = FontUnit.Point;
            txtUretimTarihLbl.Font.Size = 6;
            txtUretimTarihLbl.TextAlignment = TextAlignment.Left;
            txtUretimTarihLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtUretimTarihData = new TextItem(1.2, satir, 6, 0.25, "");
            txtUretimTarihData.DataField = "URETIMTARIH";
            txtUretimTarihData.Font.Name = "Arial Narrow";
            txtUretimTarihData.Font.Unit = FontUnit.Point;
            txtUretimTarihData.Font.Size = 6;
            txtUretimTarihData.TextAlignment = TextAlignment.Left;
            txtUretimTarihData.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Menşei
            satir += 0.26;
            TextItem txtMenseiLbl = new TextItem(0.1, satir, 1.19, 0.25, "Mensei:");
            txtMenseiLbl.Font.Name = "Arial Narrow";
            txtMenseiLbl.Font.Unit = FontUnit.Point;
            txtMenseiLbl.Font.Size = 6;
            txtMenseiLbl.TextAlignment = TextAlignment.Left;
            txtMenseiLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtMenseiData = new TextItem(1.2, satir, 6, 0.25, "");
            txtMenseiData.DataField = "URETIMYERI";
            txtMenseiData.Font.Name = "Arial Narrow";
            txtMenseiData.Font.Unit = FontUnit.Point;
            txtMenseiData.Font.Size = 6;
            txtMenseiData.TextAlignment = TextAlignment.Left;
            txtMenseiData.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Üreticinin Adi
            satir += 0.26;
            TextItem txtUreticiAdiLbl = new TextItem(0.1, satir, 1.19, 0.25, "Üreticinin Adi:");
            txtUreticiAdiLbl.Font.Name = "Arial Narrow";
            txtUreticiAdiLbl.Font.Unit = FontUnit.Point;
            txtUreticiAdiLbl.Font.Size = 6;
            txtUreticiAdiLbl.TextAlignment = TextAlignment.Left;
            txtUreticiAdiLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtUreticiAdiData = new TextItem(1.2, satir, 6.8, 0.25, "");
            txtUreticiAdiData.DataField = "URETICI";
            txtUreticiAdiData.Font.Name = "Arial Narrow";
            txtUreticiAdiData.Font.Unit = FontUnit.Point;
            txtUreticiAdiData.Font.Size = 6;
            txtUreticiAdiData.TextAlignment = TextAlignment.Left;
            txtUreticiAdiData.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Üretim Şekli
            satir += 0.26;
            TextItem txtUretimSekliLbl = new TextItem(0.1, satir, 1.19, 0.25, "Üretim Sekli:");
            txtUretimSekliLbl.Font.Name = "Arial Narrow";
            txtUretimSekliLbl.Font.Unit = FontUnit.Point;
            txtUretimSekliLbl.Font.Size = 5;
            txtUretimSekliLbl.TextAlignment = TextAlignment.Left;
            txtUretimSekliLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtUretimSekliData = new TextItem(1.20, satir, 6, 0.25, "");
            txtUretimSekliData.DataField = "URETIMSEKLI";
            txtUretimSekliData.Font.Name = "Arial Narrow";
            txtUretimSekliData.Font.Unit = FontUnit.Point;
            txtUretimSekliData.Font.Size = 5;
            txtUretimSekliData.TextAlignment = TextAlignment.Left;
            txtUretimSekliData.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Stok Kodu
            satir += 0.28;
            TextItem txtStkKod = new TextItem(0.1, satir+0.12, 1.19, 0.27, "");
            txtStkKod.DataField = "STKKOD";
            txtStkKod.Font.Name = "Arial Narrow";
            txtStkKod.Font.Unit = FontUnit.Point;
            txtStkKod.Font.Size = 7;
            txtStkKod.TextAlignment = TextAlignment.Left;
            txtStkKod.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Stok Adi
            TextItem txtStokAdi = new TextItem(1.20, satir, 6, 0.35, "");
            txtStokAdi.DataField = "STOKAD";
            txtStokAdi.Font.Name = "Arial Narrow";
            txtStokAdi.Font.Unit = FontUnit.Point;
            txtStokAdi.Font.Size = 10;
            txtStokAdi.TextAlignment = TextAlignment.Left;
            txtStokAdi.TextPadding = new FrameThickness(0, 0, 0, 0);

            /// Stok Satis Fiati
            satir += 0.5;
            TextItem txtStokSatFiyatLbl = new TextItem(0.2, satir+0.1, 1.3, 0.88, "Fiyat :");
            txtStokSatFiyatLbl.Font.Name = "Arial Narrow";
            txtStokSatFiyatLbl.Font.Unit = FontUnit.Point;
            txtStokSatFiyatLbl.Font.Size = 15;
            txtStokSatFiyatLbl.Font.Bold = true;
            txtStokSatFiyatLbl.TextAlignment = TextAlignment.Left;
            txtStokSatFiyatLbl.TextPadding = new FrameThickness(0, 0, 0, 0);

            TextItem txtStokSatFiyat = new TextItem(1.4, satir, 3, 0.88, "");
            txtStokSatFiyat.DataField = "SFIYAT";
            txtStokSatFiyat.Font.Name = "Arial Narrow";
            txtStokSatFiyat.Font.Unit = FontUnit.Point;
            txtStokSatFiyat.Font.Size = 18;
            txtStokSatFiyat.Font.Bold = true;
            txtStokSatFiyat.TextAlignment = TextAlignment.Left;
            txtStokSatFiyat.TextPadding = new FrameThickness(0, 0, 0, 0);


            /// Stok Barkod
            var eanBarcode = new BarcodeItem(5, satir, 2.5, 0.8, BarcodeSymbology.Ean8, "")
            { BarHeight = 0.5, BarWidth = 0.02, EanUpcGuardBarHeight = 0.55, AddChecksum = true };
            eanBarcode.DataField = "BARKOD";
            eanBarcode.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA;
            eanBarcode.Font.Unit = FontUnit.Point;
            eanBarcode.Font.Size = 2;
            eanBarcode.Sizing = BarcodeSizing.Fill;
            eanBarcode.RotationAngle=0;

            tLabel.Items.Add(txtKunyeNoLbl);
            tLabel.Items.Add(txtKunyeNoData);
            tLabel.Items.Add(txtUretimTarihLbl);
            tLabel.Items.Add(txtUretimTarihData);
            tLabel.Items.Add(txtMenseiLbl);
            tLabel.Items.Add(txtMenseiData);
            tLabel.Items.Add(txtUreticiAdiLbl);
            tLabel.Items.Add(txtUreticiAdiData);
            tLabel.Items.Add(txtUretimSekliLbl);
            tLabel.Items.Add(txtUretimSekliData);
            tLabel.Items.Add(txtStkKod);
            tLabel.Items.Add(txtStokAdi);
            tLabel.Items.Add(txtStokSatFiyatLbl);
            tLabel.Items.Add(txtStokSatFiyat);
            tLabel.Items.Add(eanBarcode);

            tLabel.DataSource = etkList;

            return tLabel;
        }

        private void beCozunurluk_EditValueChanged(object sender, EventArgs e)
        {
            double tmpDPI = 96;

            if (beCozunurluk.EditValue.ToString() != "Ekran")
            {
                tmpDPI = double.Parse(beCozunurluk.EditValue.ToString());
            }
            if (tmpDPI != _dpi)
            {
                _dpi = tmpDPI;
            }
            DisplayThermalLabel();
        }
        private void bbtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPrintJob = new Views.Main.PrintJobDialog();
            if (frmPrintJob.ShowDialog() == DialogResult.OK)
            {
                using (var pj = new PrintJob(frmPrintJob.PrinterSettings))
                {
                    pj.Copies = frmPrintJob.Copies;
                    pj.PrintOrientation = frmPrintJob.PrintOrientation;
                    pj.ThermalLabel = _currentThermalLabel;
                    pj.Print();
                }
            }
        }
        private void ExportToImage()
        {
            var sfd = new SaveFileDialog();

            if (_imgSettings.ImageFormat == ImageFormat.Png)
            {
                sfd.Filter = "PNG|*.png";
            }
            else
            {
                if (_imgSettings.ImageFormat == ImageFormat.Gif)
                {
                    sfd.Filter = "GIF|*.gif";
                }
                else
                {
                    if (_imgSettings.ImageFormat == ImageFormat.Jpeg)
                    {
                        sfd.Filter = "JPEG|*.jpg";
                    }
                    else
                    {
                        if (_imgSettings.ImageFormat == ImageFormat.Tiff)
                        {
                            sfd.Filter = "TIFF|*.tif";
                        }
                        else
                        {
                            if (_imgSettings.ImageFormat == ImageFormat.Bmp)
                            {
                                sfd.Filter = "BMP|*.bmp";
                            }
                        }
                    }
                }
            }
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var pj = new PrintJob())
                {
                    pj.ThermalLabel = _currentThermalLabel;


                    if (_currentEtiketIndex == 3 || _currentEtiketIndex == 4)
                    {
                        pj.Copies = 5;
                    }
                    pj.ExportToImage(sfd.FileName, _imgSettings, _dpi);



                    System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(sfd.FileName));
                }
            }
        }
        private void bbXmlTemplate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "XML Template|*.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, _currentThermalLabel.GetXmlTemplate());

                if (MessageBox.Show("XML Template saved! Do you want to open it?", "ThermalLabel SDK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }
        private void bbtnExportToPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Adobe PDF|*.pdf";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var pj = new PrintJob())
                {
                    pj.ThermalLabel = _currentThermalLabel;
                    if (_currentEtiketIndex == 3 || _currentEtiketIndex == 4)
                    {
                        pj.Copies = 5;
                    }
                    pj.ExportToPdf(sfd.FileName, _dpi);
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }
        private void bbPNG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _imgSettings.ImageFormat = ImageFormat.Png;
            ExportToImage();
        }
        private void bbJPEG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _imgSettings.ImageFormat = ImageFormat.Jpeg;
            ExportToImage();
        }
        private void bbTIFF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _imgSettings.ImageFormat = ImageFormat.Tiff;
            ExportToImage();
        }
        private void bbGIF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _imgSettings.ImageFormat = ImageFormat.Gif;
            ExportToImage();
        }
        private void bbBMP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _imgSettings.ImageFormat = ImageFormat.Bmp;
            ExportToImage();
        }
    }
}