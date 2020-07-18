# UniMemoryChecker

Unity や Mono が確保したメモリの使用状況を取得できるスクリプト

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void OnGUI()
    {
        GUILayout.Label( MonoMemoryChecker.UsedText );
        GUILayout.Label( MonoMemoryChecker.TotalText );
        GUILayout.Label( UnityMemoryChecker.UsedText );
        GUILayout.Label( UnityMemoryChecker.UnusedText );
        GUILayout.Label( UnityMemoryChecker.TotalText );
    }
}
```
