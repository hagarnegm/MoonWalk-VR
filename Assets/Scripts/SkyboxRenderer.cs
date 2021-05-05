using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRenderer : MonoBehaviour
{
    public Material space;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = space;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
