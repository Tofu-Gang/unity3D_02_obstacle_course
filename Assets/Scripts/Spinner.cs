using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float angleDeltaX = 0f;
    [SerializeField] float angleDeltaY = 0.5f;
    [SerializeField] float angleDeltaZ = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angleDeltaX, angleDeltaY, angleDeltaZ);
    }
}
