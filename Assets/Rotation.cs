using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 RotaVelo;

    void Update()
    {
        transform.Rotate(RotaVelo * Time.deltaTime);    
    }
}
