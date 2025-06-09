using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 25.5f;
    public string inputID;
    private float hprizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Separate view in two players

    // TODO ADD input for change camera view

    // Update is called once per frame
    void Update()
    {
        hprizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * hprizontalInput );
    }
}
