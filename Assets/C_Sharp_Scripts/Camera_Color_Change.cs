using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Colour_Change : MonoBehaviour
{
    
    public Camera camra;

    // Start is called before the first frame update
    void Start()
    {
        Colour_Change();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Colour_Change();
        }
    }

    void Colour_Change()
    {
        camra.backgroundColor = Random.ColorHSV();
        
    }
}
