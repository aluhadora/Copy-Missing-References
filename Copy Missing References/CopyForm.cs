using System;
using System.Windows.Forms;

namespace Copy_Missing_References
{
  public partial class CopyForm : Form
  {
    private Process _process;
    
    public CopyForm()
    {
      InitializeComponent();
    }

    private void Clear()
    {
      missingFileTextBox.Text = string.Empty;
      copyFileTextBox.Text = string.Empty;
      errorTextBox.Text = string.Empty;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      _process = new Process();
      Run();
    }

    private void rerunButton_Click(object sender, EventArgs e)
    {
      Run();
    }

    private void Run()
    {
      Clear();

      errorTextBox.Text = Clipboard.GetText();
      _process.ErrorMessage = errorTextBox.Text;
      _process.Preprocess();

      copyFileTextBox.Text = _process.CopyFile;
      missingFileTextBox.Text = _process.MissingFile;
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
      _process.Copy();
    }

  }
}
