using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client
{
    /// <summary>
    /// Το Singleton Service μας επιτρέπει να κρατάμε την τιμή του σε όλο το Instance της σελίδας
    /// και στις υποσελίδες του. Αλλά αν γίνει Refresh η σελίδα τότε θα χαθεί το Value του.
    /// </summary>
    public class SingletonService
    {
        public int Valor { get; set; }
    }

    /// <summary>
    /// Το TrasnsinetService μας επιτρέπει να κρατάμε την τιμή του αλλά δεν την κρατάει σε άλλο Instance της σελίδας.
    /// </summary>
    public class TrasnsientService
    {
        public int Valor { get; set; }
    }
}
