using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Problem3
    {
        public List<string> instruction;

        public void BMO()
        {
            instruction = new List<string>();
            instruction.Add("Left");
            instruction.Add("Right");
            instruction.Add("Right");
            instruction.Add("Down");
            instruction.Add("Spin");
            instruction.Add("Down");
            instruction.Add("Up");
            instruction.Add("Left");
            instruction.Add("Right");
            instruction.Add("Left");
            instruction.Add("Down");
            instruction.Add("Spin");
            instruction.Add("Up");
            instruction.Add("Down");
            instruction.Add("Jump");

        }
        public void comboMove()
        {
            int comboLength = instruction.Count;
            for(int i = 0;i < comboLength; i++)
                {                            
                    Console.WriteLine(instruction[i]);                    
                }
        }
    }
}       