using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;
    public GameObject pathtodisappear;
    void OnTriggerEnter(Collider other)
    {
      if (pathToAppear) pathToAppear.SetActive(true);
      if (pathtodisappear) pathtodisappear.SetActive(false);
        Destroy(gameObject);
    }

}
