using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Checkpoint : MonoBehaviour
{
    public Material Activate; 
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material = Activate;
        FindFirstObjectByType<BallRoll>().UpdateCheckpoint();
    }
}
