using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH : MonoBehaviour
{
    public float speed = 2;
    
    void FixedUpdate()
    {
        this.transform.Translate(speed/50,0,0);
    }
}
