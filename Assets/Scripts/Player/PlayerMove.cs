using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float character_speed = 7;
    public float left_right_speed = 4;
    public float updown_speed = 4;
    public bool jumping = false;
    public bool up = true;
    static public bool canMove = false;
    public GameObject Player;

    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime*character_speed, Space.World);
        if (canMove == true) {
            if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)){
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide){
                    transform.Translate(Vector3.left *Time.deltaTime*left_right_speed);
                    }
            }
                if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)){
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide){
                    transform.Translate(Vector3.right *Time.deltaTime*left_right_speed);
                    }
            }

                if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.Space)){
                    if (!jumping){
                        jumping = true;
                        Player.GetComponent<Animator>().Play("Jump");
                        StartCoroutine(JumpSequence());
                        }

                }

        }
        if (jumping){
            if (up){
                transform.Translate(Vector3.up *Time.deltaTime*updown_speed, Space.World);
                   }
            
            else {
                transform.Translate(Vector3.down *Time.deltaTime*updown_speed, Space.World);
                 }
        }
    }
    IEnumerator JumpSequence(){
        yield return new WaitForSeconds(0.35f);
        up = false;
        yield return new WaitForSeconds(0.35f);
        jumping = false;
        up = true;
        Player.GetComponent<Animator>().Play("Standard Run");
        }
}
