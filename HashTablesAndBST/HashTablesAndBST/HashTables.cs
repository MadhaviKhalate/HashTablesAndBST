﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndBST
{
    public class HashTables<K, V>
    {
        public readonly int size;
        public readonly LinkedList<KeyValue<K, V>>[] items;
        public HashTables(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }

        public int FrequencyOfWords(V input)
        {
            int frequency = 0;
            if (items == null)
            {
                Console.WriteLine("Hash Table is Empty");
            }
            for (int i = 0; i < items.Length; i++)
            {
                LinkedList<KeyValue<K, V>> list = GetLinkedList(i);
                foreach (KeyValue<K, V> data in list)
                {
                    if (data.Value.Equals(input))
                    {
                        frequency++;
                    }
                }
            }
            return frequency;
        }
    }
}