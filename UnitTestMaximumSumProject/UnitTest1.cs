using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumSum.BuisnessLogic;

namespace UnitTestMaximumSumProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTMaxSummOddEven()
        {
            var input = GetInput();
            int expected = 1512;
            string[] arrayOfRowsByNewlines = input.Split('\n');
            var tableHolder = ConvertTheTriangleIntoTable(arrayOfRowsByNewlines);
            TMaxSummOddEven obj = new TMaxSummOddEven();
            int result = obj.ProcessTheNodes(arrayOfRowsByNewlines.Length, tableHolder);
            //Assert  
            Assert.AreEqual(expected, result);

        }
        private static string GetInput()
        {

            const string input = @"     215
                                        192 124
                                        117 269 442
                                        218 836 347 235";
            return input;
        }

        private static int[,] ConvertTheTriangleIntoTable(string[] arrayOfRowsByNewlines)
        {
            int[,] tableHolder = new int[arrayOfRowsByNewlines.Length, arrayOfRowsByNewlines.Length + 1];

            for (int row = 0; row < arrayOfRowsByNewlines.Length; row++)
            {
                var eachCharactersInRow = arrayOfRowsByNewlines[row].Trim().Split(' ');

                for (int column = 0; column < eachCharactersInRow.Length; column++)
                {
                    int number;
                    int.TryParse(eachCharactersInRow[column], out number);
                    tableHolder[row, column] = number;
                }
            }
            return tableHolder;
        }
    }
}
