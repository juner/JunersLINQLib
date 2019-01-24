namespace Juners.Enumerable
{
    /// <summary>
    /// 列挙数が足りない時の挙動設定
    /// </summary>
    public enum ZipNotEnough
    {
        /// <summary>
        /// 列挙数が足りない時はその時点で列挙を終了する
        /// </summary>
        Break = 0,
        /// <summary>
        /// 列挙数が足りない時は全て列挙し終わるまでdefault値を設定する
        /// </summary>
        Default = 1,
    }
}
