using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BbSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var bubble = new BbSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            // action
            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            bubble.Items.AddRange(items);

            items.Sort();
            bubble.Sort();
            // assert
            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
            
        }
    }
}