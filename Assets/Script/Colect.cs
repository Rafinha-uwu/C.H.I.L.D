using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colect : MonoBehaviour
{
    Manager cManager;
    public GameObject CManager;

    public bool Trash;

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
        if (cManager.Fase == 5)
        {

            switch (col.gameObject.tag)
            {
                case "Fake":

                    if (Trash) { cManager.RealTax = true; cManager.RealTC++; Destroy(col); }

                    break;
                case "Taxes":

                    if (Trash == false) { cManager.RealTax = true; cManager.RealTC++; Destroy(col); }

                    break;
            }
        }
        else
        {
            switch (col.gameObject.tag)
            {
                case "Fake":

                    if (Trash) { cManager.Tax = true; cManager.TC++; Destroy(col); }

                    break;
                case "Taxes":

                    if (Trash == false) { cManager.Tax = true; cManager.TC++; Destroy(col); }

                    break;
            }
        }
    }
}