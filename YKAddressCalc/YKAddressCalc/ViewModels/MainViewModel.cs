namespace YKAddressCalc.ViewModels
{
    using System;
    using System.Reflection;
    using YKToolkit.Bindings;

    internal class MainViewModel : NotificationObject
    {
        /// <summary>
        /// アプリケーション名を取得します。
        /// </summary>
        public string Title { get { return ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute))).Title; } }

        private int _topAddress;
        /// <summary>
        /// 先頭アドレスを取得または設定します。
        /// </summary>
        public int TopAddress
        {
            get { return this._topAddress; }
            set
            {
                if (SetProperty(ref this._topAddress, value))
                {
                    RaisePropertyChanged("OffsetAddress");
                }
            }
        }

        private int _byteLength;
        /// <summary>
        /// 1 バイト要素数を取得または設定します。
        /// </summary>
        public int ByteLength
        {
            get { return this._byteLength; }
            set
            {
                if (SetProperty(ref this._byteLength, value))
                {
                    RaisePropertyChanged("OffsetAddress");
                }
            }
        }

        private int _shortLength;
        /// <summary>
        /// 2 バイト要素数を取得または設定します。
        /// </summary>
        public int ShortLength
        {
            get { return this._shortLength; }
            set
            {
                if (SetProperty(ref this._shortLength, value))
                {
                    RaisePropertyChanged("OffsetAddress");
                }
            }
        }

        private int _longLength;
        /// <summary>
        /// 4 バイト要素数を取得または設定します。
        /// </summary>
        public int LongLength
        {
            get { return this._longLength; }
            set
            {
                if (SetProperty(ref this._longLength, value))
                {
                    RaisePropertyChanged("OffsetAddress");
                }
            }
        }

        /// <summary>
        /// オフセットアドレスを取得します。
        /// </summary>
        public int OffsetAddress
        {
            get { return this.TopAddress + this.ByteLength + 2 * this.ShortLength + 4 * this.LongLength; }
        }
    }
}
