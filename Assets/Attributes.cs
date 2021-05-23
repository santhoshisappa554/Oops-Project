using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class Attributes : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField]
    //[HideInInspector]
    [Range(0,10)]
    public int speed;
    Rigidbody rb;
    private void Awake()
    {
        gameObject.AddComponent<Rigidbody>();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        rb.isKinematic = false;
    }
}
