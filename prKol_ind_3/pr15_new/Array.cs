using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr15
{
    public class Array
    {
       ArrayList ms= new ArrayList();
        int[] array;
        public string TakeElement(string index)
        {
            try
            {
                if (array == null)
                {
                    MessageBox.Show("Вы не создали массив");
                    return null;
                }
                if (int.TryParse(index, out int result))
                    return array[result].ToString();
                else
                {
                    MessageBox.Show("Введенное значение не является числом");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Элемент находится за границей массива");
                return null;
            }
        }
        public void CreateArray(int size,string text)
        {
            try
            {
                int.TryParse(text, out int result);
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = result;
                    ms.Add(array[i]);
                }

            }
            catch
            {
                MessageBox.Show("Размер массива должен быть больше 0");
            }
        }
        public string Multiply(int[] array, int b)
        {
            var res = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res[i] = array[i] * b;
            }
            return String.Join(" ", res);
        }
        public string SumArr(int[] array, int[] b)
        {
            var res = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
               res[i] = array[i]+b[i];
            }
           return String.Join(" ", res);
        }
        public string SustractArr(int[] array, int[] b)
        {
            var res = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res[i] = array[i] - b[i];
            }
            return String.Join(" ", res);
        }
        public string Skip(int[] array, int index)
        {
            return $"{index} заданный элемент по идексу {array[index-1]}";
        }

    }
}
    
