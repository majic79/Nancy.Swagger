namespace Swagger.ObjectModel.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum, AllowMultiple = false, Inherited = true)]
    internal class SwaggerDataAttribute : Attribute { }
}