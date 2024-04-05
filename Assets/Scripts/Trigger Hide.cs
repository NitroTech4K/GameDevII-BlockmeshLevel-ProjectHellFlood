using UnityEngine;

public class HideObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToHide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the tag of the object that triggers the event
        {
            if (objectToHide != null)
            {
                objectToHide.SetActive(false); // Hide the object
                gameObject.SetActive(false); // Deactivate the trigger
            }
        }
    }
}
