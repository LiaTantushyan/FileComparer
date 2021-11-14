using ASCIWebApp.Services;
using FileComparer.Helpers;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileComparer
{
    public partial class Form1 : Form
    {
        private static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string NewFileName = "/Data Difference.xlsx";

        public Form1()
        {
            InitializeComponent();
        }

        private void xmlUploadButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                xmlPath.Text = dialog.FileName;
            }
        }

        private void excelUploadButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                excelPath.Text = dialog.FileName;
            }
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (xmlPath.Text.IsValid(FileTypes.Xml) && excelPath.Text.IsValid(FileTypes.Excel))
            {
                xmlPath.Enabled = false;
                xmlPath.Visible = false;

                excelPath.Enabled = false;
                excelPath.Visible = false;

                xmlUploadButton.Enabled = false;
                xmlUploadButton.Visible = false;

                excelUploadButton.Enabled = false;
                excelUploadButton.Visible = false;

                validateButton.Enabled = false;
                validateButton.Visible = false;

                uniqueColumns.Visible = true;
                uniqueColumns.Enabled = true;

                compareAndDownloadDownload.Visible = true;
                compareAndDownloadDownload.Enabled = true;

                infoText.Visible = true;

                return;
            }
            else
            {
                MessageBox.Show("Invalid xml or(and) excel file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void compareAndDownloadDownload_Click(object sender, EventArgs e)
        {
            var dataFromXml = XmlService.GetDataFromXml(xmlPath.Text, uniqueColumns.Text);
            var dataFromExcel = ExcelService.GetDataFromExcel(excelPath.Text, uniqueColumns.Text);

            if (dataFromXml == null)
            {
                MessageBox.Show($"There are not any {uniqueColumns.Text}s or something is wrong in your file",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (dataFromExcel.Count != default)
            {
                var dataDifference = dataFromExcel.Except(dataFromXml).ToList();

                if (dataDifference.Count != 0)
                {
                    CreateExcelFile(dataDifference);
                }
                else
                {
                    MessageBox.Show($"There are not any difference data",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"There are not any {uniqueColumns.Text}s or something is wrong in your file",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void CreateExcelFile(List<string> data)
        {
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("Differences");
                worksheet.DefaultColWidth = 20;
                worksheet.Cells["A1"].Value = uniqueColumns.Text;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A2"].LoadFromCollection(data);
                var row = worksheet.Dimension.End.Row;
                worksheet.Cells[$"A1:A{row}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                if (SuccesfullySaved(package))
                {
                    MessageBox.Show($"Your excel file downloaded succesfully to {DesktopPath + NewFileName}!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    return;
                }
                else
                {
                    MessageBox.Show($"Error while saving excel file to {Directory.GetCurrentDirectory()}!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool SuccesfullySaved(ExcelPackage package)
        {
            try
            {
                package.SaveAs(DesktopPath + NewFileName);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
