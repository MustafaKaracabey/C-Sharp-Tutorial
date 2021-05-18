using System;

namespace Inheritance_1
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        
        public void Copy()
        {
            Console.WriteLine("Object Copied To Clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        } 
    }
}