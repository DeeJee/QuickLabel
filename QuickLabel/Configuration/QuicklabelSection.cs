using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLabel.Configuration
{
    public class QuickLabelSection : ConfigurationSection
    {
        [ConfigurationProperty("invoer")]
        public InvoerElement Invoer
        {
            get
            {
                return (InvoerElement)this["invoer"];
            }
            set
            { this["invoer"] = value; }
        }

        [ConfigurationProperty("label")]
        public LabelElement Label
        {
            get
            {
                return (LabelElement)this["label"];
            }
            set
            { this["label"] = value; }
        }

        [ConfigurationProperty("printerConfig")]
        public PrinterElement Printer
        {
            get
            {
                return (PrinterElement)this["printerConfig"];
            }
            set
            { this["printerConfig"] = value; }
        }
    }

    // Define the "font" element
    // with "name" and "size" attributes.
    public class FontElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "Arial", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("size", DefaultValue = "12", IsRequired = false)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 24, MinValue = 6)]
        public int Size
        {
            get
            { return (int)this["size"]; }
            set
            { this["size"] = value; }
        }
    }

    // Define the "color" element 
    // with "background" and "foreground" attributes.
    public class ColorElement : ConfigurationElement
    {
        [ConfigurationProperty("background", DefaultValue = "FFFFFF", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\GHIJKLMNOPQRSTUVWXYZ", MinLength = 6, MaxLength = 6)]
        public String Background
        {
            get
            {
                return (String)this["background"];
            }
            set
            {
                this["background"] = value;
            }
        }

        [ConfigurationProperty("foreground", DefaultValue = "000000", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\GHIJKLMNOPQRSTUVWXYZ", MinLength = 6, MaxLength = 6)]
        public String Foreground
        {
            get
            {
                return (String)this["foreground"];
            }
            set
            {
                this["foreground"] = value;
            }
        }
    }

    public class PrinterElement : ConfigurationElement
    {
        [ConfigurationProperty("alwaysShowPrintDialog", DefaultValue = false, IsRequired = true)]
        public Boolean AlwaysShowPrintDialog
        {
            get
            {
                return (bool)this["alwaysShowPrintDialog"];
            }
            set
            {
                this["alwaysShowPrintDialog"] = value;
            }
        }
        [ConfigurationProperty("landscape", DefaultValue = true, IsRequired = true)]
        public Boolean Landscape
        {
            get
            {
                return (bool)this["landscape"];
            }
            set
            {
                this["landscape"] = value;
            }
        }
        [ConfigurationProperty("printer", IsRequired = true)]
        public String Printer
        {
            get
            {
                return (String)this["printer"];
            }
            set
            {
                this["printer"] = value;
            }
        }
        [ConfigurationProperty("paper", IsRequired = true)]
        public String Paper
        {
            get
            {
                return (String)this["paper"];
            }
            set
            {
                this["paper"] = value;
            }
        }
    }

    public class InvoerElement : ConfigurationElement
    {
        [ConfigurationProperty("adressenFile", IsRequired = true)]
        public string AdressenFile
        {
            get
            {
                return (string)this["adressenFile"];
            }
            set
            {
                this["adressenFile"] = value;
            }
        }
        [ConfigurationProperty("adressenSeparator", DefaultValue = ";", IsRequired = false)]
        public string AdressenSeparator
        {
            get
            {
                return (string)this["adressenSeparator"];
            }
            set
            {
                this["adressenSeparator"] = value;
            }
        }
        [ConfigurationProperty("containersFile", IsRequired = true)]
        public string ContainersFile
        {
            get
            {
                return (string)this["containersFile"];
            }
            set
            {
                this["containersFile"] = value;
            }
        }
        [ConfigurationProperty("containersSeparator", DefaultValue = ";", IsRequired = false)]
        public string ContainersSeparator
        {
            get
            {
                return (string)this["containersSeparator"];
            }
            set
            {
                this["containersSeparator"] = value;
            }
        }
    }

    public class LabelElement : ConfigurationElement
    {
        // Create a "font" element.
        [ConfigurationProperty("font")]
        public FontElement Font
        {
            get
            {
                return (FontElement)this["font"];
            }
            set
            { this["font"] = value; }
        }

        // Create a "color element."
        [ConfigurationProperty("color")]
        public ColorElement Color
        {
            get
            {
                return (ColorElement)this["color"];
            }
            set
            { this["color"] = value; }
        }
    }
}