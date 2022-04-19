//type of method in c#?IMP
/*using System;

    public abstract class Program
//Abstract class:- using abstract keyword we can declare abstract class
//abstract class can contain abstract method and also non abstract method 
//we can not create object of abstract class
//in abstract class we can declare  variable 
//by default abstract membar are private
//abstract method don't have boday
    {
    public void EmployeeProfile()
    {
        //concreate method or non abstract method
    }
    public abstract string GetUserDetails(string name);//using actract method we can achive parsial abstraction
    public abstract int sum(int x, int y);
    public abstract int mul(int x, int y);

    static void Main(string[] args)
        {
        }
    }
*/
/*using System;

public abstract class Emp

{

    public abstract string GetUserDetails(string name);//using actract method we can achive parsial abstraction
    public abstract int sum(int x, int y);
    public abstract int mul(int x, int y);

    static void Main(string[] args)
    {
        Emp e1;        //we can make refence variable but we cant create object

        Emp e1 = new Emp();//we can't create abstract class object 
        //we you make the abstact class constractor? 
        //or asked: Abstract class can we instanciate  abstact class (instanciate means abstact class ka kya hum abject create kar sakate hain ya nhi)
        //Yes, an abstract class can have a constructor. In general, a class constructor is used to initialize fields. Along the same lines, an abstract class constructor is used to initialize fields of the abstract class.
    }
}*/
/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;
public class Employee
{
    public static void Main()
    {

    }
    public abstract class Customer
    {
        public Customer()
        {
            this._id = Guid.NewGuid();
        }
        private Guid _id;
        public Guid ID
        {
            get
            {
                return this._id;
            }
        }

    }
}*/



/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;
public class Employee
{
    public static void Main()
    {

    }
    public abstract string GetFullName(string fn, string ln);

}
*/
//we can declare abstrct method only in abstract class 

using System;//namspace
using System.Collections;
using System.Data.SqlClient;
public abstract class Employee
{
    public static void Main()
    {

    }
    public abstract string GetFullName(string fn, string ln);

    public void getDate()
    {

    }

}
// we can not create object blc abstract method don't have body
//we can declare abstrct method only in abstract class

