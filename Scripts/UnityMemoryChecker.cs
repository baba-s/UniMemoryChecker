using UnityEngine.Profiling;

namespace Kogane
{
	/// <summary>
	/// Unity の使用メモリを確認するクラス
	/// </summary>
	public sealed class UnityMemoryChecker
	{
		//================================================================================
		// プロパティ(static)
		//================================================================================
		/// <summary>
		/// Unity によって割り当てられたメモリを返します
		/// </summary>
		public float Used => ( Profiler.GetTotalAllocatedMemoryLong() >> 10 ) / 1024f;

		/// <summary>
		/// 予約済みだが割り当てられていないメモリを返します
		/// </summary>
		public float Unused => ( Profiler.GetTotalUnusedReservedMemoryLong() >> 10 ) / 1024f;

		/// <summary>
		/// Unity が現在および将来の割り当てのために確保している総メモリを返します
		/// </summary>
		public float Total => ( Profiler.GetTotalReservedMemoryLong() >> 10 ) / 1024f;

		/// <summary>
		/// Unity によって割り当てられたメモリを返します
		/// </summary>
		public string UsedText => Used.ToString( "0.0" ) + " MB";

		/// <summary>
		/// 予約済みだが割り当てられていないメモリを返します
		/// </summary>
		public string UnusedText => Unused.ToString( "0.0" ) + " MB";

		/// <summary>
		/// Unity が現在および将来の割り当てのために確保している総メモリを返します
		/// </summary>
		public string TotalText => Total.ToString( "0.0" ) + " MB";
	}
}