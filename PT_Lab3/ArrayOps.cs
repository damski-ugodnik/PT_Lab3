using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace PT_Lab3
{
    internal class ArrayOps
    {
        int[] arr;
        List<Operation> operationsLogger = new List<Operation>();

        public void GenerateArray(int n,int a,int b)
        {
            Random random = new Random();
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
            Operation arrOperation = new Operation();
            arrOperation.array = arr;
            arrOperation.actions = "Unprocessed array: ";
            foreach (int i in arrOperation.array)
                arrOperation.actions += i.ToString("# ");
            operationsLogger.Add(arrOperation);
        }

        public void SerializeArray(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(fs, arr);
            }
        }

        public void DeserializeArray(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {

                int[]? m = serializer.Deserialize(fs) as int[];
                if (m != null)
                    arr = m;
                else throw new NullReferenceException("File deserialisation error");
            }
        }

        public void SerializeOperations(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Operation>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(fs, operationsLogger);
            }

        }

        public void DeserializeOperations(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Operation>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                operationsLogger = serializer.Deserialize(fs) as List<Operation>;
                if (operationsLogger != null)
                {
                    arr = operationsLogger.Last<Operation>().array;
                    
                }
                else throw new NullReferenceException("File deserialisation error");
            }
            
        }

        public void SortArray()
        {
            Array.Sort(arr);
            Operation arrOperation = new Operation();
            arrOperation.array = arr;
            arrOperation.actions = "Sorted array: ";
            foreach (int i in arrOperation.array)
                arrOperation.actions += i.ToString("# ");
            operationsLogger.Add(arrOperation);
        }

        public void GetSum(int C)
        {
            Operation arrOperation = new Operation();
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != C&&i%2!=0)
                {
                    sum+=arr[i];
                }
            }
            arrOperation.array = arr;
            arrOperation.actions = string.Format("The sum is {0}", sum);
            operationsLogger.Add(arrOperation);
        }

        public void Task16()
        {
            Operation arrOperation = new Operation();
            int sum = 0, n = 0;
            string tmp;
            foreach(int i in arr)
            {
                tmp = i.ToString();
                if (tmp.Length > 1)
                {
                    if ((tmp[0] + tmp[1]) % 2 != 0)
                    {
                        n++; sum += i;
                    }
                }
            }
            arrOperation.array = arr;
            arrOperation.actions = string.Format("Array has {0} numbers, that match the requirements; the sum is: {1}", n, sum);
            operationsLogger.Add(arrOperation);
        }

        public void GetAmountOfSimple()
        {
            int n = 0;
            foreach(int i in arr)
            {
                for(int j = 2; j < Math.Round(Math.Sqrt(i)); j++)
                {
                    if (i % j == 0)
                    {
                        n++;
                        break;
                    }
                }
            }
            Operation arrOperation = new Operation();
            arrOperation.array = arr;
            arrOperation.actions = string.Format("Array has {0} simple numbers", n);
            operationsLogger.Add(arrOperation);
        }

        public string LastOperation { get { return operationsLogger.Last().actions; } }
        public int[] Arr { get { return arr; } }
        public List<Operation> LoggedOperations { get { return operationsLogger; } }
    }

    [Serializable]
    public class Operation
    {
        public int[] array = new int[0];
        public string actions = ""; 
    }
}
