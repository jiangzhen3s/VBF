﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.MiniSharp.Ast
{
    public abstract class Expression : AstNode
    {
        public TypeBase ExpressionType { get; set; }
    }
}
