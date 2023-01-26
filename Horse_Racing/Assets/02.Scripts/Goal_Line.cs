using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Line : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Horse>().doMove = false;
    }
}
