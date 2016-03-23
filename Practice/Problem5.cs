using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Problem5
    {
        public void dancing()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ReadKey();
                Console.Clear();
                if (i % 2 == 0)
                {
                    armUp();
                }
                else
                {
                    armDown();
                }
            }
        }
        public void armUp()
        {


            Console.WriteLine(
                @"
                     *  *
                   *      *
                     *  *        *
                      *      *
                   *  *  *
                 *    *    
               *      *      
                      *
                   *      *
                 *          *
               *              *
             *                  *
           *                      * ");



        }
        public void armDown()
        {
            Console.WriteLine(
                @"
                     *  *
                   *      *
                     *  * 
                      *  
                   *  *  *
                 *    *    * 
               *      *      *  
                      *
                   *      *
                 *          *
               *              *
             *                  *
           *                      * ");



        }







    }
}
