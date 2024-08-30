using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{


    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "Bull":
                StartCoroutine(die());
                break;
        }
    }

    public IEnumerator die()
    {
        this.transform.GetComponent<Animator>().Play("Dead");
        yield return new WaitForSeconds(1f);

        Destroy(this.gameObject);

    }
}