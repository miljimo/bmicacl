using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UI.AttachProperties
{
  class ItemControlOrientationProperty:BaseAttachedProperty<ItemControlOrientationProperty, Orientation>
    {
        public static readonly DependencyProperty OrientationProperty = CreateProperty("Orientation");


        public static void SetOrientation(DependencyObject d, Orientation Orientation)
        {
            SetValue(d, OrientationProperty, Orientation);
        }
        public static Orientation GetOrientation(DependencyObject d)
        {
            return GetValue(d, OrientationProperty);
        }

        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ItemsControl Items = d as ItemsControl;
            if(Items != null)
            {
              if(Items.ItemsPanel  != null)
                {
                    StackPanel  Panel =  Items.ItemsPanel.LoadContent() as StackPanel;
                    if(Panel != null)
                    {

                    }
                }

            }
            //Do nothing
        }
    }
}
