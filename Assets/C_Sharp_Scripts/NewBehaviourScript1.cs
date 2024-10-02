using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public SpriteRenderer meshRenderer;
    

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
        meshRenderer.material.color = Random.ColorHSV();
        
    }
}
