using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Dispara : MonoBehaviour
{
    [Range(0,1)]
    public float intensity;
    public float duration;

    public GameObject projetil;

    public GameObject prec;

    public void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(TriggerHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if(eventArgs.interactableObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if (intensity > 0)
            controller.SendHapticImpulse(intensity, duration);
    }
    public void OnDispara()
    {
        GameObject ProjR = Instantiate(prec);

        ProjR.transform.SetParent(this.transform);
        ProjR.transform.localPosition = new Vector3(-0.182f, 0, -0.056f);
        ProjR.transform.rotation = this.transform.rotation;
        ProjR.transform.SetParent(null);

        ProjR.GetComponent<Rigidbody>().velocity = ProjR.transform.right *5;

        GameObject ProjTemp = Instantiate(projetil);

        ProjTemp.transform.SetParent(this.transform);
        ProjTemp.transform.localPosition = new Vector3(-0.182f, 0, -0.056f);
        ProjTemp.transform.rotation = this.transform.rotation;
        ProjTemp.transform.SetParent(null);

        ProjTemp.GetComponent<Rigidbody>().velocity = ProjTemp.transform.right * -10;
    }
}

