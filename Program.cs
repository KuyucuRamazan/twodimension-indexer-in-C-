using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodimensionindexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<RowResult> dataStore= new DataStore<RowResult>(2,10); ;


            RowResult row1 = new RowResult { ID= 1, Name="Ram", Surname="Eli1", 
                Birthdate= new DateTime(2020,10,20), PhoneNumber=1111, Address= "address1", 
                City= "city1", Email= "email1", PostalCode= "11111", Region="region1" };
            dataStore[0,0]=row1;

            RowResult row2 = new RowResult
            {
                ID = 2,
                Name = "Ram2",
                Surname = "Eli2",
                Birthdate = new DateTime(2020, 10, 21),
                PhoneNumber = 2222,
                Address = "address2",
                City = "city2",
                Email = "email2",
                PostalCode = "22222",
                Region = "region2"
            };
            dataStore[1,0] = row2;

        }
    }

    class DataStore<T>
    {
        private T[,] store; // 
        private RowResult[] Rows; // satir

        
        public DataStore()
        {
            store = new T[10,10];
           
        }
        public DataStore(int length, int length2)
        {
            store = new T[length,length2];
        }

        public T this [int index1,int index2]
        {
            get { return store[index1,index2]; }    
            set { store[index1,index2] = value; }
        }

        public int RowCount
        {
            get => Rows.Length;
        }
         
    }

    
    class RowResult
    {
       
        public int ID { get; set; }
        public string Name {get; set; }
        public string Surname  {get; set; }
        public DateTime Birthdate {get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public RowResult() {
           
            
        }
       


    }



}

