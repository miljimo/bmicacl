


namespace UI.AttachProperties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()
    {

        #region Event handlers
        /// <summary>
        ///  The event handler for the valued changed and valued updated
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };
        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };

        #endregion

        #region Current Instance
        /// <summary>
        /// Create an instance of the parent class so that will can delegated the events changed to the parents.
        /// </summary>
        private static readonly object __instanceLocker = new Object();
        private static Parent __instance = null;
        public static Parent Instance
        {
            get
            {
                lock (__instanceLocker)
                {
                    return __instance ?? (__instance = new Parent());
                }
            }
            private set
            {
                if (value != __instance)
                {
                    __instance = value;
                }
            }
        }

        #endregion


        /// <summary>
        ///   Create the attached property  and events
        /// </summary>
       // public static DependencyProperty ValueProperty = null;

        private static DependencyProperty ValueProperty;
        protected static DependencyProperty CreateProperty(String Name)
        {
              ValueProperty = DependencyProperty.RegisterAttached(Name, typeof(Property), 
                typeof(Parent), new UIPropertyMetadata(default(Property), new PropertyChangedCallback(OnAttachedValueChanged),
                                                       new CoerceValueCallback(OnAttachedValueUpdated)));
           return ValueProperty;
        }



         /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d, DependencyProperty property) 
        {
            return (Property)d.GetValue(property);
        }

        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <param name="value">The value to set the property to</param>
        public static void SetValue(DependencyObject d, DependencyProperty dpropety,  Property value)
        {
            d.SetValue(dpropety, value);
        }

        /// <summary>
        /// Fire when the property value has be updated to new value.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static object OnAttachedValueUpdated(DependencyObject element, object Value)
        {
            object result = Value;
            if ((Instance != null) && (Instance is BaseAttachedProperty<Parent, Property>))
            {
                result = Instance.OnValueUpdated(element, Value);
                Instance.ValueUpdated(element, result);
            }
            return result;
        }

        /// <summary>
        ///  Fire anything users try to set the value of the property.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnAttachedValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((Instance != null) && (Instance is BaseAttachedProperty<Parent, Property>))
            {
                Instance.OnValueChanged(d, e);
                Instance.ValueChanged(d, e);
            }
        }



        /// <summary>
        ///   The method will be called when the value is changed
        /// </summary>
        /// <param name="d"> The xaml element that the proerty is attached to</param>
        /// <param name="e">The  arguments of the property passed.</param>
        public abstract void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e);
        

        /// <summary>
        ///  The method will be called when the property is called to be updated it does not matter what  value is passed.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="value"></param>
        public virtual object OnValueUpdated(DependencyObject d, object value)
        {
            return value;
        }


    }


}
