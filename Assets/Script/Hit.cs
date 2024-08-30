using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Manager cManager;
    public GameObject CManager;

    public bool Good;

    // Start is called before the first frame update
    void Start()
    {
        cManager = CManager.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "Bull":

                if (Good == false) { cManager.Cuts++; cManager.CutsOn = true; Destroy(col); }

                else { }
                break;
        }
    }
}
