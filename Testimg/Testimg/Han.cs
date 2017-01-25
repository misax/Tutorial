using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Testing
{
    public  class Han
    {
        public string  Type { get; set; }
        private  TypeConverter.StandardValuesCollection col;

        public Han(TypeConverter.StandardValuesCollection col)
        {
            Convertor = col;
        }

        public TypeConverter.StandardValuesCollection Convertor
        {
            get
            {
                return col;
            }
            set
            {
                if (value == null)
                {
                    col = value;
                }
                else
                {
                    col = null;
                    throw new NullReferenceException();
                }
            } 
        }

        public void ConvertSomething(CollectionConverter coll)
        {         
            var counter = 0;
            var convert = col;
            if (coll != null)
            {
                convert = new TypeConverter.StandardValuesCollection(new List<Han>());
                counter = convert.Count;
            }
            Console.WriteLine(convert.Cast<Han>() + "," + counter);
        }
    }
}