using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class login_system : MonoBehaviour
{
    public List<User> userList = new List<User>();

    [Header("Auto Save in seconds")]
    public int auto_save_time = 60;

    public static User currentUser = null;
    void Start()
    {
        
        loadUserList();
        StartCoroutine("save");
    }

    void Update()
    {
        //timer
        //auto save 
        
    }
    //return true on successfull login
    //return false on fail login
    public bool login(string email, string password)
    {
        if (userList.Count > 0)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if(userList[i].email.Equals(email) && userList[i].check_password(password))
                {
                    currentUser = userList[i];
                    Debug.Log("User " + email + " successfully login!");
                    return true;
                }
            }
            Debug.LogWarning("User " + email + " fail to login!");
            return false;
        }
        else
        {
            Debug.LogWarning("Can't login, 0 users found!");
            return false;
        }
    }
    public void logout()
    {
        currentUser = null;
    }
    //true - email is free
    //false - email is in use
    public bool checkEmail(string email)
    {
        if (userList.Count > 0)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].email.Equals(email))
                {
                    Debug.LogError("User with email: " + email + " already exists!");
                    return false;
                }
            }
            return true;
        }
        else
        {
            return true;
        }
    }
    void loadUserList()
    {
        List<User> newUserList = new List<User>();

        if(File.Exists("userList.dat"))
        {
            using (Stream stream = File.Open("userList.dat", FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();

                newUserList = (List<User>)bformatter.Deserialize(stream);

                User admin = new User("admin", "admin", "admin", 0, User.Gender.none);
                admin.set_password("admin");
                userList.Add(admin);

                for (int i = 0; i < newUserList.Count; i++)
                {
                    if (newUserList[i].email != "admin")
                    {
                        userList.Add(newUserList[i]);
                    }
                }
            }
        }
        else
        {
            User admin = new User("admin", "admin", "admin", 0, User.Gender.none);
            admin.set_password("admin");
            userList.Add(admin);
        }
    }
    public void saveUserList()
    {
        Debug.Log("Saving data...");
        FileStream fs = new FileStream("userList.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, userList);
        fs.Close();
        Debug.Log("Data successfully saved!");
    }
    //autosave
    IEnumerator save()
    {
        yield return new WaitForSeconds(auto_save_time);
        saveUserList();
        StartCoroutine("save");
    }
}
