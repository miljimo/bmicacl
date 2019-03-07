
namespace Model
{
    using System;
    using System.Collections.Generic;

    public interface IParameterBag<TKey,TValue>
    {
        string    Name { get; }
        /// <summary>
        ///  A a new value to the parameter list.
        /// </summary>
        /// <returns>Void</returns>
        /// <param name="key">The key or unique id of the item to added.</param>
        /// <param name="value">The value to added to the list</param>
        void      oAdd(TKey key, TValue value);

        /// <summary>
        ///  Get the value associated with the given key.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="key">The unique or key to the value to get.</param>
        TValue    oGet(TKey key);


        /// <summary>
        /// Removed the value associated with the given key.
        /// </summary>
        /// <returns>The remove.</returns>
        /// <param name="key">The kley to the value to return</param>
        bool      oRemove(TKey key);


        /// <summary>
        ///  Removed all the item from the list.
        /// </summary>
        void      oClear();

        /// <summary>
        ///  Check if an key exists within the parameter list.
        /// </summary>
        /// <returns>The exist.</returns>
        /// <param name="Key">Key.</param>
        bool      oExist(TKey Key);

        /// <summary>
        ///  Return an enumeration of interface that users can interate.
        /// </summary>
        /// <returns>The enumerator.</returns>
        IEnumerator<KeyValuePair<TKey, TValue>> oGetEnumerator();
    }
}
/***************** End File ********************/