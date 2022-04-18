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

        public void GenerateArray(int n,int a,int b)
        {
            Random random = new Random();
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
            
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
            }
        }

        public void SerializeOperations(string fileName, string operation)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(fs, operation);
            }

        }

        public string DeserializeOperations(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {

                string? m = serializer.Deserialize(fs) as string;
                if(m!= null)
                    return m;
            }
            throw new NullReferenceException("File deserialisation error");
        }

        public void SortArray()
        {
            Array.Sort(arr);
        }

        public int GetSum(int C)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != C&&i%2!=0)
                {
                    sum+=arr[i];
                }
            }
            return sum;
        }

        public int[] Task16()
        {
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
            return new int[] { sum, n };
        }

        public int GetAmountOfSimple()
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
            return n;
        }

        public int[] Arr { get { return arr; } }
    }
}
