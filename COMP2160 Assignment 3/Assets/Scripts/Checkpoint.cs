using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Material checkpointInactive;
    public Material checkpointActive;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Car") && gameObject.CompareTag("Checkpoint 1"))
        {
            GameObject.FindWithTag("Checkpoint 1").gameObject.GetComponent<MeshRenderer>().material = checkpointInactive;
            GameObject.FindWithTag("Checkpoint 2").gameObject.GetComponent<MeshRenderer>().material = checkpointActive;
        }
        if (other.gameObject.CompareTag("Car") && gameObject.CompareTag("Checkpoint 2"))
        {
            GameObject.FindWithTag("Checkpoint 2").gameObject.GetComponent<MeshRenderer>().material = checkpointInactive;
            GameObject.FindWithTag("Checkpoint 3").gameObject.GetComponent<MeshRenderer>().material = checkpointActive;
        }
        if (other.gameObject.CompareTag("Car") && gameObject.CompareTag("Checkpoint 3"))
        {
            GameObject.FindWithTag("Checkpoint 3").gameObject.GetComponent<MeshRenderer>().material = checkpointInactive;
            GameObject.FindWithTag("Checkpoint 4").gameObject.GetComponent<MeshRenderer>().material = checkpointActive;
        }
        if (other.gameObject.CompareTag("Car") && gameObject.CompareTag("Checkpoint 4"))
        {
            GameObject.FindWithTag("Checkpoint 4").gameObject.GetComponent<MeshRenderer>().material = checkpointInactive;
            GameObject.FindWithTag("Checkpoint 5").gameObject.GetComponent<MeshRenderer>().material = checkpointActive;
        }
        if (other.gameObject.CompareTag("Car") && gameObject.CompareTag("Checkpoint 5"))
        {
            GameObject.FindWithTag("Checkpoint 5").gameObject.GetComponent<MeshRenderer>().material = checkpointInactive;
        }

    }
}
