using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.Standalone, ApiCompatibilityLevel.NET_4_6);
    }
}
