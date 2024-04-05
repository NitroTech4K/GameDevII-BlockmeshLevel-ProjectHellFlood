using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject objectToUnhide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the tag of the object that triggers the event
        {
            if (objectToUnhide != null)
            {
                objectToUnhide.SetActive(true); // Unhide the object
                gameObject.SetActive(false); // Deactivate the trigger
            }
        }
    }
}
