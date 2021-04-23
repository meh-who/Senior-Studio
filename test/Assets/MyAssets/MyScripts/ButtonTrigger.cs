
using UnityEngine;
using UnityEngine.Events;


public static class ColliderExtensions
{
    public static bool IsTriggerButton(this Collider col)
    {
        return col.tag == "ButtonActivator";
    }
}


[RequireComponent(typeof(Collider))]
public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onButtonPressed;

    private bool pressedInProgress = false;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.IsTriggerButton() && !pressedInProgress)
        {
            pressedInProgress = true;
            onButtonPressed?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.IsTriggerButton())
        {
            pressedInProgress = false;
        }
    }
}
