using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend; 
    int i = 3; 
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Red" && i == 100) gameObject.SetActive(false); 
        if(gameObject.name == "Blue" && i == Random.Range(200, 250)) rend.enabled = false;
        Debug.Log(gameObject.name + ":" + ++i); 
    }
}
