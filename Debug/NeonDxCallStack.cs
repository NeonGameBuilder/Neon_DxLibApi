using System;

namespace NeonDX.DxLibApi.Debug
{
    public static class NeonDxCallStack
    {
        private static Stack<CallHistory> _stack = new Stack<CallHistory>();

        public class ApiArg
        {
            public string ArgName { get; set; }
            public string ArgValue { get; set; }

            public ApiArg(string arg_name, string arg_value)
            {
                ArgName = arg_name;
                ArgValue = arg_value;
            }

            public override string ToString()
            {
                return $"{ArgName}={ArgValue}";
            }
        }

        public class CallHistory
        {
            public EnumDxLibApi Api { get; set; }
            public List<ApiArg> Args { get; set; } = new List<ApiArg>();
        }

        /**
         * push call history
         */
        public static void Push(EnumDxLibApi api, params ApiArg[] args)
        {
            var history = new CallHistory()
            { 
                Api = api,
                Args = new List<ApiArg>(args)
        };
            _stack.Push(history);
        }

        /**
         * pop call history
         */
        public static void Pop()
        {
            _stack.Pop();
        }

        /**
         * dump
         */
        public static void Dump(Action<string> callback)
        {
            foreach(var item in _stack)
            {
                string line = $"[{item.Api}]" + string.Join(",", item.Args);
                callback(line);
            }
        }
    }
}
