using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFood : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public VariablesGlobal data;
    public int scoreAdd;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered");
        data.score += scoreAdd;
        Debug.Log(data.score);
        Destroy(this.gameObject);
    }


}
