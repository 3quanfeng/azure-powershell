using System;

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Support
{

    [System.ComponentModel.TypeConverter(typeof(KindConverter))]
    public partial struct Kind
    {
        /// <summary>FIXME: Field BlobStorage is MISSING DESCRIPTION</summary>
    }

    public class KindConverter : System.Management.Automation.PSTypeConverter
    {
        public override bool CanConvertFrom(object sourceValue, Type destinationType)
        {
            return true;
        }

        public override bool CanConvertTo(object sourceValue, Type destinationType)
        {
            return false;
        }

        public override object ConvertFrom(object sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase)
        {
            return Kind.CreateFrom(sourceValue);
        }

        public override object ConvertTo(object sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase)
        {
            return default(object);
        }
    }
}