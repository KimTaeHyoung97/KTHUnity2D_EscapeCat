using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrafab;
    //public GameObject arrowPrafabDown;
    //public GameObject arrowPrafabLeft;
    //public GameObject arrowPrafabRight;


    const float span = 1f;//생성시간
    float delta = 0f; // 델타타임과 중첩하여 사용하기위해서

    enum Dir { Up,Down,Left,Right}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//일정주기만큼 반복
        delta += Time.deltaTime;//이전 프레임에서 지금 프레임까지의 시간을 더해준다
        if (delta > span)
        {
            delta = 0f;//초기화
            //위에서 아래로 화살표 이동
            //GameObject go = Instantiate(arrowPrafab);
            //int px = Random.Range(-7, 8);
            //go.transform.position = new Vector3(px, 5.2f, 0);

            ////아래에서 위로 화살표 이동
            //GameObject go2 = Instantiate(arrowPrafab);
            //go2.transform.Rotate(0, 0, 180f);
            //int px2 = Random.Range(-7, 8);
            //go2.transform.position = new Vector3(px2, -5.2f, 0);

            ////왼쪽에서 오른쪽로 화살표 이동
            //GameObject go3 = Instantiate(arrowPrafab);
            //go3.transform.Rotate(0, 0, 90f);
            //int py = Random.Range(-4, 5);
            //go3.transform.position = new Vector3(-9.8f, py, 0);

            ////오른쪽에서 왼쪽로 화살표 이동
            //GameObject go4 = Instantiate(arrowPrafab);
            //go4.transform.Rotate(0, 0, 270f);
            //int py2 = Random.Range(-4, 5);
            //go4.transform.position = new Vector3(9.8f, py2, 0);

            GameObject go = Instantiate(arrowPrafab);
            Dir r = (Dir)Random.Range(0, 4);
            switch(r)
            {
                case Dir.Up:
                    go.transform.position = new Vector3(Random.Range(-9f, 9f), 7f, 0);
                    break;
                case Dir.Down:
                    go.transform.position = new Vector3(Random.Range(-9f, 9f), -7f, 0);
                    go.transform.Rotate(0, 0, 180f);
                    break;
                case Dir.Left:
                    go.transform.position = new Vector3(-11f,Random.Range(-5f, 5f), 0);
                    go.transform.Rotate(0, 0, 90f);
                    break;
                case Dir.Right:
                    go.transform.position = new Vector3(-11f, Random.Range(-5f, 5f), 0);
                    go.transform.Rotate(0, 0, -90f);
                    break;
                default:
                    break;
            }
        }
        
    }
}
