﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    public interface IFile
    {
        string Read();

        void Write();
    }
}
