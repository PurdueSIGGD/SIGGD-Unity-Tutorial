using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSpin : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
