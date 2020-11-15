using System;

namespace Exercise_9
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Program
    {
        public static void Main()
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                // Fixed with new method
                // A.addElement(r.Next(4));
                // B.addElement(r.Next(12));
                A.AddElement(r.Next(4));
                B.AddElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.Union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }

    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }
        // naming violation
        // public bool addElement(int val)
        public bool AddElement(int val)
        {
            // Fixed with new method
            //if (containsElement(val)) return false;
            if (ContainsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        // Naming violation
        // private bool containsElement(int val)
        private bool ContainsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                else
                    return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        // Naming violation
        //public void clearSet()
        public void ClearSet()
        {
            elements.Clear();
        }
       // Naming violation
       // public Set union(Set rhs)
        public Set Union(Set rhs)
        {
            Set temp = new Set();
            for (int i = 0; i < this.elements.Count; i++)
            {
                // Fixed with new method
                //temp.addElement(this.elements[i]);
                temp.AddElement(this.elements[i]);
            }
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // Fixed with new method
                // temp.addElement(rhs.elements[i]);
                temp.AddElement(rhs.elements[i]);
            }
            return temp;
        }
        // new method updated above. Temp set created to avoid the merging of the two sets.
        /*
        public Set union(Set rhs )
            {

                for(int i = 0; i < rhs.elements.Count; i++)
                {
                    this.addElement( rhs.elements[ i ] );
                }           
                return rhs;
            }
        */
    }


}
