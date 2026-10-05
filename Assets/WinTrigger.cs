using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winpanel;
  private void OnTriggerEnter (Collider other)
    {
        winpanel.SetActive(true);
        Time.timeScale = 0f; 
    }
}
