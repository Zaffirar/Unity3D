using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryBlock : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    public void StartFalling()
    {
        rb.AddForce(0,0,50);
    }
}
