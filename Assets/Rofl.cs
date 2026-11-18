
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class Rofl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject camera;
    public GameObject pipePrefab;
    public XRInputModalityManager modalityManager;
    public InputActionReference triggerAction;
    void OnEnable()
    {
        triggerAction.action.performed += OnButtonPressed;
    }
    void OnButtonPressed(InputAction.CallbackContext ctx)
    {
        Debug.Log("Trigger pressed");
        GameObject pipe = Instantiate(pipePrefab, camera.transform.position + camera.transform.forward * 3, Quaternion.identity);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
