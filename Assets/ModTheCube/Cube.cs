using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float a = 0.4f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(30.0f * Time.deltaTime, 15.0f * Time.deltaTime, 0.0f);
        Material material = Renderer.material;

        if (a < 0)
        {
            a = 0.4f;
        }
        else
        {
            a -= 0.001f;
        }
        material.color = new Color(1.0f, 1.0f, 0.3f, a);
    }
}
