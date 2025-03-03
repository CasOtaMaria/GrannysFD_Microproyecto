using UnityEngine;

public class OpenShop : MonoBehaviour
{
    private GameObject shop;
    
    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Shop");
        shop.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            shop.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            shop.SetActive(false);
        }
    }
}
