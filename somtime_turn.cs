public class Sometime_Turn : MonoBehaviour
{
    public float angle = 90;  //°¢µµ :Inspector ÁöÁ¤
    public int maxCount = 50;  //ºóµµ:Inspector ÁöÁ¤ 
    int count = 0;

    void Start()
    {   //처음
        count = 0;
    }

    void FixedUpdate()
    {
        count = count + 1;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}