using System;

namespace NeonDX.DxLibApi
{
    public class NeonDxDxLibApiException : Exception
    {
        private EnumDxLibApi _api;

        public EnumDxLibApi Api
        {
            get { return _api; }
        }

        public NeonDxDxLibApiException(string message, EnumDxLibApi api) : base(message)
        {
            _api = api;
        }
    }
}
