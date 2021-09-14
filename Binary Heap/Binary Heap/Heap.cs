﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Heap
{
    class Heap : IEnumerable  // можно TKey, TValue (чтобы вес элементов смотреть\задавать)
    {
        private List<int> items = new List<int>();
        public int Count => items.Count;
        public int? Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }
        public Heap() { }
        public Heap(List<int> items)
        {
            this.items.AddRange(items);
            for(int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
            
        }
        public void Add(int item)
        {
            // проверка входных данных (да тут)
            items.Add(item);
            var currentIndex = Count - 1; // указатель на данный элемент
            var parentIndex = GetParentIndex(currentIndex); // указатель куда будет добавлено

            while (currentIndex > 0 && items[parentIndex] < items[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }
        public int GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }
        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while(currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if(leftIndex < Count && items[leftIndex] > items[maxIndex])
                {
                    maxIndex = leftIndex;

                }
                if (rightIndex < Count && items[rightIndex] > items[maxIndex])
                {
                    maxIndex = rightIndex;

                }
                if(maxIndex == currentIndex)
                {
                    break;
                }
                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;

            }
        }
        private void Swap(int currentIndex, int parentIndex)
        {
            int temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private  int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while(Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
