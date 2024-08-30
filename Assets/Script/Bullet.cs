using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dest", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Dest()
    {
        Destroy(this.gameObject);
    }


}
