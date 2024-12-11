using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace BaiTap4._2
{
    
    public partial class frm_BtLTWindows : Form
    {
        private bool isFileSaved = false;
        private string currentFilePath = "";
        private Timer syntaxHighlightTimer;

        public frm_BtLTWindows()
        {
            InitializeComponent();
            rtb_Code.TextChanged += rtb_Code_TextChanged;
            Capnhatsodong();
            status.Text = "Ready";
            syntaxHighlightTimer = new Timer();
            syntaxHighlightTimer.Interval = 10000;
            syntaxHighlightTimer.Tick += (s, e) =>
            {
                syntaxHighlightTimer.Stop();
                HighlightSyntax();
            };

        }

        private void Menu_NewFile_Click(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("Bạn có những thay đổi chưa được lưu. Bạn có muốn lưu không?", "Những thay đổi chưa được lưu", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            rtb_Code.Clear();
            currentFilePath = "";
            isFileSaved = true;
            status.Text = "File mới đã được tạo!" + currentFilePath;
        }


        private void SaveFile()
        {
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "C++ Files|*.cpp|All Files|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveFileDialog.FileName;
                        File.WriteAllText(currentFilePath, rtb_Code.Text);
                        isFileSaved = true;
                        status.Text = "File đã được lưu! " + currentFilePath;
                    }
                }
                else
                {
                    File.WriteAllText(currentFilePath, rtb_Code.Text);
                    isFileSaved = true;
                }
            }
        }

        private void Menu_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C++ Files|*.cpp|All Files|*.*";
            openFileDialog.Title = "Open C++ File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                rtb_Code.Text = File.ReadAllText(filePath);
                currentFilePath = filePath;
                isFileSaved = true;
                status.Text = "File đã được mở! " + currentFilePath;
            }
        }

        private void Menu_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Capnhatsodong()
        {
            int lineCount = rtb_Code.Lines.Length;

            StringBuilder lineNumbers = new StringBuilder();

            for (int i = 1; i < lineCount; i++)
            {
                lineNumbers.AppendLine(i.ToString());
            }

            txt_Sodong.Text = lineNumbers.ToString();
        }
        private void rtb_Code_TextChanged(object sender, EventArgs e)
        {
            Capnhatsodong(); 
            syntaxHighlightTimer.Stop();
            syntaxHighlightTimer.Start();
            HighlightSyntax();
        }

        private void btn_NewFile_Click_1(object sender, EventArgs e)
        {
            Menu_NewFile_Click(sender, e);
        }

        private void btn_OpenFile_Click_1(object sender, EventArgs e)
        {
            Menu_OpenFile_Click(sender, e);
        }
        private void HighlightSyntax()
        {
            rtb_Code.SuspendLayout();

            string code = rtb_Code.Text;

            string[] keywords = new string[] {
                    "int", "float", "char", "if", "else", "for", "while", "return", "void", "include", "main"
                 };

            string keywordPattern = @"\b(" + string.Join("|", keywords) + @")\b";
            Regex keywordRegex = new Regex(keywordPattern);

            string stringPattern = "\".*?\"";
            Regex stringRegex = new Regex(stringPattern);

            string commentPattern = @"//.*?$|/\*.*?\*/";
            Regex commentRegex = new Regex(commentPattern, RegexOptions.Singleline);

            rtb_Code.SelectionColor = Color.Black;

            HighlightRegex(keywordRegex, Color.Blue);

            HighlightRegex(stringRegex, Color.Brown);

            HighlightRegex(commentRegex, Color.Green);

            rtb_Code.ResumeLayout();
        }

        private void HighlightRegex(Regex regex, Color color)
        {
            int startIndex = 0;

            while (startIndex < rtb_Code.Text.Length)
            {
                Match match = regex.Match(rtb_Code.Text, startIndex);
                if (!match.Success)
                    break;

                rtb_Code.Select(match.Index, match.Length);
                rtb_Code.SelectionColor = color;


                startIndex = match.Index + match.Length;
            }
        }

        private void Menu_Compile_Click(object sender, EventArgs e)
        {
            string code = rtb_Code.Text;

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Không có mã để biên dịch.");
                return;
            }

            string tempFilePath = Path.GetTempFileName() + ".cpp";

            try
            {
                File.WriteAllText(tempFilePath, code);
                status.Text = "Đang biên dịch...";
                status.ForeColor = Color.Black;

                string gccPath = @"C:\MinGW\bin\gcc.exe";
                string outputPath = Path.Combine(Path.GetTempPath(), "output.exe");
                string arguments = $"-o \"{outputPath}\" \"{tempFilePath}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = gccPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,  
                    RedirectStandardError = true,
                    UseShellExecute = false,    
                    CreateNoWindow = true
                };

                Process process = new Process();
                process.StartInfo = startInfo;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0 && string.IsNullOrWhiteSpace(error)) 
                {
                    status.Text = "Biên dịch thành công! " + output;
                    status.ForeColor = Color.Green;
                }
                else
                {
                    string errorMessage = string.IsNullOrEmpty(error) ? "Biên dịch thất bại (Lỗi không xác định)" : "Biên Dịch Lỗi: " + error;
                    status.Text = errorMessage;
                    status.ForeColor = Color.Red; 
                }
            }
            catch (Exception ex)
            {
                status.Text = "Lỗi khi biên dịch: " + ex.Message;
                status.ForeColor = Color.Red; 
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }



        private void Menu_Run_Click(object sender, EventArgs e)
        {
            string code = rtb_Code.Text;

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Vui lòng nhập mã để biên dịch!");
                return;
            }

            string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".cpp");

            try
            {
                File.WriteAllText(tempFilePath, code);

                status.Text = "Đang biên dịch...";
                status.ForeColor = Color.Black;

                string gccPath = @"C:\MinGW\bin\gcc.exe";
                string outputPath = Path.Combine(Path.GetTempPath(), "output.exe");  
                string arguments = $"-o \"{outputPath}\" \"{tempFilePath}\""; 

                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = gccPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,    
                    UseShellExecute = false,       
                    CreateNoWindow = true    
                };

                Process process = new Process();
                process.StartInfo = startInfo;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0 && string.IsNullOrWhiteSpace(error))
                {
                    status.Text = "Biên dịch thành công! " + output;
                    status.ForeColor = Color.Green;

                    RunCompiledProgram(outputPath);
                }
                else
                {
                    string errorMessage = string.IsNullOrEmpty(error) ? "Biên dịch thất bại (Lỗi không xác định)" : "Biên Dịch Lỗi: " + error;
                    status.Text = errorMessage;
                    status.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                status.Text = "Lỗi khi biên dịch: " + ex.Message;
                status.ForeColor = Color.Red; 
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }


        private void RunCompiledProgram(string outputPath)
        {
            try
            {
                if (!File.Exists(outputPath))
                {
                    status.Text = "Tệp thực thi không tồn tại!";
                    status.ForeColor = Color.Red;
                    return;
                }

                ProcessStartInfo runInfo = new ProcessStartInfo()
                {
                    FileName = outputPath, 
                    RedirectStandardOutput = true, 
                    RedirectStandardError = true, 
                    UseShellExecute = false,       
                    CreateNoWindow = true      
                };

                Process runProcess = new Process();
                runProcess.StartInfo = runInfo;

                runProcess.Start();

                string output = runProcess.StandardOutput.ReadToEnd();
                string error = runProcess.StandardError.ReadToEnd();

                runProcess.WaitForExit();

                if (runProcess.ExitCode == 0 && string.IsNullOrWhiteSpace(error))
                {
                    status.Text = "Chạy thành công: " + output;
                    status.ForeColor = Color.Green;
                }
                else
                {
                    status.Text = "Lỗi khi chạy chương trình: " + error;
                    status.ForeColor = Color.Red; 
                }
            }
            catch (Exception ex)
            {
                status.Text = "Lỗi khi chạy tệp: " + ex.Message;
                status.ForeColor = Color.Red;
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Menu_Run_Click(sender, e);
        }
    }
}
