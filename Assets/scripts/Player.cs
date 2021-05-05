using UnityEngine;

public class Player : MonoBehaviour
{

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sideForce = 500;
    // Start is called before the first frame update
    void Start()
    {

		Debug.Log("hello");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
        	rb.AddForce(sideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
        	rb.AddForce(-sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
