// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Applies a 1D adaptive average pooling over an input signal composed of several input planes.<br></br>
            ///	
            ///	The output size is H, for any input size.<br></br>
            ///	
            ///	The number of output features is equal to the number of input planes.
            /// </summary>
            public partial class AdaptiveAvgPool1d : Module
            {
                // auto-generated class
                
                public AdaptiveAvgPool1d(PyObject pyobj) : base(pyobj) { }
                
                public AdaptiveAvgPool1d(Module other) : base(other.PyObject as PyObject) { }
                
                public AdaptiveAvgPool1d(int output_size)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        output_size,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("AdaptiveAvgPool1d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}