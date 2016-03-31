using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace System
{
    public static class Extensions
    {
        public static List<TItem> GetDataSourceList<TItem>(this GridView view) where TItem: class
        {
            var dsControl = view.GridControl.DataSource;
            if (dsControl is BindingSource)
            {
                var bindingSource = dsControl as BindingSource;
                var iList = bindingSource.List as IList<TItem>;
                return iList.ToList();
            }
            else
            {
                return dsControl as List<TItem>;
            }
        }

        public static TItem GetDataSourceTItem<TItem>(this GridView view, int handle) where TItem: class
        {
            var dataSource = GetDataSourceList<TItem>(view);
            return dataSource[view.GetDataSourceRowIndex(handle)];
        }

        public static TItem GetFocusedItem<TItem>(this GridView view) where TItem: class
        {
            if (view.FocusedRowHandle < 0)
            {
                return null;
            }
            return GetDataSourceTItem<TItem>(view, view.FocusedRowHandle);
        }

        public static List<TItem> GetSelectedItems<TItem>(this GridView view) where TItem: class
        {
            var dataSource = GetDataSourceList<TItem>(view);
            var seclilenler = view.GetSelectedRows();
            if (dataSource.Count == seclilenler.Length)
            {
                return dataSource;
            }
            var result = new List<TItem>();
            foreach (int handle in seclilenler)
            {
                result.Add(GetDataSourceTItem<TItem>(view, handle));
            }
            return result;
        }

        public static void SecimColumnGoster(this GridView view)
        {
            view.OptionsSelection.MultiSelect = true;
            view.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            view.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
        }

        public static void ExcellAktar(this GridView view)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            view.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            view.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            view.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            view.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            view.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            view.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = string.Format("Dosya Açılamadı{0}{1}Path: {2}", Environment.NewLine, Environment.NewLine, exportFilePath);
                            MessageBox.Show(msg, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = string.Format("Dosya Kaydedilemedi.{0}{1}Path: {2}", Environment.NewLine, Environment.NewLine, exportFilePath);
                        MessageBox.Show(msg, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}

