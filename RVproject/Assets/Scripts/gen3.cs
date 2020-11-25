using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class gen3 : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefabMov1;
    public GameObject ballPrefabMov1b;
    public GameObject ballPrefabMov2;
    public GameObject ballPrefabMov2b;
    public GameObject ballPrefabMov3;
    public GameObject ballPrefabMov3b;
    public GameObject ballPrefabMov4;
    public GameObject ballPrefabMov4b;
    public GameObject ballPrefabMov5;
    public int nrStillBalls;
    public int nrMov1Balls;
    public int nrMov1bBalls;
    public int nrMov2Balls;
    public int nrMov2bBalls;
    public int nrMov3Balls;
    public int nrMov3bBalls;
    public int nrMov4Balls;
    public int nrMov4bBalls;
    public int nrMov5Balls;

    float speed = 6.0f;


    // 150 balls, use prints of randoms or more
    List<float> x_values = new List<float>() { -1, 668435, -2, 585354, -4, 556217, -4, 303343, 2, 056542, 3, 116492, -2, 44553, -1, 507278, -3, 488109, 1, 747576, 2, 607535, 2, 13268, -4, 243125, 0, 7047467, -1, 261317, 2, 252217, 1, 109026, 1, 856555, -3, 471379, 1, 170792, -0, 4834528, -4, 440621, 3, 909179, 2, 631252, 4, 961289, -3, 597923, -2, 182148, 4, 455318, 3, 3216, -0, 8836727, 2, 283102, -4, 826045, -0, 634666, 2, 114497, 3, 07901, -1, 551028, -4, 112191, 1, 656323, 3, 347337, 3, 152032, -3, 685746, -2, 856388, 0, 5793552, 3, 418237, 3, 291624, -1, 455093, 4, 843736, -1, 021699, -0, 4710979, 2, 476466, 3, 367579, 0, 8320899, 0, 2340097, -3, 741723, -4, 810974, -2, 238402, 3, 021646, -4, 928718, -1, 439765, 1, 283473, 0, 6520314, -4, 858635, 3, 534464, 0, 2906065, 1, 220626, 2, 089317, 0, 5895262, 4, 995094, -3, 177281, 3, 398418, 0, 411902, 4, 98293, 4, 231817, -4, 499988, -0, 05883884, -4, 102594, -0, 2888541, -0, 8697348, 3, 127409, -4, 468508, 1, 811787, 0, 7379942, 4, 075985, -0, 6399827, -0, 9495144, -1, 778562, -0, 6924458, 0, 4954367, -4, 507493, -1, 727326, -3, 140681, 2, 403085, -2, 382764, 0, 7204061, 1, 208237, 2, 37682, 2, 117716, -2, 82347, 4, 50626, 1, 035698, 4, 322048, -0, 8026962, 4, 508913, -2, 638085, -2, 855572, 1, 372242, -1, 772666, -4, 814884, -4, 447283, 3, 098522, 3, 372765, 0, 5881162, -3, 414746, -0, 2850194, -2, 620025, -1, 167233, 0, 3925819, 1, 567255, 4, 25888, -0, 5427318, -3, 431641, -0, 9857268, 3, 00149, 3, 508203, 1, 7512, 0, 9818788, 3, 140133, 1, 167571, 2, 452274, 4, 202451, -1, 701861, -1, 776248, 4, 416002, 4, 321144, -3, 983917, 3, 280706, -4, 437803, -3, 990391, -3, 473826, 3, 576889, -4, 687129, -3, 68364, -2, 656006, 3, 558198, -1, 767636, -0, 8004885, -4, 241401, -4, 726377, -3, 74083, -3, 552975 };
    List<float> y_values = new List<float>() { 1, 301664, -0, 7232463, 1, 657177, 2, 955777, 1, 566546, 0, 8799683, 1, 299759, 3, 688194, 2, 3121, 1, 732349, 3, 634373, 0, 4440113, 1, 500815, 2, 229856, -1, 290571, 2, 881601, -1, 667638, 1, 905514, 1, 864307, 1, 0962, -1, 269932, 2, 557269, -1, 33713, 2, 610664, -1, 479307, 0, 6088306, 3, 788974, -1, 604625, 3, 213755, 2, 539651, 3, 258298, 2, 627956, 1, 031927, -0, 4149708, 1, 722305, -0, 8260422, 3, 966962, 3, 269682, 3, 491211, 1, 787815, 3, 983174, -1, 284245, 1, 82456, 0, 6386746, 0, 6754624, 0, 0598489, -0, 8806312, 1, 028895, -0, 568749, 2, 32512, 0, 2721447, 3, 062519, 2, 972524, -0, 2321957, 3, 476672, -1, 867207, -0, 1604635, 3, 996334, 0, 9542025, 1, 781086, -0, 3149272, 2, 26773, -0, 6948664, -1, 983593, 3, 612832, -1, 485851, -0, 7958312, 0, 2684118, 2, 563304, 0, 2729272, -0, 1094822, 2, 980141, 0, 2415088, 0, 5737916, -0, 7132285, 1, 494503, -1, 755708, -1, 854167, 1, 697819, 2, 646803, 0, 07825029, 3, 035722, 1, 774587, 2, 195666, 3, 94832, 2, 243608, -0, 7649758, 2, 789205, 3, 645276, 3, 883714, 3, 842156, 1, 82265, 1, 8631, 2, 117658, 0, 6140026, -1, 167957, 0, 8893417, 1, 182549, -1, 414779, 2, 687954, 0, 6896037, 0, 0337342, -1, 967478, -0, 09328735, 2, 017257, -1, 928803, -0, 08346832, 2, 356991, -0, 241253, 3, 39212, -0, 8612671, 2, 049412, -1, 712234, 2, 272092, -1, 261749, 1, 933694, -1, 301736, 0, 1635617, 0, 8406843, 1, 611869, 0, 7084278, 3, 762994, 0, 5722696, -1, 103582, -0, 8654706, 0, 6610571, 1, 923525, 1, 70487, -1, 887542, 2, 548272, -1, 419904, 1, 624823, -1, 631834, 0, 1470493, -1, 322667, 0, 388986, 2, 381476, 1, 207129, -1, 772855, 3, 328806, -1, 129746, 0, 506617, -0, 1457056, 2, 755398, 3, 808671, -0, 5594206, -1, 297816, -1, 735992, -1, 09552, 2, 55019 };
    List<float> z_values = new List<float>() { 7, 062703, 7, 166088, 4, 181859, 7, 757518, 6, 796039, 6, 077807, 5, 219463, 8, 824245, 8, 544887, 5, 843788, 8, 609962, 6, 227383, 9, 215076, 4, 810775, 9, 326156, 9, 834805, 4, 823364, 7, 553266, 9, 981312, 4, 728744, 7, 1014, 9, 954927, 4, 221544, 6, 11334, 7, 594429, 9, 27821, 7, 716072, 9, 322721, 4, 470002, 5, 885586, 9, 367522, 9, 863267, 5, 606012, 7, 171397, 4, 041203, 6, 931321, 9, 629352, 7, 005275, 8, 620046, 6, 604246, 7, 512117, 9, 648326, 7, 222155, 6, 071518, 6, 264216, 7, 559865, 8, 430346, 7, 281367, 5, 817132, 6, 287437, 6, 955544, 7, 446085, 9, 986871, 9, 773526, 9, 597348, 5, 977961, 7, 915138, 9, 908688, 7, 473136, 6, 538768, 7, 838933, 6, 281688, 4, 993316, 8, 480837, 8, 424631, 4, 517394, 6, 760009, 9, 750327, 5, 93608, 6, 405537, 6, 709508, 4, 520669, 4, 037515, 6, 136742, 9, 004385, 9, 911765, 9, 446243, 7, 482416, 4, 871197, 7, 850852, 7, 678609, 7, 68395, 7, 442811, 5, 254651, 6, 077158, 9, 022939, 4, 099628, 6, 447923, 7, 280118, 6, 938876, 8, 695588, 8, 167598, 8, 371729, 8, 117905, 8, 6088, 6, 326475, 6, 386506, 8, 01634, 9, 921042, 4, 381279, 5, 96085, 4, 875809, 6, 31182, 4, 98153, 8, 025184, 9, 242486, 4, 325798, 6, 564802, 7, 136231, 6, 450169, 8, 131866, 9, 484186, 4, 684518, 5, 20215, 6, 215904, 5, 128973, 8, 179371, 8, 301902, 4, 884529, 4, 986336, 8, 198291, 6, 073623, 5, 753026, 4, 702766, 8, 025056, 5, 360391, 8, 603231, 7, 211887, 9, 618155, 9, 303708, 5, 814936, 4, 042196, 9, 531726, 8, 463659, 4, 091277, 9, 09501, 5, 120883, 4, 84732, 9, 750224, 6, 747503, 4, 267087, 4, 024764, 6, 918239, 4, 535968, 6, 812589, 6, 617634, 8, 217261, 9, 410429, 4, 599779, 5, 631126 };



    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        int nrBalls = nrStillBalls;
        for (; i < nrBalls; i++)
        {
            /*float x = UnityEngine.Random.Range(-5f, 5f);
            x_values.Add(x);
            float y = UnityEngine.Random.Range(-2f, 4f);
            y_values.Add(y);
            float z = UnityEngine.Random.Range(4f, 10f);
            z_values.Add(z);*/

            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
        /*Debug.Log(String.Join(",", new List<float>(x_values).ConvertAll(i => i.ToString()).ToArray()));
        Debug.Log(String.Join(",", new List<float>(y_values).ConvertAll(i => i.ToString()).ToArray()));
        Debug.Log(String.Join(",", new List<float>(z_values).ConvertAll(i => i.ToString()).ToArray()));*/

        nrBalls += nrMov1Balls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov1.GetComponent<Mov1>().setSpeed(speed);
            Instantiate(ballPrefabMov1, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov1bBalls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov1b.GetComponent<Mov1b>().setSpeed(speed);
            Instantiate(ballPrefabMov1b, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov2Balls;
        for (; i < nrBalls; i++)
        {

            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov2.GetComponent<Mov2>().setSpeed(speed);
            Instantiate(ballPrefabMov2, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov2bBalls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov2b.GetComponent<Mov2b>().setSpeed(speed);
            Instantiate(ballPrefabMov2b, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov3Balls;
        for (; i < nrMov3Balls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov3.GetComponent<Mov3>().setSpeed(speed);
            Instantiate(ballPrefabMov3, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov3bBalls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov3b.GetComponent<Mov3b>().setSpeed(speed);
            Instantiate(ballPrefabMov3b, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov4Balls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov4.GetComponent<Mov4>().setSpeed(speed);
            Instantiate(ballPrefabMov4, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov4bBalls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            ballPrefabMov4b.GetComponent<Mov4b>().setSpeed(speed);
            Instantiate(ballPrefabMov4b, new Vector3(x, y, z), Quaternion.identity);
        }
        nrBalls += nrMov5Balls;
        for (; i < nrBalls; i++)
        {
            float x = x_values[i];
            float y = y_values[i];
            float z = z_values[i];
            Instantiate(ballPrefabMov5, new Vector3(x, y, z), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}