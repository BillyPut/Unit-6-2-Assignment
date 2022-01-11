using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;

public class Helper : MonoBehaviour
{



    public static void FlipSprite(GameObject obj, int dir)
    {
        if (dir == Left)
        {
            obj.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            obj.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


    }



    public static int GetObjectDir(GameObject obj)
    {
        float ang = obj.transform.eulerAngles.y;
        if (ang == 180)
        {
            return Left;
        }
        else
        {
            return Right;
        }
    }



    public static void SetVelocity(float xvelo, float yvelo, GameObject obj)
    {
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(xvelo, yvelo, 0);
    }


    public static bool DoRayCollisionCheck(GameObject obj)
    {
        float rayLength = 1.0f;
        float x = obj.transform.position.x;
        float y = obj.transform.position.y - 0.5f;

        //cast a ray downward of length 1
        RaycastHit2D hit = Physics2D.Raycast(new Vector3(x, y, obj.transform.position.z), -Vector2.up, rayLength);

        Color hitColor = Color.white;


        if (hit.collider != null)
        {


            if (hit.collider.tag == "Platforms")
            {

                hitColor = Color.green;
                return true;

            }

        }

        Debug.DrawRay(new Vector3(x, y, obj.transform.position.z), -Vector2.up * rayLength, hitColor);
        return false;

    }


}
