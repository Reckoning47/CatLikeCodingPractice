using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFPS : MonoBehaviour
{
    uint i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        i++;
    }
}
