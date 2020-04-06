using System;

namespace HuffmanCompression
{
    public class HuffmanNode : IComparable<HuffmanNode>
    { 
        public readonly string Character;
        private int Frequency;          
        public string Code;            
        public readonly HuffmanNode LeftTree;   
        public readonly HuffmanNode RightTree;

        public HuffmanNode(string value, int frequency)    
        {
            Character = value;     
            Frequency = frequency;
        }
        
        public HuffmanNode(HuffmanNode firstNode, HuffmanNode secondNode)
        {
            Code = string.Empty;
            
            if (firstNode.Frequency >= secondNode.Frequency)
            {
                RightTree = firstNode;
                LeftTree = secondNode; 
                Character = firstNode.Character + secondNode.Character;
                Frequency = firstNode.Frequency + secondNode.Frequency;
            }
            else if (firstNode.Frequency < secondNode.Frequency)
            {
                RightTree = secondNode;
                LeftTree = firstNode;    
                Character = secondNode.Character + firstNode.Character;
                Frequency = secondNode.Frequency + firstNode.Frequency;
            }
        }


        public int CompareTo(HuffmanNode otherNode)
        {
            return Frequency.CompareTo(otherNode.Frequency);
        }
    }
}