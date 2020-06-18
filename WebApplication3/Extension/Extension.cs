using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Extension
{
    static class Extension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> obj)
        {
            return new ObservableCollection<T>(obj);
        }
    }
}
