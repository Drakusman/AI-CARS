using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public  class User
{
    public enum Gender
    {
        male,
        female,
        none
    }

    public string name;
    public string surname;
    public string email;
    public int age;
    public Gender gender;
    private string password;

    //all progress data
    public bool quiz_pass = false;
    public float distance_traveled = 0f;

    public User(string name,string surname,string email, int age, Gender gender)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.age = age;
        this.gender = gender;
    }
    public void set_password(string pas)
    {
        this.password = pas;
    }
    public bool change_password(string pas1, string pas2)
    {
        if(pas1.Equals(pas2))
        {
            this.password = pas1;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool check_password(string pas)
    {
        if(pas == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
