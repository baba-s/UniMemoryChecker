using UnityEngine.Profiling;

namespace Kogane
{
	/// <summary>
	/// Mono の使用メモリを確認するクラス
	/// </summary>
	public static class MonoMemoryChecker
	{
		//================================================================================
		// プロパティ(static)
		//================================================================================
		public static float Used => ( Profiler.GetMonoUsedSizeLong() >> 10 ) / 1024f;

		// ヒープが大きいほど GC の時間がかかりますが、実行される頻度は少なくなる
		public static float Total => ( Profiler.GetMonoHeapSizeLong() >> 10 ) / 1024f;

		public static string UsedText  => Used.ToString( "0.0" ) + " MB";
		public static string TotalText => Total.ToString( "0.0" ) + " MB";
	}
}