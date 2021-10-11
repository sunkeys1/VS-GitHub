﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            // action
            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            cocktail.Items.AddRange(items);

            items.Sort();
            cocktail.Sort();
            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], cocktail.Items[i]);
            }
        }
    }
}