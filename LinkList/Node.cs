﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int _value)
        {
            this.Value = _value;
        }
    }
}
