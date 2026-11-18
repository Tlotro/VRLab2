using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Lol : MonoBehaviour
{
    public AudioSource audioSource;
    public XRGrabInteractable Interactable;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        if (Interactable != null)
        {
            // Subscribe to the activated event
            Interactable.activated.AddListener(OnActivated);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnActivated(ActivateEventArgs args)
    {
        var interactor = Interactable.firstInteractorSelecting;
        if (interactor != null)
        {
            Interactable.interactionManager.SelectExit(interactor, Interactable);
            rb.AddForce(interactor.transform.forward*10,ForceMode.VelocityChange);
        }
    }
}
