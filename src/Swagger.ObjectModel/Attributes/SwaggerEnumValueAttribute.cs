namespace Swagger.ObjectModel.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    internal class SwaggerEnumValueAttribute : Attribute
    {
        public SwaggerEnumValueAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}