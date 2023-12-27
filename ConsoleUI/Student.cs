namespace ConsoleUI;

// Class default access modifier (erişim belirteci): internal
class Student : User //: Object
{
    // default access modifier: private
    internal string FirstName { get; set; } // Property
    internal string LastName { get; set; } // Property

    private int yas_; //Field


    //Encapsulation
    internal int Yas
    {
        get
        {
            return yas_;
        }
        set
        {
            if(value<0)
            {
                yas_ = value;
            }
        }
    }
   // Property

    internal string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    //internal string GetFullName()
    //{
    //    return $"{FirstName} {LastName}";
    //}

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}