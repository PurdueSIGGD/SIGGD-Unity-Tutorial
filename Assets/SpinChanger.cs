using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MakeSpin>().rotation = new Vector3(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
