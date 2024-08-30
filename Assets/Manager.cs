using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Color Bright = Color.gray;
    public Color MedBright = Color.gray;
    public Color MedDark = Color.gray;
    public Color Dark = Color.gray;
    public GameObject Lights;

    public GameObject Wall;

    public GameObject MN;
    public GameObject F1;
    public GameObject F2;
    public GameObject F3;
    public GameObject F4;
    public GameObject FT;

    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;
    public GameObject C6;
    public GameObject C7;
    public GameObject C8;

    public GameObject Fake1;
    public GameObject Fake2;
    public GameObject Fake3;
    public GameObject Taxess;
    public GameObject Spawnp;

    public bool F2Spawn = false;
    public bool F1Spawn = false;
    public bool F3Spawn = false;

    public GameObject SP1;
    public GameObject SP2;
    public GameObject SP3;
    public GameObject SP4;
    public GameObject SP5;

    public GameObject SP6;
    public GameObject SP7;
    public GameObject SP8;
    public GameObject SP9;
    public GameObject SP10;

    public GameObject Death1;
    public GameObject Death2;

    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;

    public float Lcount = 0;

    public bool die = false;

    public bool Tax = false;

    public float TC = 0;

    public bool RealTax = false;
    public float RealTC = 0;

    public float Fase = 0;
    public bool FaseOn = false;

    public bool FINAL = false;

    public float Cuts = 0;
    public bool CutsOn = false;

    public float Ctime = 0f;
    public float Stime = 7f;

    public float yang = 0;
    public float ying = 0;

    // Start is called before the first frame update
    void Start()
    {
        Stime = 13f;
        Ctime = Stime;
    }

    // Update is called once per frame
    void Update()
    {
        if (die) { StartCoroutine(Fin()); }
        if (FINAL) { StartCoroutine(Fin()); F3Spawn = false; }
        //Fases
        if (FaseOn)
        {
            switch (Fase)
            {
                case 1:
                    // Luzes
                    Lights.SetActive(true);
                    RenderSettings.ambientMode = AmbientMode.Flat;
                    RenderSettings.ambientLight = Bright;

                    F1.SetActive(true);


                    FaseOn = false;
                    break;
                case 2:
                    // Luzes
                    Lights.SetActive(true);
                    RenderSettings.ambientMode = AmbientMode.Flat;
                    RenderSettings.ambientLight = Bright;

                    F2.SetActive(true);

                    F2Spawn = true;


                    FaseOn = false;
                    break;
                case 3:

                    // Luzes
                    Lights.SetActive(true);
                    RenderSettings.ambientMode = AmbientMode.Flat;
                    RenderSettings.ambientLight = Bright;

                    F3.SetActive(true);
                    F1Spawn = true;

                    FaseOn = false;
                    break;
                case 4:

                    // Luzes
                    Lights.SetActive(true);
                    RenderSettings.ambientMode = AmbientMode.Flat;
                    RenderSettings.ambientLight = MedBright;

                    F4.SetActive(true);
                    Wall.SetActive(false);

                    F3Spawn = true;

                    FaseOn = false;
                    break;
                case 5:

                    // Luzes
                    Lights.SetActive(true);
                    RenderSettings.ambientMode = AmbientMode.Flat;
                    RenderSettings.ambientLight = MedBright;

                    FT.SetActive(true);
                    F2Spawn = true;

                    FaseOn = false;
                    break;

            }
        }

        //Spawner Paper

        int randomP = Random.Range(0, 4);

        if (Tax)
        {
            if (TC < 10)
            {
                switch (randomP)
                {
                    case 0:
                        Instantiate(Fake1, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 1:
                        Instantiate(Fake2, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 3:
                        Instantiate(Fake3, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 2:
                        Instantiate(Taxess, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                }
            }
            else { Tax = false; StartCoroutine(TFinal()); }
        }

        //Spawner REAL Paper

        int randomREAL = Random.Range(0, 4);

        if (Tax)
        {

                switch (randomREAL)
                {
                    case 0:
                        Instantiate(Fake1, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 1:
                        Instantiate(Fake2, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 2:
                        Instantiate(Fake3, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                    case 3:
                        Instantiate(Taxess, Spawnp.transform.position, transform.rotation);
                        Tax = false;
                        break;
                }
        }


        //Spawner yang

        int randomF = Random.Range(0, 5);

        if (yang == ying) { }
        else
        {
            l1.SetActive(false);
            l2.SetActive(false);
            l3.SetActive(false);
            l4.SetActive(false);
            l5.SetActive(false);
            switch (randomF)
            {
                case 1:
                    l1.SetActive(true);
                    ying++;
                    break;
                case 2:
                    l2.SetActive(true);
                    ying++;
                    break;
                case 3:
                    l3.SetActive(true);
                    ying++;
                    break;
                case 4:
                    l4.SetActive(true);
                    ying++;
                    break;
                case 0:
                    l5.SetActive(true);
                    ying++;
                    break;
            }
        }

        //Spawner bad2

        int randomB2 = Random.Range(0, 5);

        if (F2Spawn)
        {
            if (Ctime >= 0.01f)
            {
                Ctime -= 1 * Time.deltaTime;
            }
            if (Ctime < 0.1f)
            {

                switch (randomB2)
                {
                    case 1:
                        Instantiate(Death2, SP1.transform.position, transform.rotation);
                        if (Stime > 1) { Stime = Stime - 0.2f; }
                        Ctime = Stime;
                        break;
                    case 2:
                        if (Stime > 1) { Stime = Stime - 0.2f; }
                        Instantiate(Death2, SP2.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 3:
                        if (Stime > 1) { Stime = Stime - 0.2f; }
                        Instantiate(Death2, SP3.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 4:
                        if (Stime > 1) { Stime = Stime - 0.2f; }
                        Instantiate(Death2, SP4.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 0:
                        if (Stime > 1) { Stime = Stime - 0.2f; }
                        Instantiate(Death2, SP5.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                }
            }
        }

        //L

        if (Lcount < 10)
        {
            //Spawner bad1

            int randomB1 = Random.Range(0, 5);

            if (F1Spawn)
            {
                if (Ctime >= 0.01f)
                {
                    Ctime -= 1 * Time.deltaTime;
                }
                if (Ctime < 0.1f)
                {

                    switch (randomB1)
                    {
                        case 1:
                            Instantiate(Death1, SP1.transform.position, transform.rotation);
                            Ctime = Stime;
                            break;
                        case 2:
                            Instantiate(Death1, SP2.transform.position, transform.rotation);
                            Ctime = Stime;

                            break;
                        case 3:
                            Instantiate(Death1, SP3.transform.position, transform.rotation);
                            Ctime = Stime;

                            break;
                        case 4:
                            Instantiate(Death1, SP4.transform.position, transform.rotation);
                            Ctime = Stime;

                            break;
                        case 0:
                            Instantiate(Death1, SP5.transform.position, transform.rotation);
                            Ctime = Stime;

                            break;
                    }
                }
            }
        }
        else { StartCoroutine(LFinal()); }


        //Spawner bad3

        int randomK1 = Random.Range(0, 5);

        if (F3Spawn)
        {
            Stime = 10f;
            if (Ctime >= 0.01f)
            {
                Ctime -= 1 * Time.deltaTime;
            }
            if (Ctime < 0.1f)
            {

                switch (randomK1)
                {
                    case 1:
                        Instantiate(Death1, SP10.transform.position, transform.rotation);
                        Ctime = Stime;
                        break;
                    case 2:
                        Instantiate(Death1, SP6.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 3:
                        Instantiate(Death1, SP7.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 4:
                        Instantiate(Death1, SP8.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                    case 0:
                        Instantiate(Death1, SP9.transform.position, transform.rotation);
                        Ctime = Stime;

                        break;
                }
            }
        }

        //Cutouts

        if (CutsOn)
        {
            switch (Cuts)
            {
                case 1:

                    StartCoroutine(CC1());
                    CutsOn = false;
                    break;

                case 2:
                    StartCoroutine(CC2());
                    CutsOn = false;
                    break;
                case 3:
                    StartCoroutine(CC3());
                    CutsOn = false;
                    break;
                case 4:
                    StartCoroutine(CC4());
                    CutsOn = false;
                    break;
                case 5:
                    StartCoroutine(CC5());
                    CutsOn = false;
                    break;
                case 15:
                    StartCoroutine(CC6());
                    CutsOn = false;
                    break;
                case 16:
                    StartCoroutine(CC7());
                    CutsOn = false;
                    break;
                case 17:
                    StartCoroutine(CC8());
                    CutsOn = false;
                    break;

            }
        }
    }

    public IEnumerator CC1()
    {

        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C1.SetActive(false);
        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Bright;

        C2.SetActive(true);

    }
    public IEnumerator CC2()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C2.SetActive(false);
        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Bright;

        C3.SetActive(true);

    }

    public IEnumerator CC3()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C3.SetActive(false);
        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedBright;

        C4.SetActive(true);

    }

    public IEnumerator CC4()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C4.SetActive(false);

        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedBright;

        C5.SetActive(true);

    }

    public IEnumerator CC5()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C5.SetActive(false);
        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;

        C6.SetActive(true);

    }

    public IEnumerator CC6()
    {

        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C6.SetActive(false);

        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;

        C7.SetActive(true);

        yield return new WaitForSeconds(10f);

        CutsOn = true;
        Cuts = 16;

    }

    public IEnumerator CC7()
    {

        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C7.SetActive(false);

        yield return new WaitForSeconds(2f);
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        C8.SetActive(true);

    }

    public IEnumerator CC8()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        F1.SetActive(false);

        yield return new WaitForSeconds(5f);

        FaseOn = true;
        Fase = 2;
    }

    public IEnumerator TFinal()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        F2.SetActive(false);
        F2Spawn = false;

        yield return new WaitForSeconds(5f);

        FaseOn = true;
        Fase = 3;
    }

    public IEnumerator LFinal()
    {
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = MedDark;
        yield return new WaitForSeconds(0.5f);
        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        F3.SetActive(false);

        F1Spawn = false;

        yield return new WaitForSeconds(5f);

        FaseOn = true;
        Fase = 4;
    }


    public void Taxes1() { StartCoroutine(Taxes()); }
    public void Story1() { StartCoroutine(Story()); }
    public IEnumerator Story()
    {


        yield return new WaitForSeconds(1f);

        // Luzes
        Lights.SetActive(false);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        MN.SetActive(false);

        yield return new WaitForSeconds(5f);

        FaseOn = true;
        Fase = 1;



    }

    public IEnumerator Taxes()
    {



        yield return new WaitForSeconds(1f);

        // Luzes
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        MN.SetActive(false);

        yield return new WaitForSeconds(5f);

        FaseOn = true;
        Fase = 5;

    }
    public IEnumerator Fin()
    {
        // Luzes
        Lights.SetActive(true);
        RenderSettings.ambientMode = AmbientMode.Flat;
        RenderSettings.ambientLight = Dark;

        F1.SetActive(false);
        F2.SetActive(false);
        F3.SetActive(false);
        F4.SetActive(false);
        FT.SetActive(false);
        MN.SetActive(false);

        die = false;
        FINAL = false;

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
