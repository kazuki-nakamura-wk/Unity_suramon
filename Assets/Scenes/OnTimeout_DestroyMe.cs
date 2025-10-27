using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTimeout_DestroyMe : MonoBehaviour
{
    public float limitSec = 1;

    void Start()
    {
        Destroy(this.gameObject,limitSec);
    }
}
