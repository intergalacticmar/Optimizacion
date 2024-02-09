using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform gunPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1")) 
       {
          GameObject bullet = PoolManager.Instance.GetPooledObjects(gunPosition.position, gunPosition.rotation);
          
          if(bullet != null)
          {
            bullet.SetActive(true);
          }
          else
          {
            Debug.LogError("Pool demasiado pequeño");
          }
       }
    }
}
