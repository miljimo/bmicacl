
namespace Model
{
    using System.Collections.Generic;

    public class ParameterBag<K,V>: IParameterBag<K, V>
    {
       private IDictionary<K, V> oParameters;
       private string            oName;
       /// <summary>
       /// The default constructor to the parameter name
       /// </summary>
       /// <param name="Name"></param>
       public  ParameterBag(string Name)
        {
            oParameters = new Dictionary<K, V>();
            this.oName = Name;
        }
        /// <summary>
        /// Add a new value key to the dictionary collectiion.
        /// If the key exist it will override it.
        /// </summary>
        /// <param name="key">The key </param>
        /// <param name="value">The value to added.</param>
        public virtual void oAdd(K key, V value)
        {
           if(key != null)
           {
               if (oParameters.ContainsKey(key) != true)
               {
                   oParameters.Add(new KeyValuePair<K, V>(key, value));
               }
               else
               {
                   oParameters[key] = value;
               }
           }
        }
        /// <summary>
        ///  Get the value from the parameter bag using the value key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual V oGet(K key)
        {
            object Value = null;
            if (oParameters.ContainsKey(key))
                Value = oParameters[key];
            return (V)Value;
        }
        /// <summary>
        ///  Remove the value from the parameters bag
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual bool oRemove(K key)
        {
            bool Removed = false;
            if (oParameters.ContainsKey(key))
            {
                Removed = oParameters.Remove(key);
            }
            return Removed;
        }
        /// <summary>
        ///  Clear and removed all the contains of the Parameter Bag
        /// </summary>
        public virtual void oClear()
        {
            if (oParameters != null)
            {
                oParameters.Clear();
            }
        }
        /// <summary>
        ///  Return an Enumerator to the Contents
        /// </summary>
        /// <returns>return a enumerator object</returns>
        public IEnumerator<KeyValuePair<K, V>> oGetEnumerator()
        {
            return this.oParameters.GetEnumerator();
        }
        /// <summary>
        ///  Check if the Key exists
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public virtual bool oExist(K Key)
        {
            return oParameters.ContainsKey(Key);
        }
        /// <summary>
        /// Return the name of the parameter bag
        /// </summary>
        public string Name
        {
            get
            {
                return oName;
            }
        }
    }
}
/************************* End file *********************************************/