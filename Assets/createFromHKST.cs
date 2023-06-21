using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class createFromHKST : MonoBehaviour
{
    GameObject obj;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        obj= GetComponent<GameObject>();
        _text = GetComponent<Text>();
        _text.enabled= true;
        _text.text = "Ç§Å@ÇÒÅ@Ç±";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
