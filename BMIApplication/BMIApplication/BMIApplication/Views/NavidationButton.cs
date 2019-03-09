using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApplication.Views
{
   
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public enum IconType
    {
        None,
        Explorer,
        CreateNewUser,
        SignIn,
        Signout,
        Help,
        User,
        ViewRecords,
        Building,
    }

    internal class NavigationButton : Button
    {

        public NavigationButton()
        {

        }

        #region IconText Property

        /// <summary>
        ///  The IconText Property to hold the Icon Text , the value must be an IconType  that is auto convertered to the Awesome Text type
        /// </summary>
        public static readonly DependencyProperty IconTextProperty = DependencyProperty.Register("IconType", typeof(IconType),
                                                                   typeof(NavigationButton), new FrameworkPropertyMetadata(IconType.None,
                                                                    FrameworkPropertyMetadataOptions.AffectsRender));

        public IconType IconType
        {
            get
            {
                return (IconType)GetValue(IconTextProperty);
            }
            set
            {
                if (value != (IconType)GetValue(IconTextProperty))
                {
                    SetValue(IconTextProperty, value);
                }
            }
        }

        #endregion


        /// <summary>
        ///  The icon foreground property
        /// </summary>
        public static readonly DependencyProperty IconForegroundProperty = DependencyProperty.Register("IconForeground", typeof(Brush),
                                                                typeof(NavigationButton), new FrameworkPropertyMetadata(default(Brush),
                                                                  FrameworkPropertyMetadataOptions.AffectsRender));
        public Brush IconForeground
        {
            get
            {
                return (Brush)GetValue(IconForegroundProperty);
            }
            set
            {
                SetValue(IconForegroundProperty, value);
            }
        }


        /// <summary>
        ///  The icon foreground property
        /// </summary>
        public static readonly DependencyProperty SelectedBackgroundProperty = DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush),
                                                                typeof(NavigationButton), new FrameworkPropertyMetadata(default(Brush),
                                                                  FrameworkPropertyMetadataOptions.AffectsRender));
        public Brush SelectedBackground
        {
            get
            {
                return (Brush)GetValue(SelectedBackgroundProperty);
            }
            set
            {
                SetValue(SelectedBackgroundProperty, value);
            }
        }




        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register("IconSize", typeof(double),
                                                             typeof(NavigationButton), new FrameworkPropertyMetadata((double)25,
                                                                 FrameworkPropertyMetadataOptions.AffectsRender));

        [TypeConverterAttribute(typeof(FontSizeConverter))]
        [LocalizabilityAttribute(LocalizationCategory.None)]
        public double IconSize
        {
            get
            {
                return (double)GetValue(IconSizeProperty);
            }
            set
            {
                SetValue(IconSizeProperty, value);
            }
        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool),
                                                           typeof(NavigationButton), new FrameworkPropertyMetadata(false,
                                                               FrameworkPropertyMetadataOptions.AffectsRender));
        public bool IsActive
        {
            get
            {
                return (bool)GetValue(IsActiveProperty);
            }
            set
            {
                SetValue(IsActiveProperty, value);
            }
        }

    }
}
