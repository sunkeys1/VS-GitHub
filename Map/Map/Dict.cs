using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Dict<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] Items;
        public Dict()
        {
            Items = new Item<TKey, TValue>[size];
        }
        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);
            if(Items[hash] == null)
            {
                Items[hash] = item;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                    if (Items[i] == null)
                    {
                        Items[i] = item;
                        placed = true;
                        break;
                    }
                }
                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                        if (Items[i] == null)
                        {
                            Items[i] = item;
                            placed = true;
                            break;
                        }
                    }
                }
                if (!placed)
                {
                    throw new Exception("Словаррр заполнен!");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in Items)
            {
                if(item != null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);
            if (Items[hash].Key.Equals(key))
            {
                Items[hash] = null;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i].Key.Equals(key))
                    {
                        Items[hash] = null;
                        return;
                    }
                    if (Items[i] == null)
                    {
                        return;
                    }
                }
                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i].Key.Equals(key))
                        {
                            Items[hash] = null;
                            return;
                        }
                        if (Items[i] == null)
                        {
                            return;
                        }
                    }
                }
            }
        }
        public TValue Search(TKey key)
        {
            var hash = GetHash(key);
            if (Items[hash].Key.Equals(key))
            {
                return Items[hash].Value;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i].Key.Equals(key))
                    {
                        return Items[hash].Value;
                    }
                    if (Items[i] == null)
                    {
                        return default(TValue);
                    }
                }
                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i].Key.Equals(key))
                        {
                            return Items[hash].Value;
                        }
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }
                    }
                }
            }
            return default(TValue);
        }
        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}
