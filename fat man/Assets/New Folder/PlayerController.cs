using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public float moveSpeed;
    public float jumpHight;
    public bool grounded;
    string[] fruitsNames = new string[5] { "Apple", "Grapes", "Banana", "Cupcake", "Slice" };
    public GameObject[] fuits = new GameObject[5];
    float[] weight = new float[5] { 10f, 20f, 15f, -10f, -5f };
    Vector2[] positions = new Vector2[9] {

    new Vector2(-3,5),
    new Vector2(3,4),
    new Vector2(-1,0),
    new Vector2(-2,1),
    new Vector2(1,3),
    new Vector2(-2,1),
    new Vector2(2,5),
    new Vector2(0,1),
    new Vector2(0,2)
    };



    // Use this for initialization
    void Start () {
        for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(fuits[Random.Range(0,5)], positions[i], Quaternion.Euler(0, 0, 0));
        }





    }

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < 5; i++)
        {
            if (other.gameObject.tag == fruitsNames[i])
            {
                other.gameObject.SetActive(false);
                jumpHight += weight[i];
            }
        }

        
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
            grounded = true;


    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
            grounded = false;
        

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHight);

        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity. y);


    }
}
