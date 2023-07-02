using FN.Framtal.UserControls.Control.API;
using System;

namespace FN.Framtal.UserControls.Control.Services
{
    public sealed class DefaultAutoCompleteService : IAutoCompleteService
    {
        private DefaultAutoCompleteService() { }

        public string GetAutoCompleteString(object item)
        {
            return item?.ToString() ?? string.Empty;
        }

        private static readonly Lazy<DefaultAutoCompleteService> _instance = new Lazy<DefaultAutoCompleteService>(() => new DefaultAutoCompleteService());

        public static DefaultAutoCompleteService Instance => _instance.Value;
    }
}
