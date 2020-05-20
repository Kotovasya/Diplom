using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Client.Helpers
{
    public static class ControlCollectionHelper
    {
        /// <summary>
        /// Добавляет Control в начало коллекции
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ControlCollection Prepend(this ControlCollection collection, Control control)
        {
            Control[] array = new Control[collection.Count + 1];
            array[0] = control;
            for (int i = 0; i < collection.Count; i++)
                array[i + 1] = collection[i];
            collection.Clear();
            collection.AddRange(array);
            return collection;
        }

        /// <summary>
        /// Добавляет массив Control'ов в начало коллекции
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="controls"></param>
        /// <returns></returns>
        public static ControlCollection PrependRange(this ControlCollection collection, Control[] controls)
        {
            Control[] array = new Control[collection.Count + controls.Length];
            for (int i = 0; i < controls.Length; i++)
                array[i] = controls[i];
            for (int i = controls.Length; i < collection.Count; i++)
                array[i] = collection[i - 1];
            collection.Clear();
            collection.AddRange(array);
            return collection;
        }
    }
}
