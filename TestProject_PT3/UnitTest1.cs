using Xunit;
using PT_Lab3;
using System;

namespace TestProject_PT3
{
    public class UnitTest1
    {
        int[] testedArray = new int[] { 934, 212, 753, 643, 2, 9 };

        /// <summary>
        /// ћетод тестировки метода сортировки массива 
        /// </summary>
        [Fact]
        public void TestSort()
        {
            int[] expectedArr = new int[] { 2, 9, 212, 643, 753, 934 };
            int[] actualArr = ArrayOps.SortArray_ForTesting((int[])testedArray.Clone());
            Assert.Equal(expectedArr, actualArr);
        }

        /// <summary>
        /// ћетод тестировани€ метода дл€ «адани€ 16
        /// </summary>
        [Fact]
        public void TestTask16()
        {
            int[] expected = new int[] { 1, 212 };
            int[] actual = ArrayOps.Task16_ForTesting(testedArray);
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// ћетод тестировани€ метода нахождени€ количества простых чисел
        /// </summary>
        [Fact]
        public void TestGetAmountOfSimple()
        {
            int expected = 2;
            int actual = ArrayOps.GetAmountOfSimple_ForTesting(testedArray);
            Assert.Equal(expected, actual);
        }
    }
}