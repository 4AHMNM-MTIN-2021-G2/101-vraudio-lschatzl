using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inMazeTrigger : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
