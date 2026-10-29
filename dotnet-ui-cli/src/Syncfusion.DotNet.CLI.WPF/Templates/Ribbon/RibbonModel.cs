#nullable disable
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Documents;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class RibbonModel : NotificationObject
    {
        /// <summary>
        /// Maintains the font family for RibbonComboBox Control.
        /// </summary>
        private string fontFamily;

        /// <summary>
        /// Maintains the font size for RibbonComboBox Control.
        /// </summary>
        private int fontSize;

        /// <summary>
        /// Maintains the slide number.
        /// </summary>
        private int slideNumber;

        /// <summary>
        /// Maintains the text inside the slide item.
        /// </summary>
        private string itemText;

        /// <summary>
        /// Maintains the description of each slide item.
        /// </summary>
        private string description;

        /// <summary>
        /// Gets or sets the font family of the <see cref="GettingStartedModel"/> class.
        /// </summary>     
        public string FontFamily
        {
            get
            {
                return fontFamily;
            }
            set
            {
                fontFamily = value;
                RaisePropertyChanged("FontFamily");
            }
        }

        /// <summary>
        /// Gets or sets the font size of the <see cref="GettingStartedModel"/> class.
        /// </summary>     
        public int FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
                RaisePropertyChanged("FontSize");
            }
        }

        /// <summary>
        /// Gets or sets the value for slide number <see cref="GettingStartedModel"/> class.
        /// </summary>
        public int SlideNumber
        {
            get
            {
                return slideNumber;
            }
            set
            {
                slideNumber = value;
                RaisePropertyChanged("SlideNumber");
            }
        }

        /// <summary>
        /// Gets and sets the value for item text <see cref="GettingStartedModel"/> class.
        /// </summary>
        public string ItemText
        {
            get
            {
                return itemText;
            }
            set
            {
                itemText = value;
                RaisePropertyChanged("ItemText");
            }
        }

        /// <summary>
        /// Gets and sets the value for description <see cref="GettingStartedModel"/> class.
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }
    }
}
