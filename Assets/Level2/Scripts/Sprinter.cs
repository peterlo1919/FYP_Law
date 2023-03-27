using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinter : MonoBehaviour
{
    float stamina =1, maxStamina = 1;
    float walkSpeed, runSpeed;
    Playmove cm;
    bool isRunnig;

    Rect staminaRect;
    Texture2D staminaTexture;

    // Start is called before the first frame update
    void Start()
    {
        cm = gameObject.GetComponent<Playmove>();
        walkSpeed = cm.Speed;
        runSpeed = walkSpeed * 2;

        staminaRect = new Rect(Screen.width/10,Screen.height*9/10,Screen.width / 3, Screen.height / 50);
        staminaTexture = new Texture2D(1,1);
        staminaTexture.SetPixel(0,0,Color.white);
        staminaTexture.Apply();
    }

    void SetRunning(bool isRunnig)
    {
        this.isRunnig = isRunnig;
        cm.Speed = isRunnig ? runSpeed : walkSpeed;
    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.LeftShift))
            SetRunning(true);
        if(Input.GetKeyUp(KeyCode.LeftShift))
            SetRunning(false);

        if(isRunnig)
        {
            stamina -= Time.deltaTime;
            if(stamina < 0)
            {
                stamina = 0;
                SetRunning(false);
            }
        }else if (stamina < maxStamina)
        {
            stamina += Time.deltaTime;
        }

    }

    void OnGUI()
    {
        float ratio = stamina / maxStamina;
        float rectWidth = ratio * Screen.width / 3;
        staminaRect.width = rectWidth;
        GUI.DrawTexture(staminaRect, staminaTexture);
    }

}
