namespace PT_Lab3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ���������� ���������� � ���� ����� �������
        /// </summary>
        ArrayOps arrayOps;

        public Form1() => InitializeComponent();

        /// <summary>
        /// ������� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ��������� � ������������ ����������� � ����������� �� �������������� ������
            cBox.Visible = calculateSumMode.Checked;
            cLabel.Visible = calculateSumMode.Checked;
            cBox.Enabled = calculateSumMode.Checked;
        }
        /// <summary>
        /// ������ ��������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// ������������� ��������� ������ �������
            arrayBox.Text = "Unprocessed array: ";// ���� � ������ ��� ����������� ������� ��������� � �������������� �������
            try
            {
                arrayOps.GenerateArray((int)arrSizeSelect.Value, (int)minValueSelect.Value, (int)maxValueSelect.Value);// ��������� �������
                ShowArray(arrayOps.Arr);// ����� ������� � ������� � � ������
                // ��������� ������ ���������� � ���������
                serializeArrayButton.Enabled = true; 
                serializeResultsButton.Enabled = true;
                processButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ����� ������ ������� �� �����
        /// </summary>
        /// <param name="array">��������� ������</param>
        private void ShowArray(int[] array)
        {
            arrayGridView.RowCount = array.Length;// ������������ ���������� ����� � ������� � ����������� �� ����������� �������
            for (int i = 0; i < array.Length; i++)
            {
                arrayBox.Text += array[i].ToString("# ");// ���� �������� ������� � ������
                arrayGridView[0, i].Value = i;// ���� ������� � ������ �������
                arrayGridView[1, i].Value = array[i];// ���� �������� �� �������� ������� �� ������ �������
            }
        }
        /// <summary>
        /// ����� ������ ������� �� ����� � ������ � ������ ������������ ��������
        /// </summary>
        /// <param name="array">��������� ������</param>
        /// <param name="operation">������������ ��������</param>
        private void ShowArray(int[] array, string operation)
        {
            arrayGridView.RowCount = array.Length;
            arrayBox.Text = operation;// ���� ������ �������� � ������
            for (int i = 0; i < array.Length; i++)
            {
                arrayGridView[0, i].Value = i;
                arrayGridView[1, i].Value = array[i];
            }
        }
        /// <summary>
        /// ���������� ������� ������� ������ ��� ������������ �������
        /// ��������� ������ � ������� ���� � ������� SaveFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serializeArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.FileName = "savedArray";// ������� �������� �� ��������� ��� �����
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// ��������� ���������� �� ���������
                if (saveDialog.ShowDialog() == DialogResult.OK)// ���� � ������� ���� ������ ������ ��
                {
                    arrayOps.SerializeArray(saveDialog.FileName);// ������������ ������� � ������ ������

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ���������� ������� ������� ������ �������������� �������
        /// ��������� ���� � ������� ������ ���������� � �� �� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deserializeArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// �������� ������ ���������� ������
            arrayBox.Text = "Unprocessed array: ";// ����� ��������� � �������������� �������
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";//������� ���������� �� ���������
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)// � ������ ��������� ������ ����� ���������� ��������������
                {
                    arrayOps.DeserializeArray(openDialog.FileName);// ����� ������ ������ ��� ��������������
                    ShowArray(arrayOps.Arr);// ����� ������� �� �����
                    // ��������� ������ ��������� � ������������
                    serializeArrayButton.Enabled = true;
                    serializeResultsButton.Enabled = true;
                    processButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ���������� ������� ������� ������ ������������ �������� ��� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serializeResultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.FileName = "savedOperations";// ������� �������� ����� �� ���������
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// ������� ���������� �� ���������
                if (saveDialog.ShowDialog() == DialogResult.OK)// � ������ �������� ������ ������� � ����������� �� - ���������� � ��L ����
                {
                    arrayOps.SerializeOperations(saveDialog.FileName);// ���� ������ ������ ��� ������������ ��������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ���������� ������� ������ ������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "";// ������� ������ ������ ������� ��� ��������
            arrayGridView.Rows.Clear();// ������� �������
            // ���������� ������ ������������ � ���������
            serializeResultsButton.Enabled = false;
            serializeArrayButton.Enabled = false;
            processButton.Enabled = false;
            // �������� ������ ����������
            arrayOps = new ArrayOps();
        }
        /// <summary>
        /// ���������� ������� ������ �������������� ��������:
        /// � ������� ��������� ������ � ��������� ���������, � � ������ ��������� �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deserializeResultsButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// �������� ������ ����������
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// ������� ���������� �� ���������
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)// � ������ �������� ������ ������� ����������� �������� �����
                {
                    arrayOps.DeserializeOperations(openDialog.FileName);// ����� ������ ������ ��� �������������� ��������
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// ����� ������� � ������� � ��������� �������� � ������
                    // ��������� ������ ������������ � ���������
                    serializeArrayButton.Enabled = true;
                    serializeResultsButton.Enabled = true;
                    processButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ���������� ������� ������ ��������� �������
        /// ���������� ��������� �������� ��� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (calculateSumMode.Checked)// ���� ������ ����� ������������ �����
                {
                    arrayOps.GetSum((int)cBox.Value);// ����� ������ ������ �� ���������� ����� ��� ����� �������� ���������� ��������� � ��������� ��������
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// ����� ������� � ������� � �������� � ������
                }
                if (arraySortMode.Checked)// ���� ������ ����� ���������� �������
                {
                    arrayOps.SortArray();// ����� ������ ������ ��� ���������� �������
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// ����� ������� � ������� � �������� � ������
                }
                if (task16Mode.Checked)// ���� ������ ����� ������� 16
                {
                    arrayOps.Task16();// ����� ������ ������ ��� ���������� ������� 16
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// ����� ������� � ������� � �������� � ������
                }
                if (simpleNumsMode.Checked)// ���� ������ ����� ������ ����� � ���������� ������� �����
                {
                    arrayOps.GetAmountOfSimple();// ����� ������ ������ ��� ������ ����� � ���������� ������� �����
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// ����� ������� � ������� � �������� � ������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ��� ���������� ����� ��������� �� ������
            }
        }
        /// <summary>
        /// ���������� ������� ��������� ����������� ������ ������������� �����
        /// ���� ������, ���������� ����������� ��� ������� �������������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateSumMode_CheckedChanged(object sender, EventArgs e)
        {
            cBox.Visible = calculateSumMode.Checked;    
            cLabel.Visible = calculateSumMode.Checked;
            cBox.Enabled = calculateSumMode.Checked;
        }
    }
}