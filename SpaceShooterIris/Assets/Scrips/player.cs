using UnityEngine;

public class player : MonoBehaviour {
    private SpaceShooter inputActions;
    public float speed = 0.1f;
    //private const float Y_LIMIT = 4.52f;

    // set in inpector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        inputActions = new();
        inputActions.Enable();
        inputActions.Standard.Enable();


    }

    // Update is called once per frame
    private void Update()
{
        // if (inputActions.Standard.Fire.WasPressedThisFrame())
        // {
        //     Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        // }
        if (inputActions.Standard.MoveUp.IsPressed())
        {
            this.transform.Translate(Vector3.up * speed);
        }
        else if ( inputActions.Standard.MoveDown.IsPressed())
        {
            this.transform.Translate(Vector3.down * speed);
        }
        if (this.transform.position.y > 4.52f)
        {
         this.transform.position = new Vector3(this.transform.position.x, 4.52f);   
        }
        else if (this.transform.position.y < -4.67f)
        {
         this.transform.position = new Vector3(this.transform.position.x, -4.67f);
        }
    }
}
