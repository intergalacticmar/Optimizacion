using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform gunPosition;
    [SerializeField] GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1")) 
       {
        Instantiate(bulletPrefab, gunPosition.position, gunPosition.rotation);
       }
    }
}
