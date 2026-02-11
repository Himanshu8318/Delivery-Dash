using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField] float delay = 0.2f;
    [SerializeField] TMP_Text deliveryText;

    void Start()
    {
        deliveryText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up the package!!");
            hasPackage = true;
            deliveryText.gameObject.SetActive(false);
            Destroy(collision.gameObject, delay);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered the package!!");
            hasPackage = false;
            deliveryText.gameObject.SetActive(true);
        }
    }
}
