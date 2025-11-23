using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float strafeForce = 2.0f;
    [SerializeField] private Rigidbody rig;

    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        rig.AddForce(transform.right * input * strafeForce);
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Tree"))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}
