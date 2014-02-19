using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DPoints
{

   
   public class GenericList<T>
    {
        private T[] elements;

        public T[] Elements
        {
            get { return elements; }
            set { elements = value; }
        }
       private const int defaltcapacity=10;
       int count = 0;
       public GenericList()
           : this(defaltcapacity)
       {
       }

       public GenericList(int capacity)
       {
           elements = new T[capacity];
       }
       public void addelement(T element)
       {
           if (count >= elements.Length)
           {
               throw new IndexOutOfRangeException(String.Format(
                   "The list capacity of {0} was exceeded.", elements.Length));
           }
           else
           {
               ResizeData();
           }
           this.elements[count] = element;
           count++;
       }
       //public T this[int index]
       //{
       //    get
       //    {
       //        if (index >= count)
       //        {
       //            throw new IndexOutOfRangeException(String.Format(
       //                "Invalid index: {0}.", index));
       //        }
       //        T result = elements[index];
       //        return result;
       //    }
       //}

      
       public T[] removeElement(int index)
       {
           if (index >= count)
           {
               throw new IndexOutOfRangeException(String.Format(
                   "Invalid index: {0}.", index));
           }

           List<T> tmp = new List<T>(elements);
           tmp.RemoveAt(index);
           return tmp.ToArray<T>();
       }
       public T[] insertElement(int index, T element)
       {
           if (index >= count)
           {
               throw new IndexOutOfRangeException(String.Format(
                   "Invalid index: {0}.", index));
           }
           else
           {
               ResizeData();
           }
           List<T> tmp2 = new List<T>(elements);
           tmp2.Insert(index,element);
           return tmp2.ToArray();
         
       }
       public void clear()
       {
           List<T> tmp = new List<T>(elements);
           tmp.Clear();
       }

       public void findVaue(T value)
       {

           List<T> tmp2 = new List<T>(elements);
           if (tmp2.Contains(value))
           {
               Console.WriteLine("There is a value <{0}> in the list", value);
           }
           else
           {
               Console.WriteLine("Sorry ther is No value <{0}> in the list", value);
           }
         
         
       }
       private void ResizeData()
       {
           int newSize = defaltcapacity * 2;
           T[] newData = new T[newSize];
           int currentIndex = 0;
           int newIndex = 0;
           while (true)
           {
               if (currentIndex >= this.count)
               {
                   break;
               }
               if (currentIndex < this.count)
               {
                   newData[newIndex] = this.Elements[currentIndex];
                   newIndex++;
               }
               currentIndex++;
           }
           this.Elements = newData;
           this.count = newIndex;
       }
       public  T Min<T>()
        where T : IComparable<T>
       {
           GenericList<T> list = new GenericList<T>();
           T[] values = list.elements;
           object min = values[0];
           T minmin = (T)min;
           for (int i = 0; i < values.Length; i++)
           {
               if (values[i].CompareTo(minmin)<0)
               {
                   minmin = values[i];
               }
           }
           return (T)minmin ;
       }
       public  T Max<T>()
      where T : IComparable<T>
       {
           GenericList<T> list = new GenericList<T>();
           T[] values = list.elements;
           object max = values[0];
           T maxmax = (T)max;
           for (int i = 0; i < values.Length; i++)
           {
               if (values[i].CompareTo(maxmax) > 0)
               {
                   maxmax = values[i];
               }
           }
           return (T)maxmax;
       }

     
    }
}
