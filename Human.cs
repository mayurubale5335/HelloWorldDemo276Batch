﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo276Batch
{
   public class Human
    {
        //instance variables
        //name,height,weight,Age
        //syntax - access modifier datatype variables
        public string name;
        public float height,weight;
        public int age;
        
        //instance method
        public void talk()   //method signature/defination
        {
            // method body or implementation
            Console.WriteLine("Human can talk");
        }

        public void HumanDetails(string humanName, float humanHeight, float humanWeight, int age)   //method signature/defination
        {
            // method body or implementation
            Console.WriteLine("Human Details:{0} {1} {2} {3}", humanName, humanHeight, humanWeight, age);
        }
    }
}
