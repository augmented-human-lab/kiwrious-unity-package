using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Startup
{
    [System.Obsolete]
    static Startup()
    {
        PlayerSettings.apiCompatibilityLevel = ApiCompatibilityLevel.NET_4_6;
    }
}
