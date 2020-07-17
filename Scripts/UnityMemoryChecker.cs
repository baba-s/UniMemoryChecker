using UnityEngine.Profiling;

namespace Kogane
{
	/// <summary>
	/// Unity の使用メモリを確認するクラス
	/// </summary>
	public sealed class UnityMemoryChecker
	{
		//================================================================================
		// プロパティ
		//================================================================================
		/// <summary>
		/// Unity によって割り当てられたメモリを返します
		/// </summary>
		public float Used { get; private set; }

		/// <summary>
		/// 予約済みだが割り当てられていないメモリを返します
		/// </summary>
		public float Unused { get; private set; }

		/// <summary>
		/// Unity が現在および将来の割り当てのために確保している総メモリを返します
		/// </summary>
		public float Total { get; private set; }

		/// <summary>
		/// Unity によって割り当てられたメモリを返します
		/// </summary>
		public string UsedText { get; private set; }

		/// <summary>
		/// 予約済みだが割り当てられていないメモリを返します
		/// </summary>
		public string UnusedText { get; private set; }

		/// <summary>
		/// Unity が現在および将来の割り当てのために確保している総メモリを返します
		/// </summary>
		public string TotalText { get; private set; }

		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 現在のメモリの情報を取得します
		/// </summary>
		public void Update()
		{
			// Unity によって割り当てられたメモリ
			Used = ( Profiler.GetTotalAllocatedMemoryLong() >> 10 ) / 1024f;

			// 予約済みだが割り当てられていないメモリ
			Unused = ( Profiler.GetTotalUnusedReservedMemoryLong() >> 10 ) / 1024f;

			// Unity が現在および将来の割り当てのために確保している総メモリ
			Total = ( Profiler.GetTotalReservedMemoryLong() >> 10 ) / 1024f;

			UsedText   = Used.ToString( "0.0" ) + " MB";
			UnusedText = Unused.ToString( "0.0" ) + " MB";
			TotalText  = Total.ToString( "0.0" ) + " MB";
		}
	}
}