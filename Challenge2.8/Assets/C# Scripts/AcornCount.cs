using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornCount : MonoBehaviour
{
    public float Acorns;
    public Text AcornText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AcornText.text = "Acorns: " + Acorns;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Acorn")
        {
            Acorns += 1;
        }
    }
}
