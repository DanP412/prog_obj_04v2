using System;
using System.Collections; //    Zawiera interfejsy i klasy definiujące różne kolekcje obiektów, takie jak listy, kolejki, tablice bitowe, tabele skrótów i słowniki.
using System.Collections.Generic; //    Zawiera interfejsy i klasy definiujące kolekcje ogólne, które umożliwiają użytkownikom tworzenie silnie typicznych kolekcji,
                                  //    które zapewniają lepsze bezpieczeństwo i wydajność typów niż kolekcje niegeneryczne silnie typowane.
using System.Collections.Immutable; //  Zawiera interfejsy i klasy, które definiują Niezmienne kolekcje.
using System.Collections.Concurrent; //Zapewnia kilka klas kolekcji bezpiecznych dla wątków, które powinny być używane zamiast odpowiednich typów
                                     // w System.CollectionsSystem.Collections.Generic przestrzeniach nazw i za każdym razem, gdy wiele wątków uzyskuje dostęp do kolekcji współbieżnie.
namespace prog_obj_04
{
    public class DynamicArray<T>: IEnumerable<T>
    {
        private T[] arr;
        public T this[int i]
    }
    class Program
    {

        static void Main()
        {

            //LISTA
            IList list = new ArrayList();
            //DODAWANIE WARTOŚCI
            list.Add("ABC");
            //USUWANIE WARTOŚCI 
            list.Remove("ABC");

            //ITERACJA
            foreach (IList abc in list)
            {
                Console.WriteLine("ITERACJA");
            }



            //SLOWNIK
            IDictionary dictionary4 = new SortedList<string, string>();
            //Dodawanie wartości 
            dictionary4.Add("dupa", "Cycki");

            //Usuwanie Wartości


            IDictionary dictionary5 = new Hashtable();


            //KOLEJKA
            Queue queue = new Queue();

            //STOS
            Stack stack = new Stack();


            IList<int> list1 = new List<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            ISet<int> set1 = new HashSet<int>();
            ISet<int> set2 = new SortedSet<int>();
            IDictionary<string, int> dictionary1 = new Dictionary<string, int>();
            IDictionary<string, int> dictionary2 = new SortedList<string, int>();
            IDictionary<string, int> dictionary3 = new SortedDictionary<string, int>();
            Queue<int> queue1 = new Queue<int>();
            Stack<int> stack1 = new Stack<int>();
            PriorityQueue<int, int> queue2 = new PriorityQueue<int, int>();


        }
    }
}
       



