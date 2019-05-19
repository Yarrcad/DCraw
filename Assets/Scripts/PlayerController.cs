using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static float speed;

    public bool dead;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public GameObject gameOverScreen;

    private Vector2 touchOrigin = - Vector2.one;
    private int horizontal;
    private int vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    #if UNITY_EDITOR || UNITY_STANDALONE || UNITYWEBPLAYER
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

#elif UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
            
            if (Input.touchCount > 0)
            {
                Touch myTouch = Input.touches[0];
                
                if (myTouch.phase == TouchPhase.Began)
                {
                    touchOrigin = myTouch.position;
                }
                else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
                {
                    Vector2 touchEnd = myTouch.position;
                    float x = touchEnd.x - touchOrigin.x;
                    float y = touchEnd.y - touchOrigin.y;
                    
                    touchOrigin.x = -1;
                    
                    if (Mathf.Abs(x) > Mathf.Abs(y))
                        horizontal = x > 0 ? 1 : -1;
                    else
                        vertical = y > 0 ? 1 : -1;
                }
            }
#endif
        if (horizontal != 0 || vertical != 0)
        {
            moveVelocity = new Vector2(horizontal, vertical).normalized * speed;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


    void OnDisable()
    {
        dead = true;

        gameOverScreen.SetActive(true);

    }



}