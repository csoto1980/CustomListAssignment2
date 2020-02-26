using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {
        //Member Variables

        private T[] array; // Creatinog a private generic array | list has array capacity & count
        private int capacity; //how much is available - amount of seats in a bus
        public int Capacity //need set
        {
            get { return capacity; }
        }
        private int count; // How much is inside | amount of people in a bus
        public int Count
        {
            get { return count; }
        }
        //indexer
        public T this[int number]//[] is the parameter | myList[2] //defines indexer to allow code to use [] notation
        {
            get { return array[number]; }//when you try to get cus
            set { array[number] = value; }
        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
        }
        
        //Member Methods
        public void Add(T item) //add to list /array
        {
            //increment count **CHECK**

            //get item into array at correct spot | item needs to land at the next avaial index****************************
            array[count] = item;
            count++;

            //private bool ArrayFull()
            //{
            //    bool mitten = false;
            //    if (count == capacity)
            //    {
            //        mitten = true;
            //    }
            //    return mitten;
            //}
            //if capacity is more than for increase capacity by 4

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increases capacity and copy
            //increase the capacity start out of 4 make the size 8
            //
            //try adding 5 and make sure cap is 8

            //arrange check to see make sure to put 5th in
            //make sure one of the original 4 are still there.

            //bool isFull = ArrayFull();
        }

        public void Remove(T item)
        {

            //deccrement count
            
            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to decreases capacity and copy
        }
        public void ToString(T item)
        {

        }

    }
}
