using System.Xml.Serialization;
using System.IO;
namespace PT_Lab3
{
    public partial class Form1 : Form
    {
        ArrayOps arrayOps;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();
            arrayBox.Text = "Unprocessed array: ";
            try
            {
                arrayOps.GenerateArray((int)arrSizeSelect.Value, (int)minValueSelect.Value, (int)maxValueSelect.Value);
                ShowArray(arrayOps.Arr);
                serializeArrayButton.Enabled = true;
                serializeResultsButton.Enabled = true;
                processButton.Enabled = true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowArray(int[] array)
        {
            arrayGridView.RowCount = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                arrayBox.Text += array[i].ToString("# ");
                arrayGridView[0, i].Value = i;
                arrayGridView[1, i].Value = array[i];
            }
        }

        private void ShowArray(int[] array, string operation)
        {
            arrayGridView.RowCount = array.Length;
            arrayBox.Text=operation;
            for (int i = 0; i < array.Length; i++)
            {
                arrayGridView[0, i].Value = i;
                arrayGridView[1, i].Value = array[i];
            }
        }

        private void serializeArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayOps.SerializeArray(saveDialog.FileName);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deserializeArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();
            arrayBox.Text = "Unprocessed array: ";
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayOps.DeserializeArray(openDialog.FileName);
                    ShowArray(arrayOps.Arr);
                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serializeResultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    arrayOps.SerializeOperations(saveDialog.FileName);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "";
            arrayGridView.Rows.Clear();
            serializeResultsButton.Enabled = false;
            serializeArrayButton.Enabled = false;
            processButton.Enabled = false;
            arrayOps = new ArrayOps();
        }

        private void openResultsButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                   arrayOps.DeserializeOperations(openDialog.FileName);
                    ShowArray(arrayOps.Arr,arrayOps.LastOperation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (calculateSumMode.Checked)
                {
                    arrayOps.GetSum(6);
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);
                }
                if (arraySortMode.Checked)
                {
                    arrayOps.SortArray();
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);
                }
                if (task16Mode.Checked)
                {
                    arrayOps.Task16();
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);
                }
                if (simpleNumsMode.Checked)
                {
                    arrayOps.GetAmountOfSimple();
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}