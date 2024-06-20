using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public class MyCollection<T>
    {
        private List<T> items;
        public MyCollection()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }
        //&& index<items.Count
        public T Get(int index)
        {
            if(index >= 0 )
            {
                return items[index];
            }
            else
            {
               throw new IndexOutOfRangeException("Індекс поза межами колекції!");            
            }
        }
        public void Remove(int index, int index1)
        {
            if (index1 > 0 && index < items.Count)
            {
                items.RemoveAt(index1);
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс поза межами колекції!");
            }
        }
        
        
        public override string ToString()
        {
            return items.ToString();
        }
    }
}
