
namespace NeonDX.DxLibApi
{
    /**
     * 日付
     */
    public sealed class NDX_DateTime : NDX_Object
    {
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
        private int _second;

        /**
         * 年
         */
        public int Year
        {
            get { return _year; }
            set { _year = value; IsModified = true; }
        }

        /**
         * 月
         */
        public int Month
        {
            get { return _month; }
            set { _month = value; IsModified = true; }
        }

        /**
         * 日
         */
        public int Day
        {
            get { return _day; }
            set { _day = value; IsModified = true; }
        }

        /**
         * 時
         */
        public int Hour
        {
            get { return _hour; }
            set { _hour = value; IsModified = true; }
        }

        /**
         * 分
         */
        public int Minute
        {
            get { return _minute; }
            set { _minute = value; IsModified = true; }
        }

        /**
         * 秒
         */
        public int Second
        {
            get { return _second; }
            set { _second = value; IsModified = true; }
        }

        /**
         * コンストラクタ
         */
        public NDX_DateTime()
        {
            _year = 0;
            _month = 0;
            _day = 0;
            _hour = 0;
            _minute = 0;
            _second = 0;
        }
        public NDX_DateTime(NDX_DateTime datetime)
        {
            _year = datetime.Year;
            _month = datetime.Month;
            _day = datetime.Day;
            _hour = datetime.Hour;
            _minute = datetime.Minute;
            _second = datetime.Second;
        }
        public NDX_DateTime(int year, int month, int day, int hour, int minute, int second)
        {
            _year = year;
            _month = month;
            _day = day;
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        /**
         * to string
         */
        public override string ToString()
        {
            return $"{_year:D4}/{_month:D2}/{_day:D2} {_hour:D2}:{_minute:D2}:{_second:D2}";
        }
    }
}
