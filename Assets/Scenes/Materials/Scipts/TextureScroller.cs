
using System.Diagnostics;
using UnityEngine;
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

public class TextureScroller : MonoBehaviour ; 
 
 string "GetDebuggerDisplay"();
{
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
    // Start is called before the first frame update
public float speed = .5f;
    private float speed = .5f;

renderer renderer;

    // Update is called once per frame
    void Update()
    {
    // Increase offset based on time
    offset += Time.deltaTime * speed;
    // Keep offset between 0 and 1
    if (offset > 1)
        offset -= 1;
    // Apply the offset to the material
    renderer.material.mainTextureOffset = new Vector2(0, offset);
}

