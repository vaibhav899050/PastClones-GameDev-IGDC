using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour
    
{
    public GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            t.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
