using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    Manager cManager;
    public GameObject CManager;

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
            case "Evil":
                cManager.die = true;

                break;
            case "Line":
                StartCoroutine(Swait());

                break;
            case "Lever":
                cManager.FINAL = true;

                break;
        }
    }

    public IEnumerator Swait()
    {



        yield return new WaitForSeconds(5f);
        cManager.Lcount++; cManager.yang++;


    }
}