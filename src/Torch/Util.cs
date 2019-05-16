﻿using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public static class Util
    {
        public static PyTuple ToTuple(Array input)
        {
            var array = new PyObject[input.Length];
            for (int i = 0; i < input.Length; i++)
                array[i]=ToPython(input.GetValue(0));
            return new PyTuple(array);
        }

        public static PyObject ToPython(object obj)
        {
            if (obj == null)
                return null;

            switch (obj)
            {
                // basic types
                case int o: return new PyInt(o);
                case string o: return new PyString(o);
                // sequence types
                case Array o: return ToTuple(o);
                // other types
                case NumSharp.Shape o: return ToTuple(o.Dimensions);
                case Torch.Tensor o: return new PyObject( o.Handle);
                default:
                    throw new NotImplementedException("Type is not yet supported: " + obj.GetType().Name);
            }
        }

        public static T ToCsharp<T>(dynamic pyobj)
        {
            switch (typeof(T).Name)
            {
                case "Tensor": return (T)(object)new Tensor(pyobj.Handle, pyobj.ToString());
                default: return (T) pyobj;
            }
        }
    }
}
