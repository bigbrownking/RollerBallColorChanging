using UnityEngine;
public class InteractionController : MonoBehaviour
{
    public GameObject objectToChangeColor;
    private Renderer objectRenderer;
    void Start()
    {
        objectRenderer = objectToChangeColor.GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            objectRenderer.material.color = Color.red;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            objectRenderer.material.color = Color.blue;
        }
    }
}