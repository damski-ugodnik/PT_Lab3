using System.Xml.Serialization;

namespace PT_Lab3
{
    /// <summary>
    /// Класс массива содержащий методы его обработки и сериализации
    /// </summary>
    public class ArrayOps
    {
        int[] arr; // массив
        List<Operation> operationsLogger = new List<Operation>();// список состояний массива

        /// <summary>
        /// Метод генерации массива
        /// создаёт новый массив по указанным параметрам
        /// </summary>
        /// <param name="n">размерность массива</param>
        /// <param name="a">наименьшее допустимое число в массиве</param>
        /// <param name="b">наибольшее допустимое число в массиве</param>
        public void GenerateArray(int n, int a, int b)
        {
            Random random = new Random();
            arr = new int[n];// создание массива указанной размерности

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);// инициализация каждого элемента в соответсвии с допустимым диапазоном чисел
            }
            string operation = "Unprocessed array: ";// создание переменной содержащей в себе описание операции -  в начале сообщение о необработанном массиве
            foreach (int i in arr)
                operation += i.ToString("# ");// добавление в строку описания операции элементов массива
            operationsLogger.Add(new Operation((int[])arr.Clone(), operation));// запись в список первоначального состояния массива и произведённой операции
        }
        /// <summary>
        /// Метод сериализации массива
        /// записывает массив в файл с указанным именем либо создаёт файл и записывает в него в формате XML
        /// </summary>
        /// <param name="fileName">имя файла для записи</param>
        public void SerializeArray(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(int[]));// создание экземпляра сериализатора XML для типа массива
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))// создание экземпляра потока для записи (открывает, либо создаёт файл)
            {
                serializer.Serialize(fs, arr);// сериализация массива в формате XML
            }
        }
        /// <summary>
        /// Метод десериализации массива
        /// считывает массив из файла формата XML и записывает его в переменную массива
        /// </summary>
        /// <param name="fileName">Имя файла из которого происходит чтение</param>
        /// <exception cref="NullReferenceException"></exception>
        public void DeserializeArray(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(int[]));// создание экземпляра сериализатора XML для типа массива
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))// создание экземпляра потока для чтения 
            {
                int[]? m = serializer.Deserialize(fs) as int[];// десериализация массива из потока и запись в промежуточную перменную массива
                if (m != null)// если значение перменной не NULL, происходит запись массива в переменную массива
                    arr = m;
                else throw new NullReferenceException("File deserialisation error");// иначе генерируется исключение
            }
            string operation = "Unprocessed array: ";// Создание сообщения о необработанном массиве
            foreach (int i in arr)// запись в сообщение элементов массива
                operation += i.ToString("# ");
            operationsLogger.Add(new Operation((int[])arr.Clone(), operation));// запись состояния массива в список состояний
        }
        /// <summary>
        /// Метод сериализации состояний массива (сам массив в каждом состоянии и произведённая над ним операция)
        /// записывается в файл в формате XML
        /// </summary>
        /// <param name="fileName">Имя файла для записи</param>
        public void SerializeOperations(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Operation>));// создание экземпляра сериализатора XML для типа списка экземпляров структуры Operation (состояния массива)
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))//Создание потока для записи в файл
            {
                serializer.Serialize(fs, operationsLogger);// сериализация потока в формате XML
            }

        }
        /// <summary>
        /// Метод десериализации состояний массива из файла в формате XML 
        /// </summary>
        /// <param name="fileName">Имя файла для чтения</param>
        /// <exception cref="NullReferenceException"></exception>
        public void DeserializeOperations(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Operation>));// создание экземпляра сериализатора XML для типа Operation (состояния массива)
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))//Создание потока для чтения из файла
            {
                operationsLogger = serializer.Deserialize(fs) as List<Operation>;// десериализация списка состояний
                if (operationsLogger != null)// если список не NULL, то происходит присвоения перменной массива значения массива из последнего состояния
                {
                    arr = operationsLogger.Last().array;
                }
                else throw new NullReferenceException("File deserialisation error");// иначе генерируется исключение
            }

        }
        /// <summary>
        /// Метод сортировки массива
        /// сортирует массив по возрастанию
        /// </summary>
        public void SortArray()
        {
            Array.Sort(arr);// сортировка массива методом класса Array
            string operation = "Sorted array: ";// ввод в строку операции сообщения о том, что массив отсортирован
            foreach (int i in arr)// ввод в строку элементов отсортированного массива
                operation += i.ToString("# ");
            operationsLogger.Add(new Operation((int[])arr.Clone(), operation));// запись состояния массива в список состояний
        }
        /// <summary>
        /// Метод высчитывания суммы чисел неравных С с нечётными номерами
        /// </summary>
        /// <param name="C">Число, которому не должны быть равны слагаемые</param>
        public void GetSum(int C)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != C && i % 2 == 1)// если элемент массива имеет нечётный номер и неравен С, то он прибавляется к сумме
                {
                    sum += arr[i];
                }
            }

            operationsLogger.Add(new Operation((int[])arr.Clone(), string.Format("The sum is {0}", sum)));// запись состояния массива в список состояний (+ сообщение о высчитанной сумме)
        }
        /// <summary>
        /// Метод высчитывания суммы и количества чисел, у которых сумма первых двух цифр нечётна
        /// </summary>
        public void Task16()
        {
            int sum = 0, n = 0;
            string tmp;
            foreach (int i in arr)
            {
                tmp = i.ToString();// запись числа в формате строки
                if (tmp.Length > 1)// если строка имеет длинну больше 1, то будут произведены вычиления
                {
                    if ((tmp[0] + tmp[1]) % 2 != 0)// если сумма первых двух цифр нечётна, то счётчик чисел инкрементируется и число прибавляется к сумме
                    {
                        n++; sum += i;
                    }
                }
            }

            operationsLogger.Add(new Operation((int[])arr.Clone(), string.Format("Array has {0} numbers, that match the requirements; the sum is: {1}", n, sum)));// запись состояния массива с сообщением о количестве чисел и их сумме
        }
        /// <summary>
        /// Метод нахождения количества простых чисел
        /// </summary>
        public void GetAmountOfSimple()
        {
            int n = 0;
            int j;
            foreach (int i in arr)
            {
                int sqrt = (int)Math.Sqrt(i);// вычисление квадратного корня числа
                for (j = 2; j <= sqrt + 1; j++)// подбор случайных делителей (от 2, до квадратного корня числа+1)
                {
                    if (i % j == 0)// если остаток от деления на делитель равен нулю, то цикл прекращается
                    {
                        break;
                    }
                }
                if (j > sqrt)// если по истечению цикла, счётчик больше квадратного корня, т.е не найден делитель нацело, то счётчик простых чисел инкрементируется
                {
                    n++;
                }
            }

            operationsLogger.Add(new Operation((int[])arr.Clone(), string.Format("Array has {0} simple numbers", n)));// запись в список состояния массива с сообщением о количетсве простых чисел
        }
        // Статические методы с аналогичной логикой с нестатическими, для тестирования,
        // в качестве аргумента также передаётся массив и возвращается результат, который раньше выводился в сообщении

        public static int[] SortArray_ForTesting(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static int GetSum_ForTesting(int C, int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != C && i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] Task16_ForTesting(int[] array)
        {
            int sum = 0, n = 0;
            string tmp;
            foreach (int i in array)
            {
                tmp = i.ToString();
                if (tmp.Length > 1)
                {
                    if (((int)tmp[0] + (int)tmp[1]) % 2 != 0)
                    {
                        n++; sum += i;
                    }
                }
            }

            return new int[] { n, sum };
        }

        public static int GetAmountOfSimple_ForTesting(int[] array)
        {
            int n = 0;
            int j;
            foreach (int i in array)
            {
                int sqrt = (int)Math.Sqrt(i);
                for (j = 2; j <= sqrt + 1; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j > sqrt)
                {
                    n++;
                }
            }
            return n;
        }

        /// <summary>
        /// Свойство возвращающее последнюю операцию над массивом
        /// </summary>
        public string LastOperation { get { return operationsLogger.Last().actions; } }
        /// <summary>
        /// Массив класса
        /// </summary>
        public int[] Arr { get { return arr; } }
        /// <summary>
        /// Список состояний массива
        /// </summary>
        public List<Operation> LoggedOperations { get { return operationsLogger; } }

    }

    /// <summary>
    /// Структура, отображающая состояние массива и произведённую над ним операцию
    /// </summary>
    [Serializable]
    public struct Operation
    {
        /// <summary>
        /// массив
        /// </summary>
        public int[] array;
        /// <summary>
        /// строка сообщения об операции
        /// </summary>
        public string actions;
        /// <summary>
        /// конструктор структуры
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="actions">произведённая операция</param>
        public Operation(int[] array, string actions)
        {
            this.array = array;
            this.actions = actions;
        }
    }
}
