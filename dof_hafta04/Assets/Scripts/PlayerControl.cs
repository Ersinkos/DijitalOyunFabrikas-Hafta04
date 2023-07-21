using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    Vector3 playerInput;
    Vector3 move;
    RaycastHit hit;
    public GameObject barrel;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = playerInput * Time.deltaTime * speed;
        transform.Translate(move);

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(barrel.transform.position, transform.forward, out hit, Mathf.Infinity))
            {

                if (hit.collider.gameObject.tag == "Dusman")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
