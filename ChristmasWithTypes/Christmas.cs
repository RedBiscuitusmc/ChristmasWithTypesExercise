using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {

       


        public string[] Presents;
        

        public string Santa
        {//==========================

            get; set;


        }//==========================
        
         //TODO Make the Height property nullable
        public int? TreeHeight { get; set; } = null;
           
            













        //TODO Make the property, "Day", type enum
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        

    }
    
}
