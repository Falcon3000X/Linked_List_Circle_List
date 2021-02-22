using Linked_List_Circle_List.Двусвязный_список;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Circle_List.Кольцевой_список
{
    public class CircularLinkedList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public int Count { get; set; }

        public CircularLinkedList() { }// Empty constructor
        public CircularLinkedList(T data)
        {
            SetHeadItem(data);
        }

        /// <summary>
        /// Добавление елемента в кольцевой список
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);

            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }

        /// <summary>
        /// Удаление елемента из кольцевого списка
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = Count; i > 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                }
                current = current.Next; // Переход на следующий елемент
            }
        }

        /// <summary>
        /// Вспомогательный метод для удаления елемента
        /// </summary>
        /// <param name="current"></param>
        private void RemoveItem(DuplexItem<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }

        /// <summary>
        /// Установка елемента головным
        /// </summary>
        /// <param name="data"></param>
        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        /// <summary>
        /// Энумератор для перебора кольцевого списка 
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
