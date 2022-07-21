using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieMenu : MonoBehaviour
{
    public Image pie;
    // Start is called before the first frame update
    void Start()
    {
        pie = this.GetComponent<Image>();
        pie.alphaHitTestMinimumThreshold = 0.9f;
    }

    
}