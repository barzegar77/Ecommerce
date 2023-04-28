using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Ecommerce.Models.Shipping
{
    public partial class ShippingOptionTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is not string)
                return base.ConvertFrom(context, culture, value);

            var valueStr = value as string;

            if (string.IsNullOrEmpty(valueStr))
                return null;

            ShippingOption shippingOption = null;

            try
            {
                using var tr = new StringReader(valueStr);
                var xmlS = new XmlSerializer(typeof(ShippingOption));
                shippingOption = (ShippingOption)xmlS.Deserialize(tr);
            }
            catch
            {
                //XML error
            }

            return shippingOption;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string))
                return base.ConvertTo(context, culture, value, destinationType);

            if (value is not ShippingOption)
                return string.Empty;

            var sb = new StringBuilder();
            using var tw = new StringWriter(sb);
            var xmlS = new XmlSerializer(typeof(ShippingOption));
            xmlS.Serialize(tw, value);
            var serialized = sb.ToString();
            return serialized;
        }
    }
}