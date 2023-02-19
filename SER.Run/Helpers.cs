using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Data;
using System.Windows.Markup;
using DataBaseManger.Modules;

namespace SER.Run
{
    [TypeConverter(typeof(GetEnumDescription))]
    public enum SelectedView
    {
        [Description("المؤسسات والاقسام التعليمية")]
        EducationalInstitution,
        [Description("المواد التعليمية")]
        Subject,
        [Description("المستخدمين")]
        User,
        [Description("الطلاب")]
        Student,
        [Description("اعدادات تسجيل النتائج")]
        StudentSubjectManged
    }

    public class GetEnumDescription : EnumConverter
    {
        public GetEnumDescription(Type type) : base(type) { }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value != null)
                {
                    FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

                    if (fieldInfo != null)
                    {
                        var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                        return ((attributes.Length > 0) && (!string.IsNullOrEmpty(attributes[0].Description))) ? attributes[0].Description : value.ToString();
                    }
                }

                return string.Empty;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}