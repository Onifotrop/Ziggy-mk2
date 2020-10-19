using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public Color deactivated;
    public Color activated;
    public GameObject buttonCen;
    public bool istriggered;
    // Start is called before the first frame update
    void Start()
    {
        buttonCen.GetComponent<SpriteRenderer>().color = deactivated;
    }

    // Update is called once per frame
    void Update()
    {
        if (istriggered)
        {
            buttonCen.GetComponent<SpriteRenderer>().color = activated;
        }
        else
        {
            buttonCen.GetComponent<SpriteRenderer>().color = deactivated;
        }
    }
}
