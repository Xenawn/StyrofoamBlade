using UnityEngine;

public class Tutorial : MonoBehaviour
{
    int Level = 1;
    float HP = 3.14f;
    double MP = 5.5555;
    string NickName = "SuperMan";
    char Code = 'A';
    bool isAlive = true;
    void Start()
    {
        Debug.Log("GameStarted");
        Debug.Log($"Hello! My name si PNickname");
        Debug.Log($"MMy Hp is PHp, and My Mp is {MP}");
        Debug.Log($"Am i alive? {isAlive}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HP = HP - 20;
            if (HP > 0)
            {
                print($"Damaged !Current My Hp: {HP}");
            }
            else
            {
                isAlive = false;
                print($"Hp is less than 0, I'm dead...");
            }
        }
        if (HP > 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (HP >= 100f)
                {
                    HP = 100f;
                }
                HP = HP + 10f;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (MP <= 0) print("Mp is not enoggh to use skill");
                else
                {
                    MP = MP - 20;
                    print($"Cast Skill!! - Current MP: {MP}");
                }
            }
        }
        else
        {
            print("You Die");
        }
    }
}
