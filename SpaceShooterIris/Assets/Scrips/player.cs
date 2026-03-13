using UnityEngine;

public class player : MonoBehaviour
{
    // set in inpector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions = new ();
        inputActions.Enables();
        inputACtions.Standard.Enable();


    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction.Standard.Fire.WasPressedThisFrame())
        {
            instanciate(bulletPrefab,bulletSpawnPoint.position,Quaternion.identity);
        }
        if (inputActions.Standard.MoveUp.isPressed())
        {
            this.transform.Translate(Vector3.up * speed);
        }
        else if ( inputActions.Standard.MoveDown.isPressed())
        {
            this.transform.Translate(Vector3.down * speed);
        }
        if (this.transform.position.y > Y_LIMIT)
        {
         this.transform.position = new Vector3(this.transform.position.x, Y_LIMIT);   
        }
        else if (this.transform.position.y < -Y_LIMIT)
        {
         this.transform.position = new Vector3(this.transform.position.x, -Y_LIMIT);   
        }
    }
}
