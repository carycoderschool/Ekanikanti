using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody myRB;

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horMove, 0, verMove);

        myRB.AddForce(move * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.root.tag == "Pick Up")
        {
            Destroy(other.gameObject);
            gameManager.numPickedUp += 1;
        }
    }
}
