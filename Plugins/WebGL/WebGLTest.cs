using UnityEngine;

/// <summary>
/// UI view for calling a function from JS plugin
/// </summary>
public class WebGLTest : MonoBehaviour
{
    /// <summary>
    /// Call function in the JS plugin
    /// </summary>
    public void CallFunction()
    {
        // Calling JS function
        WebGLPlugin.CallFunction();
    }
}
