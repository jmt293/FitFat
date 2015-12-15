using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


   

    private bool doubleJump;
    string Name = "bob";
    private Rigidbody rb;
    public float speed = 50;
    public Text weight;
    public float jumpHigh = 200;
    

    string[] Myfruits = new string[19] { "Apple Green", "Apple Red", "Banana", "Coconut", "Kiwi", "Lemon", "Lime", "Orange", "Pear", "Pineapple", "Plum", "Pomegranate",
                "Strawberry", "Tomato", "Watermelon", "Honeydew Melon", "Pepper Green", "Pepper Red", "Pepper Yellow" };

    public GameObject test;
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
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        string Myfruit = Myfruits[Random.Range(0, (Myfruits.Length))];

        for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(test, positions[i], Quaternion.Euler(0, 0, 0));
        }


    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpHigh);

           


           


        }
    }


        void OnTriggerEnter(Collider other) 
	{
            if (other.gameObject.tag == "Pick Up")
            {
                other.gameObject.SetActive(false);
            jumpHigh -= 100;
             }
           if (other.gameObject.tag == "Apple")
           {
            other.gameObject.SetActive(false);
            jumpHigh += 100;
           }

          if (other.gameObject.tag == "Orange")
          {
            other.gameObject.SetActive(false);
            jumpHigh += 200;
          }
           if (other.gameObject.tag == "Watermelon")
          {
            other.gameObject.SetActive(false);
            jumpHigh += 200;
          }
           if (other.gameObject.tag == "Peach")
          {
            other.gameObject.SetActive(false);
            jumpHigh += 200;
            if (other.gameObject.tag == "Pineapple")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Strawberry")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Banana")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Coconut")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Kiwi")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Lemon")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Lime")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Pear")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Plum")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Pomegranate")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Tomato")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Honeydew Melon")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Pepper Green")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == "Pepper Red")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == " Pepper Yellow ")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }
            if (other.gameObject.tag == " Pepper Pointed ")
            {
                other.gameObject.SetActive(false);
                jumpHigh += 200;
            }







        }


    }
    }