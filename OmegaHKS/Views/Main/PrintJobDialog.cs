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

namespace OmegaHKS.Views.Main
{
    public partial class PrintJobDialog : BaseForm
    {
        private PrinterSettings _printerSettings = new PrinterSettings();
        private int _copies = 1;
        private PrintOrientation _printOrientation = PrintOrientation.Portrait;

        public PrintJobDialog()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            cboProgLang.SelectedIndex = 0;
            cboPrintOrientation.SelectedIndex = 0;

            cboPrinters.Properties.Items.Clear();
            cboSerialPorts.Properties.Items.Clear();
            cboParity.Properties.Items.Clear();
            cboStopBits.Properties.Items.Clear();
            cboFlowControl.Properties.Items.Clear();

            foreach (string sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboPrinters.Properties.Items.Add(sPrinters);
                cboPrinters.SelectedIndex = 0;
            }

            foreach (string sSerialPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboSerialPorts.Properties.Items.Add(sSerialPort);
                cboSerialPorts.SelectedIndex = 0;
            }

            foreach (string sParity in Enum.GetNames(typeof(System.IO.Ports.Parity)))
            {
                cboParity.Properties.Items.Add(sParity);
                cboParity.SelectedIndex = 0;
            }

            foreach (string sStopBits in Enum.GetNames(typeof(System.IO.Ports.StopBits)))
            {
                cboStopBits.Properties.Items.Add(sStopBits);
                cboStopBits.SelectedIndex = 0;
            }

            foreach (string sHandshake in Enum.GetNames(typeof(System.IO.Ports.Handshake)))
            {
                cboFlowControl.Properties.Items.Add(sHandshake);
                cboFlowControl.SelectedIndex = 0;
            }
        }


        public PrinterSettings PrinterSettings
        {
            get
            {
                return _printerSettings;
            }
        }

        public int Copies
        {
            get
            {
                return _copies;
            }
        }

        public PrintOrientation PrintOrientation
        {
            get
            {
                return _printOrientation;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cboProgLang.SelectedItem.ToString() == string.Empty)
            {
                errorProvider1.SetError(cboProgLang, "Yazıcının programlama dilini seçiniz");
                return;
            }
            else
            {
                errorProvider1.SetError(cboProgLang, string.Empty);
            }


            DialogResult = DialogResult.OK;

            try
            {
                if (tabControl1.SelectedTabPageIndex == 0)
                {
                    _printerSettings.Communication.CommunicationType = CommunicationType.USB;
                    _printerSettings.PrinterName = cboPrinters.SelectedItem.ToString();
                }
                else
                {
                    if (tabControl1.SelectedTabPageIndex == 1)
                    {
                        _printerSettings.Communication.CommunicationType = CommunicationType.Parallel;
                        _printerSettings.Communication.ParallelPortName = txtParallelPort.Text;
                    }
                    else
                    {
                        if (tabControl1.SelectedTabPageIndex == 2)
                        {
                            _printerSettings.Communication.CommunicationType = CommunicationType.Serial;
                            _printerSettings.Communication.SerialPortName = cboSerialPorts.SelectedItem.ToString();
                            _printerSettings.Communication.SerialPortBaudRate = int.Parse(txtBaudRate.Text);
                            _printerSettings.Communication.SerialPortDataBits = int.Parse(txtDataBits.Text);
                            _printerSettings.Communication.SerialPortFlowControl = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), cboFlowControl.SelectedItem.ToString());
                            _printerSettings.Communication.SerialPortParity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), cboParity.SelectedItem.ToString());
                            _printerSettings.Communication.SerialPortStopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), cboStopBits.SelectedItem.ToString());
                        }
                        else
                        {
                            if (tabControl1.SelectedTabPageIndex == 3)
                            {
                                _printerSettings.Communication.CommunicationType = CommunicationType.Network;
                                var ipAddress = System.Net.IPAddress.None;

                                try
                                {
                                    ipAddress = System.Net.IPAddress.Parse(txtIPAddress.Text);
                                }
                                catch
                                {
                                }

                                if (ipAddress != System.Net.IPAddress.None)
                                {
                                    _printerSettings.Communication.NetworkIPAddress = ipAddress;
                                }
                                else
                                {
                                    _printerSettings.PrinterName = txtIPAddress.Text;
                                }
                                _printerSettings.Communication.NetworkPort = int.Parse(txtIPPort.Text);
                            }
                        }
                    }
                }
                _printerSettings.Dpi = (double)nudDpi.Value;
                _printerSettings.ProgrammingLanguage = (ProgrammingLanguage)Enum.Parse(typeof(ProgrammingLanguage), cboProgLang.SelectedItem.ToString());


                _copies = (int)nudCopies.Value;
                _printOrientation = (PrintOrientation)Enum.Parse(typeof(PrintOrientation), cboPrintOrientation.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hatta !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PrintJobDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }
    }
}