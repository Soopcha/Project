using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField] KeyCode MovingForward;
    [SerializeField] KeyCode MovingBack;
    [SerializeField] KeyCode MovingRight;
    [SerializeField] KeyCode MovingLeft;
    [SerializeField] Vector3 MovingDirectionForwardBack;
    [SerializeField] Vector3 MovingDirectionRightLeft;

    private void FixedUpdate()
    {
        if (UnityEngine.Input.GetKey(MovingForward))
        {
            GetComponent<Rigidbody>().velocity -= MovingDirectionForwardBack;
        }
        if (UnityEngine.Input.GetKey(MovingBack))
        {
            GetComponent<Rigidbody>().velocity += MovingDirectionForwardBack;
        }
        if (UnityEngine.Input.GetKey(MovingRight))
        {
            GetComponent<Rigidbody>().velocity += MovingDirectionRightLeft;
        }
        if (UnityEngine.Input.GetKey(MovingLeft))
        {
            GetComponent<Rigidbody>().velocity -= MovingDirectionRightLeft;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
