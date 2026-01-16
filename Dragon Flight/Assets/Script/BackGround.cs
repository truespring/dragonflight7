using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Scroll available background images
    public float scrollSpeed = 1f;
    private Material myMaterial;

    void Start()
    {
        // Getting material
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Get from offset material
        Vector2 newOffset = myMaterial.mainTextureOffset;

        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        myMaterial.mainTextureOffset = newOffset;
    }
}
