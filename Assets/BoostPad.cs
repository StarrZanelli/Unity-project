using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float boostForce = 30f;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.forward * boostForce);
    }
}
