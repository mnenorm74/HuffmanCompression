using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCompression
{
    public class HuffmanPreprocessor
    {
        private readonly Dictionary<string, byte[]> charCodes = new Dictionary<string, byte[]>();

        public List<HuffmanNode> GetNodeList(Dictionary<char, int> charactersCount)
        {
            var nodeList = charactersCount
                .Select(character => new HuffmanNode(character.Key.ToString(), character.Value)).ToList();

            return nodeList;
        }

        public HuffmanNode GetHuffmanTree(List<HuffmanNode> nodes)
        {
            while (nodes.Count > 1)
            {
                var node1 = nodes[0];
                nodes.RemoveAt(0);
                var node2 = nodes[0];
                nodes.RemoveAt(0);
                nodes.Add(new HuffmanNode(node1, node2));
                nodes.Sort();
            }

            SetCodes("", nodes.First());
            return nodes.FirstOrDefault();
        }

        private void SetCodes(string code, HuffmanNode Nodes)
        {
            if (Nodes == null)
                return;
            if (Nodes.LeftTree == null && Nodes.RightTree == null)
            {
                Nodes.Code = code;
                return;
            }

            SetCodes(code + "0", Nodes.LeftTree);
            SetCodes(code + "1", Nodes.RightTree);
        }

        public Dictionary<string, byte[]> GetCharCodes(HuffmanNode nodes)
        {
            if (nodes == null)
                return new Dictionary<string, byte[]>();
            if (nodes.LeftTree == null && nodes.RightTree == null)
            {
                charCodes.Add(nodes.Character, GetByteCode(nodes.Code));
                return charCodes;
            }
            GetCharCodes(nodes.LeftTree);
            GetCharCodes(nodes.RightTree);
            
            return charCodes;
        }
        
        private byte[] GetByteCode(string line)
        {
            var bytes = new byte[line.Length];
            for (var i = 0; i < line.Length; i++)
            {
                if (line[i] != '0' && line[i] != '1')
                    throw new ArgumentException("Invalid value");
                bytes[i] = line[i] == '0' ? (byte) 0 : (byte) 1;
            }

            return bytes;
        }
    }
}