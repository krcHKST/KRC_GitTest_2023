using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createFromHKST2 : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(obj);
    }
}
