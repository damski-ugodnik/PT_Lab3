namespace PT_Lab3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Переменная содержащая в себе класс массива
        /// </summary>
        ArrayOps arrayOps;

        public Form1() => InitializeComponent();

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // установка видимости и выделяемости компонентов в зависимости от установленного режима
            cBox.Visible = calculateSumMode.Checked;
            cLabel.Visible = calculateSumMode.Checked;
            cBox.Enabled = calculateSumMode.Checked;
        }
        /// <summary>
        /// Кнопка генерации массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// инициализация перменной класса массива
            arrayBox.Text = "Unprocessed array: ";// ввод в строку для отображения событий сообщения о необработангом массиве
            try
            {
                arrayOps.GenerateArray((int)arrSizeSelect.Value, (int)minValueSelect.Value, (int)maxValueSelect.Value);// генерация массива
                ShowArray(arrayOps.Arr);// вывод массива в таблицу и в строку
                // включение кнопок сохранения и обработки
                serializeArrayButton.Enabled = true; 
                serializeResultsButton.Enabled = true;
                processButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// метод вывода массива на экран
        /// </summary>
        /// <param name="array">выводимый массив</param>
        private void ShowArray(int[] array)
        {
            arrayGridView.RowCount = array.Length;// установление количества строк в таблице в зависимости от размерности массива
            for (int i = 0; i < array.Length; i++)
            {
                arrayBox.Text += array[i].ToString("# ");// ввод элемента массива в строку
                arrayGridView[0, i].Value = i;// ввод индекса в первый столбец
                arrayGridView[1, i].Value = array[i];// ввод значения по текущему индексу во второй столбец
            }
        }
        /// <summary>
        /// метод вывода массива на экран и вывода в строку произведённой операции
        /// </summary>
        /// <param name="array">выводимый массив</param>
        /// <param name="operation">производимая операция</param>
        private void ShowArray(int[] array, string operation)
        {
            arrayGridView.RowCount = array.Length;
            arrayBox.Text = operation;// ввод текста операции в строку
            for (int i = 0; i < array.Length; i++)
            {
                arrayGridView[0, i].Value = i;
                arrayGridView[1, i].Value = array[i];
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки для сериализации массива
        /// сохраняет массив в заданый файл с помощью SaveFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serializeArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.FileName = "savedArray";// задание названия по умолчанию для файла
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// установка директории по умолчанию
                if (saveDialog.ShowDialog() == DialogResult.OK)// если в диалоге была нажата кнопка ОК
                {
                    arrayOps.SerializeArray(saveDialog.FileName);// сериализация массива в методе класса

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки десериализации массива
        /// Открывает файл и выводит массив записанный в нём на экран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deserializeArrayButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// создание нового экземпляра класса
            arrayBox.Text = "Unprocessed array: ";// вывод сообщения о необработанном массиве
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";//задание директории по умолчанию
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)// в случае успешного выбора файла происзодит десериализация
                {
                    arrayOps.DeserializeArray(openDialog.FileName);// вызов метода класса для десериализации
                    ShowArray(arrayOps.Arr);// вывод массива на экран
                    // включение кнопок обработки и среиализации
                    serializeArrayButton.Enabled = true;
                    serializeResultsButton.Enabled = true;
                    processButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки сериализации операций над массивом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serializeResultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.FileName = "savedOperations";// задание названия файла по умолчанию
                saveDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// задание директории по умолчанию
                if (saveDialog.ShowDialog() == DialogResult.OK)// в случае удачного показа диалога с результатом ОК - сохранение в ХМL файл
                {
                    arrayOps.SerializeOperations(saveDialog.FileName);// вызо метода класса для сериализации операций
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Обработчик нажатия кнопки очистки полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            arrayBox.Text = "";// очистка строки выводв массива или операций
            arrayGridView.Rows.Clear();// очистка таблицы
            // Выключение кнопок сериализации и обработки
            serializeResultsButton.Enabled = false;
            serializeArrayButton.Enabled = false;
            processButton.Enabled = false;
            // создание нового экземпляра
            arrayOps = new ArrayOps();
        }
        /// <summary>
        /// Обработчик нажатия кнопки десериализации операций:
        /// в таблице выводится массив в последнем состоянии, а в строку последняя операция 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deserializeResultsButton_Click(object sender, EventArgs e)
        {
            arrayOps = new ArrayOps();// создание нового экзмепляра
            openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\source";// задание директории по умолчанию
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)// в случае удачного показа диалога происхходит открытие файла
                {
                    arrayOps.DeserializeOperations(openDialog.FileName);// вызов метода класса для десериализации операций
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// вывод массива в таблицу и последней операции в строку
                    // включение кнопок сериализации и обработки
                    serializeArrayButton.Enabled = true;
                    serializeResultsButton.Enabled = true;
                    processButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Обработчик нажатия кнопки обработки массива
        /// производит выбранную операцию над массивом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (calculateSumMode.Checked)// если выбран режим высчитывания суммы
                {
                    arrayOps.GetSum((int)cBox.Value);// вызов метода класса по вычислению суммы для чисел неравных указанному параметру с нечётными номерами
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// вывод массива в таблицу и операции в строку
                }
                if (arraySortMode.Checked)// если выбран режим сортировки массива
                {
                    arrayOps.SortArray();// вызов метода класса для сортировки массива
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// вывод массива в таблицу и операции в строку
                }
                if (task16Mode.Checked)// если выбран режим Задания 16
                {
                    arrayOps.Task16();// вызов метода класса для выполнения задания 16
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// вывод массива в таблицу и операции в строку
                }
                if (simpleNumsMode.Checked)// если выбран режим поиска суммы и количества простых чисел
                {
                    arrayOps.GetAmountOfSimple();// вызов метода класса для посика суммы и количества простых чисел
                    ShowArray(arrayOps.Arr, arrayOps.LastOperation);// вывод массива в таблицу и операции в строку
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при исключении вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Обработчик события изменения выбранности режима высчитиывания суммы
        /// если выбран, появляются компонениты для задания дополнительных параметров
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