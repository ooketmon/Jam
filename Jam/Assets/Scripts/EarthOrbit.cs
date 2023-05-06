using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=oW9gzkR1yuw
public class EarthOrbit : MonoBehaviour
{
    private float angle = 0f;
    private float selfRotateAngle = 0f; 

   [SerializeField] private float orbitSpeed = 1f;
   [SerializeField] private float orbitRadius = 5f;
   [SerializeField] private float selfRotateSpeed = 1f; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xPos = orbitRadius * Mathf.Sin(angle);
        var zPos = orbitRadius * Mathf.Cos(angle);

        transform.localPosition = new Vector3(xPos, 0f, zPos);

        angle += orbitSpeed * Time.deltaTime;

        //Rotate is by Space.Self by default 
        transform.Rotate(0f, selfRotateAngle, 0f);
        selfRotateAngle += selfRotateSpeed * Time.deltaTime;
    }
}
