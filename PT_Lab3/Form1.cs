using System.Xml.Serialization;
using System.IO;
namespace PT_Lab3
{
    public partial class Form1 : Form
    {
        ArrayOps arrayOps = new ArrayOps();


        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "Unprocessed array: ";
            try
            {
                arrayOps.GenerateArray((int)arrSizeSelect.Value, (int)minValueSelect.Value, (int)maxValueSelect.Value);
                ShowArray(arrayOps.Arr, true);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowArray(int[] array, bool showInBox)
        {
            arrayGridView.RowCount = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (showInBox)
                    arrayBox.Text += array[i].ToString("# ");
                arrayGridView[0, i].Value = i;
                arrayGridView[1, i].Value = array[i];
            }
        }

        private void serializeArrayButton_Click(object sender, EventArgs e)
        {
            saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                arrayOps.SerializeArray(saveDialog.FileName);
                
            }
        }

        private void deserializeArrayButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "Unprocessed array: ";
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayOps.DeserializeArray(openDialog.FileName);
                    ShowArray(arrayOps.Arr, true);
                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serializeResultsButton_Click(object sender, EventArgs e)
        {

                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayOps.SerializeOperations(saveDialog.FileName, arrayBox.Text);
                }


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "";
            arrayGridView.Rows.Clear();
        }

        private void openResultsButton_Click(object sender, EventArgs e)
        {
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayBox.Text = arrayOps.DeserializeOperations(openDialog.FileName);
                    ShowArray(arrayOps.Arr, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}