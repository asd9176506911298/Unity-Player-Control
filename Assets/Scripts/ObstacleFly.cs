using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.Translate(Vector3.up * Time.deltaTime * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
