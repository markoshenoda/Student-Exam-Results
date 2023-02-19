using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace DataBaseManger.Modules
{
    [TypeConverter(typeof(GetEnumDescription))]
    public enum SubjectScoreType
    {
        [Description("أختبار عملي")]
        PracticalExam,
        [Description("أختبار كتابي")]
        WrittenExam,
        [Description("أعمال السنة")]
        YearWorks
    }

    public enum Classes
    {
        Division,
        EducationalInstitution,
        MainDataBaseVerison,
        Student,
        StudentSubjectManged,
        StudentSubjectScore,
        Subject,
        SubjectScore,
        SubjectScoreRate,
        User
    }

    public enum Action
    {
        Add,
        Edit,
        Delete,
        Update
    }

    [TypeConverter(typeof(GetEnumDescription))]
    public enum StudentStat
    {
        [Description("مستجد")]
        New,
        [Description("باقي اعادة")]
        FallBack
    }

    [TypeConverter(typeof(GetEnumDescription))]
    public enum StudentSubjectStat
    {
        [Description("جديد")]
        New,
        [Description("باقي اعادة")]
        FallBack,
        [Description("غياب")]
        Absent,
        [Description("غياب بعزر")]
        ExcusedAbsent,
        [Description("محضر")]
        Report
    }

    [TypeConverter(typeof(GetEnumDescription))]
    public enum UserAccess
    {
        [Description("مدير")]
        Admin,
        [Description("مستخدم")]
        User,
        [Description("شؤان طلاب")]
        Reader
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