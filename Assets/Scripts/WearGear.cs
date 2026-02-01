using UnityEngine;

public class WearGear : MonoBehaviour
{
    public static int wornCount = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Gear") && Input.GetKeyDown(KeyCode.E))
        {
            other.gameObject.SetActive(false);
            wornCount++;
        }
    }
}

